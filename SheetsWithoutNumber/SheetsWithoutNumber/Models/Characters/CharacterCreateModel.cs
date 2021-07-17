namespace SheetsWithoutNumber.Models.Characters
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    using static SWN.Data.DataConstants;

    public class CharacterCreateModel
    {
        [Required]
        [MaxLength(CharacterNameMaxLength)]
        public string Name { get; init; }

        public int Strength { get; init; }

        public int Dexterity { get; init; }

        public int Constitution { get; init; }

        public int Charisma { get; init; }

        public int Wisdom { get; init; }

        public int Intelligence { get; init; }

        [Required]
        [MaxLength(CharacterSpeciesMaxLength)]
        public string Species { get; init; }

        [Required]
        [MaxLength(CharacterHomeworldMaxLength)]
        public string Homeworld { get; init; }

        public string ClassId { get; init; }

        public IEnumerable<CharacterClassViewModel> Classes { get; init; }
    }
}
