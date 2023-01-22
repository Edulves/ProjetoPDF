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
    public partial class Juntar : Form
    {
        public Juntar()
        {
            InitializeComponent();
        }

        private void lblDestino_Click(object sender, EventArgs e)
        {
            if (folderBrowser.ShowDialog() != DialogResult.Cancel)
            {
                lblDestino.Text = folderBrowser.SelectedPath;
            }
        }

        private void btnJuntar_Click(object sender, EventArgs e)
        {
            PDF pdf = new PDF();
            if (lblDestino.Text != "Clique para selecionar a pasta de destino")
            {
                pdf.Juntar(lblDestino.Text);
            }
            else
            {
                MessageBox.Show("Por favor, selecione o destino");
            }
        }
    }
}
