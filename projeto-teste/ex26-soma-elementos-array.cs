using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto
{
    public class ex26_soma_elementos_array
    {
        public static int[] TamanhoArray()
        {
            while (true)
            {
                int[] arrayNumeros = new int[0];
                try
                {
                    Console.Write("Insira o tamanho do array: ");
                    int tamanhoArray = Convert.ToInt32(Console.ReadLine());
                    arrayNumeros = new int[tamanhoArray];

                    return arrayNumeros;
                }
                catch (System.FormatException)
                {
                    Console.WriteLine();
                    Console.WriteLine("Insira um número válido!");
                }
            }
        }

        public static int[] ElementosArray(int[] arrayNumeros)
        {
            while (true)
            {
                try
                {
                    string[] numerosInseridos = new string[arrayNumeros.Length];
                    Console.WriteLine();
                    Console.WriteLine("Insira os elementos: ");
                    for (int i = 0; i < arrayNumeros.Length; i++)
                    {
                        Console.Write($"Elemento {i}: ");
                        string numeros = Console.ReadLine();
                        numerosInseridos[i] = numeros;
                    }

                    for (int i = 0; i < numerosInseridos.Length; i++)
                    {
                        arrayNumeros[i] = int.Parse(numerosInseridos[i]);
                    }

                    return arrayNumeros;
                }
                catch (System.FormatException)
                {
                    Console.WriteLine();
                    Console.WriteLine("Insira um número válido!");
                }
            }
        }

        public static int SomarElementosMatriz(int[] arrayNumeros)
        {
            int somaElementos = 0;

            for (int i = 0; i < arrayNumeros.Length; i++)
            {
                somaElementos += arrayNumeros[i];
            }

            Console.WriteLine($"A soma de todos os elementos da matriz é {somaElementos}");
            Console.ReadKey();

            return somaElementos;
        }
    }
}
