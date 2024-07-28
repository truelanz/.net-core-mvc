using AutoMapper;
using class01.Controllers.Base;
using class01.Models.ModelData;
using Elfie.Serialization;
using Microsoft.AspNetCore.Mvc;

namespace class01.Controllers
{
    public class ClientController : BaseController
    {
        private readonly IMapper _mapper;

        public ClientController(IMapper mapper)
        {
            _mapper = mapper;
        }

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
            var client = new ClientModel() { CPF = "1111", Adress = "Rua Páprica Defumada", Id = 1, Name = "Lwis", Cellphone = "9977665522", CreditCard = "12345678"};
            var clientVM = _mapper.Map<ClientViewModel>(client);
            return View(clientVM);
        }

        //Post com ClientViewModel, pegar dados da View e mandar para o servidor.
        [HttpPost]
        public IActionResult Create(ClientViewModel client)
        {
            //Se o modelo não for valido
            //if (!ModelState.IsValid) // obriga a inserção de todos campos do ModelView
            if (string.IsNullOrEmpty(client.Name)) //Obriga a inserção somente do campo "Name"
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

        //Action com Quere String "Client/Details?Name=Alan"
        public IActionResult Details(string Name)
        {
            return View();
        }
    }
}
