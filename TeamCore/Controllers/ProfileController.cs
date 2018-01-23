using Microsoft.AspNetCore.Mvc;

namespace TeamCore.Controllers
{
    [Route(Shared.Routes.ClientsPrefix)]
    public class ProfileController : Controller
    {
        [HttpGet, Route(Shared.Routes.Profile.MainInfo)]
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet, Route(Shared.Routes.Profile.Skills)]
        public IActionResult Skills()
        {
            return View();
        }


    }
}