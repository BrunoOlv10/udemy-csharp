using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto.repeticao_exs4
{
    public class ex7_numeros_opostos
    {
        public static void ObterNumerosOpostos()
        {
            try
            {
                Console.WriteLine("Regra: É necessário os dois números inseridos serem opostos, caso contrário, não haverá prosseguimento");
                Console.Write("Digite o primeiro número: ");
                int numero1 = Convert.ToInt32(Console.ReadLine());

                Console.Write("Digite o segundo número: ");
                int numero2 = Convert.ToInt32(Console.ReadLine());

                if (numero1 < 0 && numero2 < 0 || numero1 > 0 && numero2 > 0)
                {
                    Console.WriteLine();
                    Console.WriteLine($"Os números inseridos foram: {numero1} e {numero2}");
                    Console.WriteLine("Não seguem a regra. É necessário os números serem opostos");
                    Console.ReadKey();
                    return;
                }

                Console.WriteLine();
                Console.WriteLine($"Os números inseridos foram: {numero1} e {numero2}");
                Console.WriteLine("Seguem a regra estabelecida");
                Console.ReadKey();
            }
            catch (System.FormatException)
            {
                Console.WriteLine();
                Console.WriteLine("É necessário inserir apenas valores numéricos");
                Console.ReadKey();
            }
        }
    }
}
