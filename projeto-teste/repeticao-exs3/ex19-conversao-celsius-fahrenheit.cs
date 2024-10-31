using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DocumentFormat.OpenXml.Drawing;

namespace projeto.repeticao_exs3
{
    public class ex19_conversao_celsius_fahrenheit
    {

        public static void ConverterTemperatura()
        {
            try
            {
                Console.Write("Digite a temperatura (apenas o valor dela, sem indicação do tipo da temperatura): ");
                int temp = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine();

                Console.Write("Digite para qual tipo de temperatura quer converter (C ou F): ");
                string tipoTemp = Console.ReadLine().ToUpper();

                int tempConvertida = temp;
                string tipoTempOriginal = tipoTemp;

                if (tipoTemp == "C")
                {
                    tempConvertida = ConverterCelsius(temp);
                    tipoTempOriginal = "F";
                }

                else if (tipoTemp == "F")
                {
                    tempConvertida = ConverterFahrenheit(temp);
                    tipoTempOriginal = "C";
                }

                else
                {
                    Console.WriteLine();
                    Console.WriteLine("Tipo de temperatura não encontrada, digite apenas C para Celsius ou F para Fahrenheit");
                    Console.ReadKey();
                    return;
                }

                Console.WriteLine();
                Console.WriteLine($"A temperatura digitada foi: {temp}°{tipoTempOriginal}");
                Console.WriteLine($"Depois de convertida para {tipoTemp}: {tempConvertida}°{tipoTemp}");
                Console.ReadKey();
            }
            catch (System.FormatException)
            {
                Console.WriteLine();
                Console.WriteLine("Digite apenas números para a temperatura");
                Console.WriteLine();
                Console.ReadKey();
            }
        }
        public static int ConverterCelsius(int converterTemp)
        {
            return (converterTemp - 32) * 5 / 9;
        }

        public static int ConverterFahrenheit(int converterTemp)
        {
            return (converterTemp * 9 / 5) + 32;
        }

    }
}
