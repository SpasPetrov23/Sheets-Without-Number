namespace SWN.Tests.Services
{
    using SheetsWithoutNumber.Services.Armor;
    using SWN.Data.Models;
    using SWN.Tests.Mocks;
    using System.Linq;
    using Xunit;

    public class ArmorsServiceTests
    {
        [Fact]
        public void ArmorExistsShouldReturnTrueIfArmorIsInDatabase()
        {
            //Arrange
            var armorService = GetArmorService();

            //Act
            var result = armorService.ArmorExists(1);

            //Assert
            Assert.True(result);
        }

        [Fact]
        public void ArmorExistsShouldReturnFalseIfArmorDoesNotExist()
        {
            //Arrange
            var armorService = GetArmorService();

            //Act
            var result = armorService.ArmorExists(12);

            //Assert
            Assert.False(result);
        }

        [Fact]
        public void GetArmorsListingShouldReturnCollectionOfArmorServiceListingViewModel()
        {
            //Arrange
            var armorService = GetArmorService();

            //Act
            var result = armorService.GetArmorListing();

            //Assert
            Assert.Equal(3, result.Count());
        }

        [Fact]
        public void GetCharacterArmorByIdShouldReturnCorrectCharacterArmor()
        {
            //Arrange
            var armorService = GetArmorService();

            //Act
            var result = armorService.GetCharacterArmorById(1);

            //Assert
            Assert.Equal(1, result.Id);
        }

        [Fact]
        public void GetArmorByIdShouldReturnCorrectArmor()
        {
            //Arrange
            var armorService = GetArmorService();

            //Act
            var result = armorService.GetArmorById(1);

            //Assert
            Assert.Equal(1, result.Id);
        }

        [Fact]
        public void DatabaseShouldContainAddedElementViaAddMethod()
        {
            //Arrange
            var armorService = GetArmorService();

            //Act
            var result = armorService.Add(1, 1, "Readied");
            var characterFocus = armorService.GetCharacterArmorById(result);

            //Assert
            Assert.Equal(result, characterFocus.Id);
        }

        [Fact]
        public void EditShouldReturnTrueForEditedEntity()
        {
            //Arrange
            var armorService = GetArmorService();

            //Act
            var result = armorService.Edit(1, 1, "Readied");

            //Assert
            Assert.True(result);
        }

        [Fact]
        public void EditShouldReturnFalseForFailedEdit()
        {
            //Arrange
            var armorService = GetArmorService();

            //Act
            var result = armorService.Edit(1, 14, "Backpack");

            //Assert
            Assert.False(result);
        }

        [Fact]
        public void DatabaseShouldNotContainTheDeletedCharacterArmor()
        {
            //Arrange
            var armorService = GetArmorService();

            //Act
            var deletedCharacterArmorId = armorService.Delete(1);
            var characterArmor = armorService.GetCharacterArmorById(deletedCharacterArmorId);

            //Assert
            Assert.Null(characterArmor);
        }

        private static IArmorService GetArmorService()
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

            data.Armors.Add(new Armor { Id = 1, });
            data.Armors.Add(new Armor { Id = 2, });
            data.Armors.Add(new Armor { Id = 3, });

            data.CharactersArmors.Add(new CharactersArmors { Id = 1, ArmorId = 1, CharacterId = 2 });

            data.SaveChanges();

            return new ArmorService(data, mapper);
        }
    }
}
