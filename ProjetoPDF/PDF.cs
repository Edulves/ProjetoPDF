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
        //private List<string> Pedidos;
        //private string pedido;
        string desktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

        public void Renomear(string diretorio)
        {
            string[] arquivos = Directory.GetFiles(diretorio);
            string dirSaida = $"{desktop}\\PDFsRenomeados";
            string result = null;
            int num;

            if (!Directory.Exists(dirSaida))
            {
                Directory.CreateDirectory(dirSaida);
            }

            for (int i = 0; i < arquivos.Length; i++)
            {
                PdfReader pdfReader = new PdfReader(arquivos[i]);
                PdfDocument pdfdoc = new PdfDocument(pdfReader);

                for (int x = 1; x <= pdfdoc.GetNumberOfPages(); x++)
                {
                    ITextExtractionStrategy strategy = new SimpleTextExtractionStrategy();
                    string contedudo = PdfTextExtractor.GetTextFromPage(pdfdoc.GetPage(x), strategy);
                    result += contedudo;
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

                MessageBox.Show(result);

                FileInfo files = new FileInfo(arquivos[i]);
                files.CopyTo(Path.Combine(dirSaida, files.Name.Replace(files.Name, result + ".pdf")));

                result = "";
            }

        }

        public void Separar(string origem,string destino, bool sobrepor)
        {
            if (!File.Exists(destino))
            {
                File.Copy(origem, destino);
                MessageBox.Show("Copia efetuada");
            }
            else
            {
                if (MessageBox.Show("Arquivo já existe! \n Deseja sobrepor?", "Copiar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    File.Copy(origem, destino, sobrepor);
                    MessageBox.Show("Copia efetuada");
                }
            }
        }

        public void Juntar()
        {

        }
    }
}
