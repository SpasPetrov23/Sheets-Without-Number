namespace SheetsWithoutNumber.Services.Character
{
    using SheetsWithoutNumber.Models.Characters;
    using System.Collections.Generic;

    public interface ICharacterService
    {
        public CharacterQueryServiceModel ByUser(
            string userId,
            CharacterSorting sorting,
            string className);

        public int Create(string name, int backgroundId, int classId, string characterImage, int strength, int constitution, int dexterity, int wisdom, int intelligence, int charisma, string homeworld, string species, string bio, string ownerId, int gameId);

        public CharacterDetailsModel Details(int characterId, string userId);

        public bool Edit(int characterId, CharacterEditFormModel characterEdit);

        public int Delete(int characterId);

        public bool ClearCharacterRelations(int characterId);

        public IEnumerable<CharacterClassViewModel> GetCharacterClasses();

        public IEnumerable<CharacterBackgroundViewModel> GetCharacterBackgrounds();

        public CharacterOwnerModel GetCharacterById(int characterId);

        public bool ClassExists(int classId);

        public bool BackgroundExists(int backgroundId);

        public int CalculateAttackBonus(string className, int level);

        public int CalculateSpeed(string encumbrance);

        public string CalculateEncumbrance(int currentReadiedEncumbrance, int maxReadiedEncumbrance, int currentStowedEncumbrance, int maxStowedEncumbrance);

        public int CalculateSavingThrow(int level, int strengthMod, int constitutionMod, int dexterityMod, int wisdomMod, int charismaMod, int intelligenceMod, string savingThrowType);

        public int CalculateLevel(int currentXP);
    }
}
