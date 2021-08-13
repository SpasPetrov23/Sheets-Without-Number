namespace SWN.Data.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    using static DataConstants.ArmorData;

    public class Armor
    {
        public int Id { get; init; }

        [Required]
        [MaxLength(NameMaxLength)]
        public string Name { get; set; }

        [Required]
        [MaxLength(TypeMaxLength)]
        public string Type { get; set; }

        public int ArmorClass { get; set; }

        public int Cost { get; set; }

        public int Encumbrance { get; set; }

        public int TechLevel { get; set; }

        [Required]
        public string Description { get; set; }

        public ICollection<CharactersArmors> CharactersArmors { get; init; } = new HashSet<CharactersArmors>();
    }
}
