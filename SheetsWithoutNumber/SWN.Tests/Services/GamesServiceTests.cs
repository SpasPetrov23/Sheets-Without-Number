namespace SWN.Tests.Services
{
    using Microsoft.Extensions.Caching.Memory;
    using SheetsWithoutNumber.Services.Character;
    using SheetsWithoutNumber.Services.Game;
    using SheetsWithoutNumber.Services.User;
    using SWN.Data.Models;
    using SWN.Tests.Mocks;
    using Xunit;

    public class GamesServiceTests
    {
        [Fact]
        public void CreateMethodShouldCreateAGame()
        {
            //Arrange
            var gameService = GetGameService();

            //Act
            var createdGameId = gameService.Create("TestGame", "Test game description.", "https://www.hiveworkshop.com/data/avatars/m/186/186388.jpg?1605866855", 3, "1");

            //Assert
            Assert.NotEqual(0, createdGameId);
        }

        [Fact]
        public void DetailsShouldReturnInfoForCorrectGame()
        {
            //Arrange
            var gameService = GetGameService();

            //Act
            var game = gameService.Details(1);

            //Assert
            Assert.Equal(1, game.Id);
        }

        [Fact]
        public void EditShouldReturnTrueForEditedEntity()
        {
            //Arrange
            var gameService = GetGameService();

            //Act
            var result = gameService.Edit(1, "TestGame", "Test game description.", "https://www.hiveworkshop.com/data/avatars/m/186/186388.jpg?1605866855", 3);

            //Assert
            Assert.True(result);
        }

        [Fact]
        public void EditShouldReturnFalseForFailedEdit()
        {
            //Arrange
            var gameService = GetGameService();

            //Act
            var result = gameService.Edit(15, "TestGame", "Test game description.", "https://www.hiveworkshop.com/data/avatars/m/186/186388.jpg?1605866855", 3);

            //Assert
            Assert.False(result);
        }

        [Fact]
        public void DatabaseShouldNotContainTheDeletedGame()
        {
            //Arrange
            var gameService = GetGameService();

            //Act
            var deletedGameId = gameService.Delete(1);

            //Assert
            Assert.NotEqual(0, deletedGameId);
        }

        [Fact]
        public void PlayerMaxIsValidShouldReturnTrueIfCurrentPlayersIsLessThanMaxPlayers()
        {
            //Arrange
            var gameService = GetGameService();

            //Act
            var arePlayersAllowed = gameService.PlayerMaxIsValid(1, 3);

            //Assert
            Assert.True(arePlayersAllowed);
        }

        [Fact]
        public void PlayerMaxIsValidShouldReturnFalseIfCurrentPlayersIsGreaterOrEqualToMaxPlayers()
        {
            //Arrange
            var gameService = GetGameService();

            //Act
            var arePlayersAllowed = gameService.PlayerMaxIsValid(3, 1);

            //Assert
            Assert.False(arePlayersAllowed);
        }

        private static IGameService GetGameService()
        {
            var data = DatabaseMock.Instance;
            var mapper = MapperMock.Instance;

            data.Classes.Add(new Class { Id = 1, });
            data.Classes.Add(new Class { Id = 2, });
            data.Classes.Add(new Class { Id = 3, });
            data.Classes.Add(new Class { Id = 4, });

            data.Characters.Add(new Character { Id = 1, ClassId = 1 });
            data.Characters.Add(new Character { Id = 2, ClassId = 4 });
            data.Characters.Add(new Character { Id = 3, ClassId = 2 });
            data.Characters.Add(new Character { Id = 4, ClassId = 3 });

            var game1 = new Game { Id = 1, };
            var game2 = new Game { Id = 2, };
            var game3 = new Game { Id = 3, };

            game1.Users.Add(new User { Id = "1" });
            game2.Users.Add(new User { Id = "2" });
            game3.Users.Add(new User { Id = "3" });
            game3.Users.Add(new User { Id = "4" });

            data.Games.Add(game1);
            data.Games.Add(game2);
            data.Games.Add(game3);

            data.SaveChanges();

            var userService = new UserService(data);
            var characterService = new CharacterService(data, mapper);

            var cache = new MemoryCache(new MemoryCacheOptions());

            return new GameService(userService, data, mapper, cache, characterService);
        }
    }
}
