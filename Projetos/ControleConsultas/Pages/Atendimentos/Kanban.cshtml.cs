using ControleConsultas.Services;
using ControleConsultas.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ControleConsultas.Pages.Atendimentos
{
    public class KanbanModel : PageModel
    {
        public List<(Atendimento Atendimento, string NomePaciente)> Agendados { get; set; } = new();
        public List<(Atendimento Atendimento, string NomePaciente)> Concluidos { get; set; } = new();
        public List<(Atendimento Atendimento, string NomePaciente)> Cancelados { get; set; } = new();

        public IActionResult OnGet()
        {
            var clientes = DatabaseHelper.CarregarClientes();
            var atendimentos = DatabaseHelper.CarregarAtendimentos();

            string NomeDo(int clienteId) =>
                clientes.FirstOrDefault(c => c.Id == clienteId)?.Nome ?? $"Paciente #{clienteId}";

            Agendados = atendimentos
                .Where(a => a.Status == StatusAtendimento.Agendado)
                .OrderBy(a => a.Horario)
                .Select(a => (a, NomeDo(a.ClienteId))).ToList();

            Concluidos = atendimentos
                .Where(a => a.Status == StatusAtendimento.Concluido)
                .OrderByDescending(a => a.Horario)
                .Select(a => (a, NomeDo(a.ClienteId))).ToList();

            Cancelados = atendimentos
                .Where(a => a.Status == StatusAtendimento.Cancelado)
                .OrderByDescending(a => a.Horario)
                .Select(a => (a, NomeDo(a.ClienteId))).ToList();

            return Page();
        }

        public IActionResult OnPostMudarStatus(int id, string novoStatus)
        {
            if (!Enum.TryParse<StatusAtendimento>(novoStatus, out var status))
                return RedirectToPage();

            if (System.IO.File.Exists("atendimentos.txt"))
            {
                var linhas = System.IO.File.ReadAllLines("atendimentos.txt").ToList();
                for (int i = 0; i < linhas.Count; i++)
                {
                    if (string.IsNullOrWhiteSpace(linhas[i])) continue;
                    var d = linhas[i].Split(';');
                    if (d.Length >= 5 && int.Parse(d[0]) == id)
                    {
                        d[4] = status.ToString();
                        linhas[i] = string.Join(";", d);
                        break;
                    }
                }
                System.IO.File.WriteAllLines("atendimentos.txt", linhas);
            }
            return RedirectToPage();
        }

        }
}
