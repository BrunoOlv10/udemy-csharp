﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto.classes_exercicios
{
    public class CriarProduto
    {
        public static void CadastrarProduto(ProdutoEmpresa produtoEmpresa)
        {
            Console.Write("Quantos produtos serão cadastrados? ");
            int quantidade = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();

            for (int i = 0; i < quantidade; i++)
            {
                Console.WriteLine($"Cadastrar o produto {i + 1}");

                Console.Write("Insira o id do produto: ");
                string id = Console.ReadLine();

                Console.Write("Insira o nome: ");
                string nomeProduto = Console.ReadLine();

                Console.Write("Insira a categoria: ");
                string categoria = Console.ReadLine();

                Console.Write("Insira o preço: ");
                double preco = Convert.ToDouble(Console.ReadLine());

                Produto produto = new Produto(id, nomeProduto, categoria, preco);

                produtoEmpresa.AdicionarProduto(produto);

                Console.WriteLine();
            }

            Console.WriteLine("Produtos cadastrados com sucesso!");
            Console.WriteLine("Pressione qualquer tecla para voltar ao menu.");
            Console.WriteLine();
            Console.ReadKey();
        }

        public static void ObterInfosMudarPreco(ProdutoEmpresa produtoEmpresa)
        {
            Console.Write("Qual a categoria que será mudado o preço? ");
            string categoriaEscolhida = Console.ReadLine();

            bool categoriaExiste = produtoEmpresa.ObterProdutos().Any(p => p.Categoria == categoriaEscolhida);

            if (!categoriaExiste)
            {
                Console.WriteLine();
                Console.WriteLine("Categoria não encontrada!");
                return;
            }

            Console.Write("Quanto será o aumento do preço do produto (em porcentagem, apenas o valor)? ");
            int porcentagemAumento = Convert.ToInt32(Console.ReadLine());

            List<Produto> ProdutosComAumento = produtoEmpresa.AlterarPrecoPorCategoria(categoriaEscolhida, porcentagemAumento);

            produtoEmpresa.ListarProdutosPrecosReajustados(ProdutosComAumento, categoriaEscolhida);
        }
    }
}