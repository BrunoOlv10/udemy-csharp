using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto.repeticao_exs4
{
    public class ex29_maior_menor_valor_array
    {
        public static void MaiorMenorValorArray()
        {
            try
            {
                Console.Write("Insira os números que entrarão no array (separados por vírgulas): ");
                string entrada = Console.ReadLine();
                int[] array = entrada.Split(',').Select(n => int.Parse(n)).ToArray();

                int maior = 0;
                int menor = int.MaxValue;

                foreach (int numero in array)
                {
                    if (numero > maior) 
                        maior = numero;

                    if (numero < menor)
                        menor = numero;
                }

                Console.WriteLine();
                Console.WriteLine($"O array inserido foi: " + String.Join(", ", array) + "");
                Console.WriteLine($"Menor número do array: {menor}");
                Console.WriteLine($"Maior número do array: {maior}");
                Console.ReadKey();
            }
            catch (System.FormatException)
            {
                Console.WriteLine();
                Console.WriteLine("Insira apenas números para entrar no array");
                Console.ReadKey();
            }
        }
    }
}
