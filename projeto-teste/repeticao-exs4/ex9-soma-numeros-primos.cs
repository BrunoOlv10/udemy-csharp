using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DocumentFormat.OpenXml.Wordprocessing;
using static ClosedXML.Excel.XLPredefinedFormat;

namespace projeto.repeticao_exs4
{
    public class ex9_soma_numeros_primos
    {
        public static void SomarNumerosPrimos()
        {
            try
            {
                Console.Write("Quantos números primos serão somados? ");
                int quantidade = Convert.ToInt32(Console.ReadLine());

                if (quantidade <= 1)
                {
                    Console.WriteLine();
                    Console.WriteLine("Para fazer a soma dos números é necessário ter no mínimo 2 números para serem somados");
                    Console.ReadKey();
                    return;
                }

                int somaPrimos = 0;
                int contador = 0;
                int numero = 2;
                int[] numerosPrimos = new int[quantidade];

                while (contador < quantidade)
                {
                    bool primo = true;
                    for (int i = 2; i <= Math.Sqrt(numero); i++)
                    {
                        if (numero % i == 0)
                        {
                            primo = false;
                            break;
                        }
                    }

                    if (primo)
                    {
                        numerosPrimos[contador] = numero;
                        somaPrimos += numero;
                        contador++;
                    }

                    numero++;
                }

                Console.WriteLine();
                Console.WriteLine($"Os números primos somados foram [" + String.Join(", ", numerosPrimos) + $"], o resultado da soma desses primeiros" +
                    $" {quantidade} números primos foi {somaPrimos}");
                Console.ReadKey();
            }
            catch (System.FormatException)
            {
                Console.WriteLine();
                Console.WriteLine("Insira apenas valores numéricos e inteiros");
                Console.ReadKey();
            }
        }
    }
}
