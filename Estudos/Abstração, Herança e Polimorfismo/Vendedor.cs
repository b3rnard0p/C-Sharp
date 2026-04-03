using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade
{
    class Vendedor : Funcionario
    {
        public double TotalVendas { get; set; }

        public override double CalcularPagamento()
        {
            return SalarioBase + (TotalVendas * 0.10);
        }
    }
}
