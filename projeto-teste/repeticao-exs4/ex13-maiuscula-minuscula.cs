using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto.repeticao_exs4
{
    public class ex13_maiuscula_minuscula
    {
        public static void TransformarMaiusculaMinuscula()
        {
            Console.Write("Digite uma frase ou sequência de letras para serem transformadas: ");
            string elemento = Console.ReadLine();

            if (string.IsNullOrEmpty(elemento.Trim()))
            {
                Console.WriteLine();
                Console.WriteLine("É necessário escrever alguma frase ou sequência de letras");
                Console.ReadKey();
                return;
            }

            Console.WriteLine("Digite a letra da opção de como desejar transformar o que foi digitado");
            Console.WriteLine("G - para maiúsculo");
            Console.WriteLine("P - para minúsculo");
            Console.Write("");
            string opcao = Console.ReadLine().ToUpper();

            if ((opcao != "G" && opcao != "P") || string.IsNullOrEmpty(opcao))
            {
                Console.WriteLine("Escolha alguma opção dentro das duas disponíveis: G - maiúscula ou P - minúscula");
                Console.ReadKey();
                return;
            }

            string elementoTransformado = "";

            if (opcao == "G")
                elementoTransformado = elemento.ToUpper();
            
            if (opcao == "P")
                elementoTransformado = elemento.ToLower();

            Console.WriteLine();
            Console.WriteLine($"A frase digitada foi: {elemento}");
            Console.WriteLine($"Após escolher a opção de transformação, a frase ficou assim: {elementoTransformado}");
            Console.ReadKey();
        }
    }
}
