namespace SWN.Data.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    using static DataConstants.Player;

    public class Player
    {
        public int Id { get; init; }

        [Required]
        [MaxLength(UsernameMaxLength)]
        public string Username { get; set; }

        [Required]
        public string UserId { get; set; }

        public DateTime JoinDate { get; set; }

        public ICollection<Game> Games { get; init; } = new HashSet<Game>();
    }
}
