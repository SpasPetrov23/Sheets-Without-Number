namespace SWN.Data.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;

    using static DataConstants;

    public class Equipment
    {
        [Required]
        public string Id { get; init; } = Guid.NewGuid().ToString();

        [Required]
        [MaxLength(ItemTypeMaxLength)]
        public string Type { get; set; }

        public int Cost { get; set; }

        public int Encumbrance { get; set; }

        public int TechLevel { get; set; }

        [Required]
        public string Description { get; set; }
    }
}
