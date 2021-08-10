namespace SheetsWithoutNumber.Models.Games
{
    using SWN.Data.Models;
    using System.Collections.Generic;

    public class GamePreviewModel
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public string GameImage { get; set; }

        public int PlayersCurrent { get; set; }

        public int PlayersMax { get; set; }

        public string GameMasterId { get; set; }

        public string CurrentUserId { get; set; }

        public IEnumerable<User> Users { get; set; }
    }
}
