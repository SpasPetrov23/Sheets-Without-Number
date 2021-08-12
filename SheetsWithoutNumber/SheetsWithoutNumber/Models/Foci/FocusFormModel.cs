namespace SheetsWithoutNumber.Models.Foci
{
    using SheetsWithoutNumber.Services.Focus;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class FocusFormModel
    {
        public string Name { get; set; }

        [Range(1, 2, ErrorMessage = "Focus level must be between 1 and 2.")]
        public int Level { get; set; }

        public int FocusId { get; set; }

        public int? PreviousFocusId { get; set; }

        public int CharacterFocusId { get; set; }

        public IEnumerable<FocusServiceListingViewModel> Foci { get; set; }
    }
}
