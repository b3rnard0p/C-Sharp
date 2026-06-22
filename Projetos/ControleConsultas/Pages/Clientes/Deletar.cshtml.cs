using ControleConsultas.Models;
using ControleConsultas.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ControleConsultas.Pages.Clientes
{
    public class DeletarModel : PageModel
    {
        public IActionResult OnGet(int id)
        {
            var atendimentos = DatabaseHelper.CarregarAtendimentos();
            bool temConsultaAgendada = atendimentos.Any(a => a.ClienteId == id && a.Status == StatusAtendimento.Agendado);
            
            if (temConsultaAgendada)
            {
                TempData["Erro"] = "Este paciente tem consultas agendadas, não é possível excluir.";
                return RedirectToPage("/Clientes/Index");
            }

            if (System.IO.File.Exists("clientes.txt"))
            {
                var linhas = System.IO.File.ReadAllLines("clientes.txt")
                    .Where(linha => !string.IsNullOrWhiteSpace(linha) && int.Parse(linha.Split(';')[0]) != id)
                    .ToList();

                System.IO.File.WriteAllLines("clientes.txt", linhas);
            }

            return RedirectToPage("/Clientes/Index");
        }
    }
}
