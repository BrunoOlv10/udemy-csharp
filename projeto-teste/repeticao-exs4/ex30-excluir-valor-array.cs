using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto.repeticao_exs4
{
    public class ex30_excluir_valor_array
    {
        public static void ExcluirValorArray()
        {
            Console.Write("Insira os elementos que integrarão o array (separados por vírgulas): ");
            string entrada = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(entrada))
            {
                Console.WriteLine();
                Console.WriteLine("É necessário inserir algo para integrar o array");
                Console.ReadKey();
                return;
            }

            string[] array = entrada.Split(',').Select(e => e.Trim()).Where(e => !string.IsNullOrEmpty(e)).ToArray();

            Console.WriteLine();
            Console.WriteLine("Digite EXATAMENTE igual da forma como o elemento foi escrito");
            Console.Write("Qual elemento deseja remover? ");
            string elementoExcluir = Console.ReadLine();

            int countExcluidos = array.Count(e => e == elementoExcluir);
            string[] novoArray = array.Where(e => e != elementoExcluir).ToArray();

            if (novoArray.Length == array.Length)
            {
                Console.WriteLine();
                Console.WriteLine($"Elemento {elementoExcluir} não encontrado no array:");
                Console.WriteLine("" + String.Join(", ", array) + "");
                Console.ReadKey();
                return;
            }

            Console.WriteLine();
            Console.WriteLine($"O elemento {elementoExcluir} foi encontrado {countExcluidos} vez(es)");
            Console.WriteLine("Array digitado: " + String.Join(", ", array) + "");
            Console.WriteLine($"Novo array sem o elemento {elementoExcluir}: " + String.Join(", ", novoArray) + "");
            Console.ReadKey();
        }
    }
}
