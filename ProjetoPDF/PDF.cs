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
                }
                catch (Exception)
                {
                }

                try
                {
                    FileInfo files = new FileInfo(arquivos[i]);
                    files.Delete();
                }
                catch (Exception)
                {
                }

                result = "";
            }

        }

        public void Separar(string origem, string destino, bool sobrepor, string lista)
        {
            string[] arquivos = Directory.GetFiles(destino);
            string[] Pedidos = lista.Split(',');
            string dirSaida = $"{desktop}\\PDFs_Separados\\";
            MessageBox.Show(dirSaida + Pedidos[0].ToString());


            for (int i = 0; i < Pedidos.Length; i++)
            {
                Pedidos[i] = Pedidos[i] + ".pdf";
            }

            if (!Directory.Exists(dirSaida))
            {
                Directory.CreateDirectory(dirSaida);
            }

            for (int i = 0; i < Pedidos.Length; i++)
            {
                if (destino != null)
                {
                    if (!File.Exists(destino + Pedidos[i]))
                    {
                        File.Copy(origem + Pedidos[i], destino + Pedidos[i]);
                    }
                    else
                    {
                        if (MessageBox.Show("Arquivo já existe! \n Deseja sobrepor?", "Copiar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            File.Copy(origem + Pedidos[i], destino + Pedidos[i], sobrepor);
                            MessageBox.Show("Sobreposição efetuada");
                        }
                    }
                }
                else
                {
                    if (!File.Exists(dirSaida + Pedidos[i]))
                    {
                        File.Copy(origem + Pedidos[i], dirSaida + Pedidos[i]);
                    }
                    else
                    {
                        if (MessageBox.Show("Arquivo já existe! \n Deseja sobrepor?", "Copiar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            File.Copy(origem + Pedidos[i], dirSaida + Pedidos[i], sobrepor);
                            MessageBox.Show("Sobreposição efetuada");
                        }
                    }
                }

            }
            MessageBox.Show("Copia efetuada");
        }

        public void Juntar()
        {

        }
    }
}
