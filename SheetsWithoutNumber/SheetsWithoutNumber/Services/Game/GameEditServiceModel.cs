namespace SheetsWithoutNumber.Services.Game
{
    using System.Collections.Generic;
    using SWN.Data.Models;

    public class GameEditServiceModel
    {

        public string Name { get; set; }

        public string Description { get; set; }

        public string GameImage { get; set; }

        public int PlayersMax { get; set; }

        public ICollection<User> Users { get; set; }
    }
}
