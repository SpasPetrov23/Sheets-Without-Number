namespace SWN.Data.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    using static DataConstants;

    public class Class
    {
        [Required]
        public string Id { get; init; } = Guid.NewGuid().ToString();

        [Required]
        [MaxLength(FocusNameMaxLength)]
        public string Name { get; set; }

        [Required]
        public string Ability { get; set; }

        [Required]
        public string Description { get; set; }

        public ICollection<Character> Characters { get; init; } = new HashSet<Character>();

    }
}
