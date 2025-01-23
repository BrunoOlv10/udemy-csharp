using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto.repeticao_exs4
{
    public class ex28_ocorrencias_array
    {
        public static void ContarOcorrenciasArray()
        {
            Console.WriteLine("OBJETIVO: verificar a quantidade de vezes que cada elemento aparece dentro de um array");
            Console.Write("Digite os elementos que entrarão no array (separados por vírgulas): ");
            string entrada = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(entrada))
            {
                Console.WriteLine();
                Console.WriteLine("É necessário inserir algum elemento no array");
                Console.ReadKey();
                return;
            }

            string[] array = entrada.Split(',').Select(e => e.Trim()).Where(e => !string.IsNullOrEmpty(e)).ToArray();

            Dictionary<string, int> ocorrencias = new Dictionary<string, int>();

            foreach (string elemento in array)
            {
                if (!ocorrencias.ContainsKey(elemento))
                {
                    ocorrencias.Add(elemento, 1);
                }
                else
                {
                    ocorrencias[elemento]++;
                }
            }

            Console.WriteLine();
            Console.WriteLine("Quantas ocorrências cada elemento possui: ");
            foreach (var elemento in ocorrencias)
            {
                Console.WriteLine($"{elemento.Key}: {elemento.Value} ocorrência(s);");
            }
            Console.ReadKey();
        }
    }
}
