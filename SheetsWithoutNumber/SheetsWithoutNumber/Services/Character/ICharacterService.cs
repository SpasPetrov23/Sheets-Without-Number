namespace SheetsWithoutNumber.Services.Character
{
    using SheetsWithoutNumber.Models.Characters;
    using System.Collections.Generic;

    public interface ICharacterService
    {
        public IEnumerable<CharacterListingModel> All();

        public int Create(string name, int backgroundId, int classId, string characterImage, int strength, int constitution, int dexterity, int wisdom, int intelligence, int charisma, string homeworld, string species, string ownerId, int gameId);

        public CharacterDetailsModel Details(int characterId);

        public IEnumerable<CharacterClassViewModel> GetCharacterClasses();

        public IEnumerable<CharacterBackgroundView> GetCharacterBackgrounds();

        public bool ClassExists(int classId);

        public bool BackgroundExists(int backgroundId);
    }
}
