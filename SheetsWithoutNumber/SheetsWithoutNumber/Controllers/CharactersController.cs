namespace SheetsWithoutNumber.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using SheetsWithoutNumber.Infrastructure;
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

        public IActionResult All()
        {
            var characters = data
                .Characters
                .Select(c => new CharacterPreviewModel
                {
                    Name = c.Name,
                    Class = c.Class.Name,
                    Background = c.Background.Name,
                    Level = c.Level,
                    Homeworld = c.Homeworld,
                    Species = c.Species,
                    CharacterImage = c.CharacterImage
                })
                .ToList();

            return View(characters);
        }

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

            if (!data.Games.Any())
            {
                var game = new Game
                {
                    Name = "In the Wake of Dreams",
                    SessionsCount = 0,
                    Description = "About to start.",
                    PlayersMax = 4,
                };

                data.Add(game);
                data.SaveChanges();
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
                Species = characterModel.Species,
                OwnerId = this.User.GetId(),
                GameId = data.Games.FirstOrDefault(x => x.Name == "In the Wake of Dreams").Id,
                Level = 1,
                Experience = 0,
                HitPoints = 0,
                MaxHitPoints = 0,
                ArmorClass = 10,
                AttackBonus = 0,
                Credits = 0,
                Effort = 0,
                MaxEffort = 0,
                Encumbrance = string.Empty,
                Goal = string.Empty,
                Initiative = 0,
                Notes = string.Empty,
                Speed = 0,
                ReadiedEncumbrance = 0,
                StowedEncumbrance = 0,
                SystemStrain = 0,
                MaxSystemStrain = 0,
                UnspentSkillPoints = 0,
            };

            data.Characters.Add(character);
            data.SaveChanges();

            return RedirectToAction("All", "Characters");
        }

        private IEnumerable<CharacterClassViewModel> GetCharacterClasses()
            => this.data
            .Classes
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
