using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade
{
    internal class Roupa: Produto
    {
        public override double CalcularDesconto()
        {
            if (Preco > 100)
            {
                return Preco * 0.20;
            }
            else
            {
                return Preco * 0.10;
            }
        }
    }
}
