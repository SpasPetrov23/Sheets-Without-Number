namespace SWN.Data.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;

    using static DataConstants.RangedWeaponData;

    public class RangedWeapon
    {
        public int Id { get; init; }

        [Required]
        [MaxLength(NameMaxLength)]
        public string Name { get; set; }

        [Required]
        [MaxLength(DamageMaxLength)]
        public string Damage { get; set; }

        public int NormalRange { get; set; }

        public int MaximumRange { get; set; }

        public int? Magazine { get; set; }

        [Required]
        [MaxLength(TypeMaxLength)]
        public string AmmoType { get; set; }

        public bool IsHeavy { get; set; }

        [Required]
        [MaxLength(AttributeMaxLength)]
        public string Attribute { get; set; }

        public int Cost { get; set; }

        public int Encumbrance { get; set; }

        public int TechLevel { get; set; }

        [Required]
        public string Description { get; set; }
    }
}
