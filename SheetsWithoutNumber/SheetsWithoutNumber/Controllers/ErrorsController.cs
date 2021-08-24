namespace SheetsWithoutNumber.Controllers
{
    using Microsoft.AspNetCore.Mvc;

    public class ErrorsController : Controller
    {
        public IActionResult Index(int statusCode)
        {
            ViewBag.StatusCode = statusCode;

            string responseName = statusCode switch
            {
                400 => "Bad Request",
                401 => "Unauthorized",
                403 => "Forbidden",
                404 => "Not Found",
                408 => "Request Timeout",
                500 => "Internal Server Error",
                501 => "Not Implemented",
                502 => "Bad Gateway",
                503 => "Service Unavailable",
                _ => ""
            };

            ViewBag.ResponseName = responseName;

            return View();
        }
    }
}
