using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace curso_udemy
{
    internal class array
    {
        static void Main(string[] args)
        {
            string[] nomes = new string[] { "bruno", "vilma", "pablo", "joão", "carlos", 
                                            "pedro" };

            //Console.WriteLine($"Tamanho do array: { nomes.Length }");

            //for (int i = 0; i < nomes.Length; i++)
            //{
            //    Console.WriteLine($"Nome: { nomes[i] } está na posição { i }");
            //}

            Console.WriteLine();
            Console.Write("Buscar um nome: ");
            string nomeBuscar = Console.ReadLine();

            // int cont = 0;
            //foreach (string nome in nomes)
            //{
            //    if (!string.IsNullOrEmpty(nome.Trim()))
            //        Console.WriteLine($"Nome: { nome }");
            //    else 
            //        break;
            //    Console.WriteLine(cont++);
            //}

            //foreach (string nome in nomes)
            //{
            //    if (nomeBuscar == nome)
            //    { 
            //        Console.WriteLine($"Achei o nome: { nome }");
            //        break;
            //    }
            //}

            int posicao = Array.IndexOf(nomes, nomeBuscar.ToLower());

            if (posicao > 0)
                Console.WriteLine($"Achei o nome: {nomes[posicao]} na posição: {posicao}");
            else
                Console.WriteLine("Não achei o elemento");

            Console.ReadKey();
        }
    }
}
