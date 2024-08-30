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
            (string elemento, int numeroLinhas) = repeticao_exs.ex22_piramide_caracteres.ObterInfosPiramide();

            repeticao_exs.ex22_piramide_caracteres.MontarPiramide(elemento, numeroLinhas);
        }
    }
}
