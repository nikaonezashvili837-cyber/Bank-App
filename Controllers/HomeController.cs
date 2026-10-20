using Microsoft.AspNetCore.Mvc;

namespace Bank_App.Controllers
{
    public class HomeController : Controller
    {
        // GET: HomeController
        [Route("/")]
        public IActionResult HomePage()
        {
            return Content("<h1>Welcome to homepage</h1>","text/html");
        }

    }
}
