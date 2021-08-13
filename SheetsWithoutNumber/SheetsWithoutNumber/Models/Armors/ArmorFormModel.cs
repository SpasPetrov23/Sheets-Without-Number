namespace SheetsWithoutNumber.Models.Armors
{
    using SheetsWithoutNumber.Services.Armor;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class ArmorFormModel
    {
        public string Name { get; set; }

        [Required]
        public string Location { get; set; }

        public int ArmorId { get; set; }

        public int CharacterArmorId { get; set; }

        public IEnumerable<ArmorServiceListingViewModel> Armors { get; set; }

    }
}
