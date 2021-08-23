namespace SheetsWithoutNumber.Services.Game
{
    using AutoMapper;
    using AutoMapper.QueryableExtensions;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.Extensions.Caching.Memory;
    using SheetsWithoutNumber.Models.Games;
    using SheetsWithoutNumber.Services.Character;
    using SheetsWithoutNumber.Services.User;
    using SWN.Data;
    using SWN.Data.Models;
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class GameService : IGameService
    {
        private readonly SWNDbContext data;
        private readonly IUserService users;
        private readonly ICharacterService characters;
        private readonly IMapper mapper;
        private readonly IMemoryCache cache;

        public GameService(
            IUserService users,
            SWNDbContext data,
            IMapper mapper,
            IMemoryCache cache,
            ICharacterService characters)
        {
            this.data = data;
            this.users = users;
            this.mapper = mapper;
            this.cache = cache;
            this.characters = characters;
        }

        public GameQueryServiceModel All(
            string currentUserId,
            GameSorting sorting,
            string searchTerm,
            int gamesPerPage,
            int currentPage)
        {
            var gamesQuery = data
                   .Games
                   .AsQueryable();

            if (!string.IsNullOrWhiteSpace(searchTerm))
            {
                gamesQuery = gamesQuery
                    .Where(g =>
                        g.Name.ToLower().Contains(searchTerm.ToLower()) ||
                        g.Description.ToLower().Contains(searchTerm.ToLower()));
            }

            gamesQuery = sorting switch
            {
                GameSorting.DateCreated => gamesQuery.OrderBy(g => g.Id),
                GameSorting.OpenSlots => gamesQuery.OrderByDescending(g => g.Id), //Adjust this sorting
                GameSorting.GameMaster => gamesQuery.OrderBy(g => g.GameMasterId),
                _ => gamesQuery.OrderByDescending(g => g.Id)
            };

            var games = gamesQuery
                .Skip((currentPage - 1) * gamesPerPage)
                .Take(gamesPerPage)
                .ProjectTo<GamePreviewModel>(this.mapper.ConfigurationProvider)
                .ToList();

            foreach (var game in games)
            {
                game.CurrentUserId = currentUserId;
            }

            var totalGames = gamesQuery.Count();

            return new GameQueryServiceModel
            {
                Games = games,
                TotalGames = totalGames
            };
        }

        public int Create(string name, string description, string gameImage, int maxPlayers, string gameMasterId)
        {
            var game = new Game
            {
                Name = name,
                Description = description,
                PlayersMax = maxPlayers,
                GameImage = gameImage,
                GameMasterId = gameMasterId,
            };

            var gameMaster = data.Users.FirstOrDefault(u => u.Id == gameMasterId);

            game.Users.Add(gameMaster);

            data.Add(game);
            data.SaveChanges();

            return game.Id;
        }

        public GameDetailsModel Details(int gameId)
        {
            var game = data
                .Games
                .Where(g => g.Id == gameId)
                //.ProjectTo<GameDetailsModel>(this.mapper)--->Automapper disabled here because it returns null for the in-memory Database during Testing.
                .Select(g => new GameDetailsModel
                {
                    Id = g.Id,
                    Name = g.Name,
                    Description = g.Description,
                    GameImage = g.GameImage,
                    PlayersMax = g.PlayersMax,
                    GameMasterId = g.GameMasterId,
                    Users = g.Users,
                    Characters = g.Characters
                })
                .FirstOrDefault();

            game.Users.OrderBy(u => u.UserName);

            return game;
        }

        public int Delete(int gameId)
        {
            var game = data
                .Games
                .Where(g => g.Id == gameId)
                .FirstOrDefault();

            var charactersToDelete = new List<Character>();

            foreach (var character in data.Characters)
            {
                if (character.GameId == gameId)
                {
                    charactersToDelete.Add(character);
                }
            }

            foreach (var character in charactersToDelete)
            {
                this.characters.Delete(character.Id);
            }

            charactersToDelete.Clear();

            data.Games.Remove(game);

            data.SaveChanges();

            return game.Id;
        }

        public bool Edit(int gameId, string name, string description, string gameImage, int maxPlayers)
        {
            var gameData = this.data.Games.Find(gameId);

            if (gameData == null)
            {
                return false;
            }

            gameData.Name = name;
            gameData.Description = description;
            gameData.GameImage = gameImage;
            gameData.PlayersMax = maxPlayers;

            this.data.SaveChanges();

            return true;
        }

        public GameDetailsModel Join(int gameId, string userId)
        {
            var game = data.Games.FirstOrDefault(g => g.Id == gameId);

            var currentUser = this.users.GetUserById(userId);

            game.Users.Add(currentUser);

            data.SaveChanges();

            var gameModel = this.mapper.Map<GameDetailsModel>(game);

            return gameModel;
        }

        public GameDetailsModel Leave(int gameId, string userId)
        {
            var game = data.Games
                .Include(g => g.Users)
                .Include(g => g.Characters)
                .FirstOrDefault(g => g.Id == gameId);

            var currentUser = this.users.GetUserById(userId);
            var userGameCharacter = game.Characters.Where(c => c.OwnerId == userId).FirstOrDefault();

            game.Users.Remove(currentUser);
            game.Characters.Remove(userGameCharacter);
            data.Characters.Remove(userGameCharacter);

            data.SaveChanges();

            var gameModel = this.mapper.Map<GameDetailsModel>(game);

            return gameModel;
        }

        public bool PlayerMaxIsValid(int gameId, int playersMax)
        {
            var game = data.Games
                .Where(g => g.Id == gameId)
                .ProjectTo<GameEditServiceModel>(this.mapper.ConfigurationProvider)
                .FirstOrDefault();

            if (game.Users.Count > playersMax)
            {
                return false;
            }

            return true;
        }
    }
}
