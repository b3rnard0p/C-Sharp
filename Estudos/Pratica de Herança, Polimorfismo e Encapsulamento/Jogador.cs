
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade
{
    internal class Jogador
    {
        public int Pontuacao { get; private set; }

        public void AdicionarPontos(int pontos)
        {
            Pontuacao += pontos;
        }
    }
}
