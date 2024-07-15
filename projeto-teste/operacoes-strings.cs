using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace curso_udemy
{
    internal class operacoes_strings
    {
        static void Main(string[] args)
        {
            string mensagem = "       Teste texto tratamento strings         ";

            Console.WriteLine(mensagem.Substring(11));
            Console.WriteLine(mensagem.Substring(6, 6));


            Console.WriteLine("-" + mensagem.Trim() + "-");
            Console.WriteLine("-" + mensagem.TrimStart() + "-");
            Console.WriteLine("-" + mensagem.TrimEnd() + "-");


            Console.WriteLine(mensagem.Replace("o", "A"));

            
            Console.WriteLine("A mensagem contém a palavra 'texto'? " + mensagem.Contains("texto"));
            if (mensagem.Contains("aula"))
            {
                Console.WriteLine("A mensagem contém 'aula'");
            } else
            {
                Console.WriteLine("A mensagem não contém 'aula'");
            }

            string nome = "Bruno";
            Console.WriteLine("Meu nome é: " + nome);
            Console.WriteLine(string.Format("Meu nome é: {0}", nome));
            Console.WriteLine($"Meu nome é: {nome}");

            DateTime data = DateTime.Now;
            int numero = 10;
            StringBuilder sb = new StringBuilder();
            sb.Append("texto 1 ");
            sb.Append($"Meu nome é: {nome} ");
            sb.Append($"Hora atual é: {data} ");
            sb.Append($"Esse é o valor da variável: {numero} ");

            Console.WriteLine(sb);

            Console.ReadKey();
        }
    }
}
