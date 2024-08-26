using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using DocumentFormat.OpenXml.Drawing;
using DocumentFormat.OpenXml.Math;

namespace curso_udemy.repeticao_exs
{
    public class ex5_remover_caractere_especifico
    {
        public static string ObterString()
        {
            while (true)
            {
                try
                {
                    Console.Write("Escreva uma palavra: ");
                    string palavra = Console.ReadLine();
                    Console.WriteLine();

                    if (string.IsNullOrEmpty(palavra) || !palavra.All(char.IsLetter))
                    {
                        throw new Exception();
                    }

                    return palavra;
                }
                catch
                {
                    Console.WriteLine("Digite apenas palavras!");
                }
            }
        }

        public static string ExcluirCaractere(string palavra)
        {
            while (true)
            {
                try
                {
                    Console.Write("Qual a posição do caractere que deseja excluir? ");
                    int posicaoCaractere = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine();

                    int posicaoReal = posicaoCaractere - 1;

                    string semCaractere = null;
                    if (posicaoCaractere > 0 && posicaoCaractere <= palavra.Length)
                        semCaractere = palavra.Remove(posicaoReal, 1);

                    else
                        Console.WriteLine("Posição inexistente na palavra");

                    Console.WriteLine($"Letra da posição {posicaoCaractere} removida da palavra '{palavra}': {semCaractere}");
                    Console.ReadKey();

                    return semCaractere;
                }
                catch (System.FormatException)
                {
                    Console.WriteLine();
                    Console.WriteLine("Insira apenas números para a posição!");
                }
            }
        }
    }
}
