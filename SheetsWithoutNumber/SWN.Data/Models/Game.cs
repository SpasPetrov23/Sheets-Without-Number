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

        public int? SessionFrequency { get; set; }

        public DateTime? NextSession { get; set; }

        public DateTime? StartDate { get; init; }

        public int SessionsCount { get; set; }

        [Required]
        [MaxLength(DescriptionMaxLength)]
        public string Description { get; set; }

        public ICollection<User> Users { get; init; } = new HashSet<User>();

        public ICollection<Character> Characters { get; init; } = new HashSet<Character>();
    }
}
