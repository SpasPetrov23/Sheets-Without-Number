namespace SheetsWithoutNumber.Services.Equipments
{
    using System.Collections.Generic;

    public interface IEquipmentService
    {
        public int Add(int characterId, int equipmentId, int count, string location);

        public bool Edit(int count, int equipmentId, int characterEquipmentId, string location);

        public int Delete(int characterEquipmentId);

        public IEnumerable<EquipmentServiceListingViewModel> GetEquipmentListing();

        public bool EquipmentExists(int equipmentId);

        public CharacterEquipmentServiceModel GetCharacterEquipmentById(int characterEquipmentId);

        public EquipmentServiceListingViewModel GetEquipmentById(int equipmentId);
    }
}
