namespace SheetsWithoutNumber.Services.Focus
{
    using System.Collections.Generic;

    public interface IFocusService
    {
        public int Add(int characterId, int focusId, int level);

        public bool Edit(int level, int focusId, int characterFocusId);

        public int Delete(int focusSkillId);

        public IEnumerable<FocusServiceListingViewModel> GetFociListing();

        public bool FocusExists(int focusId);

        public bool FocusIsLearned(int focusId, int characterId);

        public CharacterFocusServiceModel GetCharacterFocusById(int characterFocusId);

        public FocusServiceListingViewModel GetFocusById(int focusId);
    }
}
