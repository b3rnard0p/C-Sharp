using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Formulario.Pages
{
    public class AcessoModel : PageModel
    {
        [BindProperty]
        public string Nome { get; set; }

        [BindProperty]
        public int Idade { get; set; }

        public string MensagemDeRetorno { get; private set; }

        public void OnGet()
        {
        }

        public void OnPost()
        {
            if (Idade >= 18)
            {
                MensagemDeRetorno = $"Opa, {Nome}! Chega mais.";
            }
            else
            {
                MensagemDeRetorno = $"Calma lá, {Nome}! Menores não meu chapa.";
            }
        }
    }
}