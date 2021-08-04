namespace SheetsWithoutNumber.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;
    using SheetsWithoutNumber.Infrastructure;
    using SheetsWithoutNumber.Models.Characters;
    using SheetsWithoutNumber.Services.Character;
    using SWN.Data;
    using SWN.Data.Models;

    public class CharactersController : Controller
    {
        private readonly SWNDbContext data;
        private readonly ICharacterService characters;

        public CharactersController(ICharacterService characters, SWNDbContext data)
        {
            this.characters = characters;
            this.data = data;
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
            if (!this.data.Classes.Any(c => c.Id == characterModel.ClassId))
            {
                this.ModelState.AddModelError(nameof(characterModel.ClassId), "Class does not exist.");
            }

            if (!this.data.Backgrounds.Any(b => b.Id == characterModel.BackgroundId))
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
            var character = data
                .Characters
                .Where(c => c.Id == characterId)
                .Select(c => new CharacterDetailsModel
                {
                    Name = c.Name,
                    Homeworld = c.Homeworld,
                    Species = c.Species,
                    Class = c.Class.Name,
                    Background = c.Background.Name,
                    CharacterImage = c.CharacterImage,
                    Charisma = c.Charisma,
                    Constitution = c.Constitution,
                    Dexterity = c.Dexterity,
                    Intelligence = c.Intelligence,
                    Strength = c.Strength,
                    Wisdom = c.Wisdom,
                    Level = c.Level,
                    GameId = c.GameId,
                    Game = c.Game
                })
                .FirstOrDefault();

            return View(character);
        }
    }
}
