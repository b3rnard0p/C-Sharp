using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebApplication1.Model;

namespace WebApplication1.Pages.Usuarios
{
    public class IndexModel : PageModel
    {
        public List<Usuario> Usuarios { get; set; }
        public void OnGet()
        {
            Usuarios = new List<Usuario>();

            if (System.IO.File.Exists("usuarios.txt"))
            {
                var linhas = System.IO.File.ReadAllLines("usuarios.txt");
                foreach (var linha in linhas)
                {
                    var dados = linha.Split(' ');
                    var usuario = new Usuario()
                    {
                        Id = int.Parse(dados[0]),
                        Nome = dados[1],
                        Senha = dados[2],
                        Email = dados[3]
                    };
                    Usuarios.Add(usuario);
                }
            }
        }
    }
}
