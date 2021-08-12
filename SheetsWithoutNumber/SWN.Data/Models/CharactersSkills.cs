namespace SWN.Data.Models
{
    using System.ComponentModel.DataAnnotations;

    public class CharactersSkills
    {
        [Required]
        public int Id { get; set; }

        public int CharacterId { get; set; }

        public Character Character { get; set; }

        public int SkillId { get; set; }

        public Skill Skill { get; set; }

        [Required]
        public string SkillName { get; set; }

        public int SkillLevel { get; set; }

        public bool IsSkillPsychic { get; set; }

        [Required]
        public string SkillDescription { get; set; }
    }
}
