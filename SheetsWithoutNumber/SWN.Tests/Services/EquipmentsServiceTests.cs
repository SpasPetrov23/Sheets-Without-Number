namespace SWN.Tests.Services
{
    using SheetsWithoutNumber.Services.Equipments;
    using SWN.Data.Models;
    using SWN.Tests.Mocks;
    using System.Linq;
    using Xunit;

    public class EquipmentsServiceTests
    {
        [Fact]
        public void EquipmentExistsShouldReturnTrueIfEquipmentIsInDatabase()
        {
            //Arrange
            var equipmentService = GetEquipmentService();

            //Act
            var result = equipmentService.EquipmentExists(1);

            //Assert
            Assert.True(result);
        }

        [Fact]
        public void EquipmentExistsShouldReturnFalseIfEquipmentDoesNotExist()
        {
            //Arrange
            var equipmentService = GetEquipmentService();

            //Act
            var result = equipmentService.EquipmentExists(12);

            //Assert
            Assert.False(result);
        }

        [Fact]
        public void GetEquipmentsListingShouldReturnCollectionOfEquipmentServiceListingViewModel()
        {
            //Arrange
            var equipmentService = GetEquipmentService();

            //Act
            var result = equipmentService.GetEquipmentListing();

            //Assert
            Assert.Equal(3, result.Count());
        }

        [Fact]
        public void GetCharacterEquipmentByIdShouldReturnCorrectCharacterEquipment()
        {
            //Arrange
            var equipmentService = GetEquipmentService();

            //Act
            var result = equipmentService.GetCharacterEquipmentById(1);

            //Assert
            Assert.Equal(1, result.Id);
        }

        [Fact]
        public void GetEquipmentByIdShouldReturnCorrectEquipment()
        {
            //Arrange
            var equipmentService = GetEquipmentService();

            //Act
            var result = equipmentService.GetEquipmentById(1);

            //Assert
            Assert.Equal(1, result.Id);
        }

        [Fact]
        public void DatabaseShouldContainAddedElementViaAddMethod()
        {
            //Arrange
            var equipmentService = GetEquipmentService();

            //Act
            var result = equipmentService.Add(1, 2, 3, "Backpack");
            var characterFocus = equipmentService.GetCharacterEquipmentById(result);

            //Assert
            Assert.Equal(result, characterFocus.Id);
        }

        [Fact]
        public void EditShouldReturnTrueForEditedEntity()
        {
            //Arrange
            var equipmentService = GetEquipmentService();

            //Act
            var result = equipmentService.Edit(1, 1, 1, "Backpack");

            //Assert
            Assert.True(result);
        }

        [Fact]
        public void EditShouldReturnFalseForFailedEdit()
        {
            //Arrange
            var equipmentService = GetEquipmentService();

            //Act
            var result = equipmentService.Edit(3, 2, 14, "Backpack");

            //Assert
            Assert.False(result);
        }

        [Fact]
        public void DatabaseShouldNotContainTheDeletedCharacterEquipment()
        {
            //Arrange
            var equipmentService = GetEquipmentService();

            //Act
            var deletedCharacterEquipmentId = equipmentService.Delete(1);
            var characterEquipment = equipmentService.GetCharacterEquipmentById(deletedCharacterEquipmentId);

            //Assert
            Assert.Null(characterEquipment);
        }

        private static IEquipmentService GetEquipmentService()
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

            data.Equipments.Add(new Equipment { Id = 1, });
            data.Equipments.Add(new Equipment { Id = 2, });
            data.Equipments.Add(new Equipment { Id = 3, });

            data.CharactersEquipments.Add(new CharactersEquipments { Id = 1, EquipmentId = 1, CharacterId = 2 });

            data.SaveChanges();

            return new EquipmentService(data, mapper);
        }
    }
}