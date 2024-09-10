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
            (int[] array, int posicao) = repeticao_exs2.ex5_remover_caractere_especifico.ObterInfosArray();

            repeticao_exs2.ex5_remover_caractere_especifico.ArrayAlterado(array, posicao);
        }
    }
}
