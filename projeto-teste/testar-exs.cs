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
            char limite = repeticao_exs.ex24_letras_alfabeto.ObterLimite();

            List<char> alfabeto = repeticao_exs.ex24_letras_alfabeto.ExibirAlfabeto(limite);
        }
    }
}
