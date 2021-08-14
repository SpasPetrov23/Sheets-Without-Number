namespace SheetsWithoutNumber.Models.Skills
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using SheetsWithoutNumber.Services.Skill;

    public class SkillFormModel
    {
        public string Name { get; set; }

        [Range(0, 4, ErrorMessage = "Skill level must be between 0 and 4.")]
        public int Level { get; set; }

        public int SkillId { get; set; }

        public int? PreviousSkillId { get; set; }

        public int CharacterSkillId { get; set; }

        public IEnumerable<SkillServiceListingViewModel> Skills { get; set; }
    }
}
