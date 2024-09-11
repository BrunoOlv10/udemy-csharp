using System;
using System.Collections.Generic;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;

namespace projeto.repeticao_exs
{
    public class ex6_mudar_caractere_posicao
    {
        public static (string, char[]) ObterString()
        {
            while (true)
            {
                try
                {
                    Console.Write("Insira a palavra: ");
                    string palavra = Console.ReadLine();
                    char[] palavraCaracteres = palavra.ToCharArray();
                    Console.WriteLine();

                    if (string.IsNullOrEmpty(palavra) || !palavra.All(char.IsLetter))
                    {
                        throw new Exception();
                    }

                    return (palavra, palavraCaracteres);
                }
                catch
                {
                    Console.WriteLine("Digite apenas letras!");
                }
            }
        }

        public static string MudarCaracterePosicao(string palavra, char[] palavraCaracteres)
        {
            while (true)
            {
                try
                {
                    Console.Write($"Qual a posição da letra da palavra '{palavra}' que quer inverter com última letra: ");
                    int posicao = Convert.ToInt32(Console.ReadLine());
                    int posicaoReal = posicao - 1;
                    Console.WriteLine();

                    char posicaoDesejada = palavraCaracteres[posicaoReal];
                    char ultimaPosicao = palavraCaracteres[palavraCaracteres.Length - 1];

                    palavraCaracteres[palavraCaracteres.Length - 1] = posicaoDesejada;
                    palavraCaracteres[posicaoReal] = ultimaPosicao;

                    string novaPalavra = new string(palavraCaracteres);

                    Console.WriteLine($"Após trocar o caractere da palavra '{palavra}' da posição {posicao} para a última, a palavra ficou assim: {novaPalavra}");
                    Console.ReadKey();

                    return novaPalavra;
                }
                catch (System.FormatException)
                {
                    Console.WriteLine("Digite apenas números para a posição do caractere!");
                    Console.WriteLine();
                }
            }
        }
    }
}
