namespace SheetsWithoutNumber.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using SheetsWithoutNumber.Models.Characters;
    using SWN.Data;
    using SWN.Data.Models;
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class CharactersController : Controller
    {
        private readonly SWNDbContext data;

        public CharactersController(SWNDbContext data)
        {
            this.data = data;
        }

        public IActionResult All() => View();

        public IActionResult Create() => View(new CharacterCreateModel
        {
            Classes = this.GetCharacterClasses(),
            Backgrounds = this.GetCharacterBackgrounds()
        });

        [HttpPost]
        public IActionResult Create(CharacterCreateModel characterModel)
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
                characterModel.Classes = this.GetCharacterClasses();
                characterModel.Backgrounds = this.GetCharacterBackgrounds();

                return View(characterModel);
            }

            var character = new Character
            {
                Name = characterModel.Name,
                BackgroundId = characterModel.BackgroundId,
                ClassId = characterModel.ClassId,
                CharacterImage = characterModel.CharacterImage,
                Strength = characterModel.Strength,
                Constitution = characterModel.Constitution,
                Dexterity = characterModel.Dexterity,
                Wisdom = characterModel.Wisdom,
                Intelligence = characterModel.Intelligence,
                Charisma = characterModel.Charisma,
                Homeworld = characterModel.Homeworld,
                Species = characterModel.Species
            };

            return RedirectToAction("All", "Characters");
        }

        private IEnumerable<CharacterClassViewModel> GetCharacterClasses()
            => this.data
            .Classes
            .OrderBy(b => b.Name)
            .Select(c => new CharacterClassViewModel
            {
                Id = c.Id,
                Name = c.Name
            })
            .ToList();

        private IEnumerable<CharacterBackgroundView> GetCharacterBackgrounds()
            => this.data
            .Backgrounds
            .OrderBy(b => b.Name)
            .Select(b => new CharacterBackgroundView
            {
                Id = b.Id,
                Name = b.Name
            })
            .ToList();
    }
}
