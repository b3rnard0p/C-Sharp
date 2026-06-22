using ControleConsultas.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ControleConsultas.Pages.Clientes
{
    public class CriarModel : PageModel
    {
        [BindProperty]
        public Cliente Cliente { get; set; } = new();

        public void OnGet() { }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
                return Page();

            int proximoId = 1;
            if (System.IO.File.Exists("clientes.txt"))
            {
                var linhas = System.IO.File.ReadAllLines("clientes.txt")
                    .Where(l => !string.IsNullOrWhiteSpace(l)).ToList();
                if (linhas.Any())
                {
                    proximoId = linhas
                        .Select(l => int.TryParse(l.Split(';')[0], out var n) ? n : 0)
                        .Max() + 1;
                }
            }
            Cliente.Id = proximoId;

            string linha = $"{Cliente.Id};{Cliente.Nome}";

            using var writer = new StreamWriter("clientes.txt", append: true);
            writer.WriteLine(linha);

            return RedirectToPage("/Clientes/Index");
        }
    }
}
