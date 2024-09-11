using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto.repeticao_exs2
{
    public class ex7_numeros_opostos
    {
        public static void NumeroPositivoNegativo()
        {
            try
            {
                Console.WriteLine("Regra: 1 número positivo e outro negativo OU 1 número negativo e outro positivo, os dois tem que ser opostos e não nulos");
                Console.Write("Digite o primeiro número: ");
                int numero1 = Convert.ToInt32(Console.ReadLine());

                Console.Write("Digite o segundo número: ");
                int numero2 = Convert.ToInt32(Console.ReadLine());

                if (numero1 < 0 && numero2 > 0 || numero1 > 0 && numero2 < 0)
                {
                    Console.WriteLine("As regras foram respeitadas");
                    Console.WriteLine($"Temos um número positivo e outro negativo: {numero1} e {numero2}");
                }
                else
                {
                    Console.WriteLine("As regras não foram respeitadas");
                    Console.WriteLine($"Temos números que não são opostos {numero1} e {numero2}");
                }

                Console.ReadKey();
            }
            catch (System.FormatException)
            {
                Console.WriteLine();
                Console.WriteLine("Digite apenas números positivos ou negativos!");
                Console.ReadKey();
            }
        }
    }
}
