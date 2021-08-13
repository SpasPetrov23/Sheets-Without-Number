namespace SWN.Data.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    using static DataConstants.FocusData;

    public class Focus
    {
        public int Id { get; init; }

        [Required]
        [MaxLength(NameMaxLength)]
        public string Name { get; set; }

        [Required]
        public string Description { get; set; }

        public ICollection<CharactersFoci> CharactersFoci { get; init; } = new HashSet<CharactersFoci>();
    }
}
