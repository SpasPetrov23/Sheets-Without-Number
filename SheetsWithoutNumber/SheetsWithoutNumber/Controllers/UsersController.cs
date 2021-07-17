namespace SheetsWithoutNumber.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using SheetsWithoutNumber.Models.Users;
    using SWN.Data;
    using SWN.Data.Models;
    using System;

    public class UsersController : Controller
    {
        private readonly SWNDbContext data;

        public UsersController(SWNDbContext data)
        {
            this.data = data;
        }

        public IActionResult Register() => View();

        [HttpPost]
        public IActionResult Register(RegisterUserFormModel model)
        {
            var user = new User
            {
                Username = model.Username,
                Password = model.Password,
                Email = model.Email,
                JoinDate = DateTime.Now
            };

            data.Users.Add(user);

            data.SaveChanges();

            return Redirect("/");
        }
    }
}
