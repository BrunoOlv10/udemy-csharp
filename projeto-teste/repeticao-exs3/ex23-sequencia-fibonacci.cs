using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DocumentFormat.OpenXml.EMMA;

namespace projeto.repeticao_exs3
{
    public class ex23_sequencia_fibonacci
    {
        public static void GerarSequenciaFibonacci()
        {
            try
            {
                Console.Write("Digite o número de termos a ser exibidos: ");
                int numeroTermos = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine();

                int primeiroNumero = 0;
                int segundoNumero = 1;
                int proximoNumero = 0;
                List<int> sequencia = new List<int>();

                if (numeroTermos >= 1)
                    sequencia.Add(primeiroNumero);

                if (numeroTermos >= 2)
                    sequencia.Add(segundoNumero);

                for (int i = 3; i <= numeroTermos; i++)
                {
                    proximoNumero = primeiroNumero + segundoNumero;
                    sequencia.Add(proximoNumero);
                    primeiroNumero = segundoNumero;
                    segundoNumero = proximoNumero;
                }

                Console.WriteLine($"A sequência de Fibonacci com {numeroTermos} termos:");
                Console.WriteLine("" + String.Join(", ", sequencia) + "");
                Console.ReadKey();
            }
            catch (Exception)
            {
                Console.WriteLine();
                Console.WriteLine("Insira apenas números inteiros para a quantidade de termos que será exibido");
                Console.ReadLine();
            }
        }
    }
}
