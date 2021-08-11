namespace SheetsWithoutNumber.Controllers
{
    using AutoMapper;
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;
    using SheetsWithoutNumber.Models.Skills;
    using SheetsWithoutNumber.Services.Skills;

    public class SkillsController : Controller
    {
        private readonly ISkillService skills;
        private readonly IMapper mapper;

        public SkillsController(ISkillService skills, IMapper mapper)
        {
            this.skills = skills;
            this.mapper = mapper;
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
    }
}
