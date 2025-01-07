using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto.repeticao_exs4
{
    public class ex21_dias_mes
    {
        public static void QuantosDiasMes()
        {
            try
            {
                Console.WriteLine("1- Janeiro | 2- Fevereiro | 3- Março | 4- Abril | 5- Maio | 6- Junho | 7- Julho | 8- Agosto | 9- Setembro | 10- Outubro | 11- Novembro | 12- Dezembro");
                Console.Write("Insira o número do mês para saber quantos dias ele tem: ");
                int numeroMes = Convert.ToInt32(Console.ReadLine());

                if (numeroMes < 1 || numeroMes > 12)
                {
                    Console.WriteLine();
                    Console.WriteLine("Insira um número de mês válido diante dos que foram apresentados no início");
                    Console.ReadKey();
                    return;
                }

                Console.Write("Insira o ano referente a esse mês: ");
                int ano = Convert.ToInt32(Console.ReadLine());

                if (ano < 1925 || ano > 2025)
                {
                    Console.WriteLine();
                    Console.WriteLine("Insira um ano válido dentro do limite: 1925 - 2025");
                    Console.ReadKey();
                    return;
                }

                int dias = DateTime.DaysInMonth(ano, numeroMes);
                string mesEscrito = CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(numeroMes);

                Console.WriteLine();
                Console.WriteLine($"O mês de {mesEscrito} em {ano} tem {dias} dias");
                Console.ReadKey();
            }
            catch (System.FormatException)
            {
                Console.WriteLine();
                Console.WriteLine("É necessário inserir algum valor válido para conseguir obter a quantidade de dias");
                Console.ReadKey();
            }
        }
    }
}
