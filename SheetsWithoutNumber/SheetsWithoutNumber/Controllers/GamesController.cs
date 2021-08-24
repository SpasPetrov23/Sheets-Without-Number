namespace SheetsWithoutNumber.Controllers
{
    using AutoMapper;
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;
    using SheetsWithoutNumber.Infrastructure;
    using SheetsWithoutNumber.Models.Games;
    using SheetsWithoutNumber.Services.Game;
    using System.Linq;

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

            games.Create(gameModel.Name, gameModel.Description, gameModel.GameImage, gameModel.PlayersMax, currentUserId);

            return RedirectToAction("Index", "Home");
        }

        public IActionResult All([FromQuery]AllGamesQueryModel query)
        {
            var currentUserId = User.Identity.IsAuthenticated
                ? this.User.GetId()
                : null;

            ViewBag.UserIsSignedIn = User.Identity.IsAuthenticated;

            var allGames = this.games.All(
                currentUserId,
                query.Sorting,
                query.SearchTerm,
                AllGamesQueryModel.GamesPerPage,
                query.CurrentPage);

            query.Games = allGames.Games;
            query.TotalGames = allGames.TotalGames;

            return View(query);
        }

        [Authorize]
        public IActionResult Details(int gameId, string information)
        {
            var gameDetails = games.Details(gameId);

            if (information != gameDetails.GetGameUrlInfo())
            {
                return BadRequest();
            }

            return View(gameDetails);
        }

        [Authorize]
        public IActionResult Edit(int gameId)
        {
            var currentUserId = this.User.GetId();

            var game = this.games.Details(gameId);

            var isAdmin = User.IsAdmin();

            if (game.GameMasterId != currentUserId && !isAdmin)
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

            return RedirectToAction("Details", "Games", new { gameId = gameId, information = game.GetGameUrlInfo() });
        }


        [Authorize]
        public IActionResult Delete(int gameId)
        {
            var currentUserId = this.User.GetId();

            var game = this.games.Details(gameId);

            if (game.GameMasterId != currentUserId && !User.IsAdmin())
            {
                return Unauthorized();
            }

            games.Delete(gameId);

            return RedirectToAction("All", "Games");
        }

        [Authorize]
        public IActionResult Join(int gameId)
        {
            var currentUserId = this.User.GetId();

            var game = this.games.Join(gameId, currentUserId);

            return RedirectToAction("Details", "Games", new { gameId = gameId, information = game.GetGameUrlInfo() });
        }

        [Authorize]
        public IActionResult Leave(int gameId)
        {
            var currentUserId = this.User.GetId();

            var game = this.games.Leave(gameId, currentUserId);

            return RedirectToAction("Details", "Games", new { gameId = gameId, information = game.GetGameUrlInfo() });
        }
    }
}
