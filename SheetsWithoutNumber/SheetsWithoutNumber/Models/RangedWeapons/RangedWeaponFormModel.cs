namespace SheetsWithoutNumber.Models.RangedWeapons
{
    using SheetsWithoutNumber.Services.RangedWeapon;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class RangedWeaponFormModel
    {
        public string Name { get; set; }

        [Range(1, int.MaxValue, ErrorMessage = "Ammo cannot be 0 or lower.")]
        public int Ammo { get; set; }

        [Required]
        public string Location { get; set; }

        public int RangedWeaponId { get; set; }

        public int CharacterRangedWeaponId { get; set; }

        public IEnumerable<RangedWeaponServiceListingViewModel> RangedWeapons { get; set; }
    }
}
