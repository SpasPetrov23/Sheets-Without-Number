﻿namespace SheetsWithoutNumber.Controllers
{
    using AutoMapper;
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;
    using SheetsWithoutNumber.Infrastructure;
    using SheetsWithoutNumber.Models.Skills;
    using SheetsWithoutNumber.Services.Character;
    using SheetsWithoutNumber.Services.Skills;

    public class SkillsController : Controller
    {
        private readonly ICharacterService characters;
        private readonly ISkillService skills;
        private readonly IMapper mapper;

        public SkillsController(ISkillService skills, IMapper mapper, ICharacterService characters)
        {
            this.skills = skills;
            this.mapper = mapper;
            this.characters = characters;
        }

        [Authorize]
        public IActionResult Add()
        {
            return View(new SkillFormModel
            {
                Skills = this.skills.GetSkills(),
            });
        }

        [HttpPost]
        [Authorize]
        public IActionResult Add(SkillFormModel skillModel, int characterId)
        {
            if (!this.skills.SkillExists(skillModel.SkillId))
            {
                this.ModelState.AddModelError(nameof(skillModel.SkillId), "Skill does not exist.");
            }

            if (!this.skills.AllowSkill(skillModel.SkillId, characterId))
            {
                this.ModelState.AddModelError(nameof(skillModel.SkillId), "This skill is not available to your Class.");
            }

            if (!ModelState.IsValid)
            {
                skillModel.Skills = this.skills.GetSkills();

                return View(skillModel);
            }

            this.skills.Add(characterId, skillModel.SkillId, skillModel.Level);

            return RedirectToAction("Details", "Characters", new { characterId = characterId });
        }

        [Authorize]
        public IActionResult Edit(int characterSkillId)
        {
            var characterSkill = this.skills.GetCharacterSkillById(characterSkillId);

            var skillForm = new SkillFormModel
            {
                Name = characterSkill.SkillName,
                Level = characterSkill.SkillLevel,
                SkillId = characterSkill.SkillId,
                CharacterSkillId = characterSkill.Id
            };

            skillForm.Skills = this.skills.GetSkills();

            return View(skillForm);
        }

        [Authorize]
        [HttpPost]
        public IActionResult Edit(SkillFormModel skillEdit)
        {
            var characterSkill = this.skills.GetCharacterSkillById(skillEdit.CharacterSkillId);

            if (!this.skills.SkillExists(skillEdit.SkillId))
            {
                this.ModelState.AddModelError(nameof(skillEdit.SkillId), "Skill does not exist.");
            }

            if (!this.skills.AllowSkill(skillEdit.SkillId, characterSkill.CharacterId))
            {
                this.ModelState.AddModelError(nameof(skillEdit.SkillId), "This skill is not available to your Class.");
            }

            if (!ModelState.IsValid)
            {
                skillEdit.Skills = this.skills.GetSkills();

                return View(skillEdit);
            }

            this.skills.Edit(skillEdit.Level, skillEdit.SkillId, skillEdit.CharacterSkillId);

            return RedirectToAction("Details", "Characters", new { characterId = characterSkill.CharacterId });
        }
    }
}
