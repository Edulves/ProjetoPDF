namespace ProjetoPDF
{
    partial class PrimeiraVersao
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
            this.btnJuntar = new System.Windows.Forms.Button();
            this.btnSeparar = new System.Windows.Forms.Button();
            this.btnRenomear = new System.Windows.Forms.Button();
            this.lblDestino = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblOrigem = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnJuntar
            // 
            this.btnJuntar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnJuntar.Location = new System.Drawing.Point(377, 112);
            this.btnJuntar.Name = "btnJuntar";
            this.btnJuntar.Size = new System.Drawing.Size(147, 51);
            this.btnJuntar.TabIndex = 11;
            this.btnJuntar.Text = "Juntar";
            this.btnJuntar.UseVisualStyleBackColor = true;
            // 
            // btnSeparar
            // 
            this.btnSeparar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeparar.Location = new System.Drawing.Point(209, 112);
            this.btnSeparar.Name = "btnSeparar";
            this.btnSeparar.Size = new System.Drawing.Size(147, 51);
            this.btnSeparar.TabIndex = 10;
            this.btnSeparar.Text = "Separar";
            this.btnSeparar.UseVisualStyleBackColor = true;
            // 
            // btnRenomear
            // 
            this.btnRenomear.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRenomear.Location = new System.Drawing.Point(41, 112);
            this.btnRenomear.Name = "btnRenomear";
            this.btnRenomear.Size = new System.Drawing.Size(147, 51);
            this.btnRenomear.TabIndex = 9;
            this.btnRenomear.Text = "Renomear";
            this.btnRenomear.UseVisualStyleBackColor = true;
            // 
            // lblDestino
            // 
            this.lblDestino.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblDestino.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDestino.Location = new System.Drawing.Point(131, 55);
            this.lblDestino.Name = "lblDestino";
            this.lblDestino.Size = new System.Drawing.Size(393, 24);
            this.lblDestino.TabIndex = 16;
            this.lblDestino.Text = "Clique para selecionar a pasta de destino";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(37, 55);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 24);
            this.label5.TabIndex = 15;
            this.label5.Text = "Destino";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(37, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 24);
            this.label3.TabIndex = 14;
            this.label3.Text = "Origem";
            // 
            // lblOrigem
            // 
            this.lblOrigem.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblOrigem.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrigem.Location = new System.Drawing.Point(131, 17);
            this.lblOrigem.Name = "lblOrigem";
            this.lblOrigem.Size = new System.Drawing.Size(393, 23);
            this.lblOrigem.TabIndex = 13;
            this.lblOrigem.Text = "Clique para selecionar o arquivo de origem";
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 174);
            this.Controls.Add(this.lblDestino);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblOrigem);
            this.Controls.Add(this.btnJuntar);
            this.Controls.Add(this.btnSeparar);
            this.Controls.Add(this.btnRenomear);
            this.Name = "Menu";
            this.Text = "Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnJuntar;
        private System.Windows.Forms.Button btnSeparar;
        private System.Windows.Forms.Button btnRenomear;
        private System.Windows.Forms.Label lblDestino;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblOrigem;
    }
}