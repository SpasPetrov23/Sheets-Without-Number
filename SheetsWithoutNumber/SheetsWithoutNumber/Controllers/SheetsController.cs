namespace SheetsWithoutNumber.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using SWN.Data;
    using System;

    public class SheetsController : Controller
    {
        private readonly ApplicationDbContext data;

        public SheetsController(ApplicationDbContext data)
        {
            this.data = data;
        }

        public IActionResult All() => View();

        public IActionResult Create(string sheetId)
        {
            return View();
        }
    }
}
