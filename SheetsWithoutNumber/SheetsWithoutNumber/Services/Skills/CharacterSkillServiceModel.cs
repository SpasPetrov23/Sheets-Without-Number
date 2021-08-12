namespace SheetsWithoutNumber.Services.Skills
{
    public class CharacterSkillServiceModel
    {
        public int Id { get; init; }

        public int CharacterId { get; set; }

        public int SkillId { get; set; }

        public string SkillName { get; init; }

        public int SkillLevel { get; set; }

        public bool IsSkillPsychic { get; set; }

        public string SkillDescription { get; init; }
    }
}
