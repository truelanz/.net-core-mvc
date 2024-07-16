using class01.Controllers.Base;
using class01.Models.ModelData;
using Microsoft.AspNetCore.Mvc;

namespace class01.Controllers
{
    public class ClientController : BaseController
    {
        //Get com ClientViewModel - Pegar(adicionar) dados do server(controller) e mandar para view.
        public IActionResult Index()
        {
            List<ClientViewModel> clientList = new List<ClientViewModel>() 
            {
                new ClientViewModel() { Name = "truelanz", Adress = "Ovostruz", Cellphone = "123"},
                new ClientViewModel() { Name = "paprica", Adress = "defumada", Cellphone = "321"}
            };
            return View(clientList);
        }

        public IActionResult Create()
        {
            return View();
        }

        //Post com ClientViewModel, pegar dados da View e mandar para o servidor.
        [HttpPost]
        public IActionResult Create(ClientViewModel client)
        {
            if (string.IsNullOrEmpty(client.Name))
            {
                GeneralMessage("Campo nome é obrigatório", "error");
                return View(client);
            }
            else
            {
                List<ClientViewModel> clientList = new List<ClientViewModel>();
                clientList.Add(client);

                GeneralMessage("Cliente salvo", "success");
                return View("Index", clientList);
            }
        }
    }
}
