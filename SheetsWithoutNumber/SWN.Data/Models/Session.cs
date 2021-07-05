namespace SWN.Data.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public class Session
    {
        [Required]
        public string UserId { get; init; }

        public User User { get; set; }

        [Required]
        public string GameId { get; init; }

        public Game Game { get; set; }

        [Required]
        public string UserRoleId { get; init; }

        public UserRole UserRole { get; set; }
    }
}
