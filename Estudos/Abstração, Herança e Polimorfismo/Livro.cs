using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade
{
    class Livro : ItemBiblioteca
    {
        public override void ExibirDestaque()
        {
            Console.WriteLine($"LIVRO: {Titulo.ToUpper()} - Por {Autor}");
        }
    }
}
