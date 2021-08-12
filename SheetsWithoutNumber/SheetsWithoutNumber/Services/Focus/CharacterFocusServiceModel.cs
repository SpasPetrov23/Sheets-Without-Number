namespace SheetsWithoutNumber.Services.Focus
{
    public class CharacterFocusServiceModel
    {
        public int Id { get; init; }

        public int CharacterId { get; set; }

        public int FocusId { get; set; }

        public string FocusName { get; init; }

        public int FocusLevel { get; set; }

        public string FocusDescription { get; init; }
    }
}
