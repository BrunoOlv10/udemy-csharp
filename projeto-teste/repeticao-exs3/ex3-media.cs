using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto.repeticao_exs3
{
    public class ex3_media
    {
        public static void ObterMedia()
        {
            try
            {
                Console.Write("Insira os números para obter a média (separados por vírgula): ");
                string entrada = Console.ReadLine();
                string[] numerosDivididos = entrada.Split(',');
                int[] numeros = new int[numerosDivididos.Length];
                numeros = numerosDivididos.Select(int.Parse).ToArray();

                double media = numeros.Average();
                double mediaValidada = Math.Round(media, 2);

                Console.WriteLine();
                Console.WriteLine($"A média entre os números [{entrada}] é {mediaValidada}");
                Console.ReadKey();
            }
            catch (Exception ex)
            {
                Console.WriteLine();
                Console.WriteLine("Insira apenas números para calcular a média!");
                Console.ReadKey();
            }
        }
    }
}
