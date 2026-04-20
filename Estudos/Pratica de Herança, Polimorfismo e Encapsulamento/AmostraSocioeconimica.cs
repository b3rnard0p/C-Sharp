using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade
{
    public class AmostraSocioeconomica
    {
        private decimal _nivelConfiancaEstatisica;
        public decimal NivelConfiancaEstatisica
        {
            get => _nivelConfiancaEstatisica;
            set
            {
                if (value < 0 || value > 100)
                {
                    throw new ArgumentException("O dado é inválido. Deve ser entre 0 e 100.");
                }

                if (value > 1.0m)
                {
                    _nivelConfiancaEstatisica = value / 100m;
                }
                else
                {
                    _nivelConfiancaEstatisica = value;
                }
            }
        }

        private List<double> _dadosRenda = new List<double>();
        private double? _mediaCache = null;
        private double? _medianaCache = null;

        public void AdicionarDado(double valor)
        {
            _dadosRenda.Add(valor);

            // Invalida o cache
            _mediaCache = null;
            _medianaCache = null;
        }

        public double MediaRenda
        {
            get
            {
                if (_mediaCache == null)
                {
                    if (_dadosRenda.Count == 0) return 0;
                    _mediaCache = _dadosRenda.Average();
                }
                return _mediaCache.Value;
            }
        }

        public double MedianaRenda
        {
            get
            {
                if (_medianaCache == null)
                {
                    if (_dadosRenda.Count == 0) return 0;

                    var dadosOrdenados = _dadosRenda.OrderBy(x => x).ToList();
                    int tamanho = dadosOrdenados.Count;
                    int meio = tamanho / 2;

                    if (tamanho % 2 == 0)
                    {
                        _medianaCache = (dadosOrdenados[meio - 1] + dadosOrdenados[meio]) / 2.0;
                    }
                    else
                    {
                        _medianaCache = dadosOrdenados[meio];
                    }
                }
                return _medianaCache.Value;
            }
        }
    }
}