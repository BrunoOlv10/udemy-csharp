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
            int[] arrayNumeros = repeticao_exs.ex26_soma_elementos_matriz.ArrayNumeros();

            int somarNumeros = repeticao_exs.ex26_soma_elementos_matriz.SomarNumeros(arrayNumeros);
        }
    }
}
