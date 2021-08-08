namespace SheetsWithoutNumber.Services.Character
{
    using System.Collections.Generic;
    using System.Linq;
    using SWN.Data;
    using SWN.Data.Models;
    using SheetsWithoutNumber.Models.Characters;
    using AutoMapper;
    using AutoMapper.QueryableExtensions;

    public class CharacterService : ICharacterService
    {
        private readonly SWNDbContext data;
        private readonly IConfigurationProvider mapper;

        public CharacterService(SWNDbContext data, IMapper mapper)
        {
            this.data = data;
            this.mapper = mapper.ConfigurationProvider;
        }

        public IEnumerable<CharacterListingModel> All()
        {
            var characters = data
                .Characters
                .ProjectTo<CharacterListingModel>(this.mapper)
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

        public CharacterDetailsModel Details(int characterId)
        {
            var character = data
                .Characters
                .Where(c => c.Id == characterId)
                .ProjectTo<CharacterDetailsModel>(this.mapper)
                .FirstOrDefault();

            return character;
        }

        public IEnumerable<CharacterClassViewModel> GetCharacterClasses()
            => this.data
             .Classes
             .ProjectTo<CharacterClassViewModel>(this.mapper)
             .ToList();

        public IEnumerable<CharacterBackgroundView> GetCharacterBackgrounds()
            => this.data
            .Backgrounds
            .OrderBy(b => b.Name)
            .ProjectTo<CharacterBackgroundView>(this.mapper)
            .ToList();

        public bool ClassExists(int classId)
            => this.data.Classes.Any(c => c.Id == classId);

        public bool BackgroundExists(int backgroundId)
            => this.data.Backgrounds.Any(b => b.Id == backgroundId);
    }
}
