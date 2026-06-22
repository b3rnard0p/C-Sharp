using ControleConsultas.Services;
using ControleConsultas.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ControleConsultas.Pages.Clientes
{
    public class EditarModel : PageModel
    {
        [BindProperty]
        public Cliente Cliente { get; set; } = new();

        public IActionResult OnGet(int id)
        {
            var clientes = DatabaseHelper.CarregarClientes();
            Cliente = clientes.FirstOrDefault(l => l.Id == id)!;

            if (Cliente == null)
                return RedirectToPage("/Clientes/Index");

            return Page();
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
                return Page();

            if (System.IO.File.Exists("clientes.txt"))
            {
                var linhas = System.IO.File.ReadAllLines("clientes.txt").ToList();
                for (int i = 0; i < linhas.Count; i++)
                {
                    if (string.IsNullOrWhiteSpace(linhas[i])) continue;
                    var d = linhas[i].Split(';');
                    if (int.Parse(d[0]) == Cliente.Id)
                    {
                        linhas[i] = $"{Cliente.Id};{Cliente.Nome}";
                        break;
                    }
                }
                System.IO.File.WriteAllLines("clientes.txt", linhas);
            }

            return RedirectToPage("/Clientes/Index");
        }

        }
}
