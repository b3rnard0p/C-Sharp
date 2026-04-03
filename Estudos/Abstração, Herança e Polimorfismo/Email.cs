using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade
{
    class Email : Mensagem
    {
        public override void Enviar()
        {
            Console.WriteLine($"Enviando via E-MAIL: {Texto}");
        }
    }
}
