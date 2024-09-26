using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto.repeticao_exs3
{
    public class ex6_mudar_caractere_posicao
    {
        public static void MudarCaracterePosicao()
        {
            try
            {
                Console.Write("Escreva uma palavra, número ou sequência de caracteres única: ");
                string elemento = Console.ReadLine();

                if (string.IsNullOrEmpty(elemento))
                    throw new Exception();

                Console.WriteLine();
                Console.Write("Insira a posição do caractere a ser selecionado: ");
                int caractereOrigem = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine();

                Console.Write("Insira a posição para colocar o caractere selecionado: ");
                int caractereDestino = Convert.ToInt32(Console.ReadLine());

                char[] elementoArray = elemento.ToCharArray();
                char aux = elementoArray[caractereOrigem];
                elementoArray[caractereOrigem] = elementoArray[caractereDestino];
                elementoArray[caractereDestino] = aux;

                string novoElemento = new string(elementoArray);

                Console.WriteLine();
                Console.WriteLine($"O elemento inicialmente era {elemento}, mas após trocar o caractere da posição " +
                    $"{caractereOrigem} para {caractereDestino}, o elemento ficou {novoElemento}");
                Console.ReadKey();
            }
            catch (System.FormatException)
            {
                Console.WriteLine();
                Console.WriteLine("É necessário inserir apenas números para a posição!");
                Console.ReadKey();
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine();
                Console.WriteLine("É necessário inserir posições que estejam dentro do limite do elemento!");
                Console.ReadKey();
            }
            catch (Exception ex)
            {
                Console.WriteLine();
                Console.WriteLine("É necessário inserir algum elemento para trocar algum caractere de posição!");
                Console.ReadKey();
            }
        }
    }
}
