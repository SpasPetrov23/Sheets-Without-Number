namespace SWN.Data.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    using static DataConstants;

    public class UserRole
    {
        [Required]
        public string Id { get; init; } = Guid.NewGuid().ToString();

        [Required]
        [MaxLength(UserRoleNameMaxLength)]
        public string Name { get; set; }

        public ICollection<Session> Sessions { get; init; } = new HashSet<Session>();
    }
}
