namespace SWN.Tests.Services
{
    using SheetsWithoutNumber.Services.Focus;
    using SWN.Data.Models;
    using SWN.Tests.Mocks;
    using System.Linq;
    using Xunit;

    using static Data.DataConstants.ClassData;
    using static Data.DataConstants.FocusData;

    public class FociServiceTests
    {
        [Fact]
        public void FocusExistsShouldReturnTrueIfFocusIsInDatabase()
        {
            //Arrange
            var focusService = GetFocusService();

            //Act
            var result = focusService.FocusExists(1);

            //Assert
            Assert.True(result);
        }

        [Fact]
        public void FocusExistsShouldReturnFalseIfFocusDoesNotExist()
        {
            //Arrange
            var focusService = GetFocusService();

            //Act
            var result = focusService.FocusExists(12);

            //Assert
            Assert.False(result);
        }

        [Fact]
        public void AllowFocusShouldReturnFalseWhenNonPsychicsTryToLearnPsychicTraining()
        {
            //Arrange
            var focusService = GetFocusService();

            //Act
            var result = focusService.AllowFocus(2, 2);

            //Assert
            Assert.False(result);
        }

        [Fact]
        public void AllowFocusShouldReturnFalseWhenPsychicsTryToLearnWildPsychicTalent()
        {
            //Arrange
            var focusService = GetFocusService();

            //Act
            var result = focusService.AllowFocus(3, 1);
            var result2 = focusService.AllowFocus(3, 3);
            var result3 = focusService.AllowFocus(3, 4);

            //Assert
            Assert.False(result);
            Assert.False(result2);
            Assert.False(result3);
        }

        [Fact]
        public void AllowFocusShouldReturnTrueForNonPsychicFoci()
        {
            //Arrange
            var focusService = GetFocusService();

            //Act
            var result = focusService.AllowFocus(1, 1);

            //Assert
            Assert.True(result);
        }

        [Fact]
        public void FocusIsLearnedShouldReturnTrueIfCharacterHasIt()
        {
            //Arrange
            var focusService = GetFocusService();

            //Act
            var result = focusService.FocusIsLearned(1, 2);

            //Assert
            Assert.True(result);
        }

        [Fact]
        public void FocusIsLearnedShouldReturnFalseIfCharacterDoesNotHaveIt()
        {
            //Arrange
            var focusService = GetFocusService();

            //Act
            var result = focusService.FocusIsLearned(1, 3);

            //Assert
            Assert.False(result);
        }

        [Fact]
        public void GetFociShouldReturnCollectionOfFocusServiceListingViewModel()
        {
            //Arrange
            var focusService = GetFocusService();

            //Act
            var result = focusService.GetFociListing();

            //Assert
            Assert.Equal(3, result.Count());
        }

        [Fact]
        public void GetCharacterFocusByIdShouldReturnCorrectCharacterFocus()
        {
            //Arrange
            var focusService = GetFocusService();

            //Act
            var result = focusService.GetCharacterFocusById(1);

            //Assert
            Assert.Equal(1, result.Id);
        }

        [Fact]
        public void GetFocusByIdShouldReturnCorrectFocus()
        {
            //Arrange
            var focusService = GetFocusService();

            //Act
            var result = focusService.GetFocusById(1);

            //Assert
            Assert.Equal(1, result.Id);
        }

        [Fact]
        public void DatabaseShouldContainAddedElementViaAddMethod()
        {
            //Arrange
            var focusService = GetFocusService();

            //Act
            var result = focusService.Add(1, 1, 1);
            var characterFocus = focusService.GetCharacterFocusById(result);

            //Assert
            Assert.Equal(result, characterFocus.Id);
        }

        [Fact]
        public void EditShouldReturnTrueForEditedEntity()
        {
            //Arrange
            var focusService = GetFocusService();

            //Act
            var result = focusService.Edit(1, 1, 1);

            //Assert
            Assert.True(result);
        }

        [Fact]
        public void EditShouldReturnFalseForFailedEdit()
        {
            //Arrange
            var focusService = GetFocusService();

            //Act
            var result = focusService.Edit(1, 1, 15);

            //Assert
            Assert.False(result);
        }

        [Fact]
        public void DatabaseShouldNotContainTheDeletedCharacterFocus()
        {
            //Arrange
            var focusService = GetFocusService();

            //Act
            var deletedCharacterFocusId = focusService.Delete(1);
            var characterFocus = focusService.GetCharacterFocusById(deletedCharacterFocusId);

            //Assert
            Assert.Null(characterFocus);
        }

        private static IFocusService GetFocusService()
        {
            var data = DatabaseMock.Instance;
            var mapper = MapperMock.Instance;

            data.Classes.Add(new Class { Id = 1, Name = PsychicClassName });
            data.Classes.Add(new Class { Id = 2, Name = PsychicWarriorClassName });
            data.Classes.Add(new Class { Id = 3, Name = ExpertPsychicClassName });
            data.Classes.Add(new Class { Id = 4, Name = WarriorClassName });

            data.Characters.Add(new Character { Id = 1, ClassId = 1 });
            data.Characters.Add(new Character { Id = 2, ClassId = 4 });
            data.Characters.Add(new Character { Id = 3, ClassId = 2 });
            data.Characters.Add(new Character { Id = 4, ClassId = 3 });

            data.Foci.Add(new Focus { Id = 1, Name = FocusAuthorityName });
            data.Foci.Add(new Focus { Id = 2, Name = FocusPsychicTrainingName });
            data.Foci.Add(new Focus { Id = 3, Name = FocusWildPsychicTalentName });

            data.CharactersFoci.Add(new CharactersFoci { Id = 1, FocusId = 1, CharacterId = 2 });

            data.SaveChanges();

            return new FocusService(data, mapper);
        }
    }
}
