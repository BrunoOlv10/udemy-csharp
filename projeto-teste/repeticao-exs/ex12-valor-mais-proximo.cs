using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace curso_udemy.repeticao_exs
{
    public class ex12_valor_mais_proximo
    {
        public static (int, int, int) Numeros()
        {
            int numero1 = 0;
            int numero2 = 0;
            int referencia = 0;

            while (true)
            {
                try
                {
                    Console.Write("Insira o primeiro número: ");
                    numero1 = Convert.ToInt32(Console.ReadLine());

                    Console.Write("Insira o segundo número: ");
                    numero2 = Convert.ToInt32(Console.ReadLine());

                    Console.Write("Insira o número de referência (para comparar qual dos outros 2 números está mais perto dele): ");
                    referencia = Convert.ToInt32(Console.ReadLine());

                    return (numero1, numero2, referencia);
                }
                catch (System.FormatException)
                {
                    Console.WriteLine();
                    Console.WriteLine("Insira apenas números!");
                }   
            }
        }

        public static int NumeroProximo(int numero1, int numero2, int referencia)
        {
            int diferenca1 = referencia - numero1;
            int diferenca2 = referencia - numero2;
            int menorDiferenca = 0;
            
            if (diferenca1 < diferenca2)
            {
                menorDiferenca = numero1;
            }
            else if (diferenca2 < diferenca1)
            {
                menorDiferenca = numero2;
            }

            Console.WriteLine();
            Console.WriteLine($"O número que tem a menor diferença para {referencia} é: {menorDiferenca}");
            Console.ReadKey();

            return menorDiferenca;
        }
    }
}
