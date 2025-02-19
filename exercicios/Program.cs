// See https://aka.ms/new-console-template for more information 
using System;

class Program
{
    static void Main()
    {
        int soma = 0;
        for (int i = 1; i <= 100; i++)
        {
            if (i % 2 == 0)
            {
                soma += i;
            }
        }
        Console.WriteLine("A soma dos números pares de 1 a 100 é: " + soma);
    }
}
using System;

class Program
{
    static void Main()
    {
        for (int i = 10; i >= 1; i--)
        {
            Console.WriteLine(i);
        }
        Console.WriteLine("Decolagem!");
    }
}
using System;

class Program
{
    static void Main()
    {
        Console.Write("Digite uma palavra: ");
        string palavra = Console.ReadLine();
        string vogais = "aeiouAEIOU";
        int contador = 0;

        foreach (char letra in palavra)
        {
            if (vogais.Contains(letra))
            {
                contador++;
            }
        }
        Console.WriteLine("O número de vogais na palavra é: " + contador);
    }
}
using System;

class Program
{
    static void Main()
    {
        Console.Write("Digite uma palavra ou frase: ");
        string texto = Console.ReadLine();
        string textoLimpo = texto.Replace(" ", "").ToLower();
        char[] arr = textoLimpo.ToCharArray();
        Array.Reverse(arr);
        string textoInvertido = new string(arr);

        if (textoLimpo == textoInvertido)
        {
            Console.WriteLine("É um palíndromo!");
        }
        else
        {
            Console.WriteLine("Não é um palíndromo.");
        }
    }
}
using System;

class Program
{
    static void Main()
    {
        Random random = new Random();
        int numeroSecreto = random.Next(1, 101);
        int tentativas = 0;

        while (true)
        {
            Console.Write("Adivinhe o número entre 1 e 100: ");
            int tentativa = int.Parse(Console.ReadLine());
            tentativas++;

            if (tentativa < numeroSecreto)
            {
                Console.WriteLine("O número é maior.");
            }
            else if (tentativa > numeroSecreto)
            {
                Console.WriteLine("O número é menor.");
            }
            else
            {
                Console.WriteLine($"Parabéns! Você acertou o número em {tentativas} tentativas.");
                break;
            }
        }
    }
}