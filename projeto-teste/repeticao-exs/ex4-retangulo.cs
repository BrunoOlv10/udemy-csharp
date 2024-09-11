using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto.repeticao_exs
{
    public class ex4_retangulo_numero
    {
        public static (int, int, string) InfosRetangulo()
        {
            while (true)
            {
                try
                {
                    Console.Write("Insira a largura do retângulo: ");
                    int largura = Convert.ToInt32(Console.ReadLine());

                    Console.Write("Insira a altura do retângulo: ");
                    int altura = Convert.ToInt32(Console.ReadLine());

                    Console.Write("Insira por qual elemento formará o retângulo: ");
                    string elemento = Console.ReadLine();

                    return (largura, altura, elemento);
                }
                catch (System.FormatException)
                {
                    Console.WriteLine("Para largura e altura digite apenas números");
                    Console.WriteLine();
                }
            }
        }

        public static void MontarRetangulo(int largura, int altura, string elemento)
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

                Console.WriteLine(elemento);
            }

            if (altura > 1)
            {
                for (int i = 0; i < largura; i++)
                {
                    Console.Write(elemento);
                }
            }

        Console.ReadKey();
        }
    }
}
