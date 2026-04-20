using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade
{
    class Contrato : Documento, IAssinavel
    {
        public override void Imprimir()
        {
            Console.WriteLine("Imprimindo o contrato na impressora padrão");
        }

        public void Assinar()
        {
            Console.WriteLine("Contrato assinado digitalmente.");
        }
    }
}
