using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DocumentFormat.OpenXml.Drawing;

namespace projeto.repeticao_exs2
{
    public class ex20_ano_nascimento
    {
        public static void DescobrirAnoNasc()
        {
            try
            {
                Console.Write("Insira a sua idade: ");
                int idade = Convert.ToInt32(Console.ReadLine());

                if (idade < 1)
                    throw new Exception();

                int anoAtual = DateTime.Today.Year;

                int anoNasc = anoAtual - idade;

                Console.WriteLine();
                Console.WriteLine($"Você tem {idade} ano(s) e nasceu em {anoNasc}");
                Console.ReadKey();

            }
            catch (System.FormatException)
            {
                Console.WriteLine();
                Console.WriteLine("Insira apenas números para a idade!");
                Console.ReadKey();
            }
            catch (Exception ex)  
            {
                Console.WriteLine();
                Console.WriteLine("Não é permitido idades abaixo de 1 ano!");
                Console.ReadKey();
            }
            
        }
    }
}
