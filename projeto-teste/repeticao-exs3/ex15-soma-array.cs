using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto.repeticao_exs3
{
    class UmElementoInseridoException : Exception { }

    public class ex15_soma_array
    {
        public static void SomarArray()
        {
            try
            {
                Console.Write("Insira os números separados por vírgulas que entrarão no array: ");
                string entrada = Console.ReadLine();
                int[] numeros = entrada.Split(',').Select(int.Parse).ToArray();

                if (numeros.Length == 1)
                {
                    throw new UmElementoInseridoException();
                }

                int soma = numeros.Sum();

                Console.WriteLine();
                Console.WriteLine($"Os números inseridos foram " + String.Join(", ", numeros) + $" e o resultado da soma entre eles é {soma}");
                Console.ReadKey();
            }
            catch (UmElementoInseridoException)
            {
                Console.WriteLine();
                Console.WriteLine("Não é possível somar com apenas um elemento!");
                Console.ReadKey();
            }
            catch (System.FormatException)
            {
                Console.WriteLine();
                Console.WriteLine("Insira apenas números para entrar no array!");
                Console.ReadKey();
            }
        }
    }
}
