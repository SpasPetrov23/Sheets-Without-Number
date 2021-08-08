namespace SheetsWithoutNumber.Controllers
{
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;
    using SheetsWithoutNumber.Infrastructure;
    using SheetsWithoutNumber.Models.Characters;
    using SheetsWithoutNumber.Services.Character;

    public class CharactersController : Controller
    {
        private readonly ICharacterService characters;

        public CharactersController(ICharacterService characters)
        {
            this.characters = characters;
        }

        [Authorize]
        public IActionResult All()
        {
            var charactersList = this.characters.All();

            return View(charactersList);
        }

        [Authorize]
        public IActionResult Create() 
        {
            return View(new CharacterFormModel
            {
                Classes = this.characters.GetCharacterClasses(),
                Backgrounds = this.characters.GetCharacterBackgrounds()
            });
        } 

        [HttpPost]
        [Authorize]
        public IActionResult Create(CharacterFormModel characterModel, int gameId)
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

            return RedirectToAction("All", "Characters");
        }

        public IActionResult Details(int characterId)
        {
            var characterDetails = characters.Details(characterId);

            return View(characterDetails);
        }
    }
}
