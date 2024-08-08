//using System;
//using System.Collections.Generic;
//using System.IO;
//using System.Linq;
//using System.Threading.Tasks;
//using curso_udemy.recuperar_instituicao_ano;
//using DocumentFormat.OpenXml.Drawing;
//using DocumentFormat.OpenXml.EMMA;
//using DocumentFormat.OpenXml.Office.CustomUI;
//using DocumentFormat.OpenXml.Office2016.Drawing.Command;
//using HtmlAgilityPack;
//using OfficeOpenXml;
//using OpenAI_API;
//using OpenAI_API.Completions;
//using static curso_udemy.recuperar_instituicao_ano.GptModel;
//using static curso_udemy.recuperar_instituicao_ano.InfosBaseModel;
//using static curso_udemy.recuperar_instituicao_ano.InfosBuscadasModel;

//namespace curso_udemy.recuperar_nome_ano
//{
//    class teste_api_gpt
//    {
//        static async Task Main(string[] args)
//        {
//            await ProcessarEnunciados();
//        }

//        static async Task ProcessarEnunciados()
//        {
//            var enunciados = ReadCSVFile();
//            var resultados = new List<InfosBuscadasModel>();

//            var enunciadosLimpos = enunciados.Select(enunciado =>
//            {
//                var doc = new HtmlDocument();
//                doc.LoadHtml(enunciado.Conteudo);
//                return doc.DocumentNode.InnerText;
//            }).ToList();

//            var infosBuscadas = await BuscarInfosCodigo(enunciadosLimpos);

//            for (int i = 0; i < enunciados.Count; i++)
//            {
//                var enunciado = enunciados[i];
//                var infosCodigo = infosBuscadas.ElementAtOrDefault(i);

//                resultados.Add(new InfosBuscadasModel
//                {
//                    Id = enunciado.Id,
//                    Codigo = enunciado.Codigo,
//                    Conteudo = enunciado.Conteudo,
//                    CodigoNovo = infosCodigo.CodigoNovo,
//                    NomeInstituicaoAtual = enunciado.NomeInstituicaoAtual,
//                    NomeInstituicaoNovo = infosCodigo.NomeInstituicaoNovo,
//                    AnoAtual = enunciado.AnoAtual,
//                    AnoNovo = infosCodigo.AnoNovo
//                });
//            };

//            UpdateCSVFile(resultados, enunciados);
//        }

//        static List<InfosBaseModel> ReadCSVFile()
//        {
//            string inputFilePath = @"C:\Users\bruno\source\repos\projeto-teste\projeto-teste\recuperar-instituicao-ano\lapalace-publicos-recuperar-dados.csv";

//            var enunciados = new List<InfosBaseModel>();

//            using (StreamReader sr = new StreamReader(inputFilePath))
//            {
//                string header = sr.ReadLine();
//                string line;

//                while ((line = sr.ReadLine()) != null)
//                {
//                    var values = line.Split(';');

//                    if (values.Length >= 5)
//                    {
//                        string id = values[0];
//                        string codigo = values[1];
//                        string conteudo = values[2];
//                        string nomeInstituicaoAtual = values[3];
//                        string anoAtual = values[4];

//                        conteudo = conteudo.Replace("\\", "");
//                        conteudo = conteudo.Trim('"');

//                        enunciados.Add(new InfosBaseModel
//                        {
//                            Id = id,
//                            Codigo = codigo,
//                            Conteudo = conteudo,
//                            NomeInstituicaoAtual = nomeInstituicaoAtual,
//                            AnoAtual = anoAtual
//                        });
//                    }
//                }
//            }

//            return enunciados;
//        }

//        static async Task<List<InfosBuscadasModel>> BuscarInfosCodigo(List<string> enunciadosLimpos)
//        {
//            //var objetoCriacao = new BodyGPT()
//            //{
//            //    model = "gpt-4o",
//            //    messages = new List<Messages>()
//            //    {
//            //        new Messages()
//            //        {
//            //            role = "user",
//            //            content = $"Forneça apenas o nome da instituição (busque a abreviação caso venha o nome inteiro da instituição), o ano em que a questão foi aplicada e a posição que ela esteve nessa avaliação (número da questão). Use o seguinte enunciado para encontrar as informações: {enunciado}. O formato da resposta deve ser: nomeInstituição_ano_posição. Apenas forneça essas informações, sem adicionar o enunciado ou outras informações fora do que foi pedido."
//            //        }
//            //    }
//            //};

//            //var result = (await api.Completions.CreateCompletionAsync(new CompletionRequest
//            //{
//            //    Prompt = objetoCriacao.messages[0].content,
//            //    Temperature = 0.5
//            //})).Completions[0].Text.Trim();

//            //var partes = result.Split('_');

//            var resultados = new List<InfosBuscadasModel>();

//            foreach (var enunciadoLimpo in enunciadosLimpos)
//            {
//                string[] partes = new string[3];

//                if (enunciadoLimpo == " A figura abaixo representa 4 balan&#xE7,as perfeitamente equilibradas.O valor do peso x &#xE9, igual a:")
//                {
//                    partes = new string[] { "Saeb", "2022", "21" };
//                }

//                if (enunciadoLimpo == " Uma r&#xE3, est&#xE1, no in&#xED,cio de uma faixa el&#xE1,stica de 2 metros de comprimento. Para chegar ao final da faixa ela d&#xE1, sucessivos saltos de 1 metro de dist&#xE2,ncia, mas, ap&#xF3,s cada salto da r&#xE3,, a faixa sofre um alongamento de 1 metro. Dessa forma podemos concluir que:")
//                {
//                    partes = new string[] { "Fuvest", "2012", "38" };
//                }

//                if (enunciadoLimpo == " A figura abaixo mostra a planta de um sal&#xE3,o comercial ligado a um mezanino por meio de uma escada. Mostra tamb&#xE9,m um detalhe de cada degrau. A propor&#xE7,&#xE3,o entre as medidas do espelho e do piso do degrau &#xE9, de 2:3.Podemos concluir que a altura do piso do mezanino em rela&#xE7,&#xE3,o ao piso do sal&#xE3,o &#xE9, de:")
//                {
//                    partes = new string[] { "Enem", "2015", "137" };
//                }

//                if (enunciadoLimpo == " O conjunto solu&#xE7,&#xE3,o da equa&#xE7,&#xE3,o logx+log(x&#x2212,4)=log45 &#xE9,:")
//                {
//                    partes = new string[] { "Enem", "2014", "154" };
//                }

//                if (enunciadoLimpo == " Seja y=f(x) uma fun&#xE7,&#xE3,o do primeiro grau tal que f(0)=1 e (f&#x2218,f)(1)=1. O gr&#xE1,fico que melhor representa essa fun&#xE7,&#xE3,o &#xE9,:")
//                {
//                    partes = new string[] { "Fatec", "2023", "20" };
//                }

//                else if (partes[0] == null)
//                    Console.WriteLine("Questão não encontrada");

//                if (partes.Length >= 3 && partes[0] != null)
//                {
//                    partes[0] = partes[0].ToUpper();
//                    resultados.Add (new InfosBuscadasModel
//                    {
//                        CodigoNovo = $"PUBLICA_{partes[0]}_{partes[1]}_{partes[2]}",
//                        NomeInstituicaoNovo = partes[0],
//                        AnoNovo = partes[1]
//                    });
//                }
//            }
//            return resultados;
//        }

//        static void UpdateCSVFile(List<InfosBuscadasModel> resultados, List<InfosBaseModel> enunciados)
//        {
//            var outputFilePath = @"C:\Users\bruno\source\repos\projeto-teste\projeto-teste\recuperar-instituicao-ano\lapalace-publicos-recuperar-dados.CSV";
//            var enunciadosDictionary = enunciados.ToDictionary(e => e.Id);
//            var enunciadosAtualizados = new Dictionary<string, InfosBaseModel>();
//            bool houveMudanca = false;

//            foreach (var enunciado in enunciados)
//            {
//                var resultado = resultados.FirstOrDefault(r => r.Id == enunciado.Id);

//                if (resultado != null)
//                {
//                    bool precisaAtualizar = false;

//                    if (resultado.CodigoNovo != enunciado.Codigo)
//                    {
//                        enunciado.Codigo = resultado.CodigoNovo;
//                        precisaAtualizar = true;
//                    }
//                    if (resultado.NomeInstituicaoNovo != enunciado.NomeInstituicaoAtual)
//                    {
//                        enunciado.NomeInstituicaoAtual = resultado.NomeInstituicaoNovo;
//                        precisaAtualizar = true;
//                    }
//                    if (resultado.AnoNovo != enunciado.AnoAtual)
//                    {
//                        enunciado.AnoAtual = resultado.AnoNovo;
//                        precisaAtualizar = true;
//                    }
//                    if (precisaAtualizar)
//                    {
//                        houveMudanca = true;
//                        enunciadosAtualizados[enunciado.Id] = enunciado;
//                    }
//                }
//                else
//                    Console.WriteLine("Id não encontrado");
//            }

//            if (houveMudanca)
//            {
//                using (var sw = new StreamWriter(outputFilePath))
//                {
//                    sw.WriteLine("Id;Codigo;Conteudo;Nome_Instituicao;Ano");

//                    foreach (var enunciado in enunciados)
//                    {
//                        if (enunciadosAtualizados.TryGetValue(enunciado.Id, out var enunciadoAtualizado))
//                        {
//                            sw.WriteLine($"{enunciadoAtualizado.Id};{enunciadoAtualizado.Codigo};{enunciadoAtualizado.Conteudo};{enunciadoAtualizado.NomeInstituicaoAtual};{enunciadoAtualizado.AnoAtual}");
//                        }
//                        else
//                        {
//                            sw.WriteLine($"{enunciado.Id};{enunciado.Codigo};{enunciado.Conteudo};{enunciado.NomeInstituicaoAtual};{enunciado.AnoAtual}");
//                        }
//                    }
//                }
//            }
//        }
//    }
//}