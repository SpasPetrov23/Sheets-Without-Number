namespace SheetsWithoutNumber.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using SheetsWithoutNumber.Models.Characters;
    using SWN.Data;
    using System;

    public class CharactersController : Controller
    {
        private readonly ApplicationDbContext data;

        public CharactersController(ApplicationDbContext data)
        {
            this.data = data;
        }

        public IActionResult All() => View();

        public IActionResult Create() => View();

        [HttpPost]
        public IActionResult Create(CharacterCreateModel characterModel)
        {
            return View();
        }
    }
}
