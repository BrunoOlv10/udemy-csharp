using System;

namespace projeto_teste
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Insira o primeiro valor: ");
            string valor1 = Console.ReadLine();
            int numero1 = int.Parse(valor1);

            Console.WriteLine();

            Console.Write("Insira o segundo valor: ");
            string valor2 = Console.ReadLine();
            int numero2 = int.Parse(valor2);

            Console.WriteLine();

            int soma = numero1 + numero2;
            Console.WriteLine("Soma: " + soma);

            int subtracao = numero1 - numero2;
            Console.WriteLine("Subtração: " + subtracao);

            int multiplicacao = numero1 * numero2;
            Console.WriteLine("Multiplicação: " + multiplicacao);

            int divisao = numero1 / numero2;
            Console.WriteLine("Divisão: " + divisao);

            int modulo = numero1 % numero2;
            Console.WriteLine("Modulo: " + modulo);

            Boolean igual = numero1 == numero2;
            Console.WriteLine("Iguais? " + igual);

            Boolean diferentes = numero1 != numero2;
            Console.WriteLine("Diferentes? " + diferentes);

            Boolean comparacaoMaior = numero1 > numero2;
            Console.WriteLine("Valor 1 é maior que valor 2? " + comparacaoMaior);

            Console.ReadKey();
        }
    }
}
