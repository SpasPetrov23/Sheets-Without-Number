namespace SWN.Data.Models
{
    using Microsoft.AspNetCore.Identity;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    using static DataConstants.UserData;

    public class User : IdentityUser
    {
        public DateTime JoinDate { get; set; }

        public ICollection<Game> Games { get; init; } = new HashSet<Game>();
    }
}
