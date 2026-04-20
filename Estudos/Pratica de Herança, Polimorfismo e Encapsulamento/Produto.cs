using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade
{
    internal class Produto
    {
        private int quantidadeEstoque;

        public int QuantidadeEstoque
        {
            get { return quantidadeEstoque; }
            set
            {
                if (value >= 0)
                {
                    quantidadeEstoque = value;
                }
            }
        }
    }
}
