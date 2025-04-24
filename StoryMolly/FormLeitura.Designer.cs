namespace StoryMolly
{
    partial class FormLeitura
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.rtbTexto = new System.Windows.Forms.RichTextBox();
            this.pbImagem = new System.Windows.Forms.PictureBox();
            this.btnAnterior = new System.Windows.Forms.Button();
            this.btnProximo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagem)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI Emoji", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(28, 19);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(398, 37);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "O Enigma no Espelho";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rtbTexto
            // 
            this.rtbTexto.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbTexto.Location = new System.Drawing.Point(27, 68);
            this.rtbTexto.Name = "rtbTexto";
            this.rtbTexto.ReadOnly = true;
            this.rtbTexto.Size = new System.Drawing.Size(368, 229);
            this.rtbTexto.TabIndex = 1;
            this.rtbTexto.Text = "";
            // 
            // pbImagem
            // 
            this.pbImagem.Location = new System.Drawing.Point(454, 108);
            this.pbImagem.Name = "pbImagem";
            this.pbImagem.Size = new System.Drawing.Size(162, 148);
            this.pbImagem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbImagem.TabIndex = 2;
            this.pbImagem.TabStop = false;
            // 
            // btnAnterior
            // 
            this.btnAnterior.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnterior.Location = new System.Drawing.Point(27, 312);
            this.btnAnterior.Name = "btnAnterior";
            this.btnAnterior.Size = new System.Drawing.Size(75, 30);
            this.btnAnterior.TabIndex = 4;
            this.btnAnterior.Text = "Voltar";
            this.btnAnterior.UseVisualStyleBackColor = true;
            this.btnAnterior.Click += new System.EventHandler(this.btnAnterior_Click);
            // 
            // btnProximo
            // 
            this.btnProximo.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProximo.Location = new System.Drawing.Point(550, 312);
            this.btnProximo.Name = "btnProximo";
            this.btnProximo.Size = new System.Drawing.Size(75, 30);
            this.btnProximo.TabIndex = 5;
            this.btnProximo.Text = "Próximo";
            this.btnProximo.UseVisualStyleBackColor = true;
            this.btnProximo.Click += new System.EventHandler(this.btnProximo_Click);
            // 
            // FormLeitura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(661, 354);
            this.Controls.Add(this.btnProximo);
            this.Controls.Add(this.btnAnterior);
            this.Controls.Add(this.rtbTexto);
            this.Controls.Add(this.pbImagem);
            this.Controls.Add(this.lblTitulo);
            this.Name = "FormLeitura";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "A humanidade da Molly";
            ((System.ComponentModel.ISupportInitialize)(this.pbImagem)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.RichTextBox rtbTexto;
        private System.Windows.Forms.PictureBox pbImagem;
        private System.Windows.Forms.Button btnAnterior;
        private System.Windows.Forms.Button btnProximo;
    }
}

