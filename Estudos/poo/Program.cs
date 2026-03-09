namespace Aula3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Pessoa p = new Pessoa();

            //Console.Write("Digite o nome p1: ");
            //p.Nome = Console.ReadLine();

            //Console.Write("Digite a idade p1: ");
            //p.Idade = int.Parse(Console.ReadLine());

            //Pessoa p2 = new Pessoa();

            //Console.Write("Digite o nome02: ");
            //p2.Nome = Console.ReadLine();

            //Console.Write("Digite a idade p2: ");
            //p2.Idade = int.Parse(Console.ReadLine());


            //Pessoa p3 = new Pessoa();

            //Console.Write("Digite o nome03: ");
            //p3.Nome = Console.ReadLine();

            //Console.Write("Digite a idade p3: ");
            //p3.Idade = int.Parse(Console.ReadLine());

            //Console.WriteLine("Nome p1: " + p.Nome);
            //Console.WriteLine("Idade p1: " + p.Idade);
            //Console.WriteLine("Nome p2: " + p2.Nome);
            //Console.WriteLine("Idade p2: " + p2.Idade);
            //Console.WriteLine("Nome p3: " + p3.Nome);
            //Console.WriteLine("Idade p3: " + p3.Idade);

            //Professor pf = new Professor();

            //Console.Write("Digite o nome do professor: ");
            //pf.Nome = Console.ReadLine();

            //Laboratorio l = new Laboratorio();

            //Console.Write("Digite o local: ");
            //l.Local = Console.ReadLine();

            //Console.WriteLine("Nome do Professor: " + pf.Nome);
            //Console.WriteLine("Local: " + l.Local);

        //    Jogo j = new Jogo();

        //    Console.Write("Digite o nome: ");
        //    j.Titulo = Console.ReadLine();

        //    Console.Write("Digite o genêro: ");
        //    j.Genero= Console.ReadLine();

        //    Console.Write("Digite a plataforma: ");
        //    j.Plataforma = Console.ReadLine();

        //    Console.Write("Digite o lancamento: ");
        //    j.Lancamento = DateOnly.Parse(Console.ReadLine());

        //    Console.WriteLine("Titulo: " + j.Titulo);
        //    Console.WriteLine("Genêro: " + j.Genero);
        //    Console.WriteLine("Plataforma: " + j.Plataforma);
        //    Console.WriteLine("Data: " + j.Lancamento);

            Lampada l1 = new Lampada();
            l1.Potencia = 200;
            l1.Ligar();
            l1.Desligar();

            bool b = l1.EstaLigada();
            Console.WriteLine(b);
            l1.Ligar();
            b = l1.EstaLigada();
            Console.WriteLine(b);

        }

    }
}