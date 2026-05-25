using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HelloWord.Pages
{
    public class ProdutoModel : PageModel
    {
        public List<Produto> Produtos { get; set; }
        public void OnGet()
        {
            Produtos = new List<Produto>
            {
                new Produto {Descricao = "Coca-Cola", Preco = 4.99m},
                new Produto {Descricao = "Pepsi Cola", Preco = 4.51m},
                new Produto {Descricao = "DelValle", Preco = 3.99m},
                new Produto {Descricao = "Monster", Preco = 8.0m},
                new Produto {Descricao = "Agua Natural", Preco = 2.0m},
            };
        }
    }
}

public class Produto
{
    public string Descricao { get; set; }
    public decimal Preco { get; set; }


}