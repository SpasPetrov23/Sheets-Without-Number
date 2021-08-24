namespace SheetsWithoutNumber.Models.Characters
{
    using System.Collections.Generic;

    public class MyCharactersQueryModel
    {
        public string Class { get; init; }

        public IEnumerable<CharacterClassViewModel> Classes { get; set; }

        public IEnumerable<CharacterListingModel> Characters { get; set; }

        public CharacterSorting Sorting { get; init; }
    }
}
