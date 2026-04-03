using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade
{
    class Revista : ItemBiblioteca
    {
        public string Edicao { get; set; }
        public override void ExibirDestaque()
        {
            Console.WriteLine($"REVISTA: {Titulo} (Edição: {Edicao}) - Por {Autor}");
        }
    }
}
