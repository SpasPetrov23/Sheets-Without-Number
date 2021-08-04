namespace SheetsWithoutNumber.Services.Character
{
    using SheetsWithoutNumber.Models.Characters;
    using SWN.Data;
    using System.Collections.Generic;
    using System.Linq;
    using SWN.Data.Models;

    public class CharacterService : ICharacterService
    {
        private readonly SWNDbContext data;

        public CharacterService(SWNDbContext data)
        {
            this.data = data;
        }

        public IEnumerable<CharacterListingModel> All()
        {
            var characters = data
                .Characters
                .Select(c => new CharacterListingModel
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

            return characters;
        }

        public int Create(string name, int backgroundId, int classId, string characterImage, int strength, int constitution, int dexterity, int wisdom, int intelligence, int charisma, string homeworld, string species, string ownerId, int gameId)
        {
            var character = new Character
            {
                Name = name,
                BackgroundId = backgroundId,
                ClassId = classId,
                CharacterImage = characterImage,
                Strength = strength,
                Constitution = constitution,
                Dexterity = dexterity,
                Wisdom = wisdom,
                Intelligence = intelligence,
                Charisma = charisma,
                Homeworld = homeworld,
                Species = species,
                OwnerId = ownerId,
                GameId = gameId,
            };

            data.Characters.Add(character);

            data.Games
                .FirstOrDefault(g => g.Id == gameId)
                .Characters
                .Add(character);

            data.SaveChanges();

            return character.Id;
        }

        public IEnumerable<CharacterClassViewModel> GetCharacterClasses()
            => this.data
             .Classes
             .Select(c => new CharacterClassViewModel
             {
                 Id = c.Id,
                 Name = c.Name
             })
             .ToList();

        public IEnumerable<CharacterBackgroundView> GetCharacterBackgrounds()
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
