using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApplication1.Model.Usuario
{
    public class UsuarioModel : PageModel
    {
        [BindProperty]
        public Usuario usuario { get; set; }
        public void OnGet()
        {
            if(!ModelState.IsValid)
            {
                return Page();
            }
            using (var writer = new StreamWriter("Usuario.txt", true))
            {
                writer.WriteLine(
            }
        }
    }
}
