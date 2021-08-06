namespace SheetsWithoutNumber.Controllers
{
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;
    using SheetsWithoutNumber.Infrastructure;
    using SheetsWithoutNumber.Models.Games;
    using SheetsWithoutNumber.Services.Game;
    using SWN.Data;
    using SWN.Data.Models;
    using System;
    using System.Linq;

    public class GamesController : Controller
    {
        private readonly IGameService games;

        public GamesController(IGameService game)
        {
            this.games = game;
        }

        [Authorize]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [Authorize]
        public IActionResult Create(GameCreateFormModel gameModel)
        {
            if (!ModelState.IsValid)
            {
                return View(gameModel);
            }

            var currentUserId = this.User.GetId();

            games.Create(gameModel.Name, gameModel.Description, gameModel.PlayersMax, gameModel.GameImage, currentUserId);

            return RedirectToAction("Index", "Home");
        }

        public IActionResult All()
        {
            var allGames = this.games.All();

            return View(allGames);
        }

        [Authorize]
        public IActionResult Details(int gameId)
        {
            var gameDetails = games.Details(gameId);

            return View(gameDetails);
        }

        [Authorize]
        public IActionResult Join(int gameId)
        {
            var currentUser = this.User.GetId();

            this.games.Join(gameId, currentUser);

            return RedirectToAction("Details", "Games", new { gameId = gameId });
        }
    }
}
