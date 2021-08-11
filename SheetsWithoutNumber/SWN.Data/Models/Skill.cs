namespace SWN.Data.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    using static DataConstants.SkillData;

    public class Skill
    {
        [Required]
        public int Id { get; set; }

        [Required]
        [MaxLength(NameMaxLength)]
        public string Name { get; set; }

        public string Description { get; set; }

        public bool IsPsychic { get; set; }

        public ICollection<CharactersSkills> CharactersSkills { get; init; } = new HashSet<CharactersSkills>();

    }
}
