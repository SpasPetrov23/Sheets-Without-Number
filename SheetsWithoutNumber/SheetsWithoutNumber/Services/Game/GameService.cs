namespace SheetsWithoutNumber.Services.Game
{
    using AutoMapper;
    using AutoMapper.QueryableExtensions;
    using SheetsWithoutNumber.Models.Games;
    using SheetsWithoutNumber.Services.User;
    using SWN.Data;
    using SWN.Data.Models;
    using System.Collections.Generic;
    using System.Linq;

    public class GameService : IGameService
    {
        private readonly SWNDbContext data;
        private readonly IUserService users;
        private readonly IConfigurationProvider mapper;

        public GameService(IUserService users, SWNDbContext data, IConfigurationProvider mapper)
        {
            this.data = data;
            this.users = users;
            this.mapper = mapper;
        }

        public IEnumerable<GamePreviewModel> All(string currentUserId)
        {
            var games = data
               .Games
               .ProjectTo<GamePreviewModel>(this.mapper)
               .ToList();

            foreach (var game in games)
            {
                game.CurrentUserId = currentUserId;
            }

            return games;
        }

        public int Create(string name, string description, int maxPlayers, string gameImage, string gameMasterId)
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
                .ProjectTo<GameDetailsModel>(this.mapper)
                .FirstOrDefault();

            return game;
        }

        public int Delete(int gameId)
        {
            var game = data
                .Games
                .Where(g => g.Id == gameId)
                .FirstOrDefault();

            foreach (var character in data.Characters)
            {
                if (character.GameId == gameId)
                {
                    data.Characters.Remove(character);
                }
            }

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

        public int Join(int gameId, string userId)
        {
            var game = data.Games.FirstOrDefault(g => g.Id == gameId);

            var currentUser = this.users.GetUserById(userId);

            game.Users.Add(currentUser);

            data.SaveChanges();

            return game.Id;
        }

        public bool PlayerMaxIsValid(int gameId, int playersMax)
        {
            var game = data.Games
                .Where(g => g.Id == gameId)
                .ProjectTo<GameEditServiceModel>(this.mapper)
                .FirstOrDefault();

            if (game.Users.Count > playersMax)
            {
                return false;
            }

            return true;
        }
    }
}
