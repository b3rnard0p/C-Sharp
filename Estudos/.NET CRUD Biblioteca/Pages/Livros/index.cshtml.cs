using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using NET_CRUD_Biblioteca.Model;

namespace NET_CRUD_Biblioteca.Pages.Livros
{
    public class IndexModel : PageModel
    {
        public List<Livro> Livros { get; set; }

        public void OnGet()
        {
            Livros = new List<Livro>();

            if (System.IO.File.Exists("livros.txt"))
            {
                var linhas = System.IO.File.ReadAllLines("livros.txt");
                foreach (var linha in linhas)
                {
                    if (string.IsNullOrWhiteSpace(linha)) continue;

                    var dados = linha.Split(';');
                    Livros.Add(new Livro
                    {
                        Id = int.Parse(dados[0]),
                        Titulo = dados[1],
                        Autor = dados[2],
                        Isbn = dados[3]
                    });
                }
            }
        }
    }
}