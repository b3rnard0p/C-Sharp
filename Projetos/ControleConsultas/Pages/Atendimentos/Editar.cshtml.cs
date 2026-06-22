using ControleConsultas.Services;
using ControleConsultas.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace ControleConsultas.Pages.Atendimentos
{
    public class EditarModel : PageModel
    {
        [BindProperty]
        public Atendimento Atendimento { get; set; } = new();

        public List<SelectListItem> ClientesSelect { get; set; } = new();

        public IActionResult OnGet(int id)
        {
            var atendimentos = DatabaseHelper.CarregarAtendimentos();
            Atendimento = atendimentos.FirstOrDefault(l => l.Id == id)!;

            if (Atendimento == null)
                return RedirectToPage("/Atendimentos/Index");

            CarregarClientesSelect();
            return Page();
        }

        public IActionResult OnPost()
        {
            CarregarClientesSelect();

            if (!ModelState.IsValid)
                return Page();

            if (System.IO.File.Exists("atendimentos.txt"))
            {
                var linhas = System.IO.File.ReadAllLines("atendimentos.txt").ToList();
                for (int i = 0; i < linhas.Count; i++)
                {
                    if (string.IsNullOrWhiteSpace(linhas[i])) continue;
                    var d = linhas[i].Split(';');
                    if (d.Length >= 5 && int.Parse(d[0]) == Atendimento.Id)
                    {
                        string precoStr = Atendimento.Preco.Value.ToString("F2", System.Globalization.CultureInfo.InvariantCulture);
                        linhas[i] = $"{Atendimento.Id};{Atendimento.ClienteId};{Atendimento.Especialidade};{Atendimento.Horario.Value:yyyy-MM-dd HH:mm};{Atendimento.Status};{precoStr}";
                        break;
                    }
                }
                System.IO.File.WriteAllLines("atendimentos.txt", linhas);
            }

            return RedirectToPage("/Atendimentos/Index");
        }

        private void CarregarClientesSelect()
        {
            ClientesSelect = new List<SelectListItem> { new SelectListItem("-- Selecione um paciente --", "") };
            foreach (var c in DatabaseHelper.CarregarClientes())
            {
                ClientesSelect.Add(new SelectListItem($"{c.Nome} (#{c.Id})", c.Id.ToString()));
            }
        }
    }
}
