namespace SheetsWithoutNumber.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using SheetsWithoutNumber.Models.Characters;
    using SWN.Data;
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class CharactersController : Controller
    {
        private readonly SWNDbContext data;

        public CharactersController(SWNDbContext data)
        {
            this.data = data;
        }

        public IActionResult All() => View();

        public IActionResult Create() => View(new CharacterCreateModel 
        {
            Classes = this.GetCharacterClasses()
        });

        [HttpPost]
        public IActionResult Create(CharacterCreateModel characterModel)
        {
            return View();
        }

        private IEnumerable<CharacterClassViewModel> GetCharacterClasses()
            => this.data
            .Classes.Select(c => new CharacterClassViewModel
            {
                Id = c.Id,
                Name = c.Name
            })
            .ToList();
    }
}
