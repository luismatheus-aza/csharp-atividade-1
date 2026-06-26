using System;

class Program
{
    public static void Main(string[] args)
    {
        // Questão 1 de Lógica de Programação 26/06/2026
        string[] nomes = new string[1];

        for (int count = 0; count < nomes.Length; count++)
        {
            Console.WriteLine($"- - - Insira o {count+1}ª nome - - -");
            nomes[count] = Console.ReadLine();

            if (nomes[count] >= 18)
            {
                Console.WriteLine("Maior de Idade");
            }
            else
            {
                Console.WriteLine("Menor de Idade");
            }
        }
    }
}