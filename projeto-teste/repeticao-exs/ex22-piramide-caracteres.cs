using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace curso_udemy.repeticao_exs
{
    public class ex22_piramide_caracteres
    {
        public static (string, int) ObterInfosPiramide()
        {
            Console.Write("Insira apenas um elemento que formará toda a pirâmide: ");
            string elemento = Console.ReadLine();
            
            while (true)
            {
                try
                {
                    Console.Write("Quantas linhas terá a pirâmide? ");
                    int numeroLinhas = Convert.ToInt32(Console.ReadLine());

                    if (numeroLinhas < 1 || numeroLinhas > 20)
                    {
                        throw new Exception();
                    }
                    else
                    {
                        return (elemento, numeroLinhas);
                    }

                }
                catch (System.FormatException)
                {
                    Console.WriteLine();
                    Console.WriteLine("Digite apenas números para a quantidade de linhas!");
                }
                catch (Exception)
                {
                    Console.WriteLine();
                    Console.WriteLine("Insira a quantidade de linhas dentro do limite (1 a 20)!");
                }
            }
        }

        public static void MontarPiramide(string elemento, int numeroLinhas)
        {
            Console.WriteLine();
            for (int i = 1; i <= numeroLinhas; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write(elemento);
                }

                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
