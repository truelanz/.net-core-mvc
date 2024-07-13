using class01.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Globalization;

namespace class01.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Privacy()
        {
            ViewData["Title"] = "Privacy";
            ViewBag.Teste = "Isso é um teste";
            ViewBag.Name = "TRUELANZ";
            return View();
        }

        [HttpPost]
        public IActionResult Privacy(string Id, String Name)
        {
            return View();
        }

        //ROTA personalizada com string
        [Route("Home/Rota/Personalizada/{name}")]
        public IActionResult TestName(string name)
        {
            return Content($"Hello User { name }");
        }

        //ROTA com sobrecarga com PARAMETRO id int PADRÃO
        public IActionResult TestId(int id)
        {
            return Content($"Hello User { id }");
        }

    }
}
