namespace SWN.Data.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    using static DataConstants.EquipmentData;

    public class Equipment
    {
        public int Id { get; init; }

        [Required]
        [MaxLength(NameMaxLength)]
        public string Name { get; set; }

        [Required]
        [MaxLength(TypeMaxLength)]
        public string Type { get; set; }

        public int Cost { get; set; }

        public int Encumbrance { get; set; }

        public int TechLevel { get; set; }

        [Required]
        public string Description { get; set; }

        public ICollection<CharactersEquipments> CharactersEquipments { get; init; } = new HashSet<CharactersEquipments>();
    }
}
