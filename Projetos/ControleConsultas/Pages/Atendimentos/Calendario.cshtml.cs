using ControleConsultas.Services;
using ControleConsultas.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ControleConsultas.Pages.Atendimentos
{
    public class CalendarioModel : PageModel
    {
        public int Ano { get; set; }
        public int Mes { get; set; }
        public DateTime PrimeiroDia { get; set; }
        public Dictionary<int, List<(Atendimento Atendimento, string NomePaciente)>> EventosPorDia { get; set; } = new();
        public string MesNome { get; set; } = "";

        public IActionResult OnGet(int? ano, int? mes)
        {
            var hoje = DateTime.Today;
            Ano = ano ?? hoje.Year;
            Mes = mes ?? hoje.Month;

            PrimeiroDia = new DateTime(Ano, Mes, 1);
            MesNome = PrimeiroDia.ToString("MMMM yyyy", new System.Globalization.CultureInfo("pt-BR"));

            var clientes = DatabaseHelper.CarregarClientes();
            var atendimentos = DatabaseHelper.CarregarAtendimentos();

            string NomeDo(int clienteId) =>
                clientes.FirstOrDefault(c => c.Id == clienteId)?.Nome ?? $"Paciente #{clienteId}";

            foreach (var at in atendimentos.Where(a => a.Horario.Value.Year == Ano && a.Horario.Value.Month == Mes))
            {
                int dia = at.Horario.Value.Day;
                if (!EventosPorDia.ContainsKey(dia))
                    EventosPorDia[dia] = new List<(Atendimento, string)>();
                EventosPorDia[dia].Add((at, NomeDo(at.ClienteId)));
            }

            return Page();
        }

        }
}
