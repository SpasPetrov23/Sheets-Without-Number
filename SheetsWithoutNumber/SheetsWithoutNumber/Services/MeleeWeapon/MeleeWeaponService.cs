namespace SheetsWithoutNumber.Services.MeleeWeapon
{
    using AutoMapper;
    using AutoMapper.QueryableExtensions;
    using SWN.Data;
    using SWN.Data.Models;
    using System.Collections.Generic;
    using System.Linq;

    public class MeleeWeaponService : IMeleeWeaponService
    {
        private readonly SWNDbContext data;
        private readonly IConfigurationProvider mapper;

        public MeleeWeaponService(SWNDbContext data, IMapper mapper)
        {
            this.data = data;
            this.mapper = mapper.ConfigurationProvider;
        }

        public int Add(int characterId, int meleeWeaponId, string location)
        {
            var meleeWeapon = data.MeleeWeapons.Where(mw => mw.Id == meleeWeaponId).FirstOrDefault();

            var characterMeleeWeapon = new CharactersMeleeWeapons
            {
                CharacterId = characterId,
                MeleeWeaponId = meleeWeapon.Id,
                MeleeWeaponDescription = meleeWeapon.Description,
                MeleeWeaponAttribute = meleeWeapon.Attribute,
                MeleeWeaponCost = meleeWeapon.Cost,
                MeleeWeaponDamage = meleeWeapon.Damage,
                MeleeWeaponEncumbrance = meleeWeapon.Encumbrance,
                MeleeWeaponLocation = location,
                MeleeWeaponName = meleeWeapon.Name,
                MeleeWeaponShockAC = meleeWeapon.ShockAC,
                MeleeWeaponShockPoints = meleeWeapon.ShockPoints,
                MeleeWeaponSkill = meleeWeapon.Skill,
                MeleeWeaponTechLevel = meleeWeapon.TechLevel,
                MeleeWeaponThrowRange = meleeWeapon.ThrowRange
            };

            data.CharactersMeleeWeapons.Add(characterMeleeWeapon);

            data.SaveChanges();

            return characterMeleeWeapon.Id;
        }

        public bool Edit(int meleeWeaponId, int characterMeleeWeaponId, string location)
        {
            var characterMeleeWeapon = data.CharactersMeleeWeapons.Where(cmw => cmw.Id == characterMeleeWeaponId).FirstOrDefault();

            if (characterMeleeWeapon == null)
            {
                return false;
            }

            var meleeWeaponName = this.GetMeleeWeaponById(meleeWeaponId).Name;

            characterMeleeWeapon.MeleeWeaponId = meleeWeaponId;
            characterMeleeWeapon.MeleeWeaponName = meleeWeaponName;
            characterMeleeWeapon.MeleeWeaponLocation = location;

            this.data.SaveChanges();

            return true;
        }

        public int Delete(int characterMeleeWeaponId)
        {
            var characterMeleeWeapon = data.CharactersMeleeWeapons
                .Where(cmw => cmw.Id == characterMeleeWeaponId)
                .FirstOrDefault();

            data.CharactersMeleeWeapons.Remove(characterMeleeWeapon);

            data.SaveChanges();

            return characterMeleeWeapon.Id;
        }

        public IEnumerable<MeleeWeaponServiceListingViewModel> GetMeleeWeaponListing()
            => this.data
             .MeleeWeapons
             .ProjectTo<MeleeWeaponServiceListingViewModel>(this.mapper)
             .OrderBy(mw => mw.Cost)
             .ThenBy(mw => mw.Name)
             .ToList();

        public bool MeleeWeaponExists(int meleeWeaponId)
            => this.data
            .MeleeWeapons
            .Any(mw => mw.Id == meleeWeaponId);

        public CharacterMeleeWeaponServiceModel GetCharacterMeleeWeaponById(int characterMeleeWeaponId)
        {
            var characterMeleeWeapon = data.CharactersMeleeWeapons
                .Where(cmw => cmw.Id == characterMeleeWeaponId)
                .ProjectTo<CharacterMeleeWeaponServiceModel>(this.mapper)
                .FirstOrDefault();

            return characterMeleeWeapon;
        }

        public MeleeWeaponServiceListingViewModel GetMeleeWeaponById(int meleeWeaponId)
        {
            var meleeWeapon = data.MeleeWeapons
                .Where(mw => mw.Id == meleeWeaponId)
                .ProjectTo<MeleeWeaponServiceListingViewModel>(this.mapper)
                .FirstOrDefault();

            return meleeWeapon;
        }
    }
}
