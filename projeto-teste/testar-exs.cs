﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using curso_udemy.recuperar_instituicao_ano;
using DocumentFormat.OpenXml.ExtendedProperties;

namespace curso_udemy
{
    public class testar_exs
    {
        static void Main(string[] args)
        {
            (int largura, int altura, string elemento) = repeticao_exs.ex4_retangulo_numero.InfosRetangulo();

            repeticao_exs.ex4_retangulo_numero.MontarRetangulo(largura, altura, elemento);
        }
    }
}
