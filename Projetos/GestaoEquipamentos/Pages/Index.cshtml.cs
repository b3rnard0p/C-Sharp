using TrabalhoFinal.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace TrabalhoFinal.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public List<Equipamento> EquipamentosEmManutencao { get; set; } = new();
        
        public class RankingEquipamento
        {
            public Equipamento Equipamento { get; set; } = new Equipamento();
            public int QuantidadeEmprestimos { get; set; }
        }
        public List<RankingEquipamento> TopEquipamentos { get; set; } = new();

        public void OnGet()
        {
            var equipamentos = TrabalhoFinal.Services.DatabaseHelper.CarregarEquipamentos();
            var emprestimos = TrabalhoFinal.Services.DatabaseHelper.CarregarEmprestimos();

            EquipamentosEmManutencao = equipamentos
                .Where(e => e.Situacao == Models.SituacaoEquipamento.Manutencao)
                .ToList();

            TopEquipamentos = emprestimos
                .GroupBy(e => e.EquipamentoId)
                .Select(g => new RankingEquipamento
                {
                    Equipamento = equipamentos.FirstOrDefault(eq => eq.Id == g.Key) ?? new Models.Equipamento { Nome = "Equipamento Removido" },
                    QuantidadeEmprestimos = g.Count()
                })
                .Where(r => r.Equipamento.Id != 0)
                .OrderByDescending(r => r.QuantidadeEmprestimos)
                .Take(5)
                .ToList();
        }
    }
}
