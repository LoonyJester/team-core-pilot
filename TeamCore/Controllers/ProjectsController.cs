using Microsoft.AspNetCore.Mvc;

namespace TeamCore.Controllers
{
    [Route(Shared.Routes.ClientsPrefix)]
    public class ProjectsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet, Route(Shared.Routes.Project.Add)]
        [HttpGet, Route(Shared.Routes.Project.Info)]
        public IActionResult Info()
        {
            return View();
        }
        [HttpGet, Route(Shared.Routes.Project.AssignedEmployee)]
        public IActionResult AssignedProjects()
        {
            return View();
        }
    }
}