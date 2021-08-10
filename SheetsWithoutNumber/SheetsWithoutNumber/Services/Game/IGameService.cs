namespace SheetsWithoutNumber.Services.Game
{
    using SheetsWithoutNumber.Models.Games;
    using System.Collections.Generic;

    public interface IGameService
    {
        public IEnumerable<GamePreviewModel> All(string currentUserId);

        public int Create(string name, string description, int maxPlayers, string gameImage, string gameMasterId);

        public GameDetailsModel Details(int gameId);

        public int Delete(int gameId);

        public bool Edit(int gameId, string name, string description, string gameImage, int maxPlayers);

        public int Join(int gameId, string userId);

        public bool PlayerMaxIsValid(int gameId, int playersMax);
    }
}
