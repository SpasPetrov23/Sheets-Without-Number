namespace SheetsWithoutNumber.Services.Character
{
    using SheetsWithoutNumber.Models.Characters;
    using System.Collections.Generic;

    public interface ICharacterService
    {
        public IEnumerable<CharacterListingModel> ByUser(string userId);

        public int Create(string name, int backgroundId, int classId, string characterImage, int strength, int constitution, int dexterity, int wisdom, int intelligence, int charisma, string homeworld, string species, string bio, string ownerId, int gameId);

        public CharacterDetailsModel Details(int characterId, string userId);

        public bool Edit(int characterId, string name, string characterImage, int strength, int dexterity, int constitution, int intelligence, int charisma, int wisdom, int currentXP, int hitPoints, int maxHitPoints, int effort, int systemStrain, int credits, string bio);

        public int Delete(int characterId);

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
