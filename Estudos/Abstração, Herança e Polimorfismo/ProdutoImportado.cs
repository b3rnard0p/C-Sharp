using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade
{
    class ProdutoImportado : Produto
    {
        public override double PrecoFinal()
        {
            double imposto = PrecoBase * 0.20;
            double taxaAlfandega = 10.00;
            return PrecoBase + imposto + taxaAlfandega;
        }
    }
}
