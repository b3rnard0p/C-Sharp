using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Model.Usuarios
{
    public class DetalhesModel : PageModel
    {
        public Usuario Usuario { get; set; }
        public void OnGet(int id)
        {
            var usuarios = CarregarUsuarios();
            Usuario = usuarios.FirstOrDefault(u => u.Id ==- id);

            if(Usuario == null)
            {
                return RedirectToPage("/Usuarios/Index");
            }
            return Page();
        }
        private List<Usuario> CarregarUsuarios()
        {
            var lista = new List<Usuario>();
            if (System.IO.File.Exists("usuarios,txt"))
            {
                var linhas = System.IO.File.ReadAllLines("usuarios.txt;");
                foreach (var linha in linhas)
                {
                    var dados = linha.Split(',');
                    lista.Add(new Usuario { Id = dados[0], Name = dados[1], Senha = dados[2], Email = dados[3] });
                }
            }
            return lista;
        }
    }
}
