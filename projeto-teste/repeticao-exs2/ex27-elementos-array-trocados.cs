using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace curso_udemy.repeticao_exs2
{
    public class ex6_mudar_caractere_posicao
    {
        public static (int[], int, int) ObterInfosArray()
        {
            Console.Write("Insira os números do array (separados por vírgula): ");
            string numeroString = Console.ReadLine();
            string[] numerosDivividos = numeroString.Split(',');
            int[] numeros = new int[numerosDivividos.Length];

            for (int i = 0; i < numerosDivividos.Length; i++)
            {
                numeros[i] = Convert.ToInt32(numerosDivividos[i]);
            }

            Console.Write("Insira a posição do número que quer trocar de posição: ");
            int posicaoNumero = Convert.ToInt32(Console.ReadLine());

            Console.Write("Insira a posição destino para onde o número vai: ");
            int posicaoDestino = Convert.ToInt32(Console.ReadLine());

            return (numeros, posicaoNumero, posicaoDestino);
        }

        //public static (int[], int, int) Mudar
    }
}
