namespace SWN.Data.Models
{
    using System.ComponentModel.DataAnnotations;

    public class CharactersEquipments
    {
        public int Id { get; set; }

        public int CharacterId { get; set; }

        public Character Character { get; set; }

        public int EquipmentId { get; set; }

        public Equipment Equipment { get; set; }

        [Required]
        public string EquipmentName { get; set; }

        public int EquipmentEncumbrance { get; set; }

        public int EquipmentTechLevel { get; set; }

        [Required]
        public string EquipmentLocation { get; set; }

        public int EquipmentCost { get; set; }

        public int EquipmentCount { get; set; }

        [Required]
        public string EquipmentType { get; set; }

        [Required]
        public string EquipmentDescription { get; set; }
    }
}
