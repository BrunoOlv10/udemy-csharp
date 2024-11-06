using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto.repeticao_exs3
{
    public class ex26_soma_elementos_array
    {
        public static void SomarArray()
        {
            try
            {
                Console.Write("Insira os números que serão somados no array (separados por vírgula): ");
                string entrada = Console.ReadLine();
                string[] numerosDivididos = entrada.Split(',');
                int[] numeros = new int[numerosDivididos.Length];
                numeros = numerosDivididos.Select(n => int.Parse(n)).ToArray();

                int soma = 0;
                foreach (int numero in numeros)
                    soma += numero;

                Console.WriteLine();
                Console.WriteLine($"O resultado da soma do array abaixo é: {soma}");
                Console.WriteLine(entrada);
                Console.ReadKey();
            }
            catch (Exception)
            {
                Console.WriteLine();
                Console.WriteLine("Insira apenas números!");
                Console.ReadKey();
            }
        }
    }
}
