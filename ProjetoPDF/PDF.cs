using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

            if (!Directory.Exists(dirSaida))
            {
                Directory.CreateDirectory(dirSaida);
            }

            for (int i = 0; i < arquivos.Length; i++)
            {
                FileInfo files = new FileInfo(arquivos[i]);
                files.CopyTo(Path.Combine(dirSaida, files.Name.Replace(files.Name,"teste" + i + ".PDF")));
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
