using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade
{
    internal class ContaPoupanca: ContaBancaria
    {
        public ContaPoupanca(double saldoInicial) : base(saldoInicial) { }
        public override void Depositar(double valor)
        {
            Saldo += valor;
        }

        public override void Sacar(double valor)
        {
            if (valor <= Saldo)
            {
                Saldo -= valor;
                Console.WriteLine($"Saque de R${valor:F2} realizado com sucesso.");
            }
            else
            {
                Console.WriteLine("Saque negado: Valor maior que o saldo disponível.");
            }
        }
    }
}
