using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade
{
    class Funcionario : Pessoa
    {
        public int Matricula { get; set; }

        public Funcionario(string nome, int matricula) : base(nome)
        {
            Matricula = matricula;
        }
    }
}
