using Microsoft.AspNetCore.Mvc;

namespace class01.Controllers
{
    public class MessageController : Controller
    {

        public IActionResult index()
        {
            return View();
        }

        public IActionResult WelcomeMessage()
        {
            return View();
        }

    }
}
