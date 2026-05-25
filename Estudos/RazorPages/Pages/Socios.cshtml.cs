using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HelloWord.Pages
{
    public class SociosModel : PageModel
    {
        public List<SocioTorcedor> ListaSocios { get; set; }

        public void OnGet()
        {
            ListaSocios = new List<SocioTorcedor>
            {
                new SocioTorcedor { Nome = "Carlos Silva", Categoria = "Ouro", Idade = 34, Mensalidade = 120.00m },
                new SocioTorcedor { Nome = "Amanda Souza", Categoria = "Prata", Idade = 28, Mensalidade = 85.00m },
                new SocioTorcedor { Nome = "Lucas Defeito Idade", Categoria = "Bronze", Idade = -5, Mensalidade = 50.00m },
                new SocioTorcedor { Nome = "Mariana Desconto", Categoria = "Bronze", Idade = 22, Mensalidade = 20.00m }
            };
        }
    }
}
