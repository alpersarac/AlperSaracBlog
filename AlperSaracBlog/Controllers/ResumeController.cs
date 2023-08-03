using Microsoft.AspNetCore.Mvc;

namespace AlperSaracBlog.Controllers
{
    public class ResumeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
