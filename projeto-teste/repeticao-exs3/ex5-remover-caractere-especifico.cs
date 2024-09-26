using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto.repeticao_exs3
{
    public class ex5_remover_caractere_especifico
    {
        public static void RemoverCaractere()
        {
            try
            {
                Console.Write("Insira uma palavra ou número: ");
                string elemento = Console.ReadLine();

                if (string.IsNullOrEmpty(elemento))
                    throw new Exception();

                Console.WriteLine();

                Console.Write("Insira a posição do caractere que quer remover: ");
                int posicao = Convert.ToInt32(Console.ReadLine());

                string novoElemento = null;

                novoElemento = elemento.Remove(posicao, 1);

                Console.WriteLine();
                Console.WriteLine($"O elemento original era '{elemento}', foi excluído o caractere da posição {posicao} e o elemento " +
                    $"está assim agora '{novoElemento}'");
                Console.ReadKey();

            }
            catch (System.FormatException)
            {
                Console.WriteLine();
                Console.WriteLine("Insira apenas números para a posição!");
                Console.ReadKey();
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine();
                Console.WriteLine("Insira uma posição dentro do limite do elemento!");
                Console.ReadKey();
            }
            catch (Exception ex)
            {
                Console.WriteLine();
                Console.WriteLine("Não é possível deixar de preencher o elemento que será manipulado!");
                Console.ReadKey();
            }
        }
    }
}
