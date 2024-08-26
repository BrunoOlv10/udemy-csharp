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
            string[] frase = repeticao_exs.ex8_palavra_longa.ObterFrase();

            List<string> maiorPalavra = repeticao_exs.ex8_palavra_longa.MaiorPalavra(frase);
        }
    }
}
