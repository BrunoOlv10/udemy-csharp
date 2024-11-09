using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto.repeticao_exs3
{
    public class ex27_transferir_elementos_array
    {
        public static void TransferirArray()
        {
            Console.Write("Insira os dados para o primeiro array (separados por vírgulas): ");
            string entrada1 = Console.ReadLine();
            string[] array1 = entrada1.Split(',').Select(e => e.Trim()).ToArray();

            Console.Write("Insira os dados para o segundo array (separados por vírgulas): ");
            string entrada2 = Console.ReadLine();
            string[] array2 = entrada2.Split(',').Select(e => e.Trim()).ToArray();

            if (entrada1.Length == 0 || entrada2.Length == 0)
            {
                Console.WriteLine();
                Console.WriteLine("Não é possível deixar vazio em nenhum dos dois campos");
                Console.ReadKey();
                return;
            }

            var aux = array1;
            string[] arrayNovo1 = array2;
            string[] arrayNovo2 = aux;

            Console.WriteLine();
            Console.WriteLine($"Arrays originais e após ocorrer a transferência de dados entre eles: ");
            Console.WriteLine($"Array 1 original: " + String.Join(",", array1) + "");
            Console.WriteLine($"Array 2 original: " + String.Join(",", array2) + "");
            Console.WriteLine();
            Console.WriteLine($"Array 1 com os dados do array 2: " + String.Join(",", arrayNovo1) + "");
            Console.WriteLine($"Array 2 com os dados do array 1: " + String.Join(",", arrayNovo2) + "");
            Console.ReadKey();
        }
    }
}
