using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade
{
    abstract class Funcionario
    {
        public string Nome { get; set; }
        public double SalarioBase { get; set; }

        public abstract double CalcularPagamento();
    }
}
