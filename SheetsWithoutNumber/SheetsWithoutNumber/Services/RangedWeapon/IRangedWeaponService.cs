using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SheetsWithoutNumber.Services.RangedWeapon
{
    public interface IRangedWeaponService
    {
        public int Add(int characterId, int rangedWeaponId, int ammo, string location);

        public bool Edit(int rangedWeaponId, int characterRangedWeaponId, int ammo, string location);

        public int Delete(int characterRangedWeaponId);

        public IEnumerable<RangedWeaponServiceListingViewModel> GetRangedWeaponListing();

        public bool RangedWeaponExists(int rangedWeaponId);

        public CharacterRangedWeaponServiceModel GetCharacterRangedWeaponById(int characterRangedWeaponId);

        public bool IsAmmoValid(int ammo, int rangedWeaponId);

    }
}
