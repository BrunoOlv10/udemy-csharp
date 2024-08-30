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
            string palavra = repeticao_exs.ex13_maiuscula_minuscula.ObterPalavra();

            string palavraFinal = repeticao_exs.ex13_maiuscula_minuscula.PalavraFinal(palavra);
        }
    }
}
