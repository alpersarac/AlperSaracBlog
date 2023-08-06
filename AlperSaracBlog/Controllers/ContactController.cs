using Microsoft.AspNetCore.Mvc;

namespace AlperSaracBlog.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult SubmitForm(string name, string email, string phone, string message)
        {
            // Process the form data here (e.g., send an email, save to database, etc.)

            // Return a success or error response based on your logic
            return Ok(); // You can customize the response as needed
        }
    }
}
