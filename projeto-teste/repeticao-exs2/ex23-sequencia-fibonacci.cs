using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto.repeticao_exs2
{
    public class ex23_sequencia_fibonacci
    {
        public static void GerarSequencia()
        {
            try
            {
                Console.Write("Insira quantos termos vão aparecer na sequência (maior que 0): ");
                int numeroTermos = Convert.ToInt32(Console.ReadLine());

                if (numeroTermos <= 1)
                    throw new Exception();

                List<int> sequencia = new List<int>();
                int primeiroNumero = 0, segundoNumero = 1, proximoNumero;

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

                Console.WriteLine();
                Console.WriteLine($"A sequência de Fibonacci com {numeroTermos} termos");
                Console.WriteLine(String.Join(", ", sequencia));
                Console.ReadKey();
            }
            catch (System.FormatException)
            {
                Console.WriteLine();
                Console.WriteLine("Insira apenas números para a quantidade de termos que vai aparecer na sequência!");
                Console.ReadKey();
            }
            catch (Exception ex)
            {
                Console.WriteLine();
                Console.WriteLine("Insira apenas números maiores que 0!");
                Console.ReadKey();
            }
        }
    }
}
