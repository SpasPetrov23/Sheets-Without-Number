namespace SheetsWithoutNumber.Controllers
{
    using Microsoft.AspNetCore.Mvc;

    public class GamesController : Controller
    {
        public IActionResult All()
        {
            return View();
        }
    }
}
