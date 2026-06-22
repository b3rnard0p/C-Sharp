using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ControleConsultas.Pages.Atendimentos
{
    public class DeletarModel : PageModel
    {
        public IActionResult OnGet(int id)
        {
            if (System.IO.File.Exists("atendimentos.txt"))
            {
                var linhas = System.IO.File.ReadAllLines("atendimentos.txt")
                    .Where(linha => !string.IsNullOrWhiteSpace(linha)
                                    && int.Parse(linha.Split(';')[0]) != id)
                    .ToList();

                System.IO.File.WriteAllLines("atendimentos.txt", linhas);
            }

            return RedirectToPage("/Atendimentos/Index");
        }
    }
}
