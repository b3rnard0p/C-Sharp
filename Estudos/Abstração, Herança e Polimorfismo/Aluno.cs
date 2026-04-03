using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade
{
    internal class Aluno
    {
        public string Nome { get; set; }
        public int Idade { get; set; }
        public string Curso { get; set; }

        public Aluno(string nome, int idade, string curso)
        {
            Nome = nome;
            Idade = idade;
            Curso = curso;
        }

        public void ApresentarDados()
        {
            Console.WriteLine($"\n--- Dados do Aluno ---");
            Console.WriteLine($"Nome: {Nome}");
            Console.WriteLine($"Idade: {Idade} anos");
            Console.WriteLine($"Curso: {Curso}");
            Console.WriteLine("----------------------\n");
        }
    }
}
