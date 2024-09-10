using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace curso_udemy.repeticao_exs2
{
    public class ex1_trocar_numeros_variaveis
    {
        public static void TrocarNumeros()
        {
            while (true)
            {
                try
                {
                    Console.Write("Digite o primeiro número: ");
                    int numero1 = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine();

                    Console.Write("Digite o segundo número: ");
                    int numero2 = Convert.ToInt32(Console.ReadLine());

                    int aux = numero2;
                    numero2 = numero1;
                    numero1 = aux;

                    Console.WriteLine($"Os números invertidos que foram digitados são {numero1} e {numero2}");
                    Console.ReadKey();
                }
                catch (System.FormatException)
                {
                    Console.WriteLine();
                    Console.WriteLine("Digite apenas números!");
                }
            }
        }
    }
}
