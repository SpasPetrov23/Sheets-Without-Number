namespace SheetsWithoutNumber.Models.Games
{
    using SheetsWithoutNumber.Services.Game;
    using SWN.Data.Models;
    using System.Collections.Generic;

    public class GameDetailsModel : IGameModel
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public string GameImage { get; set; }

        public string GameMasterId { get; set; }

        public int PlayersMax { get; set; }

        public ICollection<User> Users { get; set; }

        public ICollection<Character> Characters { get; set; }
    }
}
