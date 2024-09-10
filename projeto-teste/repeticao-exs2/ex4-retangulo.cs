using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace curso_udemy.repeticao_exs2
{
    public class ex4_retangulo
    {
        public static (int, int, string) ObterInfosRetangulo()
        {
            while (true)
            {
                try
                {
                    Console.Write("Insira a largura do retângulo: ");
                    int largura = Convert.ToInt32(Console.ReadLine());

                    Console.Write("Insira a altura do retângulo: ");
                    int altura = Convert.ToInt32(Console.ReadLine());

                    if (largura < 3 || altura < 3)
                    {
                        throw new Exception();
                    }

                    Console.Write("Insira o elemento que formará o retângulo: ");
                    string elemento = Console.ReadLine();

                    return (largura, altura, elemento);
                }
                catch (System.FormatException)
                {
                    Console.WriteLine();
                    Console.WriteLine("Insira apenas números!");
                }
                catch (Exception)
                {
                    Console.WriteLine();
                    Console.WriteLine("Insira uma largura e altura a partir de 3!");
                }
            }
        }

        public static void GerarRetangulo(int largura, int altura, string elemento)
        {
            Console.WriteLine();

            for (int l = 0; l < largura; l++)
            {
                Console.Write(elemento);
            }

            Console.WriteLine();

            for (int i = 0; i < altura - 2; i++)
            {
                Console.Write(elemento);

                for (int j = 0; j < largura - 2; j++)
                {
                    Console.Write(" ");
                }

                Console.Write(elemento);

                Console.WriteLine();
            }

            if (altura > 1)
            {
                for (int l = 0; l < largura; l++)
                {
                    Console.Write(elemento);
                }
            }

            Console.ReadKey();
        }
    }
}
