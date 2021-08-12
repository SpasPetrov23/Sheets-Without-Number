namespace SheetsWithoutNumber.Services.Skills
{
    using SheetsWithoutNumber.Models.Skills;
    using System.Collections.Generic;

    public interface ISkillService
    {
        public int Add(int characterId, int skillId, int level);

        public bool Edit(int level, int skillId, int chracterSkillId);

        public int Delete(int characterSkillId);

        public SkillServiceListingViewModel GetSkillById(int skillId);

        public CharacterSkillServiceModel GetCharacterSkillById(int characterSkillId);

        public IEnumerable<SkillServiceListingViewModel> GetSkills();

        public bool SkillExists(int skillId);

        public bool SkillIsLearned(int skillId, int characterId);

        public bool AllowSkill(int skillId, int characterId);
    }
}
