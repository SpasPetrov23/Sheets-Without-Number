namespace SWN.Tests.Services
{
    using SheetsWithoutNumber.Services.Skill;
    using SWN.Data.Models;
    using SWN.Tests.Mocks;
    using System.Linq;
    using Xunit;

    using static Data.DataConstants.ClassData;

    public class SkillsServiceTests
    {
        [Fact]
        public void SkillExistsShouldReturnTrueIfSkillIsInDatabase()
        {
            //Arrange
            var skillService = GetSkillService();

            //Act
            var result = skillService.SkillExists(1);

            //Assert
            Assert.True(result);
        }

        [Fact]
        public void SkillExistsShouldReturnFalseIfSkillDoesNotExist()
        {
            //Arrange
            var skillService = GetSkillService();

            //Act
            var result = skillService.SkillExists(12);

            //Assert
            Assert.False(result);
        }

        [Fact]
        public void AllowSkillShouldReturnFalseForNonPsychicsTryingPsychicSkills()
        {
            //Arrange
            var skillService = GetSkillService();

            //Act
            var result = skillService.AllowSkill(1, 2);

            //Assert
            Assert.False(result);
        }

        [Fact]
        public void AllowSkillShouldReturnTrueForPsychicsTryingPsychicSkills()
        {
            //Arrange
            var skillService = GetSkillService();

            //Act
            var result = skillService.AllowSkill(1, 3);
            var result2 = skillService.AllowSkill(1, 4);
            var result3 = skillService.AllowSkill(1, 1);

            //Assert
            Assert.True(result);
            Assert.True(result2);
            Assert.True(result3);
        }

        [Fact]
        public void AllowSkillShouldReturnTrueForNonPsychicSkills()
        {
            //Arrange
            var skillService = GetSkillService();

            //Act
            var result = skillService.AllowSkill(2, 3);

            //Assert
            Assert.True(result);
        }

        [Fact]
        public void SkillIsLearnedShouldReturnTrueIfCharacterHasIt()
        {
            //Arrange
            var skillService = GetSkillService();

            //Act
            var result = skillService.SkillIsLearned(2, 1);

            //Assert
            Assert.True(result);
        }

        [Fact]
        public void SkillIsLearnedShouldReturnFalseIfCharacterDoesNotHaveIt()
        {
            //Arrange
            var skillService = GetSkillService();

            //Act
            var result = skillService.SkillIsLearned(3, 1);

            //Assert
            Assert.False(result);
        }

        [Fact]
        public void GetSkillsShouldReturnCollectionOfSkillServiceListingViewModel()
        {
            //Arrange
            var skillService = GetSkillService();

            //Act
            var result = skillService.GetSkillListing();

            //Assert
            Assert.Equal(2, result.Count());
        }

        [Fact]
        public void GetCharacterSkillByIdShouldReturnCorrectCharacterSkill()
        {
            //Arrange
            var skillService = GetSkillService();

            //Act
            var result = skillService.GetCharacterSkillById(1);

            //Assert
            Assert.Equal(1, result.Id);
        }


        [Fact]
        public void GetSkillByIdShouldReturnCorrectSkill()
        {
            //Arrange
            var skillService = GetSkillService();

            //Act
            var result = skillService.GetSkillById(1);

            //Assert
            Assert.Equal(1, result.Id);
        }

        [Fact]
        public void DatabaseShouldContainAddedElementViaAddMethod()
        {
            //Arrange
            var skillService = GetSkillService();

            //Act
            var result = skillService.Add(1, 2, 3);
            var characterSkill = skillService.GetCharacterSkillById(result);

            //Assert
            Assert.Equal(result, characterSkill.Id);
        }

        [Fact]
        public void EditShouldReturnTrueForEditedEntity()
        {
            //Arrange
            var skillService = GetSkillService();

            //Act
            var result = skillService.Edit(1, 2, 1);

            //Assert
            Assert.True(result);
        }

        [Fact]
        public void EditShouldReturnFalseForFailedEdit()
        {
            //Arrange
            var skillService = GetSkillService();

            //Act
            var result = skillService.Edit(1, 2, 15);

            //Assert
            Assert.False(result);
        }

        [Fact]
        public void DatabaseShouldNotContainTheDeletedCharacterSkill()
        {
            //Arrange
            var skillService = GetSkillService();

            //Act
            var deletedCharacterSkillId = skillService.Delete(1);
            var characterSkill = skillService.GetCharacterSkillById(deletedCharacterSkillId);

            //Assert
            Assert.Null(characterSkill);
        }

        private static ISkillService GetSkillService()
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

            data.Skills.Add(new Skill { Id = 1, IsPsychic = true });
            data.Skills.Add(new Skill { Id = 2, IsPsychic = false });

            data.CharactersSkills.Add(new CharactersSkills { Id = 1, SkillId = 2, CharacterId = 1 });

            data.SaveChanges();

            return new SkillService(data, mapper);
        }
    }
}
