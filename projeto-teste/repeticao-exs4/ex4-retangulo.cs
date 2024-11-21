using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto.repeticao_exs4
{
    public class ex4_retangulo
    {
        public static void GerarRetangulo()
        {
            try
            {
                Console.Write("O retângulo será formado por qual elemento? ");
                string elemento = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(elemento))
                {
                    Console.WriteLine();
                    Console.WriteLine("Não é possível deixar nada vazio");
                    Console.ReadKey();
                    return;
                }

                Console.Write("O retângulo terá quanto de altura (inserir apenas o valor, sem unidade de medida)? ");
                int altura = Convert.ToInt32(Console.ReadLine());

                Console.Write("Qual será a largura? ");
                int largura = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine();

                if (largura <= 1 || altura <= 2)
                {
                    Console.WriteLine("A altura tem que ser maior que 2 e largura tem que ser maior que 1");
                    Console.ReadKey();
                    return;
                }

                for (int i = 0; i < altura; i++)
                {
                    for (int j = 0; j < largura; j++)
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
                Console.WriteLine("É necessário inserir apenas valores numéricos para a altura e largura");
                Console.ReadKey();
            }
        }
    }
}
