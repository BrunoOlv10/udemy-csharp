﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using DocumentFormat.OpenXml.Wordprocessing;

namespace curso_udemy
{
    public class ex21_dias_mes
    {
        public static int obterMes()
        {
            Console.Write("Digite o número do mês que deseja: ");
            int numeroMes = Convert.ToInt32(Console.ReadLine());

            while (numeroMes < 1 || numeroMes > 12)
            {
                Console.Write($"Mês {numeroMes} inválido, digite um número entre 1 e 12: ");
                numeroMes = Convert.ToInt32(Console.ReadLine());
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