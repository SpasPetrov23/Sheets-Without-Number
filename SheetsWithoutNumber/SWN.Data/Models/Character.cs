namespace SWN.Data.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    using static DataConstants.CharacterData;

    public class Character
    {
        public int Id { get; init; }

        [Required]
        [MaxLength(NameMaxLength)]
        public string Name { get; set; }

        public int Strength { get; set; }

        public int Dexterity { get; set; }

        public int Constitution { get; set; }

        public int Charisma { get; set; }

        public int Wisdom { get; set; }

        public int Intelligence { get; set; }

        [Required]
        [MaxLength(SpeciesMaxLength)]
        public string Species { get; set; }

        [Required]
        [MaxLength(HomeworldMaxLength)]
        public string Homeworld { get; set; }

        public int Level { get; set; } = 1;

        public int CurrentXP { get; set; } = 0;

        public int SavingThrowPhysical { get; set; } = 0;

        public int SavingThrowMental { get; set; } = 0;

        public int SavingThrowEvasion { get; set; } = 0;

        public int HitPoints { get; set; } = 0;

        public int MaxHitPoints { get; set; } = 0;

        public int Effort { get; set; } = 0;

        public int SystemStrain { get; set; } = 0;

        public int Speed { get; set; } = 10;

        public int Initiative { get; set; } = 0;

        public int AttackBonus { get; set; } = 0;

        public int ArmorClass { get; set; } = 10;

        public int UnspentSkillPoints { get; set; } = 0;

        [Required]
        [MaxLength(EncumbranceMaxLength)]
        public string Encumbrance { get; set; } = string.Empty;

        public int Credits { get; set; } = 0;

        public string Notes { get; set; } = string.Empty;

        public string Goal { get; set; } = string.Empty;

        public string CharacterImage { get; set; } = string.Empty;

        public string DateCreated { get; set; } = string.Empty;

        /// <summary>
        /// Table Relations Below
        /// </summary>

        [Required]
        public string OwnerId { get; init; }

        public int ClassId { get; set; }

        public Class Class { get; set; }

        public int BackgroundId { get; set; }

        public Background Background { get; set; }

        public ICollection<CharactersSkills> CharactersSkills { get; init; } = new HashSet<CharactersSkills>();

        public ICollection<CharactersFoci> CharactersFoci { get; init; } = new HashSet<CharactersFoci>();

        public ICollection<CharactersEquipments> CharactersEquipments { get; init; } = new HashSet<CharactersEquipments>();

        public ICollection<CharactersArmors> CharactersArmors { get; init; } = new HashSet<CharactersArmors>();

        public ICollection<CharactersMeleeWeapons> CharactersMeleeWeapons { get; init; } = new HashSet<CharactersMeleeWeapons>();

        public ICollection<CharactersRangedWeapons> CharactersRangedWeapons { get; init; } = new HashSet<CharactersRangedWeapons>();

        public int GameId { get; init; }

        public Game Game { get; set; }
    }
}
