namespace SWN.Tests.Services
{
    using SheetsWithoutNumber.Services.RangedWeapon;
    using SWN.Data.Models;
    using SWN.Tests.Mocks;
    using System.Linq;
    using Xunit;

    public class RangedWeaponsServiceTests
    {
        [Fact]
        public void RangedWeaponExistsShouldReturnTrueIfRangedWeaponIsInDatabase()
        {
            //Arrange
            var rangedWeaponService = GetRangedWeaponService();

            //Act
            var result = rangedWeaponService.RangedWeaponExists(1);

            //Assert
            Assert.True(result);
        }

        [Fact]
        public void RangedWeaponExistsShouldReturnFalseIfRangedWeaponDoesNotExist()
        {
            //Arrange
            var rangedWeaponService = GetRangedWeaponService();

            //Act
            var result = rangedWeaponService.RangedWeaponExists(12);

            //Assert
            Assert.False(result);
        }

        [Fact]
        public void GetCharacterRangedWeaponByIdShouldReturnCorrectId()
        {
            //Arrange
            var rangedWeaponService = GetRangedWeaponService();

            //Act
            var result = rangedWeaponService.GetCharacterRangedWeaponById(1);

            //Assert
            Assert.Equal(1, result.Id);
        }

        [Fact]
        public void GetRangedWeaponByIdShouldReturnCorrectId()
        {
            //Arrange
            var rangedWeaponService = GetRangedWeaponService();

            //Act
            var result = rangedWeaponService.GetRangedWeaponById(1);

            //Assert
            Assert.Equal(1, result.Id);
        }

        [Fact]
        public void GetRangedWeaponListingShouldReturnCorrectAmountOfResults()
        {
            //Arrange
            var rangedWeaponService = GetRangedWeaponService();

            //Act
            var result = rangedWeaponService.GetRangedWeaponListing();

            //Assert
            Assert.Equal(3, result.Count());
        }

        [Fact]
        public void DatabaseShouldContainAddedElementViaAddMethod()
        {
            //Arrange
            var rangedWeaponService = GetRangedWeaponService();

            //Act
            var result = rangedWeaponService.Add(1, 1, 2, "Readied");
            var characterFocus = rangedWeaponService.GetCharacterRangedWeaponById(result);

            //Assert
            Assert.Equal(result, characterFocus.Id);
        }

        [Fact]
        public void EditShouldReturnTrueForEditedEntity()
        {
            //Arrange
            var rangedWeaponService = GetRangedWeaponService();

            //Act
            var result = rangedWeaponService.Edit(1, 1, 2, "Readied");

            //Assert
            Assert.True(result);
        }

        [Fact]
        public void EditShouldReturnFalseForFailedEdit()
        {
            //Arrange
            var rangedWeaponService = GetRangedWeaponService();

            //Act
            var result = rangedWeaponService.Edit(1, 14, 2, "Backpack");

            //Assert
            Assert.False(result);
        }

        [Fact]
        public void DatabaseShouldNotContainTheDeletedCharacterRangedWeapon()
        {
            //Arrange
            var rangedWeaponService = GetRangedWeaponService();

            //Act
            var deletedCharacterRangedWeaponId = rangedWeaponService.Delete(1);
            var characterRangedWeapon = rangedWeaponService.GetCharacterRangedWeaponById(deletedCharacterRangedWeaponId);

            //Assert
            Assert.Null(characterRangedWeapon);
        }

        [Fact]
        public void IsAmmoValidShouldReturnTrueIfAmmoIsLowerThanMagazine()
        {
            //Arrange
            var rangedWeaponService = GetRangedWeaponService();

            //Act
            var isValid = rangedWeaponService.IsAmmoValid(2, 1);

            //Assert
            Assert.True(isValid);
        }

        [Fact]
        public void IsAmmoValidShouldReturnFalseIfAmmoIsHigherThanMagazine()
        {
            //Arrange
            var rangedWeaponService = GetRangedWeaponService();

            //Act
            var isValid = rangedWeaponService.IsAmmoValid(15, 1);

            //Assert
            Assert.False(isValid);
        }

        private static IRangedWeaponService GetRangedWeaponService()
        {
            var data = DatabaseMock.Instance;
            var mapper = MapperMock.Instance;

            data.Characters.Add(new Character { Id = 1 });
            data.Characters.Add(new Character { Id = 2 });
            data.Characters.Add(new Character { Id = 3 });
            data.Characters.Add(new Character { Id = 4 });

            data.RangedWeapons.Add(new RangedWeapon { Id = 1, Magazine = 10});
            data.RangedWeapons.Add(new RangedWeapon { Id = 2});
            data.RangedWeapons.Add(new RangedWeapon { Id = 3});

            data.CharactersRangedWeapons.Add(new CharactersRangedWeapons { Id = 1, RangedWeaponId = 1, CharacterId = 2 });

            data.SaveChanges();

            return new RangedWeaponService(data, mapper);
        }
    }
}
