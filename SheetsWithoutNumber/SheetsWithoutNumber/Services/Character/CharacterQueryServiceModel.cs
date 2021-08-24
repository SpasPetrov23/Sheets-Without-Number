namespace SheetsWithoutNumber.Services.Character
{
    using SheetsWithoutNumber.Models.Characters;
    using System.Collections.Generic;

    public class CharacterQueryServiceModel
    {
        public string Class { get; init; }

        public IEnumerable<CharacterClassViewModel> Classes { get; init; }

        public IEnumerable<CharacterListingModel> Characters { get; init; }

    }
}
