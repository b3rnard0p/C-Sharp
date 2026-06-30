using TrabalhoFinal.Models;
using TrabalhoFinal.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace TrabalhoFinal.Pages.Equipamentos
{
    public class IndexModel : PageModel
    {
        public List<Equipamento> Equipamentos { get; set; } = new();

        [BindProperty(SupportsGet = true)]
        public string? BuscaNome { get; set; }

        [BindProperty(SupportsGet = true)]
        public SituacaoEquipamento? FiltroSituacao { get; set; }

        public void OnGet()
        {
            Equipamentos = DatabaseHelper.CarregarEquipamentos();

            if (!string.IsNullOrEmpty(BuscaNome))
            {
                Equipamentos = Equipamentos
                    .Where(e => e.Nome.Contains(BuscaNome, StringComparison.OrdinalIgnoreCase))
                    .ToList();
            }

            if (FiltroSituacao.HasValue)
            {
                Equipamentos = Equipamentos
                    .Where(e => e.Situacao == FiltroSituacao.Value)
                    .ToList();
            }

            Equipamentos = Equipamentos.OrderBy(e => e.Nome).ToList();
        }
    }
}
