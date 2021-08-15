namespace SheetsWithoutNumber.Services.MeleeWeapon
{
    using System.Collections.Generic;

    public interface IMeleeWeaponService
    {
        public int Add(int characterId, int meleeWeaponId, string location);

        public bool Edit(int meleeWeaponId, int characterMeleeWeaponId, string location);

        public int Delete(int characterMeleeWeaponId);

        public IEnumerable<MeleeWeaponServiceListingViewModel> GetMeleeWeaponListing();

        public bool MeleeWeaponExists(int meleeWeaponId);

        public CharacterMeleeWeaponServiceModel GetCharacterMeleeWeaponById(int characterMeleeWeaponId);
    }
}
