using System;
using System.Linq;

class Program
{
    public static void Main(string[] args)
    {
        // Questão 3 de Lógica de Programação 26/06/2026
        double[] numeros = new double[3];
        for (int count = 0; count < numeros.Length; count++)
        {
            Console.Write($"Insira a {count + 1}º nota: ");
            numeros[count] = double.Parse(Console.ReadLine());
        }

        double media = numeros.Average();
        Console.WriteLine($"\nMédia: {media:F2}");
        if (media >= 6.9)
        {
            Console.WriteLine("Situação: Aprovado!");
        }
        else if (media >= 5.0)
        {
            Console.WriteLine("Situação: Recuperação!");
        }
        else
        {
            Console.WriteLine("Situação: Reprovado!");
        }
    }
}
