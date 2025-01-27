using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto.repeticao_exs4
{
    public class ex31_ordenar_array_string
    {
        public static void OrdenarArrayStrings()
        {
            Console.Write("Digite os elementos que entrarão no array e serão ordenados (separados por vírgulas): ");
            string entrada = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(entrada))
            {
                Console.WriteLine();
                Console.WriteLine("É necessário inserir algo para entrar no array");
                Console.ReadKey();
                return;
            }

            string[] array = entrada.Split(',').Select(e => e.Trim()).Where(e => !string.IsNullOrWhiteSpace(e)).ToArray();

            Console.WriteLine();
            Console.WriteLine("Siga a regra para ordenar o array:");
            Console.Write("Coloque 'ASC' - ordenar de forma ascendente e 'DESC' - ordenar de forma descendente: ");
            string ordenacaoAbreviado = Console.ReadLine().ToUpper();

            string[] arrayOrdenado = new string[array.Length];
            string ordenacao = "";
            if (ordenacaoAbreviado == "ASC")
            {
                arrayOrdenado = array.OrderBy(e => e).ToArray();
                ordenacao = "Ascendente";
            }

            else if (ordenacaoAbreviado == "DESC")
            {
                arrayOrdenado = array.OrderByDescending(e => e).ToArray();
                ordenacao = "Descendente";
            }

            else
            {
                Console.WriteLine();
                Console.WriteLine("Siga a regra e digite 'ASC' ou 'DESC'");
                Console.ReadKey();
                return;
            }

            Console.WriteLine();
            Console.WriteLine("Array digitado: " + String.Join(", ", array) + "");
            Console.WriteLine($"Array ordenado de forma {ordenacao}: " + String.Join(", ", arrayOrdenado) + "");
            Console.ReadKey();
        }
    }
}
