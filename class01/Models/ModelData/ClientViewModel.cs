using System.ComponentModel.DataAnnotations;

namespace class01.Models.ModelData
{
    public class ClientViewModel
    {
        [Required(ErrorMessage = "É obrigatório a inserção de um Nome")] //Obriga a inserção do campo abaixo
        [Display(Name = "Nome e Sobrenome")]
        public string Name { get; set; }
        
        [Display(Name = "Telefone")]
        public string Cellphone { get; set; }

        [Display(Name = "Endereço")]
        public string Adress { get; set; }
    }
}
