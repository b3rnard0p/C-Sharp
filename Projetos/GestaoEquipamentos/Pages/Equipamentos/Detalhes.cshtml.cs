using TrabalhoFinal.Models;
using TrabalhoFinal.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace TrabalhoFinal.Pages.Equipamentos
{
    public class DetalhesModel : PageModel
    {
        [BindProperty(SupportsGet = true)]
        public string? Id { get; set; }

        public Equipamento? Equipamento { get; set; }
        public string CodigoMascarado { get; set; } = string.Empty;

        public IActionResult OnGet()
        {
            if (string.IsNullOrWhiteSpace(Id))
            {
                return Page();
            }

            var equipamentos = DatabaseHelper.CarregarEquipamentos();
            
            var found = equipamentos.FirstOrDefault(e => e.Id.ToString() == Id || e.CodigoPatrimonio == Id);
            
            if (found == null)
            {
                TempData["Erro"] = $"Equipamento com código '{Id}' não encontrado.";
                return Page();
            }
            
            Equipamento = found;
            CodigoMascarado = new string('*', Math.Max(8, Equipamento.CodigoPatrimonio.Length));

            return Page();
        }
    }
}
