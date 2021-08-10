namespace SheetsWithoutNumber.Controllers
{
    using AutoMapper;
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;
    using SheetsWithoutNumber.Infrastructure;
    using SheetsWithoutNumber.Models.Games;
    using SheetsWithoutNumber.Services.Game;

    public class GamesController : Controller
    {
        private readonly IGameService games;
        private readonly IMapper mapper;

        public GamesController(IGameService game, IMapper mapper)
        {
            this.games = game;
            this.mapper = mapper;
        }

        [Authorize]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [Authorize]
        public IActionResult Create(GameFormModel gameModel)
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
            var currentUserId = User.Identity.IsAuthenticated 
                ? this.User.GetId() 
                : null;

            ViewBag.UserIsSignedIn = User.Identity.IsAuthenticated;

            var allGames = this.games.All(currentUserId);

            return View(allGames);
        }

        [Authorize]
        public IActionResult Details(int gameId)
        {
            var gameDetails = games.Details(gameId);

            return View(gameDetails);
        }

        [Authorize]
        public IActionResult Edit(int gameId)
        {
            var currentUserId = this.User.GetId();

            var game = this.games.Details(gameId);

            if (game.GameMasterId != currentUserId)
            {
                return Unauthorized();
            }

            var gameForm = this.mapper.Map<GameFormModel>(game);

            return View(gameForm);
        }

        [Authorize]
        [HttpPost]
        public IActionResult Edit(int gameId, GameFormModel game)
        {
            if (!games.PlayerMaxIsValid(gameId, game.PlayersMax))
            {
                this.ModelState.AddModelError(nameof(game.PlayersMax), "Max Players cannot be lower than current Players in the game.");
            }

            if (!ModelState.IsValid)
            {
                return View(game);
            }

            this.games.Edit(gameId, game.Name, game.Description, game.GameImage, game.PlayersMax);

            return RedirectToAction("Details", "Games", new { gameId = gameId });
        }


        [Authorize]
        public IActionResult Delete(int gameId)
        {
            games.Delete(gameId);

            return RedirectToAction("All", "Games");
        }

        [Authorize]
        public IActionResult Join(int gameId)
        {
            var currentUserId = this.User.GetId();

            this.games.Join(gameId, currentUserId);

            return RedirectToAction("Details", "Games", new { gameId = gameId });
        }
    }
}
