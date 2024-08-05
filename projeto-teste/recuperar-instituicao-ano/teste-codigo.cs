using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HtmlAgilityPack;
using OfficeOpenXml;

namespace curso_udemy.recuperar_nome_ano
{
    class teste_codigo
    {
        static void Main(string[] args)
        {
            string filePath = @"C:\Users\bruno\source\repos\projeto-teste\projeto-teste\recuperar-instituicao-ano\lapalace-publicos-teste.xlsx";
            var enunciados = ReadExcelFile(filePath);

            foreach (var enunciado in enunciados)
            {
                var textoLimpo = StripHtmlTags(enunciado);
                Console.WriteLine($"Enunciado limpo: {textoLimpo}");
            }
        }

        static List<string> ReadExcelFile(string filePath)
        {
            var enunciados = new List<string>();

            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;

            using (var package = new ExcelPackage(new FileInfo(filePath)))
            {
                if (package.Workbook.Worksheets.Count == 0)
                {
                    throw new Exception("O arquivo Excel não contém planilhas.");
                }

                ExcelWorksheet worksheet = package.Workbook.Worksheets[0];
                int rowCount = worksheet.Dimension.Rows;

                for (int row = 2; row <= rowCount; row++)
                {
                    string conteudo = worksheet.Cells[row, 3].Text;
                    enunciados.Add(conteudo);
                }
            }

            return enunciados;
        }

        static string StripHtmlTags(string text)
        {
            var doc = new HtmlDocument();
            doc.LoadHtml(text);
            return doc.DocumentNode.InnerText;
        }
    }
}
