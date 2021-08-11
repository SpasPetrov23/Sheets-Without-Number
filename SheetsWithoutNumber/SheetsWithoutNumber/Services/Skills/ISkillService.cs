namespace SheetsWithoutNumber.Services.Skills
{
    using SheetsWithoutNumber.Models.Skills;
    using System.Collections.Generic;

    public interface ISkillService
    {
        public int Add(int characterId, int skillId, int level);

        public IEnumerable<SkillListingViewModel> GetSkills();

        public bool SkillExists(int skillId);

        public bool AllowSkill(int skillId, int characterId);
    }
}
