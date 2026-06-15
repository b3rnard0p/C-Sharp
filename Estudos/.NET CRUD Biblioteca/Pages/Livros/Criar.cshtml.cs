using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using NET_CRUD_Biblioteca.Model;

namespace NET_CRUD_Biblioteca.Pages.Livros
{
    public class CriarModel : PageModel
    {
        [BindProperty]
        public Livro Livro { get; set; }

        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            string linha = $"{Livro.Id};{Livro.Titulo};{Livro.Autor};{Livro.Isbn}";

            using (var writer = new StreamWriter("livros.txt", true))
            {
                writer.WriteLine(linha);
            }

            return RedirectToPage("/Livros/Index");
        }
    }
}