using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade
{
    internal class ContaVip: Conta
    {
        public override void Sacar(decimal valor)
        {
            Console.WriteLine($"Conta VIP: Saque realizado. Sem taxas. Total debitado: {valor}");
        }
    }
}
