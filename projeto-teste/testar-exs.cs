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
            int[] numeros = repeticao_exs.ex2_multiplicao.ObterNumeros();

            int multiplicacao = repeticao_exs.ex2_multiplicao.ResultadoMultiplicacao(numeros);
        }
    }
}
