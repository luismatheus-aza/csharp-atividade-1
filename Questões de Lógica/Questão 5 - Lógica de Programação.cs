using System;
using System.Linq;

class Program
{
    public static void Main(string[] args)
    {
        // Questão 5 de Lógica de Programação 26/06/2026
        Console.WriteLine("Insira o número: ");
        short numero = short.Parse(Console.ReadLine());

        for (int count = 0; count <= 10; count++)
        {
            Console.WriteLine($"{numero} x {count} = {numero*count} ");
        }

    }
}
