using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto.repeticao_exs4
{
    public class ex6_mudar_caractere_posicao
    {
        public static void MudarCaracterePosicao()
        {
            try
            {
                Console.Write("Insira os caracteres para entrar no array (separados por vírgula): ");
                string entrada = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(entrada))
                {
                    Console.WriteLine();
                    Console.WriteLine("Não é possível deixar o campo vazio");
                    Console.ReadKey();
                    return;
                }

                string[] entradaDividida = entrada.Split(',');
                string[] array = entradaDividida.Select(x => x.Trim()).ToArray();
                string[] arrayNovo = new string[array.Length];
                array.CopyTo(arrayNovo, 0);

                Console.WriteLine();
                Console.WriteLine("Lembrando que começa da posição 0");
                Console.Write("Qual a posição do caractere que vai mudar de posição? (apenas o valor numérico): ");
                int posicaoInicial = Convert.ToInt32(Console.ReadLine());

                Console.Write("Qual a posição de destino desse caractere? (novamente apenas o valor numérico): ");
                int posicaoDestino = Convert.ToInt32(Console.ReadLine());

                if (posicaoInicial < 0 || posicaoInicial > array.Length - 1 || posicaoDestino < 0 || posicaoDestino > array.Length - 1)
                {
                    Console.WriteLine();
                    Console.WriteLine($"Insira posições dentro do limite do array: 0 e {array.Length - 1}");
                    Console.ReadKey();
                    return;
                }

                string valorEscolhido = "";
                string valorMudado = "";
                for (int i = 0; i < arrayNovo.Length; i++)
                {
                    if (i == posicaoInicial)
                        valorEscolhido = arrayNovo[i];

                    if (i == posicaoDestino)
                    {
                        valorMudado = arrayNovo[i];
                        arrayNovo[i] = valorEscolhido;
                        arrayNovo[posicaoInicial] = valorMudado;
                    }
                }

                Console.WriteLine();
                Console.WriteLine($"O array originalmente era: " + String.Join(", ", array) + "");
                Console.WriteLine($"Após mudar os elementos '{valorEscolhido}' e '{valorMudado}' das posições {posicaoInicial} e {posicaoDestino}, respectivamente, no array, ");
                Console.Write($"o resultado no array foi esse: " + String.Join(", ", arrayNovo) + "");
                Console.ReadKey();
            }
            catch (System.FormatException)
            {
                Console.WriteLine();
                Console.WriteLine("É necessário inserir apenas valores numéricos");
                Console.ReadKey();
            }
        }
    }
}
