using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade
{
    class AparelhoSom
    {
        public int Volume { get; protected set; } = 0;

        public virtual void AumentarVolume()
        {
            Volume++;
        }
    }
}
