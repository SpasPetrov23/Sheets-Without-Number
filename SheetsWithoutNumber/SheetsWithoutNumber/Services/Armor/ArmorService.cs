namespace SheetsWithoutNumber.Services.Armor
{
    using AutoMapper;
    using AutoMapper.QueryableExtensions;
    using SWN.Data;
    using SWN.Data.Models;
    using System.Collections.Generic;
    using System.Linq;

    public class ArmorService : IArmorService
    {
        private readonly SWNDbContext data;
        private readonly IConfigurationProvider mapper;

        public ArmorService(SWNDbContext data, IMapper mapper)
        {
            this.data = data;
            this.mapper = mapper.ConfigurationProvider;
        }

        public int Add(int characterId, int armorId, string location)
        {
            var armor = data.Armors.Where(a => a.Id == armorId).FirstOrDefault();

            var characterArmor = new CharactersArmors
            {
                CharacterId = characterId,
                ArmorId = armorId,
                ArmorLocation = location,
                ArmorClass = armor.ArmorClass,
                ArmorCost = armor.Cost,
                ArmorDescription = armor.Description,
                ArmorEncumbrance = armor.Encumbrance,
                ArmorName = armor.Name,
                ArmorType = armor.Type,
                ArmorTechLevel = armor.TechLevel
            };

            data.CharactersArmors.Add(characterArmor);

            data.SaveChanges();

            return characterArmor.Id;
        }

        public bool Edit(int armorId, int characterArmorId, string location)
        {
            var characterArmor = data.CharactersArmors.Where(ca => ca.Id == characterArmorId).FirstOrDefault();

            var armorName = this.GetArmorById(armorId).Name;

            characterArmor.ArmorId = armorId;
            characterArmor.ArmorName = armorName;
            characterArmor.ArmorLocation = location;

            this.data.SaveChanges();

            return true;
        }

        public int Delete(int characterArmorId)
        {
            var characterArmor = data.CharactersArmors
                .Where(ca => ca.Id == characterArmorId)
                .FirstOrDefault();

            data.CharactersArmors.Remove(characterArmor);

            data.SaveChanges();

            return characterArmor.Id;
        }

        public IEnumerable<ArmorServiceListingViewModel> GetArmorListing()
            => this.data
             .Armors
             .ProjectTo<ArmorServiceListingViewModel>(this.mapper)
             .OrderBy(a => a.TechLevel)
             .ThenBy(a => a.ArmorClass)
             .ToList();

        public bool ArmorExists(int armorId)
            => this.data
            .Armors
            .Any(a => a.Id == armorId);

        public CharacterArmorServiceModel GetCharacterArmorById(int characterArmorId)
        {
            var characterArmor = data.CharactersArmors
                .Where(ca => ca.Id == characterArmorId)
                .ProjectTo<CharacterArmorServiceModel>(this.mapper)
                .FirstOrDefault();

            return characterArmor;
        }

        public ArmorServiceListingViewModel GetArmorById(int armorId)
        {
            var armor = data.Armors
                .Where(a => a.Id == armorId)
                .ProjectTo<ArmorServiceListingViewModel>(this.mapper)
                .FirstOrDefault();

            return armor;
        }
    }
}
