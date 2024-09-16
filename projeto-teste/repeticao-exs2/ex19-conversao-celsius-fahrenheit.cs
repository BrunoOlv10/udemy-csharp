using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace projeto.repeticao_exs2
{
    public class ex19_conversao_graus_fahrenheit
    {
        public static void ConversaoCelsiusFahrenheit()
        {
            try
            {
                Console.Write("Qual a temperatura para ser convertida (apenas o valor da temperatura)? ");
                string tempString = Console.ReadLine().Replace('.', ',');
                double temperatura = Convert.ToDouble(tempString);

                Console.WriteLine();

                Console.Write("Qual a unidade de medida que está a temperatura? ");
                string unidade = Console.ReadLine().ToUpper();

                double tempConvertida = 0;
                string unidadeConvertida = "";

                if (unidade == "C")
                {
                    tempConvertida = (temperatura * 1.8) + 32;
                    tempConvertida = Math.Round(tempConvertida, 2);
                    unidadeConvertida = "F";
                }
                else if (unidade == "F")
                {
                    tempConvertida = (temperatura - 32) / 1.8;
                    tempConvertida = Math.Round(tempConvertida, 2);
                    unidadeConvertida = "C";
                }
                else
                {
                    Console.WriteLine();
                    Console.Write("É necessário informar a temperatura como c ou f");
                }

                if (tempConvertida > 0)
                {
                    Console.WriteLine();
                    Console.Write($"A temperatura {temperatura}°{unidade} foi convertida para {tempConvertida}°{unidadeConvertida}");
                    Console.ReadKey();
                }
            }
            catch (Exception)
            {
                Console.WriteLine();
                Console.Write("");
                Console.ReadKey();
            }
        }
    }
}
