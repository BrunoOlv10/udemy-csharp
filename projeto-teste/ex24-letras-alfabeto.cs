﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DocumentFormat.OpenXml.Office.PowerPoint.Y2021.M06.Main;

namespace projeto
{
    public class ex24_letras_alfabeto
    {
        // por referencia de letra
        //public static char obterLimite()
        //{
        //    char limiteLetras = 'a';
        //    char limiteValidado = 'a';

        //    while (true)
        //    {
        //        try
        //        {
        //            Console.Write("Digite a letra limite para exibir o alfabeto: ");
        //            limiteLetras = Convert.ToChar(Console.ReadLine());
        //            limiteValidado = char.ToLower(limiteLetras);

        //            if (!char.IsLetter(limiteValidado))
        //            {
        //                throw new FormatException();
        //            }

        //            break;
        //        }
        //        catch (System.FormatException)
        //        {
        //            Console.WriteLine();
        //            Console.WriteLine("Entrada inválida. Digite apenas uma letra válida!");
        //        }
        //    }
        //}

        
        // por posição da letra
        public static char obterLimite()
        {
            int limiteLetras = 1;

            while (true)
            {
                try
                {
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
                    Console.WriteLine("Digite um número válido (1-26)! ");
                }
                catch (ArgumentOutOfRangeException)
                {
                    Console.WriteLine();
                    Console.WriteLine("Digite um número dentro do limite estabelecido (1-26)! ");
                }
            }
        }

        public static List<char> exibirAlfabeto(char letraCorrespondente)
        {
            List<char> alfabeto = new List<char>();

            for (char letra = 'a'; letra <= letraCorrespondente; letra++)
            {
                alfabeto.Add(letra);
            }

            Console.WriteLine();
            Console.WriteLine(string.Join(", ", alfabeto));
            Console.ReadKey();

            return alfabeto;
        }
    }
}
