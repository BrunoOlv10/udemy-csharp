using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DocumentFormat.OpenXml.Drawing.Diagrams;

namespace projeto.repeticao_exs4
{
    public class ex19_conversao_celsius_fahrenheit
    {
        public static void ConversaoTemperatura()
        {
            try
            {
                Console.WriteLine("Para números decimais use vírgula ao invés de ponto");
                Console.Write("Digite o valor da temperatura: ");
                double temperatura = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine();
                Console.WriteLine("(C - Celsius, F - Fahrenheit e K - Kelvin)");
                Console.Write("Escreva o tipo da temperatura digitada: ");
                string tipoTempDigitada = Console.ReadLine().ToUpper();

                if (tipoTempDigitada != "C" && tipoTempDigitada != "F" && tipoTempDigitada != "K")
                {
                    Console.WriteLine();
                    Console.WriteLine("Digite um tipo de temperatura válida");
                    Console.WriteLine("C - Celsius, F - Fahrenheit e K - Kelvin");
                    Console.ReadKey();
                    return;
                }

                Console.Write("Digite o tipo da temperatura para conversão: ");
                string tipoTempConverter = Console.ReadLine().ToUpper();

                if (tipoTempConverter != "C" && tipoTempConverter != "F" && tipoTempConverter != "K")
                {
                    Console.WriteLine();
                    Console.WriteLine("Digite um tipo de temperatura válida");
                    Console.WriteLine("C - Celsius, F - Fahrenheit e K - Kelvin");
                    Console.ReadKey();
                    return;
                }

                double tempConvertida = 0;
                if (tipoTempDigitada == "C" && tipoTempConverter == "F")
                    tempConvertida = temperatura * 1.8 + 32;

                else if (tipoTempDigitada == "C" && tipoTempConverter == "K")
                    tempConvertida = temperatura + 273.15;

                else if (tipoTempDigitada == "F" && tipoTempConverter == "C")
                    tempConvertida = (temperatura - 32) * 5 / 9;

                else if (tipoTempDigitada == "F" && tipoTempConverter == "K")
                    tempConvertida = (temperatura - 32) * 5 / 9 + 273.15;

                else if (tipoTempDigitada == "K" && tipoTempConverter == "C")
                    tempConvertida = temperatura - 273.15;

                else if (tipoTempDigitada == "K" && tipoTempConverter == "F")
                    tempConvertida = (temperatura - 273.15) * 9 / 5 + 32;

                Console.WriteLine();
                Console.WriteLine($"A temperatura digitada foi: {temperatura}º{tipoTempDigitada}");
                Console.WriteLine($"A temperatura convertida ficou: {Math.Round(tempConvertida, 2)}º{tipoTempConverter}");
                Console.ReadKey();
            }
            catch (System.FormatException)
            {
                Console.WriteLine();
                Console.WriteLine("Digite uma temperatura válida");
                Console.ReadKey();
            }
        }
    }
}
