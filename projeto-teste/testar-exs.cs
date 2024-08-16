using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using curso_udemy.recuperar_instituicao_ano;

namespace curso_udemy
{
    public class testar_exs
    {
        static void Main(string[] args)
        {
            int idade = ex20_ano_nascimento.ObterIdade();
            
            int anoNascimento = ex20_ano_nascimento.CalcularAnoNascimento(idade);
        }
    }
}
