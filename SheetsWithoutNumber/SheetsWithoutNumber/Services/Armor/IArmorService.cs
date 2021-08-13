namespace SheetsWithoutNumber.Services.Armor
{
    using System.Collections.Generic;

    public interface IArmorService
    {
        public int Add(int characterId, int armorId, string location);

        public bool Edit(int armorId, int characterArmorId, string location);

        public int Delete(int characterArmorId);

        public IEnumerable<ArmorServiceListingViewModel> GetArmorListing();

        public bool ArmorExists(int armorId);

        public CharacterArmorServiceModel GetCharacterArmorById(int characterArmorId);

    }
}
