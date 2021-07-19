﻿namespace SWN.Data.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    using static DataConstants;

    public class Background
    {
        [Required]
        public int Id { get; set; }

        [Required]
        [MaxLength(BackgroundNameMaxLength)]
        public string Name { get; set; }

        [Required]
        public string Description { get; set; }

        public ICollection<Character> Characters { get; init; } = new HashSet<Character>();
    }
}
