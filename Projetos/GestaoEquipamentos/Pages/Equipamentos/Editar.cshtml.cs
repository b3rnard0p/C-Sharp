using TrabalhoFinal.Models;
using TrabalhoFinal.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace TrabalhoFinal.Pages.Equipamentos
{
    public class EditarModel : PageModel
    {
        [BindProperty(SupportsGet = true)]
        public int Id { get; set; }

        [BindProperty]
        public string? CodigoInformado { get; set; }

        [BindProperty]
        public Equipamento Equipamento { get; set; } = new Equipamento();

        public Equipamento? EquipamentoAlvo { get; set; }

        public bool MostrarFormulario { get; set; } = false;

        public IActionResult OnGet()
        {
            var equipamentos = DatabaseHelper.CarregarEquipamentos();
            EquipamentoAlvo = equipamentos.FirstOrDefault(e => e.Id == Id);
            
            if (EquipamentoAlvo == null)
            {
                TempData["Erro"] = "Equipamento não encontrado.";
                return RedirectToPage("/Equipamentos/Index");
            }
            
            return Page();
        }

        public IActionResult OnPostBuscar()
        {
            var equipamentos = DatabaseHelper.CarregarEquipamentos();
            EquipamentoAlvo = equipamentos.FirstOrDefault(e => e.Id == Id);

            if (EquipamentoAlvo == null)
            {
                TempData["Erro"] = "Equipamento não encontrado.";
                return RedirectToPage("/Equipamentos/Index");
            }

            if (string.IsNullOrWhiteSpace(CodigoInformado) || CodigoInformado != EquipamentoAlvo.CodigoPatrimonio)
            {
                TempData["Erro"] = "O código de patrimônio informado está incorreto.";
                return Page();
            }

            Equipamento = EquipamentoAlvo;
            MostrarFormulario = true;
            return Page();
        }

        public IActionResult OnPostSalvar()
        {
            if (!ModelState.IsValid)
            {
                MostrarFormulario = true;
                return Page();
            }

            var equipamentos = DatabaseHelper.CarregarEquipamentos();
            var index = equipamentos.FindIndex(e => e.Id == Equipamento.Id);
            if (index != -1)
            {
                equipamentos[index] = Equipamento;
                var linhas = equipamentos.Select(e => $"{e.Id};{e.Nome};{e.CodigoPatrimonio};{e.Situacao}");
                System.IO.File.WriteAllLines("equipamentos.txt", linhas);
            }

            TempData["Sucesso"] = $"Equipamento '{Equipamento.Nome}' atualizado com sucesso!";
            return RedirectToPage("/Equipamentos/Index");
        }
    }
}
