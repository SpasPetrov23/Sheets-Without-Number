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
        private readonly SWNDbContext data;
        private readonly IGameService game;

        public GamesController(IGameService game, SWNDbContext data)
        {
            this.data = data;
            this.game = game;
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

            game.Create(gameModel.Name, gameModel.Description, gameModel.PlayersMax, gameModel.GameImage, currentUserId);

            return RedirectToAction("Index", "Home");
        }

        public IActionResult All()
        {
            var games = data
                .Games
                .Select(g => new GamePreviewModel
                {
                    Id = g.Id,
                    Name = g.Name,
                    PlayersCurrent = g.Users.Count,
                    PlayersMax = g.PlayersMax,
                    Description = g.Description,
                    GameImage = g.GameImage,
                    Users = g.Users
                })
                .ToList();

            return View(games);
        }

        [Authorize]
        public IActionResult Details(int gameId)
        {
            var game = data
                .Games
                .Where(g => g.Id == gameId)
                .Select(g => new GameDetailsModel
                {
                    Id = g.Id,
                    Name = g.Name,
                    Description = g.Description,
                    GameImage = g.GameImage,
                    Players = g.Users,
                    Characters = g.Characters,
                    GameMasterId = g.GameMasterId,
                    PlayersMax = g.PlayersMax
                })
                .FirstOrDefault();

            return View(game);
        }

        [Authorize]
        public IActionResult Join(int gameId)
        {
            var game = data.Games.FirstOrDefault(g => g.Id == gameId);

            var currentUser = data.Users.FirstOrDefault(u => u.Id == this.User.GetId());

            game.Users.Add(currentUser);

            data.SaveChanges();

            return RedirectToAction("Details", "Games", new { gameId = gameId });
        }
    }
}
