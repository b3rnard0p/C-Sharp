using ControleConsultas.Services;
using ControleConsultas.Models;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ControleConsultas.Pages
{
    public class IndexModel : PageModel
    {
        public int TotalPacientes { get; set; }
        public int TotalAgendados { get; set; }
        public int TotalConcluidos { get; set; }
        public int TotalCancelados { get; set; }
        public decimal ReceitaTotal { get; set; }
        public List<(Atendimento Atendimento, string NomePaciente)> ProximasConsultas { get; set; } = new();

        public void OnGet()
        {
            var clientes = DatabaseHelper.CarregarClientes();
            var atendimentos = DatabaseHelper.CarregarAtendimentos();

            TotalPacientes = clientes.Count;
            TotalAgendados = atendimentos.Count(a => a.Status == StatusAtendimento.Agendado);
            TotalConcluidos = atendimentos.Count(a => a.Status == StatusAtendimento.Concluido);
            TotalCancelados = atendimentos.Count(a => a.Status == StatusAtendimento.Cancelado);
            ReceitaTotal = atendimentos
                .Where(a => a.Status == StatusAtendimento.Concluido)
                .Sum(a => a.Preco ?? 0);

            ProximasConsultas = atendimentos
                .Where(a => a.Status == StatusAtendimento.Agendado && a.Horario.Value >= DateTime.Now)
                .OrderBy(a => a.Horario)
                .Take(5)
                .Select(a => (a, clientes.FirstOrDefault(c => c.Id == a.ClienteId)?.Nome ?? $"Paciente #{a.ClienteId}"))
                .ToList();
        }

        }
}
