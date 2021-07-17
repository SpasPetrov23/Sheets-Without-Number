namespace SWN.Data.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    using static DataConstants;

    public class Character
    {
        [Required]
        public string Id { get; init; } = Guid.NewGuid().ToString();

        [Required]
        [MaxLength(CharacterNameMaxLength)]
        public string Name { get; set; }

        public int Strength { get; set; }

        public int Dexterity { get; set; }

        public int Constitution { get; set; }

        public int Charisma { get; set; }

        public int Wisdom { get; set; }

        public int Intelligence { get; set; }

        [Required]
        [MaxLength(CharacterSpeciesMaxLength)]
        public string Species { get; set; }

        [Required]
        [MaxLength(CharacterHomeworldMaxLength)]
        public string Homeworld { get; set; }

        public int HitPoints { get; set; }

        public int MaxHitPoints { get; set; }

        public int Effort { get; set; }

        public int MaxEffort { get; set; }

        public int SystemStrain { get; set; }

        public int MaxSystemStrain { get; set; }

        public int Speed { get; set; }

        public int Initiative { get; set; }

        public int AttackBonus { get; set; }

        public int ArmorClass { get; set; }

        public int UnspentSkillPoints { get; set; }

        public int ReadiedEncumbrance { get; set; }

        public int StowedEncumbrance { get; set; }

        [Required]
        [MaxLength(CharacterEncumbranceMaxLength)]
        public string Encumbrance { get; set; }

        public int Credits { get; set; }

        public string Notes { get; set; }

        public string Goal { get; set; }

        public string CharacterImage { get; set; }

        /// <summary>
        /// Table Relations Below
        /// </summary>

        [Required]
        public string UserId { get; set; }

        public User User { get; set; }

        public ICollection<Skill> Skills { get; init; } = new HashSet<Skill>();

        [Required]
        public string ClassId { get; set; }

        public Class Class { get; set; }

        [Required]
        public string BackgroundId { get; set; }

        public Background Background { get; set; }

        public ICollection<Focus> Foci { get; init; } = new HashSet<Focus>();
    }
}
