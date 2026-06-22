using ControleConsultas.Services;
using ControleConsultas.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ControleConsultas.Pages.Clientes
{
    public class IndexModel : PageModel
    {
        public List<Cliente> Clientes { get; set; } = new();

        public void OnGet()
        {
            Clientes = DatabaseHelper.CarregarClientes();
        }
    }
}
