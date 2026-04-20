using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade
{
    internal class ContaPoupanca: Conta
    {
        public new void Sacar(decimal valor)
        {
            Console.WriteLine($"Conta Poupança: Saque realizado. Comportamento oculto pela palavra new.");
        }
    }
}
