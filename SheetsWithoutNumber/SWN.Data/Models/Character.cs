﻿namespace SWN.Data.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    using static DataConstants.Character;

    public class Character
    {
        public int Id { get; init; }

        [Required]
        [MaxLength(NameMaxLength)]
        public string Name { get; set; }

        public int Strength { get; set; }

        public int Dexterity { get; set; }

        public int Constitution { get; set; }

        public int Charisma { get; set; }

        public int Wisdom { get; set; }

        public int Intelligence { get; set; }

        [Required]
        [MaxLength(SpeciesMaxLength)]
        public string Species { get; set; }

        [Required]
        [MaxLength(HomeworldMaxLength)]
        public string Homeworld { get; set; }

        public int Level { get; set; } = 1;

        public int Experience { get; set; } = 0;

        public int HitPoints { get; set; } = 0;

        public int MaxHitPoints { get; set; } = 0;

        public int Effort { get; set; } = 0;

        public int MaxEffort { get; set; } = 0;

        public int SystemStrain { get; set; } = 0;

        public int MaxSystemStrain { get; set; } = 0;

        public int Speed { get; set; } = 0;

        public int Initiative { get; set; } = 0;

        public int AttackBonus { get; set; } = 0;

        public int ArmorClass { get; set; } = 10;

        public int UnspentSkillPoints { get; set; } = 0;

        public int ReadiedEncumbrance { get; set; } = 0;

        public int StowedEncumbrance { get; set; } = 0;

        [Required]
        [MaxLength(EncumbranceMaxLength)]
        public string Encumbrance { get; set; } = string.Empty;

        public int Credits { get; set; } = 0;

        public string Notes { get; set; } = string.Empty;

        public string Goal { get; set; } = string.Empty;

        public string CharacterImage { get; set; } = string.Empty;

        /// <summary>
        /// Table Relations Below
        /// </summary>
        
        [Required]
        public string OwnerId { get; init; }

        public ICollection<Skill> Skills { get; init; } = new HashSet<Skill>();

        public int ClassId { get; set; }

        public Class Class { get; set; }

        [Required]
        public int BackgroundId { get; set; }

        public Background Background { get; set; }

        public ICollection<Focus> Foci { get; init; } = new HashSet<Focus>();

        public int GameId { get; init; }

        public Game Game { get; set; }
    }
}
