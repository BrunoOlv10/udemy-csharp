using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto.repeticao_exs4
{
    public class ex20_ano_nascimento
    {
        public static void DescobrirNascimento()
        {
            try
            {
                Console.WriteLine("Ano de nascimento pela idade - digite 'ano' ou a idade pelo ano de nascimento - digite 'idade' ");
                Console.Write("Quer descobrir o ano de nascimento pela idade ou a idade pelo ano de nascimento? ");
                string resposta = Console.ReadLine().ToLower();

                if (resposta != "ano" && resposta != "idade")
                {
                    Console.WriteLine();
                    Console.WriteLine("Digite apenas respostas válidas para ter a resposta: 'ano' ou 'idade'");
                    Console.ReadKey();
                    return;
                }

                int anoAtual = DateTime.Now.Year;
                int anoNascCalculado = 0;
                int idadeCalculada = 0;

                if (resposta == "ano")
                {
                    Console.WriteLine();
                    Console.Write("Digite a idade: ");
                    int idade = Convert.ToInt16(Console.ReadLine());

                    if (idade < 0 || idade > anoAtual)
                    {
                        Console.WriteLine();
                        Console.WriteLine("Não é possível calcular o ano de nascimento com uma idade menor a 0");
                        Console.WriteLine($"Também não é possível calcular com uma idade maior que o ano atual ({anoAtual})");
                        Console.ReadKey();
                        return;
                    }

                    anoNascCalculado = anoAtual - idade;

                    Console.WriteLine();
                    Console.WriteLine($"A idade digitada foi {idade} e o ano de nascimento é {anoNascCalculado}");
                    Console.ReadKey();
                }

                if (resposta == "idade")
                {
                    Console.WriteLine();
                    Console.Write("Digite o ano de nascimento: ");
                    int anoNasc = Convert.ToInt16(Console.ReadLine());

                    if (anoNasc > anoAtual || anoNasc <= 0)
                    {
                        Console.WriteLine();
                        Console.WriteLine($"Não é possível calcular a idade com um ano maior que o atual ({anoAtual})");
                        Console.WriteLine($"Também não é possível calcular com um ano igual ou menor a 0");
                        Console.ReadKey();
                        return;
                    }

                    idadeCalculada = anoAtual - anoNasc;

                    Console.WriteLine();
                    Console.WriteLine($"O ano de nascimento digitado foi {anoNasc} e a idade é {idadeCalculada}");
                    Console.ReadKey();
                }
            }
            catch (System.FormatException)
            {
                Console.WriteLine();
                Console.WriteLine("Insira apenas valores numéricos para a idade e ano de nascimento");
                Console.ReadKey();
            }
        }
    }
}
