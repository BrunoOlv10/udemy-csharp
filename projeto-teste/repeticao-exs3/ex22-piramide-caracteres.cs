using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto.repeticao_exs3
{
    public class ex22_piramide_caracteres
    {
        public static void GerarPiramide()
        {
            try
            {
                Console.Write("Insira o caractere ou a sequência de caracteres que formará a pirâmide: ");
                string caractere = Console.ReadLine();

                Console.Write("Digite a altura que terá a pirâmide: ");
                int altura = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine();

                for (int i = 0; i < altura; i++)
                {
                    for (int j = 0; j <= i; j++)
                    {
                        Console.Write(caractere);
                    }

                    Console.WriteLine();
                }

                Console.ReadKey();
            }
            catch (Exception ex)
            {
                Console.WriteLine();
                Console.WriteLine("Digite apenas valores numéricos e inteiros para a altura da pirâmide");
                Console.ReadKey();
            }
        }
    }
}
