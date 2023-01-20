using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoPDF
{
    public partial class Separar : Form
    {
        public Separar()
        {
            InitializeComponent();
        }

        private void lblOrigem_Click_1(object sender, EventArgs e)
        {
            if (folderBrowser2.ShowDialog() != DialogResult.Cancel)
            {
                lblOrigem.Text = folderBrowser2.SelectedPath;
            }
        }

        private void lblDestino_Click_1(object sender, EventArgs e)
        {
            if (folderBrowser.ShowDialog() != DialogResult.Cancel)
            {
                lblDestino.Text = folderBrowser.SelectedPath;
            }
        }

        private void btnSeparar_Click(object sender, EventArgs e)
        {
            PDF pdf = new PDF();

            if (/*lblDestino.Text != "Clique para selecionar a pasta de destino" &&*/ lblOrigem.Text != "Clique para selecionar o arquivo de origem")
            {
                try
                {
                    pdf.Separar(folderBrowser2.SelectedPath + @"\", folderBrowser.SelectedPath + @"\", true, txtLista.Text);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecione o arquivo de origem e o destino");
            }
        }
    }
}
