using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using iText.Kernel.Pdf;
using iText.Kernel.Pdf.Canvas.Parser;
using iText.Kernel.Pdf.Canvas.Parser.Listener;
using iText.Kernel.Utils;

namespace ProjetoPDF
{
    class PDF
    {
        string desktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

        public byte[] Combine(IEnumerable<byte[]> pdfs)
        {
            using (var writerMemoryStream = new MemoryStream())
            {
                using (var writer = new PdfWriter(writerMemoryStream))
                {
                    using (var mergedDocument = new PdfDocument(writer))
                    {
                        var merger = new PdfMerger(mergedDocument);

                        foreach (var pdfBytes in pdfs)
                        {
                            using (var copyFromMemoryStream = new MemoryStream(pdfBytes))
                            {
                                using (var reader = new PdfReader(copyFromMemoryStream))
                                {
                                    using (var copyFromDocument = new PdfDocument(reader))
                                    {
                                        merger.Merge(copyFromDocument, 1, copyFromDocument.GetNumberOfPages());
                                    }
                                }
                            }
                        }
                    }
                }

                return writerMemoryStream.ToArray();
            }
        }
        public void Renomear(string diretorio)
        {
            string[] arquivos = Directory.GetFiles(diretorio);
            string result = null;
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

                if (int.TryParse(result.Substring(acharPedido - 7, 6), out num))
                {
                    result = result.Substring(acharPedido - 7, 6);
                }
                else
                {
                    acharPedido = result.IndexOf("Número pedido");
                    result = result.Substring(acharPedido - 7, 6);
                }

                try
                {
                    FileInfo files = new FileInfo(arquivos[i]);
                    files.CopyTo(Path.Combine(diretorio, files.Name.Replace(files.Name, result + ".pdf")));
                    files.Delete();
                }
                catch
                {
                }

                result = "";
            }

        }

        public void Separar(string origem, string destino, bool sobrepor, string lista)
        {
            lista = lista.Replace(" ", "");
            string[] Pedidos = lista.Split(',');
            string dirSaida = desktop + @"\PDFs Separados\";

            if (!Directory.Exists(dirSaida))
            {
                Directory.CreateDirectory(dirSaida);
            }

            for (int i = 0; i < Pedidos.Length; i++)
            {
                try
                {
                    if (destino != @"\")
                    {
                        File.Copy(origem + Pedidos[i] + ".pdf", destino + Pedidos[i] + ".pdf", sobrepor);
                    }
                    else
                    {
                        File.Copy(origem + Pedidos[i] + ".pdf", dirSaida + Pedidos[i] + ".pdf", sobrepor);
                    }
                }
                catch
                {
                }
            }
            MessageBox.Show("Copia efetuada");
        }

        public void Juntar(string diretorio)
        {
            DirectoryInfo destino = new DirectoryInfo(diretorio);

            var pdfList = new List<byte[]> { };

            foreach (var file in destino.GetFiles("*.pdf"))
            {
                pdfList.Add(File.ReadAllBytes(file.FullName));
            }

            File.WriteAllBytes(diretorio + "\\PDFsUnidos.pdf", Combine(pdfList));
        }
    }
}
