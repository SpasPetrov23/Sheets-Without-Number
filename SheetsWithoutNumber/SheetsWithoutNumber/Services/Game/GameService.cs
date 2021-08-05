namespace SheetsWithoutNumber.Services.Game
{
    using SWN.Data;
    using SWN.Data.Models;
    using System.Linq;

    public class GameService : IGameService
    {
        private readonly SWNDbContext data;

        public GameService(SWNDbContext data)
        {
            this.data = data;
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
    }
}
