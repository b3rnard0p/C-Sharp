using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade
{
    abstract class Produto
    {
        public string Nome { get; set; }
        public double Preco { get; set; }

        public abstract double CalcularDesconto();

        public void ExibirPrecoFinal()
        {
            double precoFinal = Preco - CalcularDesconto();
            Console.WriteLine($"Produto: {Nome}, Preço: R${precoFinal:F2}");
        }
    }
}
