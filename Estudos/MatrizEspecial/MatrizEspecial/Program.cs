using System;
using System.Collections.Generic;

class Celula
{
    public int linha;
    public int coluna;
    public int valor;
    public static int qtdLinhas;
    public static int qtdColunas;

    public Celula(int linha, int coluna, int valor)
    {
        this.linha = linha;
        this.coluna = coluna;
        this.valor = valor;
    }

    public override string ToString()
    {
        return $"Celula [linha={linha}, coluna={coluna}, valor={valor}]";
    }

    public override int GetHashCode()
    {
        unchecked
        {
            int prime = 31;
            int result = 1;
            result = prime * result + linha;
            result = prime * result + coluna;
            return result;
        }
    }

    public override bool Equals(object obj)
    {
        if (this == obj)
            return true;
        if (obj == null)
            return false;
        if (GetType() != obj.GetType())
            return false;
        Celula other = (Celula)obj;
        if (linha != other.linha)
            return false;
        if (coluna != other.coluna)
            return false;
        return true;
    }

    public static void TransformaMatrizEmHash(int[][] matriz, HashSet<Celula> tabelaHash)
    {
        for (int i = 0; i < matriz.Length; i++)
        {
            for (int j = 0; j < matriz[i].Length; j++)
            {
                if (matriz[i][j] != 0)
                {
                    tabelaHash.Add(new Celula(i, j, matriz[i][j]));
                }
            }
        }
        Celula.qtdLinhas = matriz.Length;
        Celula.qtdColunas = matriz[0].Length;
    }

    public static void TransformaHashEmMatriz(HashSet<Celula> tabelaHash, int[][] matriz)
    {
        for (int i = 0; i < matriz.Length; i++)
        {
            for (int j = 0; j < matriz[i].Length; j++)
            {
                matriz[i][j] = 0;
            }
        }

        foreach (Celula ponto in tabelaHash)
        {
            matriz[ponto.linha][ponto.coluna] = ponto.valor;
        }
    }

    public static void ExibeMatrizEmHash(HashSet<Celula> tabelaHash)
    {
        Console.WriteLine($"Matriz[{Celula.qtdLinhas}][{Celula.qtdColunas}]");

        foreach (Celula ponto in tabelaHash)
        {
            Console.WriteLine(ponto);
        }
    }
}

class MatrizEspecial
{
    const int TAML = 10;
    const int TAMC = 10;

    public static void ZerarMatriz(int[][] matriz)
    {
        for (int i = 0; i < TAML; i++)
        {
            for (int j = 0; j < TAMC; j++)
            {
                matriz[i][j] = 0;
            }
        }
    }

    public static void MostrarMatriz(int[][] matriz)
    {
        for (int i = 0; i < TAML; i++)
        {
            for (int j = 0; j < TAMC; j++)
            {
                Console.Write(matriz[i][j] + "\t");
            }
            Console.WriteLine();
        }
    }

    public static void Main(string[] args)
    {
        int[][] matriz = new int[TAML][];
        for (int i = 0; i < TAML; i++)
        {
            matriz[i] = new int[TAMC];
        }

        ZerarMatriz(matriz);
        matriz[0][0] = 100;
        matriz[5][5] = 100;
        matriz[9][9] = 100;

        MostrarMatriz(matriz);

        HashSet<Celula> tabelaHash = new HashSet<Celula>();

        Celula.TransformaMatrizEmHash(matriz, tabelaHash);
        Celula.ExibeMatrizEmHash(tabelaHash);

        ZerarMatriz(matriz);

        Celula.TransformaHashEmMatriz(tabelaHash, matriz);

        Console.WriteLine("\nMatriz reconstruída a partir do HashSet:");
        MostrarMatriz(matriz);
    }
}

