using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade
{
    abstract class Produto
    {
        public string Nome { get; set; }
        public double PrecoBase { get; set; }

        public virtual double PrecoFinal() => PrecoBase;
    }
}
