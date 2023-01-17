namespace ProjetoPDF
{
    partial class Menu
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
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnJuntar
            // 
            this.btnJuntar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnJuntar.Location = new System.Drawing.Point(377, 82);
            this.btnJuntar.Name = "btnJuntar";
            this.btnJuntar.Size = new System.Drawing.Size(147, 51);
            this.btnJuntar.TabIndex = 11;
            this.btnJuntar.Text = "Juntar";
            this.btnJuntar.UseVisualStyleBackColor = true;
            // 
            // btnSeparar
            // 
            this.btnSeparar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeparar.Location = new System.Drawing.Point(209, 82);
            this.btnSeparar.Name = "btnSeparar";
            this.btnSeparar.Size = new System.Drawing.Size(147, 51);
            this.btnSeparar.TabIndex = 10;
            this.btnSeparar.Text = "Separar";
            this.btnSeparar.UseVisualStyleBackColor = true;
            // 
            // btnRenomear
            // 
            this.btnRenomear.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRenomear.Location = new System.Drawing.Point(41, 82);
            this.btnRenomear.Name = "btnRenomear";
            this.btnRenomear.Size = new System.Drawing.Size(147, 51);
            this.btnRenomear.TabIndex = 9;
            this.btnRenomear.Text = "Renomear";
            this.btnRenomear.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(38, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(486, 43);
            this.label1.TabIndex = 12;
            this.label1.Text = "Selecione o serviço";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 158);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnJuntar);
            this.Controls.Add(this.btnSeparar);
            this.Controls.Add(this.btnRenomear);
            this.Name = "Menu";
            this.Text = "Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnJuntar;
        private System.Windows.Forms.Button btnSeparar;
        private System.Windows.Forms.Button btnRenomear;
        private System.Windows.Forms.Label label1;
    }
}