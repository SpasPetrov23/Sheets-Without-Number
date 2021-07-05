﻿namespace SWN.Data.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;

    using static DataConstants;

    public class Armor
    {
        [Required]
        public string Id { get; init; } = Guid.NewGuid().ToString();

        [Required]
        [MaxLength(ItemNameMaxLength)]
        public string Name { get; set; }

        [Required]
        [MaxLength(ItemTypeMaxLength)]
        public string Type { get; set; }

        public int ArmorClass { get; set; }

        public int? ArmorClassModifier { get; set; }

        public int Cost { get; set; }

        public int Encumbrance { get; set; }

        public int TechLevel { get; set; }

        [Required]
        public string Description { get; set; }
    }
}
