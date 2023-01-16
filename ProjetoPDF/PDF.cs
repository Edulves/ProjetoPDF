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

        public void Renomear()
        {
            
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
