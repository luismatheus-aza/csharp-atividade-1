using System;

class Program
{
    public static void Main(string[] args)
    {
        // Questão 2 de Lógica de Programação 26/06/2026
        short[] idades = new short[1];

        for (int count = 0; count < idades.Length; count++)
        {
            Console.WriteLine($"- - - Insira a {count + 1}ª idade - - -");
            idades[count] = short.Parse(Console.ReadLine());

            if (idades[count] >= 18)
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


