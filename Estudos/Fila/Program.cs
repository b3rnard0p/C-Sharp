// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;

public class Cliente
{
    public string Fone;    
    public string Nome;
    public int FichaAtendimento;

    public Cliente(string fone, string nome, int ficha)
    {
        Fone = fone;
        Nome = nome;
        FichaAtendimento = ficha;
    }

    public override string ToString()
    {
        return $"Cliente: {Nome} : {Fone} -> Ficha: {FichaAtendimento}\n";
    }
}

public class Principal
{
    public static void Chamar(Queue<Cliente> fila, ref int quantidadeAtendimento)
    {
        Cliente obj = fila.Dequeue();
        Console.WriteLine($"Chamando ficha ... {obj.FichaAtendimento}");

        quantidadeAtendimento++;
    }

    public static void Menu(Queue<Cliente> filaNormal, Queue<Cliente> filaPrioritaria)
    {
        int quantidadeAtendimento = 0;
        int contadorNormal = 0;
        int contadorPrioritario = 1000;

        string op;
        string fone, nome;
        do
        {
            Console.WriteLine("\n1 - Normal");
            Console.WriteLine("2 - Prioritário");
            Console.WriteLine("3 - Chamar");
            Console.WriteLine("4 - Finalizar");
            Console.Write("Opção: ");
            op = Console.ReadLine();

            switch (op)
            {
                case "1":
                    contadorNormal++;
                    Console.Write("Nome do cliente: ");
                    nome = Console.ReadLine().ToUpper();
                    Console.Write("Fone do cliente: ");
                    fone = Console.ReadLine();
                    filaNormal.Enqueue(new Cliente(fone, nome, contadorNormal));
                    Console.WriteLine($"Imprimindo a ficha {contadorNormal}");
                    break;
                case "2":
                    contadorPrioritario++;
                    Console.Write("Nome do cliente: ");
                    nome = Console.ReadLine().ToUpper();
                    Console.Write("Fone do cliente: ");
                    fone = Console.ReadLine();
                    filaPrioritaria.Enqueue(new Cliente(fone, nome, contadorPrioritario));
                    Console.WriteLine($"Imprimindo a ficha {contadorPrioritario}");
                    break;
                case "3":
                    if (quantidadeAtendimento % 3 == 0)
                    {
                        // chamar ficha prioritaria
                        try
                        {
                            Chamar(filaPrioritaria, ref quantidadeAtendimento);
                        }
                        catch (Exception)
                        {
                            try
                            {
                                Chamar(filaNormal, ref quantidadeAtendimento);
                            }
                            catch (Exception)
                            {

                            }
                        }
                    }
                    else
                    {
                        // chamar ficha normal
                        try
                        {
                            Chamar(filaNormal, ref quantidadeAtendimento);
                        }
                        catch (Exception)
                        {
                            try
                            {
                                Chamar(filaPrioritaria, ref quantidadeAtendimento);
                            }
                            catch (Exception)
                            {

                            }
                        }
                    }
                    break;
                case "4":
                    break;
                default:
                    Console.WriteLine("Opção inválida");
                    break;
            }
        } while (op != "4");
    }

    public static void Main(string[] args)
    {
        Queue<Cliente> filaNormal = new Queue<Cliente>();
        Queue<Cliente> filaPrioritaria = new Queue<Cliente>();

        Menu(filaNormal, filaPrioritaria);
    }
}

