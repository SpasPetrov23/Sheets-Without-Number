namespace SheetsWithoutNumber.Services.Skills
{
    using AutoMapper;
    using AutoMapper.QueryableExtensions;
    using SheetsWithoutNumber.Models.Skills;
    using SWN.Data;
    using SWN.Data.Models;
    using System.Collections.Generic;
    using System.Linq;

    using static SWN.Data.DataConstants.ClassData;

    public class SkillService : ISkillService
    {
        private readonly SWNDbContext data;
        private readonly IConfigurationProvider mapper;

        public SkillService(SWNDbContext data, IMapper mapper)
        {
            this.data = data;
            this.mapper = mapper.ConfigurationProvider;
        }

        public int Add(int characterId, int skillId, int level)
        {
            var skill = data.Skills.Where(s => s.Id == skillId).FirstOrDefault();

            var characterSkills = new CharactersSkills
            {
                CharacterId = characterId,
                SkillId = skillId,
                SkillLevel = level,
                SkillName = skill.Name,
                IsSkillPsychic = skill.IsPsychic,
                SkillDescription = skill.Description
            };

            data.CharactersSkills.Add(characterSkills);
            
            data.SaveChanges();
            
            return characterSkills.Id;
        }

        public bool Edit(int level, int skillId, int chracterSkillId)
        {
            var characterSkill = data.CharactersSkills.Where(cs => cs.Id == chracterSkillId).FirstOrDefault();

            var skillName = this.GetSkillById(skillId).Name;

            characterSkill.SkillId = skillId;
            characterSkill.SkillLevel = level;
            characterSkill.SkillName = skillName;

            this.data.SaveChanges();

            return true;
        }

        public SkillServiceViewModel GetSkillById(int skillId)
        {
            var skill = data.Skills
                .Where(s => s.Id == skillId)
                .ProjectTo<SkillServiceViewModel>(this.mapper)
                .FirstOrDefault();

            return skill;
        }

        public CharacterSkillServiceModel GetCharacterSkillById(int characterSkillId)
        {
            var characterSkill = data.CharactersSkills
                .Where(cs => cs.Id == characterSkillId)
                .ProjectTo<CharacterSkillServiceModel>(this.mapper)
                .FirstOrDefault();

            return characterSkill;
        }

        public IEnumerable<SkillServiceViewModel> GetSkills()
            => this.data
             .Skills
             .ProjectTo<SkillServiceViewModel>(this.mapper)
             .OrderBy(s => s.IsPsychic)
             .ThenBy(s => s.Name)
             .ToList();

        public bool SkillExists(int skillId)
            => this.data.Skills.Any(s => s.Id == skillId);

        public bool AllowSkill(int skillId, int characterId)
        {
            var skill = this.data.Skills.Where(s => s.Id == skillId).FirstOrDefault();
            var character = this.data.Characters.Where(c => c.Id == characterId).FirstOrDefault();
            var className = this.data.Classes.Where(cl => cl.Id == character.ClassId).FirstOrDefault().Name;

            if (!skill.IsPsychic)
            {
                return true;
            }

            if (className == PsychicClassName ||
                className == PsychicWarriorClassName ||
                className == ExpertPsychicClassName)
            {
                return true;
            }

            return false;
        }
    }
}
