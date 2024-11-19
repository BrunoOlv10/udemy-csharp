using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ClosedXML.Excel.XLPredefinedFormat;
using System.Globalization;

namespace projeto.repeticao_exs4
{
    public class ex3_media
    {
        public static void ObterMedia()
        {
            try
            {
                Console.Write("Insira os números, inteiros e/ou decimais, que entrarão no cálculo da média (separados por vírgulas): ");
                string entrada = Console.ReadLine();
                string[] entradaDividida = entrada.Split(',');
                double[] numeros = entradaDividida.Select(x => double.Parse(x, CultureInfo.InvariantCulture)).ToArray();

                double media = 0;
                double somador = 0;

                foreach (var numero in numeros)
                    somador += numero;

                media = somador / numeros.Length;

                Console.WriteLine();
                Console.WriteLine($"A média dos números " + String.Join(", ", numeros.Select(x => x.ToString(CultureInfo.InvariantCulture)))
                    + $" é: {Math.Round(media, 2)}");
                Console.ReadKey();
            }
            catch (System.FormatException)
            {
                Console.WriteLine();
                Console.WriteLine("Digite apenas números, inteiros e/ou decimais, para ser possível realizar o cálculo da média");
                Console.ReadKey();
            }
        }
    }
}
