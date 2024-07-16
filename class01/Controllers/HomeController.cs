using class01.Controllers.Base;
using class01.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Globalization;


//import classe para herança
namespace class01.Controllers
{
    public class HomeController : BaseController //Classe herdada
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
            GeneralMessage("Mensagem herdada de um método da classe \"BaseController\"", "info");
            return View();
        }

        [HttpPost]
        public IActionResult Privacy(string Id, String Name)
        {
            //Gerenciamento de ERRORS: Método herdado de BaseController
            if ((string.IsNullOrEmpty(Name)) && (string.IsNullOrEmpty(Id)))
                GeneralMessage("Insira um Nome e um ID", "error");
            else if (string.IsNullOrEmpty(Name))
                GeneralMessage("Insira um Nome", "error");
            else if (string.IsNullOrEmpty(Id))
                GeneralMessage("Insira um ID", "error");
            else
            {
                GeneralMessage("Entrando na aplicação", "success");
                //return View("Index");
            }
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

        //Retornar uma View específica dentro de um método
        public IActionResult ReturnCustomView()
        {
        //Retorna o conteúdo da View Privacy
        return View("Privacy");
        }
    }
}
