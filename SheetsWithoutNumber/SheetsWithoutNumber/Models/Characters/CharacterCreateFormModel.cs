namespace SheetsWithoutNumber.Models.Characters
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    using static SWN.Data.DataConstants.Character;

    public class CharacterCreateFormModel
    {
        [Required]
        [StringLength(NameMaxLength, MinimumLength = 2)]
        public string Name { get; init; }

        [Range(3,18)]
        public int Strength { get; init; }

        [Range(3, 18)]
        public int Dexterity { get; init; }

        [Range(3, 18)]
        public int Constitution { get; init; }

        [Range(3, 18)]
        public int Charisma { get; init; }

        [Range(3, 18)]
        public int Wisdom { get; init; }

        [Range(3, 18)]
        public int Intelligence { get; init; }

        [Required]
        [StringLength(SpeciesMaxLength, MinimumLength = 2)]
        public string Species { get; init; }

        [Required]
        [StringLength(HomeworldMaxLength, MinimumLength = 2)]
        public string Homeworld { get; init; }

        [Required]
        [Url]
        [Display(Name = "Image")]
        public string CharacterImage { get; init; }

        public int ClassId { get; init; }

        public IEnumerable<CharacterClassViewModel> Classes { get; set; }

        public int BackgroundId { get; init; }

        public IEnumerable<CharacterBackgroundView> Backgrounds { get; set; }
    }
}
