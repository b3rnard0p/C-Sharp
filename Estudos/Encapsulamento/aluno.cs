using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laços
{
    internal class Aluno
    {
        public string Nome { get; set; }

        private double _nota;

        public double Nota
        {
            get { return _nota; }
            set
            {
                if (value < 10)
                {
                    Console.WriteLine("Erro: A nota não pode ser menor que 10!");
                    _nota = 10;
                }
                else
                {
                    _nota = value;
                }
            }
        }

        public string Matricula { get; private set; }

        public Aluno(string numeroMatricula)
        {
            Matricula = numeroMatricula;
        }
    }
}
