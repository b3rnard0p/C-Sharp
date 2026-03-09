using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula3
{
    internal class Lampada
    {
        public Boolean Ligada; //public bool Ligada
        public double Potencia;

        public void Ligar()
        {
            if (!Ligada)
            {
                Ligada = true;
                Console.WriteLine("Ligado");
            }
            else
            {
                Console.WriteLine("Já esta ligada");
            }
        }

        public void Desligar()
        {
            if (Ligada)
            {
                Ligada = false;
                Console.WriteLine("Desligado");
            }
            else
            {
                Console.WriteLine("Já esta desligada");
            }
        }

        public bool EstaLigada()
        {
            return Ligada;
        }
    }
}
