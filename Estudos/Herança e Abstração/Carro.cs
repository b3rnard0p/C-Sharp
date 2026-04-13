using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade
{
    internal class Carro: Veiculo
    {
        public int Portas { get; set; }
        public double KmL { get; set; }

        public override void Dirigir() 
        {
            Console.WriteLine($"Dirigindo o {Marca} com {Portas} portas");
        }

        public override void CalcularConsumo()
        {
            double consumo = DistanciaPercorrida / KmL;
            Console.WriteLine($"O consumo do carro é de {consumo}.");
        }
    }
}
