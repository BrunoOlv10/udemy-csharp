using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace curso_udemy.repeticao_exs
{
    public class ex7_numero_positivo_negativo
    {
        public static (int, int) ObterNumeros()
        {
            int numero1 = 0;
            int numero2 = 0;
            bool numero1Valido = false;
            bool numero2Valido = false;

            while (!numero1Valido)
            {
                try
                {
                    Console.Write("Insira o primeiro número (positivo ou negativo): ");
                    numero1 = Convert.ToInt32(Console.ReadLine());
                    numero1Valido = true;

                    Console.WriteLine();
                }
                catch (System.FormatException)
                {
                    Console.WriteLine();
                    Console.WriteLine("Digite apenas números!");
                }
            }

            while (!numero2Valido)
            {
                try
                {
                    Console.Write("Insira o segundo número (positivo ou negativo): ");
                    numero2 = Convert.ToInt32(Console.ReadLine());
                    numero2Valido = true;

                    Console.WriteLine();
                }
                catch (System.FormatException)
                {
                    Console.WriteLine();
                    Console.WriteLine("Digite apenas números!");
                }
            }

            return (numero1, numero2);
        }

        public static bool ObterResultado(int numero1, int numero2)
        {
            bool objetivo = false;
            if (numero1 > 0 && numero2 < 0 || numero1 < 0 && numero2 > 0)
            {
                objetivo = true;
                Console.WriteLine($"Objetivo {objetivo}, regras respeitadas!");
            }
            else
            {
                Console.WriteLine($"Objetivo {objetivo}, regras NÃO respeitadas!");
            }

            Console.ReadKey();

            return objetivo;
        }
    }
}
