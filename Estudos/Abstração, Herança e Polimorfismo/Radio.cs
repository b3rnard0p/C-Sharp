using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade
{
    class Radio : AparelhoSom
    {
        public override void AumentarVolume()
        {
            Volume += 1;
        }
    }
}
