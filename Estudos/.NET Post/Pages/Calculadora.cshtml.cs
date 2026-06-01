using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Formulario.Pages
{
    public class CalculadoraModel : PageModel
    {
        [BindProperty]
        public int Numero1 { get; set; }

        [BindProperty]
        public int Numero2 { get; set; }

        public int? Resultado { get; private set; }
        public string MensagemDeErro { get; private set; }

        public void OnGet()
        {
        }

        public void OnPost()
        {
            try
            {
                Resultado = Numero1 / Numero2;
            }
            catch (DivideByZeroException)
            {
                MensagemDeErro = "Não pode dividir por zero paizão!";
            }
        }
    }
}