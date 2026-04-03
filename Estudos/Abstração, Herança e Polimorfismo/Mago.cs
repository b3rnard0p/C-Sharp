using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade
{
    class Mago : Personagem
    {
        public override void Atacar()
        {
            Console.WriteLine($"{Nome} ataca com Magia!");
        }
    }
}
