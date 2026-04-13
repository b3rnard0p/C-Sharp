using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade
{
    internal class Funcionario: Pessoa
    {
        public string Cargo { get; set; }

        public override void Apresentar()
        {
            Console.WriteLine($"Nome: {Nome}, Idade: {Idade}, Cargo: {Cargo}");
        }

        public override void ExibirTipo()
        {
            Console.WriteLine("Eu sou um Funcionario");
        }
    }
}
