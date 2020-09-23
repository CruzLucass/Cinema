namespace ProjetoCinema
{
    partial class FrmLogin
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.cmdSair = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cmdCadastra = new System.Windows.Forms.Button();
            this.cmdEntrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(105, 94);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(105, 143);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Senha";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(217, 19);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Cine for Fun";
            // 
            // txtNome
            // 
            this.txtNome.AutoCompleteCustomSource.AddRange(new string[] {
            "Lucas",
            "Geovanna",
            "Caio"});
            this.txtNome.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtNome.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(172, 90);
            this.txtNome.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(142, 28);
            this.txtNome.TabIndex = 3;
            // 
            // txtSenha
            // 
            this.txtSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSenha.Location = new System.Drawing.Point(172, 141);
            this.txtSenha.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(81, 28);
            this.txtSenha.TabIndex = 4;
            this.txtSenha.UseSystemPasswordChar = true;
            // 
            // cmdSair
            // 
            this.cmdSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdSair.ForeColor = System.Drawing.Color.Maroon;
            this.cmdSair.Location = new System.Drawing.Point(393, 200);
            this.cmdSair.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmdSair.Name = "cmdSair";
            this.cmdSair.Size = new System.Drawing.Size(61, 29);
            this.cmdSair.TabIndex = 8;
            this.cmdSair.Text = "Sair";
            this.cmdSair.UseVisualStyleBackColor = true;
            this.cmdSair.Click += new System.EventHandler(this.cmdSair_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::ProjetoCinema.Properties.Resources.teste;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(141, 2);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(82, 41);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // cmdCadastra
            // 
            this.cmdCadastra.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdCadastra.ForeColor = System.Drawing.Color.Maroon;
            this.cmdCadastra.Location = new System.Drawing.Point(9, 204);
            this.cmdCadastra.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmdCadastra.Name = "cmdCadastra";
            this.cmdCadastra.Size = new System.Drawing.Size(189, 35);
            this.cmdCadastra.TabIndex = 10;
            this.cmdCadastra.Text = "Novo Cadastro";
            this.cmdCadastra.UseVisualStyleBackColor = true;
            this.cmdCadastra.Click += new System.EventHandler(this.cmdCadastra_Click);
            // 
            // cmdEntrar
            // 
            this.cmdEntrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdEntrar.ForeColor = System.Drawing.Color.Maroon;
            this.cmdEntrar.Location = new System.Drawing.Point(304, 128);
            this.cmdEntrar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmdEntrar.Name = "cmdEntrar";
            this.cmdEntrar.Size = new System.Drawing.Size(91, 41);
            this.cmdEntrar.TabIndex = 6;
            this.cmdEntrar.Text = "Entrar";
            this.cmdEntrar.UseVisualStyleBackColor = true;
            this.cmdEntrar.Click += new System.EventHandler(this.cmdEntrar_Click);
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(481, 250);
            this.Controls.Add(this.cmdCadastra);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.cmdSair);
            this.Controls.Add(this.cmdEntrar);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FrmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.FrmLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Button cmdSair;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button cmdCadastra;
        private System.Windows.Forms.Button cmdEntrar;
    }
}

