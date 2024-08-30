using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace curso_udemy.repeticao_exs
{
    public class ex21_dias_mes
    {
        public static int ObterMes()
        {
            while (true)
            {
                try
                {
                    Console.Write("Digite o número do mês para verificar quantos dias tem nele: ");
                    int numeroMes = Convert.ToInt32(Console.ReadLine());

                    while (numeroMes < 1 || numeroMes > 12)
                    {
                        Console.WriteLine();
                        Console.WriteLine($"O número {numeroMes} está fora da quantidade de meses que tem no ano!");
                        Console.Write("Digite um mês entre 1 e 12: ");
                        numeroMes = Convert.ToInt32(Console.ReadLine());
                    }

                    return numeroMes;
                }
                catch (System.FormatException)
                {
                    Console.WriteLine();
                    Console.WriteLine("Digite apenas números para o mês!");
                }
            }
        }

        public static int ObterDias(int numeroMes) 
        {
            int anoAtual = DateTime.Now.Year;

            int diasMes = DateTime.DaysInMonth(anoAtual, numeroMes);

            Console.WriteLine();
            Console.WriteLine($"No mês {numeroMes} tem {diasMes} dias");
            Console.ReadKey();

            return diasMes;
        }
    }
}
