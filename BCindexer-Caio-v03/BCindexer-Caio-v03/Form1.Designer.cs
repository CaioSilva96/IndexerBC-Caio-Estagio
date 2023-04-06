namespace BCindexer_Caio_v03
{
    partial class MainFormIndexter
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnEscolherPasta = new System.Windows.Forms.Button();
            this.lblPathDir = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnEscolherPasta
            // 
            this.btnEscolherPasta.Location = new System.Drawing.Point(64, 74);
            this.btnEscolherPasta.Name = "btnEscolherPasta";
            this.btnEscolherPasta.Size = new System.Drawing.Size(75, 23);
            this.btnEscolherPasta.TabIndex = 0;
            this.btnEscolherPasta.Text = "button1";
            this.btnEscolherPasta.UseVisualStyleBackColor = true;
            this.btnEscolherPasta.Click += new System.EventHandler(this.btnEscolherPasta_Click);
            // 
            // lblPathDir
            // 
            this.lblPathDir.AutoSize = true;
            this.lblPathDir.Location = new System.Drawing.Point(163, 81);
            this.lblPathDir.Name = "lblPathDir";
            this.lblPathDir.Size = new System.Drawing.Size(44, 16);
            this.lblPathDir.TabIndex = 1;
            this.lblPathDir.Text = "label1";
            // 
            // MainFormIndexter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblPathDir);
            this.Controls.Add(this.btnEscolherPasta);
            this.Name = "MainFormIndexter";
            this.Text = "BCindexer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEscolherPasta;
        private System.Windows.Forms.Label lblPathDir;
    }
}

