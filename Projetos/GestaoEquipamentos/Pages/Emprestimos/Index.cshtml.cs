using TrabalhoFinal.Models;
using TrabalhoFinal.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace TrabalhoFinal.Pages.Emprestimos
{
    public class IndexModel : PageModel
    {
        public class EmprestimoDetalhado
        {
            public Emprestimo Emprestimo { get; set; } = new Emprestimo();
            public Equipamento Equipamento { get; set; } = new Equipamento();
        }

        public List<EmprestimoDetalhado> Emprestimos { get; set; } = new();

        public void OnGet()
        {
            var emprestimos = DatabaseHelper.CarregarEmprestimos();
            var equipamentos = DatabaseHelper.CarregarEquipamentos();

            foreach (var emp in emprestimos)
            {
                var equip = equipamentos.FirstOrDefault(e => e.Id == emp.EquipamentoId);
                if (equip != null)
                {
                    Emprestimos.Add(new EmprestimoDetalhado
                    {
                        Emprestimo = emp,
                        Equipamento = equip
                    });
                }
            }
            
            Emprestimos = Emprestimos.OrderByDescending(e => e.Emprestimo.DataEmprestimo).ToList();
        }

        public IActionResult OnPostDevolver(int id)
        {
            var emprestimos = DatabaseHelper.CarregarEmprestimos();
            var emp = emprestimos.FirstOrDefault(e => e.Id == id);
            
            if (emp != null)
            {
                var index = emprestimos.FindIndex(e => e.Id == emp.Id);
                if (index != -1)
                {
                    emprestimos[index].StatusAtivo = false;
                    var linhasEmprestimos = emprestimos.Select(e => $"{e.Id};{e.EquipamentoId};{e.EmailResponsavel};{e.DataEmprestimo.ToString("O", System.Globalization.CultureInfo.InvariantCulture)};{e.StatusAtivo}");
                    System.IO.File.WriteAllLines("emprestimos.txt", linhasEmprestimos);
                }
                
                var equipamentos = DatabaseHelper.CarregarEquipamentos();
                var equip = equipamentos.FirstOrDefault(e => e.Id == emp.EquipamentoId);
                if (equip != null)
                {
                    equip.Situacao = SituacaoEquipamento.Disponivel;
                    var linhasEquipamentos = equipamentos.Select(e => $"{e.Id};{e.Nome};{e.CodigoPatrimonio};{e.Situacao}");
                    System.IO.File.WriteAllLines("equipamentos.txt", linhasEquipamentos);
                }

                TempData["Sucesso"] = "Equipamento devolvido com sucesso!";
            }
            
            return RedirectToPage();
        }
    }
}
