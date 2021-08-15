namespace SWN.Tests.Services
{
    using AutoMapper;
    using SheetsWithoutNumber.Infrastructure;
    using SheetsWithoutNumber.Services.Character;
    using SWN.Data.Models;
    using SWN.Tests.Mocks;
    using Xunit;

    public class CharactersServiceTests
    {
        [Fact]
        public void CreateMethodShouldCreateACharacter()
        {
            //Arrange
            var characterService = GetCharacterService();

            //Act
            var createdCharacterId = characterService.Create("John Doe", 1, 1, "https://www.hiveworkshop.com/data/avatars/m/186/186388.jpg?1605866855", 9, 9, 9, 9, 9, 9, "Terra", "Human", "1", 1);
            var character = characterService.GetCharacterById(createdCharacterId);

            //Assert
            Assert.NotNull(character);
        }

        [Fact]
        public void CreateDetailsShouldReturnACharacter()
        {
            //Arrange
            var characterService = GetCharacterService();

            //Act
            var character = characterService.Details(5, "1");

            //Assert
            Assert.NotNull(character);
        }

        private static ICharacterService GetCharacterService()
        {
            var data = DatabaseMock.Instance;
            var mapper = MapperMock.Instance;

            var game1 = new Game 
            { 
                Id = 1, 
                Description = "Test Description", 
                GameImage = "https://www.hiveworkshop.com/data/avatars/m/186/186388.jpg?1605866855",
                PlayersMax = 3,
                GameMasterId = "1",
                Name = "Test Game"
            };

            data.Characters.Add(new Character 
            { 
                Id = 5,
                Name = "John Doe",
                BackgroundId = 1,
                ClassId = 1,
                CharacterImage = "https://www.hiveworkshop.com/data/avatars///m/186/186388.jpg?1605866855",
                Strength = 9,
                Dexterity = 9,
                Constitution = 9,
                Intelligence = 9,
                Charisma = 9,
                Wisdom = 9,
                Homeworld = "Terra",
                Species = "Human",
                OwnerId = "1",
                GameId = 1
            });

            data.Games.Add(game1);

            data.SaveChanges();

            var test = data.Characters;

            return new CharacterService(data, mapper);
        }
    }
}
