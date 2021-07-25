namespace SheetsWithoutNumber.Models.Users
{
    using System;
    using System.ComponentModel.DataAnnotations;

    using static SWN.Data.DataConstants.User;

    public class RegisterFormModel
    {
        [Required]
        public string Username { get; init; }

        [Required]
        [RegularExpression(EmailRegularExpression, ErrorMessage = "Invalid email address format.")]
        public string Email { get; init; }

        [Required]
        public string Password { get; init; }

        [Required]
        [Display(Name = "Confirm Password")]
        public string ConfirmPassword { get; init; }
    }
}
