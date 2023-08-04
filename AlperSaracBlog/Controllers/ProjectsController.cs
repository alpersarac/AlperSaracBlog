using Microsoft.AspNetCore.Mvc;

namespace AlperSaracBlog.Controllers
{
    public class ProjectsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
