using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade
{
    internal class ContaCorrente: ContaBancaria
    {
        public ContaCorrente(double saldoInicial) : base(saldoInicial) { }
        public override void Depositar(double valor)
        {
            Saldo += valor;
        }
        public override void Sacar(double valor)
        {
            double valorTotal = valor + 2.00;
            if (Saldo >= valorTotal)
            {
                Saldo -= valorTotal;
                Console.WriteLine($"Saque de R${valor:F2} realizado (Taxa de R$2,00 aplicada).");
            }
            else
            {
                Console.WriteLine("Saldo insuficiente para saque + taxa.");
            }
        }
    }
}
