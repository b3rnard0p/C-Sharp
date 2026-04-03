using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade
{
    class ContaPoupanca : Conta
    {
        public ContaPoupanca(double saldoInicial) : base(saldoInicial) { }

        public override void Sacar(double valor)
        {
            double taxa = 0.50;
            if (saldo - (valor + taxa) >= 0)
            {
                saldo -= (valor + taxa);
                Console.WriteLine($"Saque de R${valor} + Taxa R$0.50 realizado. Saldo: R${saldo}");
            }
            else
            {
                Console.WriteLine("Saldo insuficiente para saque com taxa na Poupança.");
            }
        }
    }
}
