using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto.repeticao_exs
{
    public class ex19_conversao_graus_fahrenheit
    {
        public static (int, string) ObterInfosTemperatura()
        {
            int temperatura = 0;
            string unidadeMedida;

            while (true)
            {
                try
                {
                    Console.Write("Digite a temperatura: ");
                    temperatura = Convert.ToInt32(Console.ReadLine());
                    break;
                }
                catch (System.FormatException)
                {
                    Console.WriteLine();
                    Console.WriteLine("Insira apenas números para a temperatura!");
                }
            }

            while (true)
            {
                Console.WriteLine();
                Console.Write("Digite para qual temperatura quer converter (c ou f): ");
                unidadeMedida = Console.ReadLine().ToUpper();

                if (unidadeMedida == "C" || unidadeMedida == "F")
                {
                    break;
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("A unidade de medida deve ser 'c' para Celsius ou 'f' para Fahrenheit!");
                }
            }

            return (temperatura, unidadeMedida);
        }

        public static int ConverterTemperatura(int temperatura, string unidadeMedida)
        {
            int temperaturaConvertida = 0;

            Console.WriteLine();
            if (unidadeMedida == "C")
            {
                temperaturaConvertida = ConverterCelsius(temperatura);
                Console.WriteLine($"A temperatura {temperatura}F foi convertida para {temperaturaConvertida}{unidadeMedida}");
            }

            if (unidadeMedida == "F")
            {
                temperaturaConvertida = ConverterFahrenheit(temperatura);
                Console.WriteLine($"A temperatura {temperatura}C foi convertida para {temperaturaConvertida}{unidadeMedida}");
            }

            Console.ReadKey();
            return temperaturaConvertida;
        }

        public static int ConverterCelsius(int temperatura)
        {
            return (temperatura - 32) * 5 / 9;
        }

        public static int ConverterFahrenheit(int temperatura)
        {
            return (temperatura * 9 / 5) + 32;
        }
    }
}
