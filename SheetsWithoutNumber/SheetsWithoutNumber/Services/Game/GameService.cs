namespace SheetsWithoutNumber.Services.Game
{
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

        public GameService(IUserService users, SWNDbContext data)
        {
            this.data = data;
            this.users = users;
        }

        public IEnumerable<GamePreviewModel> All()
        {
            var games = data
               .Games
               .Select(g => new GamePreviewModel
               {
                   Id = g.Id,
                   Name = g.Name,
                   PlayersCurrent = g.Users.Count,
                   PlayersMax = g.PlayersMax,
                   Description = g.Description,
                   GameImage = g.GameImage,
                   GameMasterId = g.GameMasterId,
                   Users = g.Users
               })
               .ToList();

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
                .Select(g => new GameDetailsModel
                {
                    Id = g.Id,
                    Name = g.Name,
                    Description = g.Description,
                    GameImage = g.GameImage,
                    Players = g.Users,
                    Characters = g.Characters,
                    GameMasterId = g.GameMasterId,
                    PlayersMax = g.PlayersMax
                })
                .FirstOrDefault();

            return game;
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
                .Where(g => g.Id == gameId).
                Select(g => new GameEditServiceModel
                { 
                    Name = g.Name,
                    Description = g.Description,
                    GameImage = g.GameImage,
                    PlayersMax = g.PlayersMax,
                    Users = g.Users
                })
                .FirstOrDefault();

            if (game.Users.Count > playersMax)
            {
                return false;
            }

            return true;
        }
    }
}
