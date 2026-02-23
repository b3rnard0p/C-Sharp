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
        }
    }
}
