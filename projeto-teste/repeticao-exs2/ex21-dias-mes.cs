using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto.repeticao_exs2
{
    public class ex21_dias_mes
    {
        public static void DescobrirDiasMes()
        {
            try
            {
                Console.Write("Insira o ano: ");
                int ano = Convert.ToInt32(Console.ReadLine());

                Console.Write("Insira o número do mês para retornar a quantidade de dias dele (1 a 12): ");
                int mes = Convert.ToInt32(Console.ReadLine());

                if (mes < 1 && mes > 12)
                {
                    throw new Exception();
                }

                int dias = DateTime.DaysInMonth(ano, mes);

                string nomeMes = new DateTime(ano, mes, 1).ToString("MMMM");

                Console.WriteLine();
                Console.WriteLine($"O mês de {nomeMes} do ano de {ano} tem {dias} dias");
                Console.ReadKey();
            }
            catch (System.FormatException)
            {
                Console.WriteLine();
                Console.WriteLine("Insira apenas números para o ano e mês!");
                Console.ReadKey();
            }
            catch (Exception ex) 
            {
                Console.WriteLine();
                Console.WriteLine("Para o mês insira um número de 1 a 12!");
                Console.ReadKey();
            }
        }
    }
}
