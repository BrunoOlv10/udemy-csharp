using System;

namespace projeto_teste
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Calculadora
            //Console.Write("Digite o primeiro valor: ");
            //int valor1 = Convert.ToInt16(Console.ReadLine());
            //Console.WriteLine();

            //Console.Write("Digite o segundo valor: ");
            //int valor2 = Convert.ToInt16(Console.ReadLine());
            //Console.WriteLine();

            //Console.Write("Digite um operador (+ - * /): ");
            //string operador = Console.ReadLine();
            //Console.WriteLine();

            //decimal resultado = 0;
            //Boolean resposta = true;
            //if (valor1 == 0 || valor2 == 0 && operador == "/")
            //{
            //    Console.Write("Não é possível fazer divisão por zero");
            //    resposta = false;
            //} else
            //{
            //    if (operador == "+")
            //    {
            //        resultado = valor1 + valor2;
            //    }
            //    if (operador == "-")
            //    {
            //        resultado = valor1 - valor2;
            //    }
            //    if (operador == "*")
            //    {
            //        resultado = valor1 * valor2;
            //    }
            //    if (operador == "/")
            //    {
            //        resultado = valor1 / valor2;
            //    }
            //}

            //if (resposta == true)
            //{
            //    Console.Write("O resultado é " + resultado);
            //}

            // Sistema Login
            string user = "Bruno";
            string password = "teste";

            Console.Write("User: ");
            string userInsert = Console.ReadLine();
            Console.WriteLine();
                
            Console.Write("Password: ");
            string passwordInsert = Console.ReadLine();
            Console.WriteLine();

            Boolean resposta = false;
            if (user == userInsert && password == passwordInsert)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("Seja bem-vindo!");
                resposta = true;
            } if (user != userInsert && password != passwordInsert)
            {
                Console.ForegroundColor= ConsoleColor.Red;
                Console.Write("Usuário e senha incorretas!");
                resposta = true;
            }
            if (resposta == false)
            {
                if (user != userInsert)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("Usuário incorreto!");
                }
                if (password != passwordInsert)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("Senha incorreta!");
                }
            }
            Console.ReadKey();
        }
    }
}
