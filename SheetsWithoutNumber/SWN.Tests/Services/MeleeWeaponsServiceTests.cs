namespace SWN.Tests.Services
{
    using SheetsWithoutNumber.Services.MeleeWeapon;
    using SWN.Data.Models;
    using SWN.Tests.Mocks;
    using System.Linq;
    using Xunit;

    public class MeleeWeaponsServiceTests
    {
        [Fact]
        public void MeleeWeaponExistsShouldReturnTrueIfMeleeWeaponIsInDatabase()
        {
            //Arrange
            var meleeWeaponService = GetMeleeWeaponService();

            //Act
            var result = meleeWeaponService.MeleeWeaponExists(1);

            //Assert
            Assert.True(result);
        }

        [Fact]
        public void MeleeWeaponExistsShouldReturnFalseIfMeleeWeaponDoesNotExist()
        {
            //Arrange
            var meleeWeaponService = GetMeleeWeaponService();

            //Act
            var result = meleeWeaponService.MeleeWeaponExists(12);

            //Assert
            Assert.False(result);
        }

        [Fact]
        public void GetCharacterMeleeWeaponByIdShouldReturnCorrectId()
        {
            //Arrange
            var meleeWeaponService = GetMeleeWeaponService();

            //Act
            var result = meleeWeaponService.GetCharacterMeleeWeaponById(1);

            //Assert
            Assert.Equal(1, result.Id);
        }

        [Fact]
        public void GetMeleeWeaponByIdShouldReturnCorrectId()
        {
            //Arrange
            var meleeWeaponService = GetMeleeWeaponService();

            //Act
            var result = meleeWeaponService.GetMeleeWeaponById(1);

            //Assert
            Assert.Equal(1, result.Id);
        }

        [Fact]
        public void GetMeleeWeaponListingShouldReturnCorrectAmountOfResults()
        {
            //Arrange
            var meleeWeaponService = GetMeleeWeaponService();

            //Act
            var result = meleeWeaponService.GetMeleeWeaponListing();

            //Assert
            Assert.Equal(3, result.Count());
        }

        [Fact]
        public void DatabaseShouldContainAddedElementViaAddMethod()
        {
            //Arrange
            var meleeWeaponService = GetMeleeWeaponService();

            //Act
            var result = meleeWeaponService.Add(1, 1, "Readied");
            var characterFocus = meleeWeaponService.GetCharacterMeleeWeaponById(result);

            //Assert
            Assert.Equal(result, characterFocus.Id);
        }

        [Fact]
        public void EditShouldReturnTrueForEditedEntity()
        {
            //Arrange
            var meleeWeaponService = GetMeleeWeaponService();

            //Act
            var result = meleeWeaponService.Edit(1, 1, "Readied");

            //Assert
            Assert.True(result);
        }

        [Fact]
        public void EditShouldReturnFalseForFailedEdit()
        {
            //Arrange
            var meleeWeaponService = GetMeleeWeaponService();

            //Act
            var result = meleeWeaponService.Edit(1, 14, "Backpack");

            //Assert
            Assert.False(result);
        }

        [Fact]
        public void DatabaseShouldNotContainTheDeletedCharacterMeleeWeapon()
        {
            //Arrange
            var meleeWeaponService = GetMeleeWeaponService();

            //Act
            var deletedCharacterMeleeWeaponId = meleeWeaponService.Delete(1);
            var characterMeleeWeapon = meleeWeaponService.GetCharacterMeleeWeaponById(deletedCharacterMeleeWeaponId);

            //Assert
            Assert.Null(characterMeleeWeapon);
        }

        private static IMeleeWeaponService GetMeleeWeaponService()
        {
            var data = DatabaseMock.Instance;
            var mapper = MapperMock.Instance;

            data.Characters.Add(new Character { Id = 1 });
            data.Characters.Add(new Character { Id = 2 });
            data.Characters.Add(new Character { Id = 3 });
            data.Characters.Add(new Character { Id = 4 });

            data.MeleeWeapons.Add(new MeleeWeapon { Id = 1, });
            data.MeleeWeapons.Add(new MeleeWeapon { Id = 2, });
            data.MeleeWeapons.Add(new MeleeWeapon { Id = 3, });

            data.CharactersMeleeWeapons.Add(new CharactersMeleeWeapons { Id = 1, MeleeWeaponId = 1, CharacterId = 2 });

            data.SaveChanges();

            return new MeleeWeaponService(data, mapper);
        }
    }
}
