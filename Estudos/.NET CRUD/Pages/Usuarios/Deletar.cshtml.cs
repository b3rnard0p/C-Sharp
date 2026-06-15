using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Linq;

namespace CadastroUsuario.Pages.Usuarios
{
    public class DeletarModel : PageModel
    {
        public IActionResult OnGet(int id)
        {
            string caminhoArquivo = "usuarios.txt";

            if (System.IO.File.Exists(caminhoArquivo))
            {
                string[] linhas = System.IO.File.ReadAllLines(caminhoArquivo);

                var linhasRestantes = linhas
                    .Where(linha => !string.IsNullOrWhiteSpace(linha) && linha.Split(';')[0] != id.ToString())
                    .ToArray();

                System.IO.File.WriteAllLines(caminhoArquivo, linhasRestantes);
            }

            return RedirectToPage("/Usuarios/Index");
        }
    }
}