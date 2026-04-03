using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade
{
    class Cachorro : Animal
    {
        public override void EmitirSom() => Console.WriteLine($"{Nome} faz: Au Au!");
    }
}
