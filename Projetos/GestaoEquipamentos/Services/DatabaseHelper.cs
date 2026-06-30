using TrabalhoFinal.Models;
using System.IO;
using System.Globalization;

namespace TrabalhoFinal.Services
{
    public static class DatabaseHelper
    {
        private const string EquipamentosFilePath = "equipamentos.txt";
        private const string EmprestimosFilePath = "emprestimos.txt";

        public static List<Equipamento> CarregarEquipamentos()
        {
            var equipamentos = new List<Equipamento>();

            if (!File.Exists(EquipamentosFilePath))
                return equipamentos;

            var linhas = File.ReadAllLines(EquipamentosFilePath).Where(l => !string.IsNullOrWhiteSpace(l));

            foreach (var linha in linhas)
            {
                var dados = linha.Split(';');
                if (dados.Length >= 4)
                {
                    string idStr = dados[0].Trim('\uFEFF', '\u200B', ' ');
                    if (int.TryParse(idStr, out int id))
                    {
                        equipamentos.Add(new Equipamento
                        {
                            Id = id,
                            Nome = dados[1],
                            CodigoPatrimonio = dados[2],
                            Situacao = Enum.Parse<SituacaoEquipamento>(dados[3])
                        });
                    }
                }
            }

            return equipamentos;
        }

        public static List<Emprestimo> CarregarEmprestimos()
        {
            var emprestimos = new List<Emprestimo>();

            if (!File.Exists(EmprestimosFilePath))
                return emprestimos;

            var linhas = File.ReadAllLines(EmprestimosFilePath).Where(l => !string.IsNullOrWhiteSpace(l));

            foreach (var linha in linhas)
            {
                var dados = linha.Split(';');
                if (dados.Length >= 4)
                {
                    string idStr = dados[0].Trim('\uFEFF', '\u200B', ' ');
                    if (int.TryParse(idStr, out int id) && int.TryParse(dados[1], out int equipId))
                    {
                        if (DateTime.TryParse(dados[3], CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime data))
                        {
                            bool statusAtivo = true;
                            if (dados.Length >= 5)
                            {
                                bool.TryParse(dados[4], out statusAtivo);
                            }
                            
                            emprestimos.Add(new Emprestimo
                            {
                                Id = id,
                                EquipamentoId = equipId,
                                EmailResponsavel = dados[2],
                                DataEmprestimo = data,
                                StatusAtivo = statusAtivo
                            });
                        }
                    }
                }
            }

            return emprestimos;
        }
    }
}
