namespace SheetsWithoutNumber.Controllers
{
    using AutoMapper;
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;
    using SheetsWithoutNumber.Infrastructure;
    using SheetsWithoutNumber.Models.Characters;
    using SheetsWithoutNumber.Services.Character;

    public class CharactersController : Controller
    {
        private readonly ICharacterService characters;
        private readonly IMapper mapper;

        public CharactersController(ICharacterService characters, IMapper mapper)
        {
            this.characters = characters;
            this.mapper = mapper;
        }

        [Authorize]
        public IActionResult Mine()
        {
            var charactersList = this.characters.ByUser(this.User.GetId());

            return View(charactersList);
        }

        [Authorize]
        public IActionResult Create() 
        {
            return View(new CharacterCreateFormModel
            {
                Classes = this.characters.GetCharacterClasses(),
                Backgrounds = this.characters.GetCharacterBackgrounds()
            });
        } 

        [HttpPost]
        [Authorize]
        public IActionResult Create(CharacterCreateFormModel characterModel, int gameId)
        {
            if (!this.characters.ClassExists(characterModel.ClassId))
            {
                this.ModelState.AddModelError(nameof(characterModel.ClassId), "Class does not exist.");
            }

            if (!this.characters.BackgroundExists(characterModel.BackgroundId))
            {
                this.ModelState.AddModelError(nameof(characterModel.BackgroundId), "Background does not exist.");
            }

            if (!ModelState.IsValid)
            {
                characterModel.Classes = this.characters.GetCharacterClasses();
                characterModel.Backgrounds = this.characters.GetCharacterBackgrounds();

                return View(characterModel);
            }

            var characterOwnerId = this.User.GetId();

            this.characters.Create(characterModel.Name, characterModel.BackgroundId, characterModel.ClassId, characterModel.CharacterImage, characterModel.Strength, characterModel.Constitution, characterModel.Dexterity, characterModel.Wisdom, characterModel.Intelligence, characterModel.Charisma, characterModel.Homeworld, characterModel.Species, characterOwnerId, gameId);

            return RedirectToAction("Mine", "Characters");
        }

        [Authorize]
        public IActionResult Details(int characterId)
        {
            var currentUserId = this.User.GetId();

            var characterDetails = characters.Details(characterId, currentUserId);

            return View(characterDetails);
        }

        [Authorize]
        public IActionResult Edit(int characterId)
        {
            var userId = this.User.GetId();

            var character = this.characters.Details(characterId, userId);

            if (character.OwnerId != character.UserId && character.Game.GameMasterId != userId)
            {
                return Unauthorized();
            }

            var characterForm = this.mapper.Map<CharacterEditFormModel>(character);

            return View(characterForm);
        }

        [Authorize]
        [HttpPost]
        public IActionResult Edit(int characterId, CharacterEditFormModel characterEdit)
        {
            if (characterEdit.HitPoints > characterEdit.MaxHitPoints)
            {
                this.ModelState.AddModelError(nameof(characterEdit.HitPoints), "Hit Points cannot be higher than maximum Hit Points.");
            }

            if (!ModelState.IsValid)
            {
                return View(characterEdit);
            }

            this.characters.Edit(characterId, characterEdit.Name, characterEdit.CharacterImage, characterEdit.Strength, characterEdit.Dexterity, characterEdit.Constitution, characterEdit.Intelligence, characterEdit.Charisma, characterEdit.Wisdom, characterEdit.CurrentXP, characterEdit.HitPoints, characterEdit.MaxHitPoints, characterEdit.Effort, characterEdit.SystemStrain, characterEdit.Credits);

            return RedirectToAction("Details", "Characters", new { characterId = characterId });
        }

        [Authorize]
        public IActionResult Delete(int characterId)
        {
            characters.Delete(characterId);

            return RedirectToAction("Mine", "Characters");
        }
    }
}
