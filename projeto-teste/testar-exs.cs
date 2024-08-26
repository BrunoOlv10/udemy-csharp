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
            (string palavra, char[] palavraCaracteres) = repeticao_exs.ex6_mudar_caractere_posicao.ObterString();

            string mudarCaractere = repeticao_exs.ex6_mudar_caractere_posicao.MudarCaracterePosicao(palavra, palavraCaracteres);
        }
    }
}
