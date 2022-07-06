using System;

namespace questao1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1, n2;

            Console.WriteLine("Digite um número inteiro : ");
            n1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo número inteiro : ");
            n2 = int.Parse(Console.ReadLine());

            int soma;
            soma = n1 + n2;
            Console.WriteLine("SOMA = " + soma);
        }
    }
}
