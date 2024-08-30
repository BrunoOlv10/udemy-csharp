using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using curso_udemy.recuperar_instituicao_ano;
using DocumentFormat.OpenXml.ExtendedProperties;

namespace curso_udemy
{
    public class testar_exs
    {
        static void Main(string[] args)
        {
            int idade = repeticao_exs.ex20_ano_nascimento.ObterIdade();

            int anoNascimento = repeticao_exs.ex20_ano_nascimento.CalcularAnoNascimento(idade);
        }
    }
}
