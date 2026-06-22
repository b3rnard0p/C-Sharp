using ControleConsultas.Services;
using ControleConsultas.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace ControleConsultas.Pages.Atendimentos
{
    public class CriarModel : PageModel
    {
        [BindProperty]
        public Atendimento Atendimento { get; set; } = new();

        public List<SelectListItem> ClientesSelect { get; set; } = new();

        public void OnGet()
        {
            CarregarClientesSelect();
        }

        public IActionResult OnPost()
        {
            CarregarClientesSelect();

            if (!ModelState.IsValid)
                return Page();

            int proximoId = 1;
            if (System.IO.File.Exists("atendimentos.txt"))
            {
                var linhas = System.IO.File.ReadAllLines("atendimentos.txt")
                    .Where(l => !string.IsNullOrWhiteSpace(l)).ToList();
                if (linhas.Any())
                {
                    proximoId = linhas
                        .Select(l => int.TryParse(l.Split(';')[0], out var n) ? n : 0)
                        .Max() + 1;
                }
            }
            Atendimento.Id = proximoId;

            string precoStr = Atendimento.Preco.Value.ToString("F2", System.Globalization.CultureInfo.InvariantCulture);
            string linha = $"{Atendimento.Id};{Atendimento.ClienteId};{Atendimento.Especialidade};{Atendimento.Horario.Value:yyyy-MM-dd HH:mm};{Atendimento.Status};{precoStr}";

            using var writer = new StreamWriter("atendimentos.txt", append: true);
            writer.WriteLine(linha);

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
