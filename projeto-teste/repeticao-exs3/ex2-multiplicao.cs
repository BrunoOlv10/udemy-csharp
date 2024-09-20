using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto.repeticao_exs3
{
    public class ex2_multiplicao
    {
        public static void Multiplicar()
        {
            try
            {
                int[] numeros = new int[2];
                for (int i = 0; i < 2; i++)
                {
                    Console.Write($"Insira o número {i + 1}: ");
                    string entrada = Console.ReadLine();
                    numeros[i] = int.Parse(entrada);
                }

                int multiplicacao = numeros[0] * numeros[1];

                Console.WriteLine();
                Console.WriteLine($"A multiplicação entre os números {numeros[0]} e {numeros[1]} resulta em {multiplicacao}");
                Console.ReadKey();
            }
            catch (Exception ex)
            {
                Console.WriteLine();
                Console.WriteLine("Insira apenas números!");
                Console.ReadKey();
            }
        }
    }
}
