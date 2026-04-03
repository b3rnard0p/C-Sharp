using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade
{
    class Gerente : Funcionario
    {
        public double BonusFixo { get; set; }

        public override double CalcularPagamento()
        {
            return SalarioBase + BonusFixo;
        }
    }
}
