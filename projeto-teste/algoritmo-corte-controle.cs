using System;
using System.Collections.Generic;

namespace curso_udemy
{
    class algoritmo_corte_controle
    {
        //static void Main(string[] args)
        //{
        //    string[,] dadosProdutos = new string[,] {
        //        { "1", "martelos", "01/2019", "10" },
        //        { "1", "martelos", "01/2019", "14" },
        //        { "1", "martelos", "02/2019", "5" },
        //        { "1", "martelos", "03/2019", "12" },
        //        { "2", "chaves fenda", "02/2019", "2" },
        //        { "2", "chaves fenda", "03/2019", "1" },
        //        { "3", "chaves philips", "01/2019", "20" },
        //        { "3", "chaves philips", "01/2019", "30" },
        //        { "3", "chaves philips", "01/2019", "50" },
        //        { "4", "baldes", "03/2019", "100" },
        //        { "5", "pas", "02/2019", "50" },
        //        { "5", "pas", "03/2019", "150" },
        //    };

        //    int totalProduto = 0;
        //    int totalGeral = 0;
        //    string idProdutoAtual = "";
        //    string idProdutoAnterior = "";
        //    int linha = 0;
        //    int numLinhas = dadosProdutos.GetLength(0);

        //    Dictionary<string, int> vendasPorData = new Dictionary<string, int>();

        //    Console.WriteLine("Id - Produto - Data - Qnd");
        //    while (linha < numLinhas)
        //    {
        //        idProdutoAtual = dadosProdutos[linha, 0];
        //        idProdutoAnterior = idProdutoAtual;

        //        totalProduto = 0;

        //        while (linha < numLinhas && dadosProdutos[linha, 0] == idProdutoAtual)
        //        {
        //            string dataVendaAtual = dadosProdutos[linha, 2];

        //            Console.WriteLine($"{dadosProdutos[linha, 0]} - {dadosProdutos[linha, 1]} - {dadosProdutos[linha, 2]} - {dadosProdutos[linha, 3]}");

        //            if (int.TryParse(dadosProdutos[linha, 3], out int quantidadeProdutos))
        //            {
        //                totalProduto += quantidadeProdutos;

        //                if (vendasPorData.ContainsKey(dataVendaAtual))
        //                    vendasPorData[dataVendaAtual] += quantidadeProdutos;

        //                else
        //                    vendasPorData[dataVendaAtual] = quantidadeProdutos;
        //            }

        //            linha++;
        //        }

        //        Console.WriteLine($"Total do Produto: {totalProduto}");
        //        Console.WriteLine();
        //        totalGeral += totalProduto;
        //    }

        //    Console.WriteLine($"Total Geral: {totalGeral}");
        //    Console.WriteLine();

        //    Console.WriteLine("Total de vendas por data:");
        //    foreach (var data in vendasPorData)
        //    {
        //        Console.WriteLine($"{data.Key}: {data.Value}");
        //    }

        //    Console.ReadKey();
        //}
    }
}


