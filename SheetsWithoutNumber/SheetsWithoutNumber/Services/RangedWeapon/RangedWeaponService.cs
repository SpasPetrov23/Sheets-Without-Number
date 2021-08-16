namespace SheetsWithoutNumber.Services.RangedWeapon
{
    using AutoMapper;
    using AutoMapper.QueryableExtensions;
    using SWN.Data;
    using SWN.Data.Models;
    using System.Collections.Generic;
    using System.Linq;

    public class RangedWeaponService : IRangedWeaponService
    {
        private readonly SWNDbContext data;
        private readonly IConfigurationProvider mapper;

        public RangedWeaponService(SWNDbContext data, IMapper mapper)
        {
            this.data = data;
            this.mapper = mapper.ConfigurationProvider;
        }

        public int Add(int characterId, int rangedWeaponId, int ammo, string location)
        {
            var rangedWeapon = data.RangedWeapons.Where(rw => rw.Id == rangedWeaponId).FirstOrDefault();

            var characterRangedWeapon = new CharactersRangedWeapons
            {
                CharacterId = characterId,
                RangedWeaponId = rangedWeapon.Id,
                RangedWeaponDescription = rangedWeapon.Description,
                RangedWeaponAttribute = rangedWeapon.Attribute,
                RangedWeaponCost = rangedWeapon.Cost,
                RangedWeaponDamage = rangedWeapon.Damage,
                RangedWeaponEncumbrance = rangedWeapon.Encumbrance,
                RangedWeaponLocation = location,
                RangedWeaponName = rangedWeapon.Name,
                RangedWeaponAmmoType = rangedWeapon.AmmoType,
                RangedWeaponAmmo = ammo,
                RangedWeaponMagazine = rangedWeapon.Magazine,
                RangedWeaponNormalRange = rangedWeapon.NormalRange,
                RangedWeaponMaximumRange = rangedWeapon.MaximumRange,
                RangedWeaponTechLevel = rangedWeapon.TechLevel
            };

            data.CharactersRangedWeapons.Add(characterRangedWeapon);

            data.SaveChanges();

            return characterRangedWeapon.Id;
        }

        public bool Edit(int rangedWeaponId, int characterRangedWeaponId, int ammo, string location)
        {
            var characterRangedWeapon = data.CharactersRangedWeapons.Where(crw => crw.Id == characterRangedWeaponId).FirstOrDefault();

            if (characterRangedWeapon == null)
            {
                return false;
            }

            var rangedWeaponName = this.GetRangedWeaponById(rangedWeaponId).Name;

            characterRangedWeapon.RangedWeaponId = rangedWeaponId;
            characterRangedWeapon.RangedWeaponName = rangedWeaponName;
            characterRangedWeapon.RangedWeaponAmmo = ammo;
            characterRangedWeapon.RangedWeaponLocation = location;

            this.data.SaveChanges();

            return true;
        }

        public int Delete(int characterRangedWeaponId)
        {
            var characterRangedWeapon = data.CharactersRangedWeapons
                .Where(crw => crw.Id == characterRangedWeaponId)
                .FirstOrDefault();

            data.CharactersRangedWeapons.Remove(characterRangedWeapon);

            data.SaveChanges();

            return characterRangedWeapon.Id;
        }

        public IEnumerable<RangedWeaponServiceListingViewModel> GetRangedWeaponListing()
            => this.data
             .RangedWeapons
             .ProjectTo<RangedWeaponServiceListingViewModel>(this.mapper)
             .OrderBy(rw => rw.IsHeavy)
             .ThenByDescending(rw => rw.AmmoType)
             .ThenBy(rw => rw.Cost)
             .ToList();

        public bool RangedWeaponExists(int rangedWeaponId)
            => this.data
            .RangedWeapons
            .Any(rw => rw.Id == rangedWeaponId);

        public CharacterRangedWeaponServiceModel GetCharacterRangedWeaponById(int characterRangedWeaponId)
        {
            var characterRangedWeapon = data.CharactersRangedWeapons
                .Where(crw => crw.Id == characterRangedWeaponId)
                .ProjectTo<CharacterRangedWeaponServiceModel>(this.mapper)
                .FirstOrDefault();

            return characterRangedWeapon;
        }

        public RangedWeaponServiceListingViewModel GetRangedWeaponById(int rangedWeaponId)
        {
            var rangedWeapon = data.RangedWeapons
                .Where(rw => rw.Id == rangedWeaponId)
                .ProjectTo<RangedWeaponServiceListingViewModel>(this.mapper)
                .FirstOrDefault();

            return rangedWeapon;
        }

        public bool IsAmmoValid(int ammo, int rangedWeaponId)
        {
            var rangedWeapon = this.GetRangedWeaponById(rangedWeaponId);

            if (ammo > rangedWeapon.Magazine)
            {
                return false;
            }

            return true;
        }
    }
}
