using ControleConsultas.Services;
using ControleConsultas.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ControleConsultas.Pages.Atendimentos
{
    public class DetalhesModel : PageModel
    {
        public Atendimento Atendimento { get; set; } = new();
        public string NomePaciente { get; set; } = "";

        public IActionResult OnGet(int id)
        {
            var atendimentos = DatabaseHelper.CarregarAtendimentos();
            Atendimento = atendimentos.FirstOrDefault(l => l.Id == id)!;

            if (Atendimento == null)
                return RedirectToPage("/Atendimentos/Index");

            var clientes = DatabaseHelper.CarregarClientes();
            NomePaciente = clientes.FirstOrDefault(c => c.Id == Atendimento.ClienteId)?.Nome
                           ?? $"Paciente #{Atendimento.ClienteId}";

            return Page();
        }

        }
}
