using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Formulario.Pages
{
    public class NotasModel : PageModel
    {
        [BindProperty]
        public double Nota1 { get; set; }
        [BindProperty]
        public double Nota2 { get; set; }
        public double? Media { get; set; }
        public string ResultadoFinal { get; private set; }
        public void OnGet()
        {
        }

        public void OnPost()
        {
            Media = (Nota1 + Nota2) / 2;

            if (Media >= 7.0)
            {
                ResultadoFinal = "Aprovado";
            }
            else ResultadoFinal = "Reprovado";
        }
    }
}
