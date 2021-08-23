namespace SheetsWithoutNumber.Services.Game
{
    using SheetsWithoutNumber.Models.Games;
    using System.Collections.Generic;

    public class GameQueryServiceModel
    {
        public int GamesPerPage { get; init; }

        public int CurrentPage { get; init; }

        public int TotalGames { get; init; }

        public IEnumerable<GamePreviewModel> Games { get; init; }
    }
}
