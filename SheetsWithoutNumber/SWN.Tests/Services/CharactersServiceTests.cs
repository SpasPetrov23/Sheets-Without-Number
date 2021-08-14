namespace SWN.Tests.Services
{
    using SheetsWithoutNumber.Services.Character;
    using SheetsWithoutNumber.Services.User;
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

            data.Games.Add(game1);

            data.SaveChanges();

            var test = data.Characters;

            return new CharacterService(data, mapper);
        }
    }
}
