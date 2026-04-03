using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade
{
    class Guerreiro : Personagem
    {
        public override void Atacar()
        {
            Console.WriteLine($"{Nome} ataca com a Espada!");
        }
    }
}
