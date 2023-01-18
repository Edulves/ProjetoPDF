namespace ProjetoPDF
{
    partial class Separar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnSeparar = new System.Windows.Forms.Button();
            this.lblDestino = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblOrigem = new System.Windows.Forms.Label();
            this.openFile = new System.Windows.Forms.OpenFileDialog();
            this.folderBrowser = new System.Windows.Forms.FolderBrowserDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.txtLista = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnSeparar
            // 
            this.btnSeparar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeparar.Location = new System.Drawing.Point(379, 95);
            this.btnSeparar.Name = "btnSeparar";
            this.btnSeparar.Size = new System.Drawing.Size(147, 51);
            this.btnSeparar.TabIndex = 19;
            this.btnSeparar.Text = "Separar";
            this.btnSeparar.UseVisualStyleBackColor = true;
            this.btnSeparar.Click += new System.EventHandler(this.btnSeparar_Click);
            // 
            // lblDestino
            // 
            this.lblDestino.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblDestino.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDestino.Location = new System.Drawing.Point(133, 67);
            this.lblDestino.Name = "lblDestino";
            this.lblDestino.Size = new System.Drawing.Size(393, 24);
            this.lblDestino.TabIndex = 18;
            this.lblDestino.Text = "Clique para selecionar a pasta de destino";
            this.lblDestino.Click += new System.EventHandler(this.lblDestino_Click_1);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(39, 67);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 24);
            this.label5.TabIndex = 17;
            this.label5.Text = "Destino";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(39, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 24);
            this.label3.TabIndex = 23;
            this.label3.Text = "Origem";
            // 
            // lblOrigem
            // 
            this.lblOrigem.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblOrigem.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrigem.Location = new System.Drawing.Point(133, 37);
            this.lblOrigem.Name = "lblOrigem";
            this.lblOrigem.Size = new System.Drawing.Size(393, 23);
            this.lblOrigem.TabIndex = 22;
            this.lblOrigem.Text = "Clique para selecionar o arquivo de origem";
            this.lblOrigem.Click += new System.EventHandler(this.lblOrigem_Click_1);
            // 
            // openFile
            // 
            this.openFile.FileName = "openFileDialog1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(39, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 24);
            this.label1.TabIndex = 25;
            this.label1.Text = "Lista";
            // 
            // txtLista
            // 
            this.txtLista.Location = new System.Drawing.Point(132, 7);
            this.txtLista.Name = "txtLista";
            this.txtLista.Size = new System.Drawing.Size(394, 20);
            this.txtLista.TabIndex = 26;
            // 
            // Separar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 158);
            this.Controls.Add(this.txtLista);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblOrigem);
            this.Controls.Add(this.btnSeparar);
            this.Controls.Add(this.lblDestino);
            this.Controls.Add(this.label5);
            this.Name = "Separar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Separar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSeparar;
        private System.Windows.Forms.Label lblDestino;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblOrigem;
        private System.Windows.Forms.OpenFileDialog openFile;
        private System.Windows.Forms.FolderBrowserDialog folderBrowser;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtLista;
    }
}