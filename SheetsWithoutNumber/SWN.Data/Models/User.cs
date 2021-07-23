namespace SWN.Data.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    using static DataConstants.User;

    public class User
    {
        [Required]
        public string Id { get; init; } = Guid.NewGuid().ToString();

        [Required]
        [MaxLength(UsernameMaxLength)]
        public string Username { get; set; }

        [Required]
        public string Password { get; set; }

        [Required]
        public string Email { get; set; }

        public DateTime JoinDate { get; set; }

        public ICollection<Session> Sessions { get; init; } = new HashSet<Session>();

        public ICollection<Character> Characters { get; init; } = new HashSet<Character>();
    }
}
