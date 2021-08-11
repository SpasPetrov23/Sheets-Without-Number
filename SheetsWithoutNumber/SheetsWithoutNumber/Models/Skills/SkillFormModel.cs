namespace SheetsWithoutNumber.Models.Skills
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class SkillFormModel
    {
        public string Name { get; init; }

        [Range(0, 4, ErrorMessage = "Skill level must be between 0 and 4.")]
        public int Level { get; set; }

        public int SkillId { get; init; }

        public IEnumerable<SkillListingViewModel> Skills { get; set; }
    }
}
