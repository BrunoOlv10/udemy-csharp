using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto.repeticao_exs3
{
    public class ex7_numeros_opostos
    {
        public static void VerificarNumerosOpostos()
        {
            try
            {
                Console.WriteLine("Insira um número postivo e outro negativo");
                Console.Write("Insira o primeiro número: ");
                int numero1 = Convert.ToInt32(Console.ReadLine());

                Console.Write("Insira o segundo número: ");
                int numero2 = Convert.ToInt32(Console.ReadLine());

                if (numero1 > 0 && numero2 < 0 || numero1 < 0 && numero2 > 0)
                {
                    Console.WriteLine();
                    Console.WriteLine($"Foi seguido a regra de um positivo e outro negativo: {numero1} e {numero2}");
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine($"Não foi seguido a regra: {numero1} e {numero2}");
                }
                Console.ReadKey();
            }
            catch (Exception ex)
            {
                Console.WriteLine();
                Console.WriteLine("Insira apenas números!");
                Console.ReadKey();
            }
        }
    }
}
