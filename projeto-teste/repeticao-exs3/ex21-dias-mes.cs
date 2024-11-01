using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto.repeticao_exs3
{
    public class ex21_dias_mes
    {
        public static void EncontrarDiasMes()
        {
            try
            {
                Console.Write("Qual mês vc quer saber a quantidade de dias que ele possui? (ano do mês de 1 a 12): ");
                int mes = Convert.ToInt32(Console.ReadLine());

                if (mes < 1 || mes > 12)
                    throw new Exception();

                Console.Write("De qual ano seria o mês digitado anteriormente? (ano entre 1900 e 2050): ");
                int ano = Convert.ToInt32(Console.ReadLine()); 

                if (ano < 1900 || ano > 2050)
                    throw new Exception();

                int diasMes = DateTime.DaysInMonth(ano, mes);

                DateTime dataAtual = new DateTime(2024, mes, 1);
                string nomeMes = dataAtual.ToString("MMMM");

                Console.WriteLine();
                Console.WriteLine($"O mês digitado foi '{nomeMes}' e tem {diasMes} dias no ano de {ano}");
                Console.ReadKey();
            }
            catch (Exception ex)
            {
                Console.WriteLine();
                Console.WriteLine("Insira apenas números de 1 a 12 para o mês e entre 1900 e 2050 para o ano");
                Console.ReadKey();
            }
        }
    }
}
