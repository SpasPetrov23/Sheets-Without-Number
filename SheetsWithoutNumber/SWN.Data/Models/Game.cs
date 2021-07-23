﻿namespace SWN.Data.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    using static DataConstants.Game;

    public class Game
    {
        [Required]
        public string Id { get; init; } = Guid.NewGuid().ToString();

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

        public ICollection<Session> Sessions { get; init; } = new HashSet<Session>();
    }
}
