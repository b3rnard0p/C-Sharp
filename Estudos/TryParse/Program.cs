namespace TryParse
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Pessoa pessoa = new Pessoa();

            Console.Write("Digite o número o cpf (apenas números): ");

            while (true)
            {
                if (long.TryParse(Console.ReadLine(), out pessoa.cpf))
                {
                    Console.WriteLine("Cadastrado com sucesso!");
                    break;
                }
                else
                {
                    Console.WriteLine("Entrada inválida!");
                    Console.Write("Por favor, digite novamente: ");
                }
            }
        }
    }
}
