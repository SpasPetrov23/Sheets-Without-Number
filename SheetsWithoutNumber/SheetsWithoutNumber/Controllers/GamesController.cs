namespace SheetsWithoutNumber.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using SheetsWithoutNumber.Infrastructure;
    using SheetsWithoutNumber.Models.Games;
    using SWN.Data;
    using SWN.Data.Models;
    using System;
    using System.Linq;

    public class GamesController : Controller
    {
        private readonly SWNDbContext data;

        public GamesController(SWNDbContext data)
        {
            this.data = data;
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(GameCreateFormModel gameModel)
        {
            if (!ModelState.IsValid)
            {
                return View(gameModel);
            }

            var game = new Game
            {
                Name = gameModel.Name,
                Description = gameModel.Description,
                PlayersMax = gameModel.PlayersMax,
                StartDate = DateTime.Now.ToString("d"),
                SessionsCount = 0,
                GameImage = gameModel.GameImage,
                GameMasterId = this.User.GetId(),
            };

            data.Add(game);
            data.SaveChanges();

            return RedirectToAction("Index", "Home");
        }

        public IActionResult All()
        {
            var characters = data
                .Games
                .Select(g => new GamePreviewModel
                {
                    Name = g.Name,
                    PlayersCurrent = g.Users.Count,
                    PlayersMax = g.PlayersMax,
                    Description = g.Description,
                    GameImage = g.GameImage
                })
                .ToList();

            return View(characters);
        }
    }
}
