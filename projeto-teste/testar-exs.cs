﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using curso_udemy.classes;
using curso_udemy.recuperar_instituicao_ano;
using projeto.classes;
//using projeto.classes_exercicios;
using projeto.classes_exercicios_2;

namespace projeto
{
    public class testar_exs
    {
        static void Main(string[] args)
        {
            //FuncionarioEmpresa funcionario = new FuncionarioEmpresa();
            //ProdutoEmpresa produto = new ProdutoEmpresa();
            //VendaEmpresa venda = new VendaEmpresa();
            //Menu_Principal.SelecionarMenu(funcionario, produto, venda);

            FuncionarioEmpresa funcionario = new FuncionarioEmpresa();
            ProdutoEmpresa produto = new ProdutoEmpresa();
            VendaEmpresa venda = new VendaEmpresa(produto);
            MenuPrincipal.SelecionarOpcao(funcionario, produto, venda);
        }
    }
}
