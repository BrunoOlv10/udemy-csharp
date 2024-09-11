using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto.repeticao_exs
{
    public class ex24_letras_alfabeto
    {
        public static char ObterLimite()
        {
            while (true)
            {
                try
                {
                    int limiteLetras = 1;

                    Console.Write("Digite o limite a ser exibido do alfabeto (1-26): ");
                    limiteLetras = int.Parse(Console.ReadLine());

                    if (limiteLetras < 1 || limiteLetras > 26)
                    {
                        throw new ArgumentOutOfRangeException();
                    }

                    char letraCorrespondente = (char)('a' + limiteLetras - 1);

                    return letraCorrespondente;
                }
                catch (System.FormatException)
                {
                    Console.WriteLine();
                    Console.WriteLine("Digite um número dentro do limite (1-26)");
                }
                catch (ArgumentOutOfRangeException)
                {
                    Console.WriteLine();
                    Console.WriteLine("Digite um número dentro do limite (1-26)");
                }
            }
        }

        public static List<char> ExibirAlfabeto(char letraCorrespondente)
        {
            List<char> alfabeto = new List<char>();

            for (char letra = 'a'; letra <= letraCorrespondente; letra++)
            {
                alfabeto.Add(letra);
            }

            Console.WriteLine(string.Join(", ", alfabeto));
            Console.ReadKey();

            return alfabeto;
        }
    }
}
