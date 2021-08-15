namespace SWN.Data.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    using static DataConstants.MeleeWeaponData;

    public class MeleeWeapon
    {
        public int Id { get; init; }

        [Required]
        [MaxLength(NameMaxLength)]
        public string Name { get; set; }

        [Required]
        [MaxLength(DamageMaxLength)]
        public string Damage { get; set; }

        public int ShockPoints { get; set; }

        public int ShockAC { get; set; }

        public int ThrowRange { get; set; }

        [Required]
        [MaxLength(AttributeMaxLength)]
        public string Attribute { get; set; }

        public int Cost { get; set; }

        public int Encumbrance { get; set; }

        public int TechLevel { get; set; }

        [Required]
        public string Skill { get; set; }

        [Required]
        public string Description { get; set; }

        public ICollection<CharactersMeleeWeapons> CharactersMeleeWeapons { get; init; } = new HashSet<CharactersMeleeWeapons>();
    }
}
