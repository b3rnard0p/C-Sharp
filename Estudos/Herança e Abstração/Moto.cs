using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade
{
    internal class Moto : Veiculo
    {
        public int Cilindrada {  get; set; }

        public override void Dirigir()
        {
            Console.WriteLine($"Dirigindo o {Marca} com {Cilindrada} cilindradas");
        }

        public override void CalcularConsumo()
        {
            double kmPorLitroEstimado = 8000.0 / Cilindrada;
            double consumo = DistanciaPercorrida / kmPorLitroEstimado;
            Console.WriteLine($"O consumo é de {consumo}.");
        }
    }
}
