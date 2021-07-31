namespace SheetsWithoutNumber.Models.Games
{
    using SWN.Data.Models;
    using System.Collections.Generic;

    public class GameDetailsModel
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public string GameImage { get; set; }

        public string GameMasterId { get; set; }

        public ICollection<User> Players { get; set; }

        public ICollection<Character> Characters { get; set; }
    }
}
