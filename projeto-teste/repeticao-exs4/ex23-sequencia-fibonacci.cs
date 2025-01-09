using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto.repeticao_exs4
{
    public class ex23_sequencia_fibonacci
    {
        public static void GerarSequenciaFibonacci()
        {
            try
            {
                Console.Write("Digite o número de termos que serão exibidos: ");
                int numerosTermos = Convert.ToInt32(Console.ReadLine());

                if (numerosTermos < 1)
                {
                    Console.WriteLine();
                    Console.WriteLine("É necessário inserir um número positivo e inteiro para a quantidade de termos");
                    Console.ReadKey();
                    return;
                }

                int primeiroNumero = 0;
                int segundoNumero = 1;
                int proximoNumero = 0;
                List<int> sequencia = new List<int>();

                if (numerosTermos >= 1)
                    sequencia.Add(primeiroNumero);

                if (numerosTermos >= 2)
                    sequencia.Add(segundoNumero);

                for (int i = 3; i <= numerosTermos; i++)
                {
                    proximoNumero = primeiroNumero + segundoNumero;
                    sequencia.Add(proximoNumero);
                    primeiroNumero = segundoNumero;
                    segundoNumero = proximoNumero;
                }

                Console.WriteLine();
                Console.WriteLine($"A sequência de Fibonacci com {numerosTermos} termo(s):");
                Console.WriteLine("" + String.Join(", ", sequencia) + "");
                Console.ReadKey();
            }
            catch (System.FormatException)
            {
                Console.WriteLine();
                Console.WriteLine("Insira apenas valores numéricos para a quantidade de termos");
                Console.ReadKey();
            }
        }
    }
}
