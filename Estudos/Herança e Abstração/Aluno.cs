using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade
{
    internal class Aluno : Pessoa
    {
        public int Matricula { get; set; }

        public override void Apresentar()
        {
            Console.WriteLine($"Nome: {Nome}, Idade: {Idade}, Matrícula: {Matricula}");
        }

        public override void ExibirTipo()
        {
            Console.WriteLine("Eu sou um Aluno");
        }
    }
}
