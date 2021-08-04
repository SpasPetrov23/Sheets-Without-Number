﻿namespace SheetsWithoutNumber.Controllers
{
    using Microsoft.AspNetCore.Authorization;
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

            var currentUser = data.Users.FirstOrDefault(u => u.Id == this.User.GetId());

            game.Users.Add(currentUser);

            data.Add(game);
            data.SaveChanges();

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
                    GameImage = g.GameImage
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
                    
                })
                .FirstOrDefault();

            return View(game);
        }
    }
}
