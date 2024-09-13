using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto.repeticao_exs2
{
    public class ex15_soma_array
    {
        public static void SomarValoresArray()
        {
            try
            {
                Console.Write("Escreva os valores que entrarão no array (separados por vírgula): ");
                string[] numerosString = Console.ReadLine().Split(',');
                int[] numeros = new int[numerosString.Length];

                for (int i = 0; i < numerosString.Length; i++)
                {
                    numeros[i] = int.Parse(numerosString[i]);
                }

                int somador = 0;
                foreach (int numero in numeros)
                {
                    somador += numero;
                }

                Console.WriteLine();
                Console.WriteLine($"A soma entre os números " + String.Join(", ", numeros) + $" resulta em {somador}");
                Console.ReadKey();
            }
            catch (Exception)
            {
                Console.WriteLine();
                Console.WriteLine("Digite apenas números para o array!");
                Console.ReadKey();
            }
        }
    }
}
