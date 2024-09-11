using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto.repeticao_exs
{
    public class ex27_elementos_array_trocados
    {
        public static int[] ObterArray()
        {
            while (true)
            {
                try
                {
                    Console.Write("Insira o tamanho do array: ");
                    int tamanhoArray = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine();
                    int[] numeros = new int[tamanhoArray];
                    for (int i = 0; i < tamanhoArray; i++)
                    {
                        Console.Write($"Insira o elemento {i} do array: ");
                        int numero = Convert.ToInt32(Console.ReadLine());
                        numeros[i] = numero;
                    }

                    return numeros;
                }
                catch (System.FormatException)
                {
                    Console.WriteLine();
                    Console.WriteLine("Insira apenas números no tamanho e elementos do array!");
                }
            }
        }

        public static int[] InverterArray(int[] numeros)
        {
            int[] numerosInvertidos = (int[])numeros.Clone();

            Array.Reverse(numerosInvertidos);

            Console.WriteLine();
            Console.WriteLine($"O array [" + string.Join(", ", numeros) + "] invertido ficou [" + string.Join(", ", numerosInvertidos) + "]");
            Console.ReadKey();

            return numerosInvertidos;
        }
    }
}
