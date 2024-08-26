using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using iText.Kernel.Pdf;
using iText.Kernel.Pdf.Canvas.Parser;
using iText.Kernel.Pdf.Canvas.Parser.Listener;
using iText.Kernel.Utils;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ProjetoPDF
{
    class PDF
    {
        string desktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

        //public byte[] Combine(IEnumerable<byte[]> pdfs)
        //{
        //    using (var writerMemoryStream = new MemoryStream())
        //    {
        //        using (var writer = new PdfWriter(writerMemoryStream))
        //        {
        //            using (var mergedDocument = new PdfDocument(writer))
        //            {
        //                var merger = new PdfMerger(mergedDocument);

        //                foreach (var pdfBytes in pdfs)
        //                {
        //                    using (var copyFromMemoryStream = new MemoryStream(pdfBytes))
        //                    {
        //                        using (var reader = new PdfReader(copyFromMemoryStream))
        //                        {
        //                            using (var copyFromDocument = new PdfDocument(reader))
        //                            {
        //                                merger.Merge(copyFromDocument, 1, copyFromDocument.GetNumberOfPages());
        //                            }
        //                        }
        //                    }
        //                }
        //            }
        //        }

        //        return writerMemoryStream.ToArray();
        //    }
        //}
        public void Renomear(string diretorio)
        {
            string[] arquivos = Directory.GetFiles(diretorio);
            string result = null;
            string validação = null;
            int num;

            for (int i = 0; i < arquivos.Length; i++)
            {
                PdfReader pdfReader = new PdfReader(arquivos[i]);
                PdfDocument pdfdoc = new PdfDocument(pdfReader);

                for (int x = 1; x <= pdfdoc.GetNumberOfPages(); x++)
                {
                    ITextExtractionStrategy strategy = new SimpleTextExtractionStrategy();
                    string conteudo = PdfTextExtractor.GetTextFromPage(pdfdoc.GetPage(x), strategy);
                    result += conteudo;
                }
                pdfdoc.Close();
                pdfReader.Close();

                int acharPedido = result.IndexOf("Número pedido ERP");

                validação = result.Substring(acharPedido - 7, 6).Trim().Length <= 6 ? result.Substring(acharPedido - 7, 6) : "false";

                if (validação.Contains(":"))
                {
                    acharPedido = result.IndexOf("Número pedido");
                    result = result.Substring(acharPedido - 7, 6);
                }
                else
                {
                    result = validação;
                }

                FileInfo files = new FileInfo(arquivos[i]);

                var nomeArquivo = files.Name.Replace(files.Name, result + ".pdf");

                if (!File.Exists(Path.Combine(diretorio, nomeArquivo)))
                {
                    files.CopyTo(Path.Combine(diretorio, nomeArquivo));
                    files.Delete();
                    result = "";
                }
                else if (!files.Name.Contains(result))
                {
                    var Pedidorepetido = 1;
                    while(File.Exists(Path.Combine(diretorio, nomeArquivo)))
                    {
                        nomeArquivo = files.Name.Replace(files.Name, result + " - " + Pedidorepetido + ".pdf");
                        Pedidorepetido++;
                    }
                    files.CopyTo(Path.Combine(diretorio, nomeArquivo));
                    files.Delete();
                    result = "";
                }

            }

            MessageBox.Show("Pedidos renomeados com sucesso!");
        }

        public string Separar(string origem, string destino, bool sobrepor, string lista)
        {
            lista = lista.Replace(" ", "");
            string[] Pedidos = lista.Split(',');
            string dirSaida = desktop + @"\PDFs Separados\";
            List<string> pedidosNaoEncotrados = new List<string>();
  

            for (int i = 0; i < Pedidos.Length; i++)
            {
                if (destino != @"\" && File.Exists(Path.Combine(origem, Pedidos[i] + ".pdf")))
                {
                    File.Copy(origem + Pedidos[i] + ".pdf", destino + Pedidos[i] + ".pdf", sobrepor);
                }
                else
                {
                    pedidosNaoEncotrados.Add(Pedidos[i]);
                }
            }

            string mensgem = String.Join(", ", pedidosNaoEncotrados);

            if (pedidosNaoEncotrados.Count() == 0)
                MessageBox.Show("Copia efetuada");
            else
            {
                MessageBox.Show($"Copia efetuada, porém os seguinte pedidos não foram encontrados: {mensgem}");
                return mensgem;
            }
                
            return "";
        }

        //public void Juntar(string diretorio)
        //{
        //    DirectoryInfo destino = new DirectoryInfo(diretorio);

        //    var pdfList = new List<byte[]> { };

        //    foreach (var file in destino.GetFiles("*.pdf"))
        //    {
        //        pdfList.Add(File.ReadAllBytes(file.FullName));
        //    }

        //    File.WriteAllBytes(diretorio + "\\PDFsUnidos.pdf", Combine(pdfList));
        //}
    }
}
