namespace SWN.Data.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;

    using static DataConstants;

    public class MeleeWeapon
    {
        [Required]
        public string Id { get; init; } = Guid.NewGuid().ToString();

        [Required]
        [MaxLength(ItemNameMaxLength)]
        public string Name { get; set; }

        [Required]
        [MaxLength(ItemDamageMaxLength)]
        public string Damage { get; set; }

        public int ShockPoints { get; set; }

        public int ShockAC { get; set; }

        [Required]
        [MaxLength(ItemAttributeMaxLength)]
        public string Attribute { get; set; }

        public int Cost { get; set; }

        public int Encumbrance { get; set; }

        public int TechLevel { get; set; }

        [Required]
        public string Description { get; set; }
    }
}
