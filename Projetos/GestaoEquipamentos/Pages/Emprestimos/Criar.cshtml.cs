using TrabalhoFinal.Models;
using TrabalhoFinal.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace TrabalhoFinal.Pages.Emprestimos
{
    public class CriarModel : PageModel
    {
        [BindProperty]
        public Emprestimo Emprestimo { get; set; } = new Emprestimo();

        public List<SelectListItem> EquipamentosDisponiveis { get; set; } = new();

        public void OnGet()
        {
            CarregarEquipamentosDisponiveis();
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                CarregarEquipamentosDisponiveis();
                return Page();
            }

            var emprestimos = DatabaseHelper.CarregarEmprestimos();
            int proximoId = emprestimos.Any() ? emprestimos.Max(e => e.Id) + 1 : 1;
            Emprestimo.Id = proximoId;
            Emprestimo.DataEmprestimo = DateTime.Now;
            Emprestimo.StatusAtivo = true;
            var linha = $"{Emprestimo.Id};{Emprestimo.EquipamentoId};{Emprestimo.EmailResponsavel};{Emprestimo.DataEmprestimo.ToString("O", System.Globalization.CultureInfo.InvariantCulture)};{Emprestimo.StatusAtivo}";
            using (var writer = new System.IO.StreamWriter("emprestimos.txt", append: true))
            {
                writer.WriteLine(linha);
            }
            
            var equipamentos = DatabaseHelper.CarregarEquipamentos();
            var equip = equipamentos.FirstOrDefault(e => e.Id == Emprestimo.EquipamentoId);
            if (equip != null)
            {
                equip.Situacao = SituacaoEquipamento.EmUso;
                var linhas = equipamentos.Select(e => $"{e.Id};{e.Nome};{e.CodigoPatrimonio};{e.Situacao}");
                System.IO.File.WriteAllLines("equipamentos.txt", linhas);
            }

            TempData["Sucesso"] = "Empréstimo registrado com sucesso!";
            return RedirectToPage("/Emprestimos/Index");
        }

        private void CarregarEquipamentosDisponiveis()
        {
            var equipamentos = DatabaseHelper.CarregarEquipamentos()
                .Where(e => e.Situacao == SituacaoEquipamento.Disponivel)
                .ToList();
                
            EquipamentosDisponiveis = equipamentos.Select(e => new SelectListItem
            {
                Value = e.Id.ToString(),
                Text = $"{e.Nome} (Patrimônio: {e.CodigoPatrimonio})"
            }).ToList();
        }
    }
}
