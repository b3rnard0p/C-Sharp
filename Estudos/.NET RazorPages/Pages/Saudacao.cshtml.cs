using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HelloWord.Pages
{
    public class SaudacaoModel : PageModel
    {
        public string Mensagem = "";


        public void OnGet()
        {
            Mensagem = "Hello World";
        }
    }
}
