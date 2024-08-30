using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DocumentFormat.OpenXml.Wordprocessing;

namespace curso_udemy
{
    public class ex19_conversao_graus_fahrenheit
    {
        public static int ObterTempConvertido()
        {
            Console.Write("Digite a temperatura: ");
            string temp = Console.ReadLine();
            int converterTemp;

            if (!int.TryParse(temp, out converterTemp))
            {
                Console.WriteLine("Por favor, insira um valor numérico válido.");
                return 0;
            }

            Console.Write("Digite para qual temperatura quer converter (f ou c): ");
            string escalaTemp = Console.ReadLine().ToLower();

            if (escalaTemp == "c")
            {
                converterTemp = ConverterCelsius(converterTemp);
                Console.WriteLine($"A temperatura inserida foi {temp} e convertida ficou {converterTemp}{escalaTemp}");
            }
            else if (escalaTemp == "f")
            {
                converterTemp = ConverterFahrenheit(converterTemp);
                Console.WriteLine($"A temperatura inserida foi {temp} e convertida ficou {converterTemp} {escalaTemp}");
            }
            else
            {
                Console.WriteLine("Escala inválida. Use 'c' para Celsius ou 'f' para Fahrenheit.");
                return 0;
            }

            Console.ReadKey();
            return converterTemp;
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
