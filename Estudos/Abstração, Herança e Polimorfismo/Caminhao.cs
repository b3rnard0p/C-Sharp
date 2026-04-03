using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade
{
    class Caminhao : Veiculo
    {
        public int Eixos { get; set; }
        public override double CalcularPedagio() => 10.00 * Eixos;
    }
}
