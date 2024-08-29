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
            (int numero1, int numero2, int referencia) = repeticao_exs.ex12_valor_mais_proximo.Numeros();

            int numeroProximo = repeticao_exs.ex12_valor_mais_proximo.NumeroProximo(numero1, numero2, referencia); 
        }
    }
}
