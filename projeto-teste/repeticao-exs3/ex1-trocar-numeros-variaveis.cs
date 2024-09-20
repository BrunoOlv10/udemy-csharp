using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto.repeticao_exs3
{
    public class ex1_trocar_numeros_variaveis
    {
        public static void TrocarNumerosVariaveis()
        {
            try
            {
                Console.Write("Escreva o primeiro número: ");
                int numero1 = Convert.ToInt32(Console.ReadLine());

                Console.Write("Escreva o segundo número: ");
                int numero2 = Convert.ToInt32(Console.ReadLine());

                int numeroNovo1 = 0, numeroNovo2 = 0;

                numeroNovo1 = numero2;
                numeroNovo2 = numero1;

                Console.WriteLine();
                Console.WriteLine($"A ordem dos números digitados foi {numero1} e {numero2}, agora a ordem é {numeroNovo1} e {numeroNovo2}");
                Console.ReadKey();
            }
            catch (Exception)
            {
                Console.WriteLine();
                Console.WriteLine("Digite apenas números!");
                Console.ReadKey();
            }
        }
    }
}
