using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade
{
    public class ProjetoMesa
    {
        private double _comprimentoTampo;
        public double ComprimentoTampo
        {
            get => _comprimentoTampo;
            set
            {
                if (value < 50)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Aviso: O Comprimento do Tampo não pode ser menor que 50 cm.");
                    Console.ResetColor();
                }
                else
                {
                    _comprimentoTampo = value;
                }
            }
        }

        private double _larguraTampo;
        public double LarguraTampo
        {
            get => _larguraTampo;
            set
            {
                if (value < 50)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Aviso: A Largura do Tampo não pode ser menor que 50 cm.");
                    Console.ResetColor();
                }
                else
                {
                    _larguraTampo = value;
                }
            }
        }

        private List<double> _cortesNecessarios = new List<double>();

        public IReadOnlyCollection<double> Cortes => _cortesNecessarios.AsReadOnly();

        public void AdicionarCorte(double tamanho)
        {
            _cortesNecessarios.Add(tamanho);
        }

        public int BarrasNecessarias
        {
            get
            {
                if (_cortesNecessarios.Count == 0) return 0;

                int barras = 1;
                double usoAtualDaBarra = 0;
                double tamanhoBarraCm = 600.0;

                foreach (var corte in _cortesNecessarios)
                {
                    if (usoAtualDaBarra + corte > tamanhoBarraCm)
                    {
                        barras++;
                        usoAtualDaBarra = corte;
                    }
                    else
                    {
                        usoAtualDaBarra += corte;
                    }
                }

                return barras;
            }
        }
    }
}
