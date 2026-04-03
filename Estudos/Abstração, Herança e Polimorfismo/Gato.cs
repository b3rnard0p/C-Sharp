using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade
{
    class Gato : Animal
    {
        public override void EmitirSom() => Console.WriteLine($"{Nome} faz: Miau!");
    }
}
