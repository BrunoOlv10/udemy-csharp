using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DocumentFormat.OpenXml.Wordprocessing;
using static ClosedXML.Excel.XLPredefinedFormat;

namespace projeto.repeticao_exs4
{
    public class ex2_multiplicao
    {
        public static void MultiplicarValores()
        {
            try
            {
                Console.Write("Insira os números que deseja multiplicar (separados por vírgula): ");
                string entrada = Console.ReadLine();
                string[] entradaDividida = entrada.Split(',');
                int[] numeros = entradaDividida.Select(x => int.Parse(x)).ToArray();

                int multiplicador = 1;
                foreach (var numero in numeros)
                    multiplicador *= numero;

                Console.WriteLine();
                Console.WriteLine($"Os números inseridos foram [" + String.Join(", ", numeros) + $"W] e o resultado da multiplicação é {multiplicador}");
                Console.ReadKey();
            }
            catch (System.FormatException)
            {
                Console.WriteLine();
                Console.WriteLine("Insira apenas números");
                Console.ReadLine();
            }
        }
    }
}
