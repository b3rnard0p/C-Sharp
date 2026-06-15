using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace NET_CRUD_Biblioteca.Pages.Livros
{
    public class DeletarModel : PageModel
    {
        public IActionResult OnGet(int id)
        {
            if (System.IO.File.Exists("livros.txt"))
            {
                var linhas = System.IO.File.ReadAllLines("livros.txt")
                    .Where(linha => !string.IsNullOrWhiteSpace(linha) && int.Parse(linha.Split(';')[0]) != id)
                    .ToList();

                System.IO.File.WriteAllLines("livros.txt", linhas);
            }

            return RedirectToPage("/Livros/Index");
        }
    }
}