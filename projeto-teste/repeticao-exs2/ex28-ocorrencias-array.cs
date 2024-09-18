using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto.repeticao_exs2
{
    public class ex28_ocorrencias_array
    {
        public static void EncontrarOcorrenciasArray()
        {
            try
            {
                Console.Write("Insira os números que entrarão no array (separados por vírgula): ");
                string entrada = Console.ReadLine();
                string[] numerosDivididos = entrada.Split(',');
                int[] array = new int[numerosDivididos.Length];
                array = numerosDivididos.Select(n => int.Parse(n)).ToArray();

                Dictionary<int, int> ocorrencias = new Dictionary<int, int>();

                foreach (int numero in array)
                {
                    if(ocorrencias.ContainsKey(numero))
                        ocorrencias[numero]++;

                    else
                        ocorrencias[numero] = 1;
                }

                Console.WriteLine();
                Console.WriteLine("Ocorrências");

                foreach (var numero in ocorrencias)
                {
                    Console.WriteLine($"O {numero.Key} tem {numero.Value} ocorrência(s)");
                }

                Console.ReadKey();

            }
            catch (System.FormatException)
            {
                Console.WriteLine();
                Console.WriteLine("Insira apenas números para entrar no array!");
                Console.ReadKey();
            }
        }
    }
}
