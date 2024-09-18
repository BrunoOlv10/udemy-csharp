using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto.repeticao_exs2
{
    public class ex22_piramide_caracteres
    {
        public static void MontarPiramide()
        {
            try
            {
                Console.Write("Insira o elemento que formará a pirâmide: ");
                string elemento = Console.ReadLine();

                if (elemento.Length < 1 || elemento.Length > 3)
                    throw new Exception();

                Console.WriteLine();

                Console.Write("Insira a altura da pirâmide: ");
                int altura = Convert.ToInt32(Console.ReadLine());

                for (int i = 0; i <= altura; i++)
                {
                    for (int j = 0; j < i; j++)
                    {
                        Console.Write(elemento);
                    }

                    Console.WriteLine();
                }

                Console.ReadKey();
            }
            catch (System.FormatException)
            {
                Console.WriteLine();
                Console.WriteLine("Insira apenas números para a altura!");
                Console.ReadKey();
            }
            catch (Exception e)
            {
                Console.WriteLine();
                Console.WriteLine("Insira até três elementos para formar a pirâmide!");
                Console.ReadKey();
            }
        }
    }
}
