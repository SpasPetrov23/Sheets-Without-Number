namespace SheetsWithoutNumber.Models.Characters
{
    using SWN.Data.Models;

    public class CharacterDetailsModel
    {
        public int Id { get; init; }

        public string Name { get; init; }

        public int Strength { get; init; }

        public int Dexterity { get; init; }

        public int Constitution { get; init; }

        public int Charisma { get; init; }

        public int Wisdom { get; init; }

        public int Intelligence { get; init; }

        public string Species { get; init; }

        public string Homeworld { get; init; }

        public int ClassId { get; init; }

        public string Class { get; init; }

        public int BackgroundId { get; init; }

        public string Background { get; init; }

        public string CharacterImage { get; init; }

        public string OwnerId { get; init; }

        public int GameId { get; init; }

        public Game Game { get; init; }

        public int Level { get; init; }

        public int CurrentXP { get; init; }

        public int MinimumXP { get; init; }

        public int MaximumXP { get; init; }

        public int XPBarWidth { get; set; }
    }
}
