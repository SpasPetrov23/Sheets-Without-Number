namespace SWN.Data.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;

    using static DataConstants;

    public class Contact
    {
        [Required]
        public string Id { get; init; } = Guid.NewGuid().ToString();

        [Required]
        [MaxLength(ContactNameMaxLength)]
        public string Name { get; set; }

        public string Description { get; set; }
    }
}
