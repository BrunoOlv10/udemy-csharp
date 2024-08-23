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
            char[] palavra = ex31_ordenar_matriz_string.ObterPalavra();

            string palavraOrdenada = ex31_ordenar_matriz_string.OrdenarPalavra(palavra);
        }
    }
}
