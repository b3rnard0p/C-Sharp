using ControleConsultas.Models;
using System.Globalization;

namespace ControleConsultas.Services
{
    public static class DatabaseHelper
    {
        public static List<Cliente> CarregarClientes()
        {
            var lista = new List<Cliente>();
            if (System.IO.File.Exists("clientes.txt"))
            {
                var linhas = System.IO.File.ReadAllLines("clientes.txt");
                foreach (var linha in linhas)
                {
                    if (string.IsNullOrWhiteSpace(linha)) continue;

                    var dados = linha.Split(';');
                    lista.Add(new Cliente
                    {
                        Id = int.Parse(dados[0]),
                        Nome = dados[1]
                    });
                }
            }
            return lista;
        }

        public static List<Atendimento> CarregarAtendimentos()
        {
            var lista = new List<Atendimento>();
            if (System.IO.File.Exists("atendimentos.txt"))
            {
                foreach (var linha in System.IO.File.ReadAllLines("atendimentos.txt"))
                {
                    if (string.IsNullOrWhiteSpace(linha)) continue;
                    var d = linha.Split(';');
                    if (d.Length >= 6)
                    {
                        lista.Add(new Atendimento
                        {
                            Id = int.Parse(d[0]),
                            ClienteId = int.Parse(d[1]),
                            Especialidade = d[2],
                            Horario = DateTime.Parse(d[3]),
                            Status = Enum.Parse<StatusAtendimento>(d[4]),
                            Preco = decimal.Parse(d[5], CultureInfo.InvariantCulture)
                        });
                    }
                }
            }
            return lista;
        }
    }
}
