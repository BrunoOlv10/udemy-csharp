using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto.repeticao_exs2
{
    public class ex6_mudar_caractere_posicao
    {
        public static void MudarPosicaoCaractere()
        {
            while (true)
            {
                try
                {
                    Console.Write("Escreva sua string: ");
                    string elementoString = Console.ReadLine();
                    char[] elementoDividido = elementoString.ToCharArray();

                    Console.Write("Qual a posição do elemento que quer trocar de posição? ");
                    int posicaoOrigem = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine();

                    Console.Write("Qual a posição que quer colocar o elemento? ");
                    int posicaoDestino = Convert.ToInt32(Console.ReadLine());

                    char aux;
                    if (posicaoOrigem >= 0 && posicaoOrigem <= elementoDividido.Length && posicaoDestino >= 0 && posicaoDestino <= elementoDividido.Length)
                    {
                        aux = elementoDividido[posicaoOrigem];
                        elementoDividido[posicaoOrigem] = elementoDividido[posicaoDestino];
                        elementoDividido[posicaoDestino] = aux;
                        string novaPalavra = new string(elementoDividido);

                        Console.WriteLine();
                        Console.WriteLine($"Após inverter os elementos das posições {posicaoOrigem} e {posicaoDestino} do '{elementoString}', a palavra ficou assim '{novaPalavra}'");
                    }
                    else
                    {
                        Console.WriteLine();
                        Console.WriteLine("Posição ou posições inexistentes nesse elemento!");
                    }
                    
                    Console.ReadKey();

                }
                catch (System.FormatException)
                {
                    Console.WriteLine();
                    Console.WriteLine("Escreva apenas números para a posição!");
                }
            }
        }
    }
}
