using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using curso_udemy.recuperar_instituicao_ano;
using DocumentFormat.OpenXml.Drawing;
using DocumentFormat.OpenXml.EMMA;
using DocumentFormat.OpenXml.Office.CustomUI;
using DocumentFormat.OpenXml.Office2016.Drawing.Command;
using HtmlAgilityPack;
using OfficeOpenXml;
using OpenAI_API;
using OpenAI_API.Completions;
using static curso_udemy.recuperar_instituicao_ano.GptModel;
using static curso_udemy.recuperar_instituicao_ano.InfosBaseModel;
using static curso_udemy.recuperar_instituicao_ano.InfosBuscadasModel;

namespace curso_udemy.recuperar_nome_ano
{
    class teste_api_gpt
    {
        static async Task Main(string[] args)
        {
            await ProcessarEnunciados();
        }

        static async Task ProcessarEnunciados()
        {
            var enunciados = ReadCSVFile();
            var resultados = new List<InfosBuscadasModel>();

            var tasks = enunciados.Select(async enunciado =>
            {
                var doc = new HtmlDocument();
                doc.LoadHtml(enunciado.Conteudo);
                var enunciadoLimpo = doc.DocumentNode.InnerText;

                var infosCodigo = await BuscarInfosCodigo(enunciadoLimpo);              

                return new InfosBuscadasModel
                {
                    Id = enunciado.Id,
                    Codigo = enunciado.Codigo,
                    Conteudo = enunciado.Conteudo,
                    CodigoNovo = infosCodigo.CodigoNovo,
                    NomeInstituicaoAtual = enunciado.NomeInstituicaoAtual,
                    NomeInstituicaoNovo = infosCodigo.NomeInstituicaoNovo,
                    AnoAtual = enunciado.AnoAtual,
                    AnoNovo = infosCodigo.AnoNovo
                };
            });
            resultados = (await Task.WhenAll(tasks)).ToList();

            WriteExcelFile(resultados);
        }

        static List<InfosBaseModel> ReadCSVFile()
        {
            string inputFilePath = @"C:\Users\bruno\source\repos\projeto-teste\projeto-teste\recuperar-instituicao-ano\lapalace-publicos-recuperar-dados.csv";

            var enunciados = new List<InfosBaseModel>();

            using (StreamReader sr = new StreamReader(inputFilePath))
            {
                string line = sr.ReadLine();

                while ((line = sr.ReadLine()) != null)
                {
                    var values = line.Split(';');

                    if (values.Length >= 5)
                    {
                        string id = values[0];
                        string codigo = values[1];
                        string conteudo = values[2];
                        string nomeInstituicaoAtual = values[3];
                        string anoAtual = values[4];

                        conteudo = conteudo.Replace("\\", "");
                        conteudo = conteudo.Trim('"');

                        enunciados.Add(new InfosBaseModel
                        {
                            Id = id,
                            Codigo = codigo,
                            Conteudo = conteudo,
                            NomeInstituicaoAtual = nomeInstituicaoAtual,
                            AnoAtual = anoAtual
                        });
                    }
                }
            }

            return enunciados;
        }

        static async Task<InfosBuscadasModel> BuscarInfosCodigo(string enunciadoLimpo)
        {
            //var objetoCriacao = new BodyGPT()
            //{
            //    model = "gpt-4o",
            //    messages = new List<Messages>()
            //    {
            //        new Messages()
            //        {
            //            role = "user",
            //            content = $"Forneça apenas o nome da instituição (busque a abreviação caso venha o nome inteiro da instituição), o ano em que a questão foi aplicada e a posição que ela esteve nessa avaliação (número da questão). Use o seguinte enunciado para encontrar as informações: {enunciado}. O formato da resposta deve ser: nomeInstituição_ano_posição. Apenas forneça essas informações, sem adicionar o enunciado ou outras informações fora do que foi pedido."
            //        }
            //    }
            //};

            //var result = (await api.Completions.CreateCompletionAsync(new CompletionRequest
            //{
            //    Prompt = objetoCriacao.messages[0].content,
            //    Temperature = 0.5
            //})).Completions[0].Text.Trim();

            //var partes = result.Split('_');

            string[] partes = new string[3];

            if (enunciadoLimpo == " A figura abaixo representa 4 balan&#xE7,as perfeitamente equilibradas.O valor do peso x &#xE9, igual a:")
            {
                partes = new string[] { "Saeb", "2022", "21" };
            }

            if (enunciadoLimpo == " Uma r&#xE3, est&#xE1, no in&#xED,cio de uma faixa el&#xE1,stica de 2 metros de comprimento. Para chegar ao final da faixa ela d&#xE1, sucessivos saltos de 1 metro de dist&#xE2,ncia, mas, ap&#xF3,s cada salto da r&#xE3,, a faixa sofre um alongamento de 1 metro. Dessa forma podemos concluir que:")
            {
                partes = new string[] { "Fuvest", "2012", "38" };
            }

            if (enunciadoLimpo == " A figura abaixo mostra a planta de um sal&#xE3,o comercial ligado a um mezanino por meio de uma escada. Mostra tamb&#xE9,m um detalhe de cada degrau. A propor&#xE7,&#xE3,o entre as medidas do espelho e do piso do degrau &#xE9, de 2:3.Podemos concluir que a altura do piso do mezanino em rela&#xE7,&#xE3,o ao piso do sal&#xE3,o &#xE9, de:")
            {
                partes = new string[] { "Enem", "2015", "137" };
            }

            if (enunciadoLimpo == " O conjunto solu&#xE7,&#xE3,o da equa&#xE7,&#xE3,o logx+log(x&#x2212,4)=log45 &#xE9,:")
            {
                partes = new string[] { "Enem", "2014", "154" };
            }

            if (enunciadoLimpo == " Seja y=f(x) uma fun&#xE7,&#xE3,o do primeiro grau tal que f(0)=1 e (f&#x2218,f)(1)=1. O gr&#xE1,fico que melhor representa essa fun&#xE7,&#xE3,o &#xE9,:")
            {
                partes = new string[] { "Fatec", "2023", "20" };
            }

            else if (partes[0] == null)
                Console.WriteLine("Questão não encontrada");

            if (partes.Length >= 3 && partes[0] != null)
            {
                partes[0] = partes[0].ToUpper();
                return new InfosBuscadasModel
                {
                    CodigoNovo = $"PUBLICA_{partes[0]}_{partes[1]}_{partes[2]}",
                    NomeInstituicaoNovo = partes[0],
                    AnoNovo = partes[1]
                };
            }

            return new InfosBuscadasModel
            {
                CodigoNovo = "Erro ao processar o código",
                NomeInstituicaoNovo = "Erro ao processar o nome da instituição",
                AnoNovo = "Erro ao processar o ano"
            };
        }

        static void WriteExcelFile(List<InfosBuscadasModel> resultados)
        {
            var outputFilePath = @"C:\Users\bruno\source\repos\projeto-teste\projeto-teste\recuperar-instituicao-ano\lapalace-publicos-recuperar-dados.xlsx";

            using (var package = new ExcelPackage(new FileInfo(outputFilePath)))
            {
                ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
                        
                ExcelWorksheet worksheet = package.Workbook.Worksheets["itens publicos de instituicoes"];

                foreach (var item in resultados)
                {
                    if (item.Codigo == item.CodigoNovo && item.NomeInstituicaoAtual == item.NomeInstituicaoNovo &&
                        item.AnoAtual == item.AnoNovo)
                        Console.WriteLine("Todos as colunas já estão atualizadas");

                    else
                    {
                        int row = 2;
                        bool encontrado = false;

                        for (; row <= worksheet.Dimension.Rows; row++)
                        {
                            if (worksheet.Cells[row, 1].Text == item.Id)
                            {
                                encontrado = true;
                                break;
                            }
                        }

                        if (encontrado)
                        {
                            worksheet.Cells[row, 2].Value = item.CodigoNovo != item.Codigo ? item.CodigoNovo : worksheet.Cells[row, 2].Value;
                            worksheet.Cells[row, 4].Value = item.NomeInstituicaoNovo != item.NomeInstituicaoAtual ? item.NomeInstituicaoNovo : worksheet.Cells[row, 4].Value;
                            worksheet.Cells[row, 5].Value = item.AnoNovo != item.AnoAtual ? item.AnoNovo : worksheet.Cells[row, 5].Value;
                        }
                    }
                    
                }
                package.SaveAs(new FileInfo(outputFilePath));
            }
        }
    }
}