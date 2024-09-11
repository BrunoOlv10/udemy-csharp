using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using DocumentFormat.OpenXml.Wordprocessing;

namespace projeto
{
    public class ex21_dias_mes
    {
        public static int obterMes()
        {
            int numeroMes = 0;

            try
            {
            Console.Write("Digite o número do mês que deseja: ");
            numeroMes = Convert.ToInt32(Console.ReadLine());

                while (numeroMes < 1 || numeroMes > 12)
                {
                    Console.Write($"Mês {numeroMes} inválido, digite um número entre 1 e 12: ");
                    numeroMes = Convert.ToInt32(Console.ReadLine());
                }
            }
            catch (System.FormatException ex)
            {
                Console.Write("É necessário inserir o número do mês, não é permitido qualquer outro elemento");
                Console.ReadKey();
                Environment.Exit(1);
            }

            return numeroMes;
        }

        public static bool obterDiasMes(int numeroMes)
        {
            DateTime dataAtual = DateTime.Today;
            int anoAtual = dataAtual.Year;

            int dias = DateTime.DaysInMonth(anoAtual, numeroMes);

            Console.WriteLine($"No mês {numeroMes} tem {dias} dias");

            Console.ReadKey();

            return true;
        }
    }
}
