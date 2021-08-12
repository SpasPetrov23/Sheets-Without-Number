namespace SheetsWithoutNumber.Models.Characters
{
    using SWN.Data.Models;
    using System.Collections.Generic;

    public class CharacterDetailsModel
    {
        public int Id { get; init; }

        public string OwnerId { get; init; }

        public string UserId { get; set; }

        public string Name { get; init; }

        public int Strength { get; init; }

        public int StrengthMod { get; set; }

        public int Dexterity { get; init; }

        public int DexterityMod { get; set; }

        public int Constitution { get; init; }

        public int ConstitutionMod { get; set; }

        public int Charisma { get; init; }

        public int CharismaMod { get; set; }

        public int Wisdom { get; init; }

        public int WisdomMod { get; set; }

        public int Intelligence { get; init; }

        public int IntelligenceMod { get; set; }

        public string Species { get; init; }

        public string Homeworld { get; init; }

        public int ClassId { get; init; }

        public string Class { get; init; }

        public int BackgroundId { get; init; }

        public string Background { get; init; }

        public string CharacterImage { get; init; }

        public int HitPoints { get; init; }

        public int MaxHitPoints { get; init; }

        public int Effort { get; init; }

        public int MaxEffort { get; set; }

        public int SystemStrain { get; init; }

        public int MaxSystemStrain { get; set; }

        public int SavingThrowPhysical { get; set; } 

        public int SavingThrowMental { get; set; }

        public int SavingThrowEvasion { get; set; }

        public int Speed { get; set; }

        public int Initiative { get; set; }

        public int AttackBonus { get; set; }

        public int ArmorClass { get; set; }

        public int GameId { get; init; }

        public Game Game { get; init; }

        public int Level { get; init; }

        public ICollection<CharactersSkills> CharactersSkills { get; set; }

        public ICollection<CharactersFoci> CharactersFoci { get; set; }

        public int CurrentXP { get; init; }

        public int MinimumXP { get; set; }

        public int MaximumXP { get; set; }

        public int XPBarWidth { get; set; }
    }
}
