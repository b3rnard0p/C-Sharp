using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade
{
    class Carrinho
    {
        public List<Produto> Itens { get; set; } = new List<Produto>();

        public double SomarTotal()
        {
            double total = 0;
            foreach (var item in Itens)
            {
                total += item.PrecoFinal();
            }
            return total;
        }
    }
}
