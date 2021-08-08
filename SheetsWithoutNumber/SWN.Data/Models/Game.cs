namespace SWN.Data.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using Microsoft.AspNetCore.Identity;

    using static DataConstants.Game;

    public class Game
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(NameMaxLength)]
        public string Name { get; set; }

        public int PlayersMax { get; set; }

        [Required]
        public string StartDate { get; init; } = DateTime.Now.ToString("d");

        public int SessionsCount { get; set; } = 0;

        public string GameImage { get; set; }

        [Required]
        public string GameMasterId { get; set; }

        [Required]
        [MaxLength(DescriptionMaxLength)]
        public string Description { get; set; }

        public ICollection<User> Users { get; init; } = new List<User>();

        public ICollection<Character> Characters { get; init; } = new List<Character>();
    }
}
