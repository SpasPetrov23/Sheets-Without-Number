namespace SWN.Data.Models
{
    using System.ComponentModel.DataAnnotations;

    public class CharactersArmors
    {
        public int Id { get; set; }

        public int CharacterId { get; set; }

        public Character Character { get; set; }

        public int ArmorId { get; set; }

        public Armor Armor { get; set; }

        [Required]
        public string ArmorName { get; set; }

        [Required]
        public string ArmorType { get; set; }

        public int ArmorClass { get; set; }

        public int ArmorCost { get; set; }

        public int ArmorEncumbrance { get; set; }

        public int ArmorTechLevel { get; set; }

        [Required]
        public string ArmorLocation { get; set; }

        [Required]
        public string ArmorDescription { get; set; }
    }
}
