using TrabalhoFinal.Models;
using TrabalhoFinal.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace TrabalhoFinal.Pages.Equipamentos
{
    public class DeletarModel : PageModel
    {
        [BindProperty(SupportsGet = true)]
        public int Id { get; set; }

        [BindProperty]
        public string? CodigoInformado { get; set; }

        public Equipamento? EquipamentoAlvo { get; set; }

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

        public IActionResult OnPost()
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

            var filtrados = equipamentos.Where(e => e.Id != EquipamentoAlvo.Id).ToList();
            var linhas = filtrados.Select(e => $"{e.Id};{e.Nome};{e.CodigoPatrimonio};{e.Situacao}");
            System.IO.File.WriteAllLines("equipamentos.txt", linhas);

            TempData["Sucesso"] = $"Equipamento '{EquipamentoAlvo.Nome}' excluído com sucesso!";
            
            return RedirectToPage("/Equipamentos/Index");
        }
    }
}
