using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto.repeticao_exs2
{
    public class ex27_transferir_elementos_array
    {
        public static int[] ObterInfosArray()
        {
            Console.Write("Insira os números do array (separados por vírgula): ");
            string numeroString = Console.ReadLine();
            string[] numerosDivividos = numeroString.Split(',');
            int[] numeros = new int[numerosDivividos.Length];

            for (int i = 0; i < numerosDivividos.Length; i++)
            {
                numeros[i] = Convert.ToInt32(numerosDivividos[i]);
            }

            return numeros;
        }

        public static void TransferirArray(int[] numeros)
        {
            int[] numerosNovo = new int[numeros.Length];
            Array.Copy(numeros, numerosNovo, numeros.Length);

            Console.WriteLine($"O array inicial: " + String.Join(",", numeros) + "");
            Console.WriteLine("O array novo: " + String.Join(",", numerosNovo) + "");
            Console.ReadKey();
        }
    }
}
