using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade
{
    internal class Professor : Pessoa
    {
        public string Disciplina { get; set; }

        public override void Apresentar()
        {
            Console.WriteLine($"Nome: {Nome}, Idade: {Idade}, Disciplina: {Disciplina}");
        }

        public override void ExibirTipo()
        {
            Console.WriteLine("Eu sou um Professor");
        }
    }
}
