using Microsoft.AspNetCore.Mvc;

namespace AlperSaracBlog.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
