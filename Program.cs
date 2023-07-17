using Exercício_1;
using System;
class Program
{
    public static void Main(string[] args)
    {
        int n = 5;

        Console.WriteLine("---------- A SUA CHAVE ----------");
        int[] chUser = new int[n];
        Chave.Ler(n, chUser);
        Console.WriteLine();
        Console.Write("Os seus números: ");
        Chave.Mostrar(n, chUser);
        Console.Write("Chave Ordenada: ");
        Chave.Ordenar(n, chUser);
        Console.WriteLine();

        Console.WriteLine("---------- CHAVE ALEATÓRIA ----------");
        int[] chSort = new int[n];
        Chave.LerRand(n, chSort);
        Console.WriteLine();
        Console.Write("Números da Chave Aleatória: ");
        Chave.Mostrar(n, chSort);
        Console.Write("Chave Aleatória Ordenada: ");
        Chave.Ordenar(n, chSort);
        Console.WriteLine();

        Console.WriteLine("---------- NÚMEROS ACERTADOS ----------");
        Console.WriteLine();
        Chave.Acertados(n,chUser);
       
    }
}
