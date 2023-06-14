using Microsoft.AspNetCore.Mvc;

namespace Mvc_Part_2.Controllers
{
    public class HomeController : Controller
    {
        [Route("/")]
        [Route("home")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
