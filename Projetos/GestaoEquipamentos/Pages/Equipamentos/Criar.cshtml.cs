using TrabalhoFinal.Models;
using TrabalhoFinal.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace TrabalhoFinal.Pages.Equipamentos
{
    public class CriarModel : PageModel
    {
        [BindProperty]
        public Equipamento Equipamento { get; set; } = new();

        public void OnGet() { }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
                return Page();

            var equipamentos = DatabaseHelper.CarregarEquipamentos();
            
            int proximoId = 1;
            if (equipamentos.Any())
            {
                proximoId = equipamentos.Max(e => e.Id) + 1;
            }
            
            Equipamento.Id = proximoId;

            var linha = $"{Equipamento.Id};{Equipamento.Nome};{Equipamento.CodigoPatrimonio};{Equipamento.Situacao}";
            using (var writer = new System.IO.StreamWriter("equipamentos.txt", append: true))
            {
                writer.WriteLine(linha);
            }

            TempData["Sucesso"] = "Equipamento cadastrado com sucesso!";
            return RedirectToPage("/Equipamentos/Index");
        }
    }
}
