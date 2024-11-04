using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto.repeticao_exs3
{
    public class ex24_letras_alfabeto
    {
        public static void GerarAlfabeto()
        {
            try
            {
                Console.Write("Quantas letras do alfabeto serão geradas? ");
                int quantidade = Convert.ToInt32(Console.ReadLine());

                if (quantidade < 1 || quantidade > 26)
                {
                    Console.WriteLine();
                    Console.WriteLine("Digite apenas números de 1 a 26");
                    Console.ReadKey();
                    return;
                }

                Console.Write("Digite 'maiuscula' ou 'minuscula' para escolher como o alfabeto virá: ");
                string resposta = Console.ReadLine();

                List<char> alfabeto = new List<char>();

                if (resposta == "maiuscula")
                {
                    for (int i = 0; i < quantidade; i++)
                        alfabeto.Add((char)('A' + i));
                }

                else if (resposta == "minuscula")
                {
                    for (int i = 0; i < quantidade; i++)
                        alfabeto.Add((char)('a' + i));
                }

                else 
                { 
                    Console.WriteLine();
                    Console.WriteLine("Não digite nada diferente de 'maiuscula' ou 'minuscula'");
                    Console.ReadKey();
                    return;
                }

                Console.WriteLine();
                Console.WriteLine($"{quantidade} letra(s) do alfabeto: ");
                Console.WriteLine("" + String.Join(", ", alfabeto) + "");
                Console.ReadKey();
            }
            catch (Exception)
            {
                Console.WriteLine();
                Console.WriteLine("Digite apenas números para a quantidade");
                Console.ReadKey();
            }
        }
    }
}
