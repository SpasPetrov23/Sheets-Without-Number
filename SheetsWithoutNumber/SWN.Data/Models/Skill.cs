namespace SWN.Data.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    using static DataConstants.Skill;

    public class Skill
    {
        [Required]
        public string Id { get; init; } = Guid.NewGuid().ToString();

        [Required]
        [MaxLength(NameMaxLength)]
        public string Name { get; set; }

        public int Level { get; set; }

        [Required]
        public string Description { get; set; }

        public bool IsPsychic { get; set; }

        public ICollection<Character> Characters { get; init; } = new HashSet<Character>();

    }
}
