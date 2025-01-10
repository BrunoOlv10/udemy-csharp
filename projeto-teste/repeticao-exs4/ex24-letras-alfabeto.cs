using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto.repeticao_exs4
{
    public class ex24_letras_alfabeto
    {
        public static void ExibirLetrasAlfabeto()
        {
            try
            {
                Console.Write("Quantas letras do alfabeto serão geradas? ");
                int qntdLetras = Convert.ToInt32(Console.ReadLine());

                if (qntdLetras < 1 || qntdLetras > 26)
                {
                    Console.WriteLine();
                    Console.WriteLine("Número de letras inválido, digite dentro do limite do alfabeto: 1 a 26");
                    Console.ReadKey();
                    return;
                }

                Console.WriteLine();

                Console.WriteLine("1- Alfabeto Minúsculo");
                Console.WriteLine("2- Alfabeto Maiúsculo");
                Console.Write("Digite a opção de como deseja que o alfabeto seja exibido (1 ou 2): ");
                int opcaoFormatacao = Convert.ToInt32(Console.ReadLine());

                List<char> alfabeto = new List<char>();

                if (opcaoFormatacao == 1)
                {
                    for (int i = 0; i < qntdLetras; i++)
                        alfabeto.Add((char)('a' + i));
                }
                else if (opcaoFormatacao == 2)
                {
                    for (int i = 0; i < qntdLetras; i++)
                        alfabeto.Add((char)('A' + i));
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("Digite apenas as opções disponíveis: 1 para minúsculo e 2 para maiúsculo");
                    Console.ReadKey();
                    return;
                }

                Console.WriteLine();
                Console.WriteLine($"{qntdLetras} letras do alfabeto: ");
                Console.WriteLine($"" + String.Join(", ", alfabeto) + "");
                Console.ReadKey();
            }
            catch (System.FormatException)
            {
                Console.WriteLine();
                Console.WriteLine("Digite apenas valores numéricos e disponíveis dentro dos limites de cada solicitação");
                Console.ReadKey();
            }
        }
    }
}
