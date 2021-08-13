namespace SheetsWithoutNumber.Services.Equipments
{
    using AutoMapper;
    using AutoMapper.QueryableExtensions;
    using SWN.Data;
    using SWN.Data.Models;
    using System.Collections.Generic;
    using System.Linq;

    public class EquipmentService : IEquipmentService
    {
        private readonly SWNDbContext data;
        private readonly IConfigurationProvider mapper;

        public EquipmentService(SWNDbContext data, IMapper mapper)
        {
            this.data = data;
            this.mapper = mapper.ConfigurationProvider;
        }

        public int Add(int characterId, int equipmentId, int count, string location)
        {
            var equipment = data.Equipments.Where(e => e.Id == equipmentId).FirstOrDefault();

            var characterEquipment = new CharactersEquipments
            {
                CharacterId = characterId,
                EquipmentId = equipmentId,
                EquipmentCount = count,
                EquipmentLocation = location,
                EquipmentName = equipment.Name,
                EquipmentCost = equipment.Cost,
                EquipmentDescription = equipment.Description,
                EquipmentEncumbrance = equipment.Encumbrance,
                EquipmentTechLevel = equipment.TechLevel,
                EquipmentType = equipment.Type
            };

            data.CharactersEquipments.Add(characterEquipment);

            data.SaveChanges();

            return characterEquipment.Id;
        }

        public bool Edit(int count, int equipmentId, int characterEquipmentId, string location)
        {
            var characterEquipment = data.CharactersEquipments.Where(ce => ce.Id == characterEquipmentId).FirstOrDefault();

            var equipmentName = this.GetEquipmentById(equipmentId).Name;

            characterEquipment.EquipmentId = equipmentId;
            characterEquipment.EquipmentCount = count;
            characterEquipment.EquipmentName = equipmentName;
            characterEquipment.EquipmentLocation = location;

            this.data.SaveChanges();

            return true;
        }

        public int Delete(int characterEquipmentId)
        {
            var characterEquipment = data.CharactersEquipments
                .Where(ce => ce.Id == characterEquipmentId)
                .FirstOrDefault();

            data.CharactersEquipments.Remove(characterEquipment);

            data.SaveChanges();

            return characterEquipment.Id;
        }

        public IEnumerable<EquipmentServiceListingViewModel> GetEquipmentListing()
            => this.data
             .Equipments
             .ProjectTo<EquipmentServiceListingViewModel>(this.mapper)
             .OrderBy(e => e.Type)
             .ThenBy(e => e.Name)
             .ToList();

        public bool EquipmentExists(int equipmentId)
            => this.data
            .Equipments
            .Any(e => e.Id == equipmentId);

        public CharacterEquipmentServiceModel GetCharacterEquipmentById(int characterEquipmentId)
        {
            var characterEquipment = data.CharactersEquipments
                .Where(ce => ce.Id == characterEquipmentId)
                .ProjectTo<CharacterEquipmentServiceModel>(this.mapper)
                .FirstOrDefault();

            return characterEquipment;
        }

        public EquipmentServiceListingViewModel GetEquipmentById(int equipmentId)
        {
            var equipment = data.Equipments
                .Where(e => e.Id == equipmentId)
                .ProjectTo<EquipmentServiceListingViewModel>(this.mapper)
                .FirstOrDefault();

            return equipment;
        }
    }
}
