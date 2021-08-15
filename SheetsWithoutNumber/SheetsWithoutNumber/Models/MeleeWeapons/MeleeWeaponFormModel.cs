namespace SheetsWithoutNumber.Models.MeleeWeapons
{
    using SheetsWithoutNumber.Services.MeleeWeapon;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class MeleeWeaponFormModel
    {
        public string Name { get; set; }

        [Required]
        public string Location { get; set; }

        public int MeleeWeaponId { get; set; }

        public int CharacterMeleeWeaponId { get; set; }

        public IEnumerable<MeleeWeaponServiceListingViewModel> MeleeWeapons { get; set; }

    }
}
