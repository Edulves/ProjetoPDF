namespace ProjetoPDF
{
    partial class Renomear
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
            this.btnRenomear = new System.Windows.Forms.Button();
            this.lblDestino = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.folderBrowser = new System.Windows.Forms.FolderBrowserDialog();
            this.SuspendLayout();
            // 
            // btnRenomear
            // 
            this.btnRenomear.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRenomear.Location = new System.Drawing.Point(379, 79);
            this.btnRenomear.Name = "btnRenomear";
            this.btnRenomear.Size = new System.Drawing.Size(147, 51);
            this.btnRenomear.TabIndex = 16;
            this.btnRenomear.Text = "Renomear";
            this.btnRenomear.UseVisualStyleBackColor = true;
            this.btnRenomear.Click += new System.EventHandler(this.btnRenomear_Click);
            // 
            // lblDestino
            // 
            this.lblDestino.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblDestino.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDestino.Location = new System.Drawing.Point(133, 28);
            this.lblDestino.Name = "lblDestino";
            this.lblDestino.Size = new System.Drawing.Size(393, 24);
            this.lblDestino.TabIndex = 15;
            this.lblDestino.Text = "Clique para selecionar a pasta de destino";
            this.lblDestino.Click += new System.EventHandler(this.lblDestino_Click_1);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(39, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 24);
            this.label5.TabIndex = 14;
            this.label5.Text = "Destino";
            // 
            // Renomear
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 158);
            this.Controls.Add(this.btnRenomear);
            this.Controls.Add(this.lblDestino);
            this.Controls.Add(this.label5);
            this.Name = "Renomear";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Renomear";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRenomear;
        private System.Windows.Forms.Label lblDestino;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.FolderBrowserDialog folderBrowser;
    }
}