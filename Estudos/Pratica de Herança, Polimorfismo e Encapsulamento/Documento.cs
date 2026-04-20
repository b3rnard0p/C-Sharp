using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade
{
    abstract class Documento
    {
        public abstract void Imprimir();

        public void Abrir()
        {
            Console.WriteLine("Documento aberto.");
        }
    }
}
