namespace SheetsWithoutNumber.Services.Equipments
{
    public class CharacterEquipmentServiceModel
    {
        public int Id { get; init; }

        public int CharacterId { get; set; }

        public int EquipmentId { get; set; }

        public string EquipmentName { get; init; }

        public int EquipmentCount { get; set; }

        public string EquipmentLocation { get; set; }
    }
}
