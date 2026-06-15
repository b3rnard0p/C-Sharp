using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using NET_CRUD_Biblioteca.Model;

namespace NET_CRUD_Biblioteca.Pages.Livros
{
    public class EditarModel : PageModel
    {
        [BindProperty]
        public Livro Livro { get; set; }

        public IActionResult OnGet(int id)
        {
            var livros = CarregarLivros();
            Livro = livros.FirstOrDefault(l => l.Id == id);

            if (Livro == null)
            {
                return RedirectToPage("/Livros/Index");
            }
            return Page();
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            if (System.IO.File.Exists("livros.txt"))
            {
                var linhas = System.IO.File.ReadAllLines("livros.txt").ToList();
                for (int i = 0; i < linhas.Count; i++)
                {
                    if (string.IsNullOrWhiteSpace(linhas[i])) continue;

                    var dados = linhas[i].Split(';');
                    if (int.Parse(dados[0]) == Livro.Id)
                    {
                        linhas[i] = $"{Livro.Id};{Livro.Titulo};{Livro.Autor};{Livro.Isbn}";
                        break;
                    }
                }
                System.IO.File.WriteAllLines("livros.txt", linhas);
            }

            return RedirectToPage("/Livros/Index");
        }

        private List<Livro> CarregarLivros()
        {
            var lista = new List<Livro>();
            if (System.IO.File.Exists("livros.txt"))
            {
                var linhas = System.IO.File.ReadAllLines("livros.txt");
                foreach (var linha in linhas)
                {
                    if (string.IsNullOrWhiteSpace(linha)) continue;

                    var dados = linha.Split(';');
                    lista.Add(new Livro
                    {
                        Id = int.Parse(dados[0]),
                        Titulo = dados[1],
                        Autor = dados[2],
                        Isbn = dados[3]
                    });
                }
            }
            return lista;
        }
    }
}
