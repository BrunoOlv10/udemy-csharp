using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace curso_udemy.repeticao_exs
{
    public class ex23_sequencia_fibonacci
    {
        public static int ObterNumerosTermos()
        {
            int numeroTermos = 0;
            while (numeroTermos < 1)
            {
                try
                {
                    Console.Write("Digite o número de termos a ser exibidos da sequência (maior que 0): ");
                    numeroTermos = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine();

                }
                catch (System.FormatException)
                {
                    Console.WriteLine();
                    Console.WriteLine("Insira apenas números!");
                }
            }
            
            return numeroTermos;
        }

        public static List<int> GerarSequencia(int numeroTermos)
        {
            List<int> sequencia = new List<int>();
            int primeiroNumero = 0, segundoNumero = 1, proximoNumero;

            Console.WriteLine();

            if (numeroTermos >= 1)
                Console.Write($"{primeiroNumero}, ");
            
            if (numeroTermos >= 2)
                Console.Write($"{segundoNumero}, ");

            for (int i = 3; i <= numeroTermos; i++)
            {
                proximoNumero = primeiroNumero + segundoNumero;
                sequencia.Add(proximoNumero);
                primeiroNumero = segundoNumero;
                segundoNumero = proximoNumero;
            }
            Console.WriteLine(string.Join(", ", sequencia));
            Console.ReadKey();

            return sequencia;
        }
    }
}
