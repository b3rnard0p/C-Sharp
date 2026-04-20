using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade
{
    internal class Conta
    {
        public virtual void Sacar(decimal valor)
        {
            Console.WriteLine($"Conta Base: Saque realizado. Taxa de R$ 1,00 cobrada. Total debitado: {valor + 1.00m}");
        }
    }
}
