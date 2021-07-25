namespace SheetsWithoutNumber.Models.Users
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public class LoginFormModel
    {

        [Required]
        public string Email { get; init; }

        [Required]
        public string Password { get; init; }
    }
}
