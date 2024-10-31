using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DocumentFormat.OpenXml.Drawing.Diagrams;

namespace projeto.repeticao_exs3
{
    public class ex20_ano_nascimento
    {
        public static void EncontrarAno()
        {
            try
            {
                Console.WriteLine("Você quer encontrar o ano de nascimento baseado na idade ou a idade baseado no ano de nascimento? (digite 'ano' para a primeira opção ou 'idade' para a segunda opção) ");
                Console.Write("");
                string resposta = Console.ReadLine().ToLower();

                int anoAtual = DateTime.Now.Year;

                Console.WriteLine();

                if (resposta == "ano")
                {
                    Console.WriteLine("Qual é a idade? (apenas o número) ");
                    Console.Write("");
                    int idadeDigitada = Convert.ToInt32(Console.ReadLine());

                    if (idadeDigitada <= 0 )
                    {
                        Console.WriteLine();
                        Console.WriteLine("Digite idades maiores que 0");
                        Console.ReadKey();
                        return;
                    }

                    int anoNascCalc = anoAtual - idadeDigitada;

                    Console.WriteLine();
                    Console.WriteLine($"A idade digitada foi {idadeDigitada} anos e o ano de nascimento é {anoNascCalc}");
                    Console.ReadKey();
                }

                else if (resposta == "idade")
                {
                    Console.WriteLine("Qual é o ano de nascimento (apenas o número)? ");
                    Console.Write("");
                    int anoNascDigitado = Convert.ToInt32(Console.ReadLine());

                    if (anoNascDigitado <= 1800)
                    {
                        Console.WriteLine();
                        Console.WriteLine("Digite anos maiores que 1800");
                        Console.ReadKey();
                        return;
                    }

                    int idadeCalc = anoAtual - anoNascDigitado;

                    Console.WriteLine();
                    Console.WriteLine($"O ano de nascimento digitado foi {anoNascDigitado} e a idade é {idadeCalc} anos");
                    Console.ReadKey();
                }

                else
                {
                    Console.WriteLine("Resposta inválida, tem apenas duas opções: ");
                    Console.WriteLine("'ano' para achar o ano de nascimento a partir da idade");
                    Console.WriteLine("'idade' para achar a idade a partir do ano de nascimento");
                    Console.ReadKey();
                    return;
                }
            }
            catch (System.FormatException)
            {
                Console.WriteLine();
                Console.WriteLine("Digite apenas números para o ano de nascimento ou para a idade");
                Console.ReadKey();
            }
        }
    }
}
