namespace Atividade
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Exercicio 1
            //    List<Animal> animais = new List<Animal>
            //{
            //    new Cachorro { Nome = "Rex" },
            //    new Gato { Nome = "Mingau" }
            //};

            //    foreach (var animal in animais)
            //    {
            //        animal.EmitirSom();
            //    }

            // Exercicio 2
            //List<AparelhoSom> aparelhos = new List<AparelhoSom> { new Radio(), new HomeTheater() };

            //foreach (var aparelho in aparelhos)
            //{

            //    Console.WriteLine($"\n{aparelho.GetType().Name}");
            //    for (int i = 0; i < 3; i++)
            //    {
            //        aparelho.AumentarVolume();
            //        Console.WriteLine($"Aumento {i + 1}: Volume atual -> {aparelho.Volume}");
            //    }
            //}

            // Exercicio 3
            //Console.WriteLine("Digite o lado do quadrado:");
            //Quadrado q = new Quadrado();
            //q.Lado = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine($"Área do Quadrado: {q.CalcularArea()}");

            //Console.WriteLine("\nDigite a base e depois a altura do retângulo:");
            //Retangulo r = new Retangulo();
            //r.Base = Convert.ToDouble(Console.ReadLine());
            //r.Altura = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine($"Área do Retângulo: {r.CalcularArea()}");

            // Exercicio 4
            //Mensagem m1 = new Email { Texto = "Relatório mensal pronto." };
            //Mensagem m2 = new SMS { Texto = "Seu código de verificação é 1234." };

            //m1.Enviar();
            //m2.Enviar();

            //Exercicio 5
            //Conta cc = new ContaCorrente(100);
            //cc.Sacar(50);
            //cc.Sacar(60);

            //Conta cp = new ContaPoupanca(100);
            //cp.Sacar(50);

            //Exercicio 6
            //List<Veiculo> veiculos = new List<Veiculo>();
            //string opcao;

            //do
            //{
            //    Console.WriteLine("1-Carro | 2-Caminhao | 0-Sair");
            //    opcao = Console.ReadLine();

            //    if (opcao == "1")
            //    {
            //        veiculos.Add(new Carro());
            //        Console.WriteLine("Adicionado.");
            //    }
            //    else if (opcao == "2")
            //    {
            //        Console.WriteLine("Quantos eixos?");
            //        int eixos = Convert.ToInt32(Console.ReadLine());
            //        veiculos.Add(new Caminhao { Eixos = eixos });
            //        Console.WriteLine("Adicionado.");
            //    }

            //} while (opcao != "0");

            //double totalArrecadado = 0;
            //foreach (var v in veiculos)
            //{
            //    totalArrecadado += v.CalcularPedagio();
            //}

            //Console.WriteLine($"Total arrecadado: R${totalArrecadado}");

            //Exercicio 7
            //Livro l = new Livro { Titulo = "O Senhor dos Anéis", Autor = "J.R.R. Tolkien" };
            //Revista r = new Revista { Titulo = "Superinteressante", Autor = "Editora Abril", Edicao = "450" };

            //l.ExibirDestaque();
            //r.ExibirDestaque();

            //Exercicio 8
            //    List<Personagem> personagens = new List<Personagem>
            //{
            //    new Guerreiro { Nome = "Arthur" },
            //    new Mago { Nome = "Merlin" }
            //};

            //    for (int turno = 1; turno <= 3; turno++)
            //    {
            //        Console.WriteLine($"\n--- Turno {turno} ---");
            //        foreach (var p in personagens)
            //        {
            //            p.Atacar();
            //        }
            //    }

            //Exercicio 9
            //Carrinho c = new Carrinho();
            //c.Itens.Add(new ProdutoNacional { Nome = "Feijão", PrecoBase = 8.00 });
            //c.Itens.Add(new ProdutoImportado { Nome = "Perfume", PrecoBase = 100.00 });

            //Console.WriteLine($"Total do Carrinho: R${c.SomarTotal()}");

            //Exercicio 10
            //List<Funcionario> funcionarios = new List<Funcionario>();

            //Console.WriteLine("Quantos funcionários deseja cadastrar?");
            //int qtd = Convert.ToInt32(Console.ReadLine());

            //for (int i = 0; i < qtd; i++)
            //{
            //    Console.WriteLine("\nTipo (1-Vendedor | 2-Gerente):");
            //    string tipo = Console.ReadLine();

            //    Console.WriteLine("Nome:");
            //    string nome = Console.ReadLine();

            //    Console.WriteLine("Salário Base:");
            //    double salario = Convert.ToDouble(Console.ReadLine());

            //    if (tipo == "1")
            //    {
            //        Console.WriteLine("Total de Vendas:");
            //        double vendas = Convert.ToDouble(Console.ReadLine());
            //        funcionarios.Add(new Vendedor { Nome = nome, SalarioBase = salario, TotalVendas = vendas });
            //    }
            //    else if (tipo == "2")
            //    {
            //        Console.WriteLine("Bônus Fixo:");
            //        double bonus = Convert.ToDouble(Console.ReadLine());
            //        funcionarios.Add(new Gerente { Nome = nome, SalarioBase = salario, BonusFixo = bonus });
            //    }
            //}

            //Console.WriteLine("\n--- Folha de Pagamento ---");
            //foreach (var func in funcionarios)
            //{
            //    double pagamento = func.CalcularPagamento();
            //    Console.WriteLine($"{func.Nome} - Receberá: R${pagamento}");

            //    if (pagamento > 5000.00)
            //    {
            //        Console.WriteLine($"[ALERTA DE ORÇAMENTO] O pagamento de {func.Nome} excedeu R$5.000,00!");
            //    }
            //}
        }
    }
}
