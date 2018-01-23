using Microsoft.AspNetCore.Mvc;

namespace TeamCore.Controllers
{
    [Route("")]
    public class HomeController : Controller
    {
        [HttpGet, Route("")]
        public IActionResult Index()
        {
            return Redirect("~/login");
        }


        [HttpGet, Route(Shared.Routes.Home.Login)]
        public IActionResult Login()
        {
            return View();
        }
    }
}