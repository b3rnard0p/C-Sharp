using System.Runtime.CompilerServices;

namespace Conceitos_Básicos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Abaixo
            //Console.WriteLine("Hello, World!");
            //Console.WriteLine("Hello, World!");
            //Console.Write("Hello, World!\n");

            //Mesma
            //Console.Write("Hello, World!");
            //Console.Write("Hello, World!");

            //Váriaveis
            int n1, n2;
            float f;
            double d;
            decimal preco; // Sugerido utilizar pois faz soma direta no número

            string nome; // Atalho, ambos são o mesmo
            String sobrenome;

            nome = "Bernardo";
            sobrenome = "Paz";
            string nomeCompleto = nome + " " + sobrenome;

            n1 = 2;
            n2 = 3;
            d = 4.33;
            f = 5.44f; // Colocar o f no fim para avisar que chegou o fim
            preco = 6.55m; // Colocar o m no fim para avisar que chegou o fim

            //Console.WriteLine("Nome: " + nomeCompleto);
            //Console.WriteLine("n1: " + n1);
            //Console.WriteLine("n2: " + n2);
            //Console.WriteLine("d: " + d);
            //Console.WriteLine("f: " + f);
            //Console.WriteLine("preco: " + preco);

            DateTime data = DateTime.Now;
            //Console.WriteLine("Dia: " + data.Day);
            //Console.WriteLine("Dia da Semana: " + data.DayOfWeek);
            //Console.WriteLine("Mês: " + data.Month);
            //Console.WriteLine("Ano: " + data.Year);
            //Console.WriteLine("Hora: " + data.Hour);
            //Console.WriteLine("Minuto: " + data.Minute);
            //Console.WriteLine("Completo: " + data);

            string frase1;
            string frase2;

            frase1 = "Hoje é Segunda-Feira";
            frase2 = "dia da melhor aula do melhor framework";

            //Console.WriteLine($"{frase1} {frase2}"); // Forma padrão do C# de concatenar
            //Console.WriteLine($"Usando concatenação: {frase1}");

            string disciplina;
            string curso;

            Console.WriteLine("Digite o nome do curso: ");
            curso = Console.ReadLine();
            Console.WriteLine("Digite o nome do discplina: ");
            disciplina = Console.ReadLine();

            Console.WriteLine("Curso:" + curso);
            Console.WriteLine("Disciplina:" + disciplina);

             //double n1;
             //Console.WriteLine("Digite um double: ");
             //n1 = double.Parse(Console.ReadLine());
             //if (n1 > 0)
             //{
             //    Console.WriteLine("N1 positivo!");
             //}
             //else if (n1 < 0)
             //{
             //    Console.WriteLine("N2 negativo!");
             //}
             //else
             //{
             //    Console.WriteLine("N1 é 0!");
             //}
            
             //int n2;
             //Console.WriteLine("Digite um numero: ");
             //n2 = int.Parse(Console.ReadLine());
             //if (n2 % 2 == 0)
             //{
             //    Console.WriteLine("Divisivel por 2!");
             //}
             //if (n2 % 4 == 0)
             //{
             //    Console.WriteLine("Divisivel por 4!");
             //}
             //if (n2 % 8 == 0)
             //{
             //    Console.WriteLine("Divisivel por 8!");
             //}
            
             //bool continuar = true;
            
             //Console.Write("Escolha o número da operação: ");
             //Console.WriteLine("\n1 - Soma");
             //Console.WriteLine("2 - Subtração");
             //Console.WriteLine("3 - Divisão");
             //Console.WriteLine("4 - Multiplicação");
             //string opcao = Console.ReadLine();
            
             //Console.Write("Digite o primeiro número: ");
             //double numero1 = Convert.ToDouble(Console.ReadLine());
            
             //Console.Write("Digite o segundo número: ");
             //double numero2 = Convert.ToDouble(Console.ReadLine());
            
             //if (opcao == "1")
             //{
             //    double resultado = numero1 + numero2;
             //    Console.WriteLine($"Usar calculadora p isso é sacanagem: {resultado}");
             //}
             //else if (opcao == "2")
             //{
             //    double resultado = numero1 - numero2;
             //    Console.WriteLine($"Só falta me dizer que conta nos dedos ainda: {resultado}");
             //}
             //else if (opcao == "3")
             //{
             //    if (numero2 == 0)
             //    {
             //        Console.WriteLine("Erro: Não é possível que com a tua idade tu não sabe que não se divide por zero.");
             //    }
             //    else
             //    {
             //        double resultado = numero1 / numero2;
             //        Console.WriteLine($"Da próxima vez usa a cabeça: {resultado}");
             //    }
             //}
             //else if (opcao == "4")
             //{
             //    double resultado = numero1 * numero2;
             //    Console.WriteLine($"P tu ser burro falta muito ainda: {resultado}");
             //}
            
             //for (int i = 0; i < 10; i++)
             //{
             //    if(i == 5)
             //    {
             //        continue;
             //    }
             //    if (i == 8)
             //    {
             //        break;
             //    }
             //    Console.WriteLine(i);
             //}
            
             while (true)
             {
                 double op;
                 Console.Write("Escolha o número da operação (1 a 4): ");
                 op = Convert.ToDouble(Console.ReadLine());
            
                 if (op == 1 || op == 2 || op == 3 || op == 4)
                 {
                     break;
                 }
                 else
                 {
                     Console.WriteLine("Opção inválida! Por favor, digite um valor entre 1 e 4.\n");
                 }
             }
        }
    }
}

