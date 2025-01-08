using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace projeto.repeticao_exs4
{
    public class ex22_piramide_caracteres
    {
        public static void GerarPiramide()
        {
            try
            {
                Console.Write("Digite o caractere que formará a pirâmide: ");
                string caractereValidado = Regex.Replace(Console.ReadLine(), @"\s+", "");

                if (string.IsNullOrEmpty(caractereValidado))
                {
                    Console.WriteLine();
                    Console.WriteLine("É necessário digitar algum caractere para formar a pirâmide");
                    Console.ReadKey();
                    return;
                }

                Console.Write("Digite a altura da pirâmide (entre 2 e 50): ");
                int altura = Convert.ToInt32(Console.ReadLine());

                if (altura < 2 || altura > 50)
                {
                    Console.WriteLine();
                    Console.WriteLine("Digite uma altura entre 2 e 50");
                    Console.ReadKey();
                    return;
                }

                Console.WriteLine();

                for (int i = 0; i < altura; i++)
                {
                    for (int j = 0; j <= i; j++)
                    {
                        Console.Write(caractereValidado);
                    }

                    Console.WriteLine();
                }

                Console.ReadKey();
            }
            catch (System.FormatException)
            {
                Console.WriteLine();
                Console.WriteLine("Insira apenas valores numéricos para a altura");
                Console.ReadKey();
            }
        }
    }
}
