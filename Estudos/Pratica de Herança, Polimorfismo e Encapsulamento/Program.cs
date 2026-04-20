using static System.Net.Mime.MediaTypeNames;

namespace Atividade
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Exercicio 1
            //ConfiguracaoSistema config = new ConfiguracaoSistema();
            //Console.WriteLine($"NomeServidor:{config.NomeServidor} Porta: {config.Porta} e ModoDebug: {config.ModoDebug}");

            //Exercicio 2
            //Produto prod = new Produto();
            //prod.QuantidadeEstoque = 10;
            //prod.QuantidadeEstoque = -5;
            //Console.WriteLine(prod.QuantidadeEstoque);

            //Exercicio 3
            //Jogador jog = new Jogador();
            ////jog.AdicionarPontos(150);
            //jog.Pontuacao = 150;
            //Console.WriteLine($"Pontuação do Jogador: {jog.Pontuacao}\n");

            //Exercicio 4
            //Motocicleta moto = new Motocicleta();
            //moto.RegistrarChassi("CHASSI-999X");
            //moto.numeroChassi = "123";

            //Exercício 5
            //Funcionario func = new Funcionario("Bernardo Paz", 123);
            //Console.WriteLine($"Funcionario: {func.Nome} e Matrícula: {func.Matricula}\n");

            // Exercício 7
            //Calculadora calc = new Calculadora();
            //Console.WriteLine($"Soma 1: {calc.Somar(10, 5)}");
            //Console.WriteLine($"Soma 2: {calc.Somar(10, 5, 2)}");
            //Console.WriteLine($"Soma 3: {calc.Somar(10.5, 5.5)}");

            //Exercício 8 e 9
            //Conta contaComum = new Conta();
            //Conta contaVip = new ContaVip();
            //Conta contaPoupanca = new ContaPoupanca();

            //contaComum.Sacar(50m);
            //contaVip.Sacar(50m);
            //contaPoupanca.Sacar(50m);

            //Exercício 10
            Contrato contrato = new Contrato();
            contrato.Abrir();
            contrato.Imprimir();
            contrato.Assinar();
        }
    }
}
