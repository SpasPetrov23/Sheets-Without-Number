namespace SheetsWithoutNumber.Models.Games
{
    using System;

    public class GamePreviewModel
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int PlayersCurrent { get; set; }

        public int PlayersMax { get; set; }

        public string Description { get; set; }

        public string GameImage { get; set; }
    }
}
