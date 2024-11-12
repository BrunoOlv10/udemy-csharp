using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto.repeticao_exs3
{
    public class ex31_ordenar_array_string
    {
        public static void OrdenarArray()
        {
            Console.Write("Insira os elementos que entrarão no array (separados por vírgula): ");
            string entrada = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(entrada))
            {
                Console.WriteLine();
                Console.WriteLine("Não é possível deixar o campo vazio, é necessário inserir algo para entrar no array");
                Console.ReadKey();
                return;
            }

            object[] array = entrada.Split(',')
                .Select(n => int.TryParse(n.Trim(), out int num) ? (object)num : n.Trim())
                .ToArray();

            Console.Write("Deseja ordenar o array de forma crescente ou decrescente? (digite 'c' para crescente ou 'd' para decrescente'): ");
            string ordem = Console.ReadLine().ToLower();

            if (ordem != "c" && ordem != "d")
            {
                Console.WriteLine();
                Console.WriteLine("Não é possível digitar outra resposta, digite 'c' ou 'd'");
                Console.ReadKey();
                return;
            }

            else
            {
                var arrayOrdenado = Array.Empty<object>();

                if (ordem == "c")
                {
                    arrayOrdenado = array
                        .OrderBy(e => e is string)
                        .ThenBy(e => e is int ? (int)e : int.MaxValue)
                        .ThenBy(e => e.ToString())
                        .ToArray();
                    ordem = "crescente";
                }

                else if (ordem == "d")
                {
                    arrayOrdenado = array
                       .OrderBy(e => e is string)
                       .ThenByDescending(e => e is int ? (int)e : int.MinValue)
                       .ThenByDescending(e => e.ToString())
                       .ToArray();
                    ordem = "decrescente";
                }

                Console.WriteLine();
                Console.WriteLine("O array digitado foi: " + String.Join(", ", array) + "");
                Console.WriteLine($"Após a ordenação '{ordem}', o array ordenado ficou: " + String.Join(", ", arrayOrdenado) + "");
                Console.ReadKey();
            }
        }
    }
}
