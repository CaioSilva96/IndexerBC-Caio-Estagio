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
            this.NDir = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnEscolherPasta
            // 
            this.btnEscolherPasta.Location = new System.Drawing.Point(48, 60);
            this.btnEscolherPasta.Margin = new System.Windows.Forms.Padding(2);
            this.btnEscolherPasta.Name = "btnEscolherPasta";
            this.btnEscolherPasta.Size = new System.Drawing.Size(56, 19);
            this.btnEscolherPasta.TabIndex = 0;
            this.btnEscolherPasta.Text = "Escolher Pasta";
            this.btnEscolherPasta.UseVisualStyleBackColor = true;
            this.btnEscolherPasta.Click += new System.EventHandler(this.btnEscolherPasta_Click);
            // 
            // lblPathDir
            // 
            this.lblPathDir.AutoSize = true;
            this.lblPathDir.Location = new System.Drawing.Point(122, 66);
            this.lblPathDir.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPathDir.Name = "lblPathDir";
            this.lblPathDir.Size = new System.Drawing.Size(0, 13);
            this.lblPathDir.TabIndex = 1;
            // 
            // NDir
            // 
            this.NDir.AutoSize = true;
            this.NDir.Location = new System.Drawing.Point(122, 79);
            this.NDir.Name = "NDir";
            this.NDir.Size = new System.Drawing.Size(35, 13);
            this.NDir.TabIndex = 2;
            this.NDir.Text = "label1";
            // 
            // MainFormIndexter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.NDir);
            this.Controls.Add(this.lblPathDir);
            this.Controls.Add(this.btnEscolherPasta);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainFormIndexter";
            this.Text = "BCindexer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEscolherPasta;
        private System.Windows.Forms.Label lblPathDir;
        private System.Windows.Forms.Label NDir;
    }
}

