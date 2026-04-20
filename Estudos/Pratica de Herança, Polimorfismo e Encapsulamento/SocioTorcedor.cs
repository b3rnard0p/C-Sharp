using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade
{
    using System;

    public class SocioTorcedor
    {
        public string Nome { get; set; }
        public string Categoria { get; set; }

        private decimal _mensalidade;
        public decimal Mensalidade
        {
            get => _mensalidade;
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("A mensalidade não pode ser negativa ou zero.");
                }
                _mensalidade = value;
            }
        }

        public DateTime DataAdesao { get; private set; }

        private int _mesesInadimplente;

        public bool StatusAdimplente => _mesesInadimplente == 0;

        public SocioTorcedor()
        {
            DataAdesao = DateTime.Now;
        }

        public void RegistrarPagamento()
        {
            _mesesInadimplente = 0;
        }

        public void RegistrarAtraso()
        {
            _mesesInadimplente++;
        }

        private decimal CalcularFatorDesconto()
        {
            if (!StatusAdimplente) return 1m;
            return Categoria switch
            {
                "Colorado" => 0.5m,
                "Campeão" => 0.7m,
                _ => 1m
            };
        }

        public decimal ValorComDescontoIngresso => 100m * CalcularFatorDesconto();
    }
}
