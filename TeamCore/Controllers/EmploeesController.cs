using Microsoft.AspNetCore.Mvc;

namespace TeamCore.Controllers
{
    [Route(Shared.Routes.ClientsPrefix)]
    public class EmploeesController : Controller
    {
        [HttpGet, Route(Shared.Routes.Employee.GetList)]
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet, Route(Shared.Routes.Employee.Info)]
        public IActionResult Info()
        {
            return View();
        }

        [HttpGet, Route(Shared.Routes.Employee.Add)]
        public IActionResult Add()
        {
            return View("Info");
        }

        [HttpGet, Route(Shared.Routes.Employee.Skills)]
        public IActionResult Skills()
        {
            return View();
        }

        [HttpGet, Route(Shared.Routes.Employee.AssignedProjects)]
        public IActionResult AssignedProjects()
        {
            return View();
        }
    }
}