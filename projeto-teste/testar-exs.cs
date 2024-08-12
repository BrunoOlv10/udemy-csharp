using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using curso_udemy.recuperar_instituicao_ano;

namespace curso_udemy
{
    public class testar_exs
    {
        static void Main(string[] args)
        {
            string palavra = ex18_polindromo.ObterPalavra();

            bool palindromo = ex18_polindromo.Palindromo(palavra);

            ex18_polindromo.ExibirResultado(palavra, palindromo);
        }
    }
}
