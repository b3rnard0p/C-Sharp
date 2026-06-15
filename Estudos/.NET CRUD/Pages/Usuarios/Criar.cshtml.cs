using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApplication1.Model.Usuario
{
    public class CriarModel : PageModel
    {
        [BindProperty]
        public Usuario usuario { get; set; }

        public void OnGet() // Executado ao acessar a página 
        {
        }

        public IActionResult OnPost() // Executado ao enviar o formulário (POST) 
        {
            // Verifica se as regras do Data Annotations do modelo foram respeitadas 
            if (!ModelState.IsValid)
            {
                return Page(); // Permanece na página exibindo os erros 
            }

            // Armazenamento dos dados delimitados por ponto e vírgula em arquivo texto 
            using (var writer = new StreamWriter("usuarios.txt", true))
            {
                writer.WriteLine(usuario.Id + ";" + usuario.Nome + ";" + usuario.Senha + ";"
                    + usuario.Email);

            }
            return RedirectToPage("/Usuarios/Index"); // Redireciona para a listagem

        }

    }
}
