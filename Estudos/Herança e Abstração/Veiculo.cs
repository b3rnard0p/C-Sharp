using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade
{
    abstract class Veiculo
    {
        public string Marca { get; set; }
        public string Modelo { get; set; }

        public double DistanciaPercorrida { get; set; }

        public abstract void Dirigir();

        public abstract void CalcularConsumo();
    }
}
