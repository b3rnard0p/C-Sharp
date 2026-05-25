using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HelloWord.Pages
{
    public class FuncionariosModel : PageModel
    {
        public List<Funcionario> Funcionarios { get; set; }
        public void OnGet()
        {
            Funcionarios = new List<Funcionario>
            {
                new Funcionario {Nome = "Ana", Cargo = "Junior", Salario = 2000m},
                new Funcionario {Nome = "Pedro", Cargo = "Estagiario", Salario = 1000m},
                new Funcionario {Nome = "João", Cargo = "Junior", Salario = 3000m},
                new Funcionario {Nome = "Isa", Cargo = "Pleno", Salario = 5000m},
                new Funcionario {Nome = "Bernardo", Cargo = "Senior", Salario = 10000m},
            };
        }
    }
}
