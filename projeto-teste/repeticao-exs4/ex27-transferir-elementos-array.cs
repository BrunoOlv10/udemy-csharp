using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OfficeOpenXml.ConditionalFormatting.Contracts;

namespace projeto.repeticao_exs4
{
    public class ex27_transferir_elementos_array
    {
        public static void TransferirElementosArray()
        {
            try
            {
                Console.Write("Insira os elementos que entrarão no array (separados por vírgulas): ");
                string entrada = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(entrada))
                {
                    Console.WriteLine();
                    Console.WriteLine("É necessário inserir elementos, não é possível deixar vazio");
                    Console.ReadKey();
                    return;
                }

                string[] elementos = entrada.Split(',');

                Console.Write("Quantos elementos quer transferir para um novo array? ");
                int quantidade = Convert.ToInt32(Console.ReadLine());

                if (quantidade > elementos.Length)
                {
                    Console.WriteLine();
                    Console.WriteLine($"Não é possível transferir mais elementos do que os {elementos.Length} que estão dentro do array");
                    Console.ReadKey();
                    return;
                }

                if (quantidade < 0)
                {
                    Console.WriteLine();
                    Console.WriteLine("Não insira números menores que zero, pois não será possível transferir os elementos");
                    Console.ReadKey();
                    return;
                }

                if (quantidade == 0)
                {
                    Console.WriteLine();
                    Console.WriteLine("Não foi transferido nenhum elemento para o outro array");
                    Console.WriteLine("O array digitado foi: " + String.Join(", ", elementos) + "");
                    Console.ReadKey();
                    return;
                }

                string[] novoArray = new string[quantidade];
                for (int i = 0; i < quantidade; i++)
                {
                    novoArray[i] = elementos[i];
                }

                Console.WriteLine();
                Console.WriteLine($"Foram transferidos {quantidade} elementos para o novo array. Veja os resultados abaixo:");
                Console.WriteLine("Array digitado: " + String.Join(", ", elementos) + "");
                Console.WriteLine($"Novo array com os {quantidade} elementos transferidos: " + String.Join(", ", novoArray) + "");
                Console.ReadKey();
            }
            catch (System.FormatException)
            {
                Console.WriteLine();
                Console.WriteLine("É necessário inserir apenas números para a quantidade de elementos que serão transferidos");
                Console.ReadKey();
            }
        }
    }
}
