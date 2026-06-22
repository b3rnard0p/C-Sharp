using ControleConsultas.Services;
using ControleConsultas.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ControleConsultas.Pages.Clientes
{
    public class DetalhesModel : PageModel
    {
        public Cliente Cliente { get; set; } = new();

        public IActionResult OnGet(int id)
        {
            var clientes = DatabaseHelper.CarregarClientes();
            var found = clientes.FirstOrDefault(l => l.Id == id);
            if (found == null) return RedirectToPage("/Clientes/Index");
            Cliente = found;

            return Page();
        }

        }
}
