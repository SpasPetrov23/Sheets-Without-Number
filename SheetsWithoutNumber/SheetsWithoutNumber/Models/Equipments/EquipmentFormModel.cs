namespace SheetsWithoutNumber.Models.Equipments
{
    using SheetsWithoutNumber.Services.Equipments;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class EquipmentFormModel
    {
        public string Name { get; set; }

        [Range(1, int.MaxValue, ErrorMessage = "Count cannot be 0.")]
        public int Count { get; set; }

        [Required]
        public string Location { get; set; }

        public int EquipmentId { get; set; }

        public int CharacterEquipmentId { get; set; }

        public IEnumerable<EquipmentServiceListingViewModel> Equipments { get; set; }
    }
}
