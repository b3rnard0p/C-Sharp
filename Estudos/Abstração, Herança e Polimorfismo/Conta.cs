using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade
{
    abstract class Conta
    {
        protected double saldo;

        public Conta(double saldoInicial)
        {
            saldo = saldoInicial;
        }

        public virtual void Sacar(double valor)
        {
            if (saldo - valor >= 0)
            {
                saldo -= valor;
                Console.WriteLine($"Saque de R${valor} realizado. Saldo: R${saldo}");
            }
            else
            {
                Console.WriteLine("Saldo insuficiente para este saque.");
            }
        }
    }
}
