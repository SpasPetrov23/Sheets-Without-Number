namespace SWN.Data.Models
{
    using System.ComponentModel.DataAnnotations;

    public class CharactersRangedWeapons
    {
        public int Id { get; set; }

        public int CharacterId { get; set; }

        public Character Character { get; set; }

        public int RangedWeaponId { get; set; }

        public RangedWeapon RangedWeapon { get; set; }

        [Required]
        public string RangedWeaponName { get; set; }

        [Required]
        public string RangedWeaponDamage { get; set; }

        public int RangedWeaponMagazine { get; set; }

        public int RangedWeaponAmmo { get; set; }

        public int RangedWeaponNormalRange { get; set; }

        public int RangedWeaponMaximumRange { get; set; }

        [Required]
        public string RangedWeaponAttribute { get; set; }

        public int RangedWeaponCost { get; set; }

        public int RangedWeaponEncumbrance { get; set; }

        public int RangedWeaponTechLevel { get; set; }

        [Required]
        public string RangedWeaponLocation { get; set; }

        [Required]
        public string RangedWeaponAmmoType { get; set; }

        [Required]
        public string RangedWeaponDescription { get; set; }

        public bool RangedWeaponIsHeavy { get; set; }
    }
}
