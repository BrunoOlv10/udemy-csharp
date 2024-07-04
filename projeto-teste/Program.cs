using System;

namespace projeto_teste
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Insira o seu nome completo: ");
            string nomeCompleto = Console.ReadLine();

            Console.WriteLine("Seu nome completo é: " + nomeCompleto);
            Console.ReadKey();
        }
    }
}
