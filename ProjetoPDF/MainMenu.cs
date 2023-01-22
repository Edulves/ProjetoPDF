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
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }


        #region backup do código original
        //private void lblOrigem_Click(object sender, EventArgs e)
        //{
        //    if (openFile.ShowDialog() != DialogResult.Cancel)
        //    {
        //        lblOrigem.Text = openFile.FileName;
        //    }
        //}

        //private void lblDestino_Click(object sender, EventArgs e)
        //{
        //    if (folderBrowser.ShowDialog() != DialogResult.Cancel)
        //    {
        //        lblDestino.Text = folderBrowser.SelectedPath;
        //    }
        //}

        //private void btnSeparar_Click(object sender, EventArgs e)
        //{
        //    PDF pdf = new PDF();
        //    FileInfo origem = new FileInfo(openFile.FileName);
        //    if (lblDestino.Text != "Clique para selecionar a pasta de destino" && lblOrigem.Text != "Clique para selecionar o arquivo de origem")
        //    {
        //        try
        //        {
        //            pdf.Separar(openFile.FileName, folderBrowser.SelectedPath + @"\" + origem.Name, true);
        //        }
        //        catch (Exception ex)
        //        {
        //            MessageBox.Show(ex.Message);
        //        }
        //    }
        //    else
        //    {
        //        MessageBox.Show("Por favor, selecione o arquivo de origem e o destino");
        //    }
        //}

        //private void btnRenomear_Click(object sender, EventArgs e)
        //{
        //    PDF pdf = new PDF();
        //    if (lblDestino.Text != "Clique para selecionar a pasta de destino")
        //    {
        //        pdf.Renomear(lblDestino.Text);
        //    }
        //    else
        //    {
        //        MessageBox.Show("Por favor, selecione o destino");
        //    }
        //}
        #endregion

        private void btnRenomear_Click(object sender, EventArgs e)
        {
            Hide();
            Renomear renomear = new Renomear();
            renomear.ShowDialog();
            Show();
        }

        private void btnSeparar_Click(object sender, EventArgs e)
        {
            Hide();
            Separar separar = new Separar();
            separar.ShowDialog();
            Show();
        }
    }
}
