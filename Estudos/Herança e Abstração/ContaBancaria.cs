using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade
{
    abstract class ContaBancaria
    {
        public double Saldo { get; set; }

        public ContaBancaria(double saldoInicial)
        {
            Saldo = saldoInicial;
        }

        public abstract void Depositar(double valor);

        public abstract void Sacar(double valor);

        public void ExibirSaldo()
        {
            Console.WriteLine($"Saldo: R$ {Saldo}");
        }
    }
}
