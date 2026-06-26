using System;

class Program
{
    public static void Main(string[] args)
    {
        // Questão 4 de Lógica de Programação 26/06/2026
        int[] numeros = new int[5];

        for (int count = 0; count < numeros.Length; count++)
        {
            Console.WriteLine($"- - - Insira o {count+1}ª número - - -");
            numeros[count] = int.Parse(Console.ReadLine());
        }

        for (int count = 0;count < numeros.Length; count++)
        {
            if (numeros[count] % 2 == 0)
            {
                Console.WriteLine($"O {count+1}ª Número é Par!");
            } else
            {
                Console.WriteLine($"O {count + 1}ª Número é Impar!");
            }
        }
        
    }
}
