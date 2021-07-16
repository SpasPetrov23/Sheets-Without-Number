namespace SheetsWithoutNumber.Models.Characters
{
    using System;
    using System.ComponentModel.DataAnnotations;

    using static SWN.Data.DataConstants;

    public class CharacterCreateModel
    {
        [Required]
        [MaxLength(SheetCharacterNameMaxLength)]
        public string Name { get; set; }

        public int Strength { get; set; }

        public int Dexterity { get; set; }

        public int Constitution { get; set; }

        public int Charisma { get; set; }

        public int Wisdom { get; set; }

        public int Intelligence { get; set; }

        [Required]
        [MaxLength(SheetSpeciesMaxLength)]
        public string Species { get; set; }

        [Required]
        [MaxLength(SheetHomeworldMaxLength)]
        public string Homeworld { get; set; }
    }
}
