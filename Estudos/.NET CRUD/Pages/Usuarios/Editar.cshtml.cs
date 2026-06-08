using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebApplication1.Model;

namespace WebApplication1.Pages.Usuarios
{
    public class EditarModel : PageModel
    {
        [BindProperty]
        public Usuario Usuario { get; set; }
        public void OnGet(int id)
        {
            var usuarios = CarregarUsuarios();
            Usuario = usuarios.FirstOrDefault(u => u.Id == id);
        }

        public IActionResult onPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            var linhas = System.IO.File.ReadAllLines("usuarios.txt");
            for (int i = 0; i < linhas.Length; i++)
            {
                var dados = linhas[i].Split(';');
                if(int.Parse(dados[0]) == Usuario.Id)
                {
                    linhas[i] = Usuario.Id + ";" + Usuario.Nome + ";" + Usuario.Senha + ";" + Usuario.Email + ";";
                    break;
                }
            }

            System.IO.File.WriteAllLines("usuarios.txt", contents: linhas);
            return RedirectToPage("Usuarios/Index");
        }

        private List<Usuario> CarregarUsuarios()
        {
            var lista = new List<Usuario>();
            if(System.IO.File.Exists("usuarios.txt"))
            {
                var linhas = System.IO.File.ReadAllLines("usuarios.txt");
                foreach(var linha in linhas)
                {
                    var dados = linha.Split(";");
                    lista.Add(new Usuario
                    {
                        Id = int.Parse(dados[0]),
                        Nome = dados[1],
                        Senha = dados[2],
                        Email = dados[3]
                    });
                }
            }
            return lista;
        }
    }
}
