namespace SWN.Data.Models
{
    using System.ComponentModel.DataAnnotations;

    public class CharactersMeleeWeapons
    {
        public int Id { get; set; }

        public int CharacterId { get; set; }

        public Character Character { get; set; }

        public int MeleeWeaponId { get; set; }

        public MeleeWeapon MeleeWeapon { get; set; }

        [Required]
        public string MeleeWeaponName { get; set; }

        [Required]
        public string MeleeWeaponDamage { get; set; }

        public int MeleeWeaponShockPoints { get; set; }

        public int MeleeWeaponShockAC { get; set; }

        public int MeleeWeaponThrowRange { get; set; }

        [Required]
        public string MeleeWeaponAttribute { get; set; }

        public int MeleeWeaponCost { get; set; }

        public int MeleeWeaponEncumbrance { get; set; }

        public int MeleeWeaponTechLevel { get; set; }

        [Required]
        public string MeleeWeaponLocation { get; set; }

        [Required]
        public string MeleeWeaponSkill { get; set; }

        [Required]
        public string MeleeWeaponDescription { get; set; }
    }
}
