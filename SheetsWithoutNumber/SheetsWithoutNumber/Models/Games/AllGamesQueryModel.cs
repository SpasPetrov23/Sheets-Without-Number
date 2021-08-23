namespace SheetsWithoutNumber.Models.Games
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class AllGamesQueryModel
    {
        public const int GamesPerPage = 3;

        public GameSorting Sorting { get; set; }

        [Display(Name = "Search")]
        public string SearchTerm { get; init; }

        public int CurrentPage { get; init; } = 1;

        public int TotalGames { get; set; }

        public IEnumerable<GamePreviewModel> Games { get; set; }
    }
}
