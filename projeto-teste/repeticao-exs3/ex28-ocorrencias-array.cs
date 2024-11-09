using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto.repeticao_exs3
{
    public class ex28_ocorrencias_array
    {
        public static void ObterOcorrenciasArray()
        {
            Console.Write("Insira os elementos que entrarão no array (separados por vírgulas): ");
            string entrada = Console.ReadLine();
            string[] itens = entrada.Split(',').Select(e => e.Trim()).ToArray();

            if (entrada.Length == 0)
            {
                Console.WriteLine();
                Console.WriteLine("Não é possível deixar o campo vazio");
                Console.ReadKey();
                return;
            }

            Dictionary<string, int> ocorrencias = new Dictionary<string, int>();

            foreach (string item in itens)
            {
                if (!ocorrencias.ContainsKey(item))
                    ocorrencias.Add(item, 1);
                
                else
                    ocorrencias[item]++;
            }

            Console.WriteLine();
            Console.WriteLine("Veja abaixo a quantidade de ocorrências que cada elemento possui no array: ");
            foreach (var item in ocorrencias)
                Console.WriteLine($"Elemento: {item.Key} - Ocorrência(s): {item.Value}");
            Console.ReadKey();
        }
    }
}
