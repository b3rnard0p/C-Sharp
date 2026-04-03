using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade
{
    abstract class Mensagem
    {
        public string Texto { get; set; }
        public abstract void Enviar();
    }
}
