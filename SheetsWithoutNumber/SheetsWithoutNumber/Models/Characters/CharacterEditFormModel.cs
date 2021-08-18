namespace SheetsWithoutNumber.Models.Characters
{
    using System;
    using System.ComponentModel.DataAnnotations;

    using static SWN.Data.DataConstants.CharacterData;

    public class CharacterEditFormModel
    {
        [Required]
        [StringLength(NameMaxLength, MinimumLength = 2)]
        public string Name { get; init; }

        [Range(3, 18)]
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
        [Url]
        [Display(Name = "Image")]
        public string CharacterImage { get; init; }

        [Required]
        [Display(Name = "Current XP")]
        [Range(0, int.MaxValue, ErrorMessage = "Experience cannot be lower than 0.")]
        public int CurrentXP { get; init; }

        [Required]
        [Display(Name = "Hit Points")]
        [Range(0, int.MaxValue, ErrorMessage = "Hit Points cannot be lower than 0.")]
        public int HitPoints { get; init; }

        [Required]
        [Display(Name = "Max Hit Points")]
        [Range(0, int.MaxValue, ErrorMessage = "Hit Points cannot be lower than 0.")]
        public int MaxHitPoints { get; init; }

        [Required]
        [Range(0, int.MaxValue, ErrorMessage = "Effort cannot be lower than 0.")]
        public int Effort { get; init; }

        [Required]
        [Display(Name = "System Strain")]
        [Range(0, int.MaxValue, ErrorMessage = "System Strain cannot be lower than 0.")]
        public int SystemStrain { get; init; }

        [Required]
        [Range(0, int.MaxValue, ErrorMessage = "Credits cannot be lower than 0.")]
        public int Credits { get; init; }

        [Required]
        public string Bio { get; init; }
    }
}
