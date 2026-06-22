using ControleConsultas.Services;
using ControleConsultas.Models;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ControleConsultas.Pages.Atendimentos
{
    public class IndexModel : PageModel
    {
        public List<(Atendimento Atendimento, string NomePaciente)> Atendimentos { get; set; } = new();

        public void OnGet()
        {
            var clientes = DatabaseHelper.CarregarClientes();
            var atendimentos = DatabaseHelper.CarregarAtendimentos();

            Atendimentos = atendimentos
                .OrderByDescending(a => a.Horario)
                .Select(a => (a, clientes.FirstOrDefault(c => c.Id == a.ClienteId)?.Nome ?? $"Paciente #{a.ClienteId}"))
                .ToList();
        }

        }
}
