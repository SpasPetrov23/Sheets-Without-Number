namespace SheetsWithoutNumber.Services.Game
{
    using SheetsWithoutNumber.Models.Games;
    using System.Collections.Generic;

    public interface IGameService
    {
        public IEnumerable<GamePreviewModel> All();

        public int Create(string name, string description, int maxPlayers, string gameImage, string gameMasterId);

        public GameDetailsModel Details(int gameId);

        public int Join(int gameId, string userId);
    }
}
