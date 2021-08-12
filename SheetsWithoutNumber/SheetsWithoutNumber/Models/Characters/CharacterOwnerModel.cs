namespace SheetsWithoutNumber.Models.Characters
{
    public class CharacterOwnerModel
    {
        public int Id { get; init; }

        public string OwnerId { get; set; }

        public string Class { get; set; }

        public int Level { get; set; }
    }
}
