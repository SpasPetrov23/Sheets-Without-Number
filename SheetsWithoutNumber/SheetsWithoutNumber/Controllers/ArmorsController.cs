namespace SheetsWithoutNumber.Controllers
{
    using AutoMapper;
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;
    using SheetsWithoutNumber.Infrastructure;
    using SheetsWithoutNumber.Models.Armors;
    using SheetsWithoutNumber.Services.Armor;
    using SheetsWithoutNumber.Services.Character;

    public class ArmorsController : Controller
    {
        private readonly ICharacterService characters;
        private readonly IArmorService armors;
        private readonly IMapper mapper;

        public ArmorsController(ICharacterService characters, IArmorService armors, IMapper mapper)
        {
            this.characters = characters;
            this.armors = armors;
            this.mapper = mapper;
        }

        [Authorize]
        public IActionResult Add()
        {
            return View(new ArmorFormModel
            {
                Armors = this.armors.GetArmorListing()
            });
        }

        [HttpPost]
        [Authorize]
        public IActionResult Add(ArmorFormModel armorModel, int characterId)
        {
            if (!this.armors.ArmorExists(armorModel.ArmorId))
            {
                this.ModelState.AddModelError(nameof(armorModel.ArmorId), "Armor does not exist.");
            }

            if (!ModelState.IsValid)
            {
                armorModel.Armors = this.armors.GetArmorListing();

                return View(armorModel);
            }

            this.armors.Add(characterId, armorModel.ArmorId, armorModel.Location);

            return RedirectToAction("Details", "Characters", new { characterId = characterId });
        }

        [Authorize]
        public IActionResult Edit(int characterArmorId)
        {
            var characterArmor = this.armors.GetCharacterArmorById(characterArmorId);

            var currentUserId = this.User.GetId();
            var currentCharacter = this.characters.GetCharacterById(characterArmor.CharacterId);

            if (currentCharacter.OwnerId != currentUserId)
            {
                return Unauthorized();
            }

            var armorForm = this.mapper.Map<ArmorFormModel>(characterArmor);

            armorForm.Armors = this.armors.GetArmorListing();

            return View(armorForm);
        }

        [Authorize]
        [HttpPost]
        public IActionResult Edit(ArmorFormModel armorEdit)
        {
            var characterArmor = this.armors.GetCharacterArmorById(armorEdit.CharacterArmorId);

            if (!this.armors.ArmorExists(armorEdit.ArmorId))
            {
                this.ModelState.AddModelError(nameof(armorEdit.ArmorId), "Armor does not exist.");
            }

            if (!ModelState.IsValid)
            {
                armorEdit.Armors = this.armors.GetArmorListing();

                return View(armorEdit);
            }

            this.armors.Edit(armorEdit.ArmorId, armorEdit.CharacterArmorId, armorEdit.Location);

            return RedirectToAction("Details", "Characters", new { characterId = characterArmor.CharacterId });
        }

        [Authorize]
        public IActionResult Delete(int characterArmorId)
        {
            var characterArmor = this.armors.GetCharacterArmorById(characterArmorId);

            armors.Delete(characterArmorId);

            return RedirectToAction("Details", "Characters", new { characterId = characterArmor.CharacterId });
        }
    }
}
