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
            (string[] frase, string palavraBuscada) = repeticao_exs.ex11_contem_palavra.ObterInfos();

            bool encontrarPalavra = repeticao_exs.ex11_contem_palavra.EncontrarPalavra(frase, palavraBuscada);
        }
    }
}
