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
                    Id = c.Id,
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
        public IActionResult Create(CharacterCreateModel characterModel, int gameId)
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
                Species = characterModel.Species,
                OwnerId = this.User.GetId(),
                GameId = gameId,
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

            data.Games
                .FirstOrDefault(g => g.Id == gameId)
                .Characters
                .Add(character);

            data.SaveChanges();

            return RedirectToAction("All", "Characters");
        }

        public IActionResult Details(int characterId)
        {
            var characterGame = data
                .Characters
                .Where(c => c.Id == characterId).FirstOrDefault().Game;

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
