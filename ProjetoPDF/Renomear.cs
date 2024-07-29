using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoPDF
{
    public partial class Renomear : Form
    {
        public Renomear()
        {
            InitializeComponent();
        }

        private void lblDestino_Click_1(object sender, EventArgs e)
        {
            if (folderBrowser.ShowDialog() != DialogResult.Cancel)
            {
                lblDestino.Text = folderBrowser.SelectedPath;
            }
        }
        private void btnRenomear_Click(object sender, EventArgs e)
        {
            PDF pdf = new PDF();
            if (lblDestino.Text != "Clique para selecionar a pasta de destino")
            {
                try
                {
                    pdf.Renomear(lblDestino.Text);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocorreu um erro ao tentar salvar o arquivo." + ex.Message);
                }
               
            }
            else
            {
                MessageBox.Show("Por favor, selecione o destino");
            }
        }
    }
}
