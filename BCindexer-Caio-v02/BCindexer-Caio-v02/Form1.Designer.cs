namespace BCindexer_Caio_v02
{
    partial class Form1
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
            this.lblCaminhoPasta = new System.Windows.Forms.Label();
            this.btnProcessar = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnEscolherPasta
            // 
            this.btnEscolherPasta.Location = new System.Drawing.Point(44, 47);
            this.btnEscolherPasta.Name = "btnEscolherPasta";
            this.btnEscolherPasta.Size = new System.Drawing.Size(118, 35);
            this.btnEscolherPasta.TabIndex = 0;
            this.btnEscolherPasta.Text = "Escolher pasta";
            this.btnEscolherPasta.UseVisualStyleBackColor = true;
            this.btnEscolherPasta.Click += new System.EventHandler(this.btnEscolherPasta_Click);
            // 
            // lblCaminhoPasta
            // 
            this.lblCaminhoPasta.AutoSize = true;
            this.lblCaminhoPasta.Location = new System.Drawing.Point(178, 56);
            this.lblCaminhoPasta.Name = "lblCaminhoPasta";
            this.lblCaminhoPasta.Size = new System.Drawing.Size(0, 20);
            this.lblCaminhoPasta.TabIndex = 1;
            // 
            // btnProcessar
            // 
            this.btnProcessar.Location = new System.Drawing.Point(477, 68);
            this.btnProcessar.Name = "btnProcessar";
            this.btnProcessar.Size = new System.Drawing.Size(91, 31);
            this.btnProcessar.TabIndex = 2;
            this.btnProcessar.Text = "Processar";
            this.btnProcessar.UseVisualStyleBackColor = true;
            this.btnProcessar.Click += new System.EventHandler(this.btnProcessar_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(274, 351);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(187, 22);
            this.button2.TabIndex = 3;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnProcessar);
            this.Controls.Add(this.lblCaminhoPasta);
            this.Controls.Add(this.btnEscolherPasta);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEscolherPasta;
        private System.Windows.Forms.Label lblCaminhoPasta;
        private System.Windows.Forms.Button btnProcessar;
        private System.Windows.Forms.Button button2;
    }
}

