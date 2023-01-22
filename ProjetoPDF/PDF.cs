using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iText.Kernel.Pdf;
using iText.Kernel.Pdf.Canvas.Parser;
using iText.Kernel.Pdf.Canvas.Parser.Listener;

namespace ProjetoPDF
{
    class PDF
    {
        string desktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

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

        public void Juntar()
        {

        }
    }
}
