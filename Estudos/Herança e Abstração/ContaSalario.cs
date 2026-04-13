using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade
{
    internal class ContaSalario: ContaBancaria
    {
        public ContaSalario(double saldoInicial) : base(saldoInicial) { }
        public override void Depositar(double valor)
        {
            Console.WriteLine("Operação negada: Conta Salário não permite depósito manual.");
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
                Console.WriteLine("Saldo insuficiente.");
            }
        }
    }
}
