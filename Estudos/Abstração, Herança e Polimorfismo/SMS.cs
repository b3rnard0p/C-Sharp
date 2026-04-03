using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade
{
    class SMS : Mensagem
    {
        public override void Enviar()
        {
            Console.WriteLine($"Enviando via SMS: {Texto}");
        }
    }
}
