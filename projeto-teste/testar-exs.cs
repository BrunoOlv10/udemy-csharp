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
            (string caractere, int numeroLinhas) elemento = ex22_piramide_caracteres.obterElementoUtilizado();

            bool montarPirâmide = ex22_piramide_caracteres.MontarPiramidade(elemento.caractere, elemento.numeroLinhas);
        }
    }
}
