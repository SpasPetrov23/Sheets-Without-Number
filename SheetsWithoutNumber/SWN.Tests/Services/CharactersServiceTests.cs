namespace SWN.Tests.Services
{
    using AutoMapper;
    using SheetsWithoutNumber.Infrastructure;
    using SheetsWithoutNumber.Services.Character;
    using SWN.Data.Models;
    using SWN.Tests.Mocks;
    using Xunit;

    using static SWN.Data.DataConstants.ClassData;

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
        public void DatabaseShouldNotContainTheDeletedCharacterArmor()
        {
            //Arrange
            var characterService = GetCharacterService();

            //Act
            var deletedCharacterId = characterService.Delete(5);

            //Assert
            Assert.NotNull(deletedCharacterId);
        }

        [Fact]
        public void ClassExistsShouldReturnIdOfClassIfItExists()
        {
            //Arrange
            var characterService = GetCharacterService();

            //Act
            var classId = characterService.ClassExists(1);

            //Assert
            Assert.True(classId);
        }

        [Fact]
        public void BackgroundExistsShouldReturnIdOfBackgroundIfItExists()
        {
            //Arrange
            var characterService = GetCharacterService();

            //Act
            var backgroundId = characterService.BackgroundExists(1);

            //Assert
            Assert.True(backgroundId);
        }

        [Fact]
        public void AttackBonusShouldReturn3ForWarriorLevel3()
        {
            //Arrange
            var characterService = GetCharacterService();

            //Act
            var attackBonus = characterService.CalculateAttackBonus(WarriorClassName, 3);

            //Assert
            Assert.Equal(3, attackBonus);
        }

        [Fact]
        public void AttackBonusShouldReturn2ForPartialWarriorLevel3()
        {
            //Arrange
            var characterService = GetCharacterService();

            //Act
            var attackBonus = characterService.CalculateAttackBonus(ExpertWarriorClassName, 3);
            var attackBonus2 = characterService.CalculateAttackBonus(PsychicWarriorClassName, 3);

            //Assert
            Assert.Equal(2, attackBonus);
            Assert.Equal(2, attackBonus2);
        }

        [Fact]
        public void AttackBonusShouldReturn4ForPartialWarriorLevel5()
        {
            //Arrange
            var characterService = GetCharacterService();

            //Act
            var attackBonus = characterService.CalculateAttackBonus(ExpertWarriorClassName, 5);
            var attackBonus2 = characterService.CalculateAttackBonus(PsychicWarriorClassName, 5);

            //Assert
            Assert.Equal(4, attackBonus);
            Assert.Equal(4, attackBonus2);
        }

        [Fact]
        public void AttackBonusShouldReturn1ForNonWarriorLevel3()
        {
            //Arrange
            var characterService = GetCharacterService();

            //Act
            var attackBonus = characterService.CalculateAttackBonus(ExpertClassName, 3);
            var attackBonus2 = characterService.CalculateAttackBonus(PsychicClassName, 3);

            //Assert
            Assert.Equal(1, attackBonus);
            Assert.Equal(1, attackBonus2);
        }

        [Fact]
        public void SpeedShouldReturn10WhenNormalEncumbered()
        {
            //Arrange
            var characterService = GetCharacterService();

            //Act
            var speed = characterService.CalculateSpeed("Normal");

            //Assert
            Assert.Equal(10, speed);
        }

        [Fact]
        public void SpeedShouldReturn7WhenLightlyEncumbered()
        {
            //Arrange
            var characterService = GetCharacterService();

            //Act
            var speed = characterService.CalculateSpeed("Lightly Encumbered");

            //Assert
            Assert.Equal(7, speed);
        }

        [Fact]
        public void SpeedShouldReturn5WhenHeavilyEncumbered()
        {
            //Arrange
            var characterService = GetCharacterService();

            //Act
            var speed = characterService.CalculateSpeed("Heavily Encumbered");

            //Assert
            Assert.Equal(5, speed);
        }

        [Fact]
        public void SpeedShouldReturn0WhenOverburdened()
        {
            //Arrange
            var characterService = GetCharacterService();

            //Act
            var speed = characterService.CalculateSpeed("Overburdened");

            //Assert
            Assert.Equal(0, speed);
        }

        [Fact]
        public void EncumbranceShouldBeNormalIfSurplusReadiedIsLessThan4()
        {
            //Arrange
            var characterService = GetCharacterService();

            //Act
            var encumbrance = characterService.CalculateEncumbrance(2, 4, 10, 10);

            //Assert
            Assert.Equal("Normal", encumbrance);
        }

        [Fact]
        public void EncumbranceShouldBeLightIfSurplusReadiedIsBetween1And2()
        {
            //Arrange
            var characterService = GetCharacterService();

            //Act
            var encumbrance = characterService.CalculateEncumbrance(5, 4, 10, 10);

            //Assert
            Assert.Equal("Lightly Encumbered", encumbrance);
        }

        [Fact]
        public void EncumbranceShouldBeHeavyIfSurplusReadiedIsIsBetween3And4()
        {
            //Arrange
            var characterService = GetCharacterService();

            //Act
            var encumbrance = characterService.CalculateEncumbrance(7, 4, 10, 10);

            //Assert
            Assert.Equal("Heavily Encumbered", encumbrance);
        }

        [Fact]
        public void EncumbranceShouldBeOverburdenedIfSurplusReadiedIsIsHigherThan4()
        {
            //Arrange
            var characterService = GetCharacterService();

            //Act
            var encumbrance = characterService.CalculateEncumbrance(9, 4, 10, 10);

            //Assert
            Assert.Equal("Overburdened!", encumbrance);
        }

        [Fact]
        public void SavingThrowPhysicalShouldReturn13ForLevel2With1StrengthAndMinus1Const()
        {
            //Arrange
            var characterService = GetCharacterService();

            //Act
            var savingThrow = characterService.CalculateSavingThrow(2, 1, -1, 0, 0, 0, 0, "Physical");

            //Assert
            Assert.Equal(13, savingThrow);
        }

        [Fact]
        public void SavingThrowMenalShouldReturn11ForLevel3With2WisdomAnd0Charisma()
        {
            //Arrange
            var characterService = GetCharacterService();

            //Act
            var savingThrow = characterService.CalculateSavingThrow(3, 0, 0, 0, 2, 0, 0, "Mental");

            //Assert
            Assert.Equal(11, savingThrow);
        }

        [Fact]
        public void SavingThrowEvasionShouldReturn12ForLevel3With1DexterityAnd1Intelligence()
        {
            //Arrange
            var characterService = GetCharacterService();

            //Act
            var savingThrow = characterService.CalculateSavingThrow(3, 0, 0, 1, 0, 0, 1, "Evasion");

            //Assert
            Assert.Equal(12, savingThrow);
        }

        [Fact]
        public void SavingThrowEvasionShouldReturn15ForLevel1With0DexterityAnd0Intelligence()
        {
            //Arrange
            var characterService = GetCharacterService();

            //Act
            var savingThrow = characterService.CalculateSavingThrow(1, 0, 0, 0, 0, 0, 0, "Evasion");

            //Assert
            Assert.Equal(15, savingThrow);
        }

        [Fact]
        public void LevelShouldReturnCorrectLevel()
        {
            //Arrange
            var characterService = GetCharacterService();

            //Act
            var level1 = characterService.CalculateLevel(2);
            var level2 = characterService.CalculateLevel(4);
            var level3 = characterService.CalculateLevel(8);
            var level4 = characterService.CalculateLevel(15);
            var level5 = characterService.CalculateLevel(20);
            var level6 = characterService.CalculateLevel(30);
            var level7 = characterService.CalculateLevel(40);
            var level8 = characterService.CalculateLevel(55);
            var level9 = characterService.CalculateLevel(75);
            var level10 = characterService.CalculateLevel(95);
            var level11 = characterService.CalculateLevel(120);

            //Assert
            Assert.Equal(1, level1);
            Assert.Equal(2, level2);
            Assert.Equal(3, level3);
            Assert.Equal(4, level4);
            Assert.Equal(5, level5);
            Assert.Equal(6, level6);
            Assert.Equal(7, level7);
            Assert.Equal(8, level8);
            Assert.Equal(9, level9);
            Assert.Equal(10, level10);
            Assert.Equal(11, level11);
        }

        private static ICharacterService GetCharacterService()
        {
            var data = DatabaseMock.Instance;
            var mapper = MapperMock.Instance;

            data.Classes.Add(new Class { Id = 1 });
            data.Classes.Add(new Class { Id = 2 });

            data.Backgrounds.Add(new Background { Id = 1 });

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
