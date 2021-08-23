namespace SheetsWithoutNumber.Services.Game
{
    using SheetsWithoutNumber.Models.Games;
    using System.Collections.Generic;

    public interface IGameService
    {
        public GameQueryServiceModel All(
            string currentUserId,
            GameSorting sorting,
            string searchTerm,
            int gamesPerPage,
            int currentPage);

        public int Create(string name, string description, string gameImage, int maxPlayers, string gameMasterId);

        public GameDetailsModel Details(int gameId);

        public int Delete(int gameId);

        public bool Edit(int gameId, string name, string description, string gameImage, int maxPlayers);

        public GameDetailsModel Join(int gameId, string userId);

        public bool PlayerMaxIsValid(int gameId, int playersMax);

        public GameDetailsModel Leave(int gameId, string userId);
    }
}
