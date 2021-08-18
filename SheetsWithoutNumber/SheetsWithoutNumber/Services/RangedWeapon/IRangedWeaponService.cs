namespace SheetsWithoutNumber.Services.RangedWeapon
{
    using System.Collections.Generic;

    public interface IRangedWeaponService
    {
        public int Add(int characterId, int rangedWeaponId, int ammo, string location);

        public bool Edit(int rangedWeaponId, int characterRangedWeaponId, int ammo, string location);

        public int Delete(int characterRangedWeaponId);

        public IEnumerable<RangedWeaponServiceListingViewModel> GetRangedWeaponListing();

        public bool RangedWeaponExists(int rangedWeaponId);

        public CharacterRangedWeaponServiceModel GetCharacterRangedWeaponById(int characterRangedWeaponId);

        public RangedWeaponServiceListingViewModel GetRangedWeaponById(int rangedWeaponId);

        public bool IsAmmoValid(int ammo, int rangedWeaponId);

    }
}
