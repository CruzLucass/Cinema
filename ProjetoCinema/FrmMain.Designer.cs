namespace ProjetoCinema
{
    partial class FrmMain
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cadastroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastraFilmeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calendarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtDuracao = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmdConfirma = new System.Windows.Forms.Button();
            this.cmdCancelar = new System.Windows.Forms.Button();
            this.txtClassificacao = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtGenero = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmdVoltar = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Maroon;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastroToolStripMenuItem,
            this.cadastraFilmeToolStripMenuItem,
            this.calendarioToolStripMenuItem,
            this.salasToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1441, 29);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cadastroToolStripMenuItem
            // 
            this.cadastroToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cadastroToolStripMenuItem.Name = "cadastroToolStripMenuItem";
            this.cadastroToolStripMenuItem.Size = new System.Drawing.Size(172, 25);
            this.cadastroToolStripMenuItem.Text = "Cadastrar Vendedor";
            this.cadastroToolStripMenuItem.Click += new System.EventHandler(this.cadastroToolStripMenuItem_Click);
            // 
            // cadastraFilmeToolStripMenuItem
            // 
            this.cadastraFilmeToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cadastraFilmeToolStripMenuItem.Name = "cadastraFilmeToolStripMenuItem";
            this.cadastraFilmeToolStripMenuItem.Size = new System.Drawing.Size(140, 25);
            this.cadastraFilmeToolStripMenuItem.Text = "Cadastrar Filme";
            this.cadastraFilmeToolStripMenuItem.Click += new System.EventHandler(this.cadastraFilmeToolStripMenuItem_Click);
            // 
            // calendarioToolStripMenuItem
            // 
            this.calendarioToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calendarioToolStripMenuItem.Name = "calendarioToolStripMenuItem";
            this.calendarioToolStripMenuItem.Size = new System.Drawing.Size(98, 25);
            this.calendarioToolStripMenuItem.Text = "Em Cartaz";
            this.calendarioToolStripMenuItem.Click += new System.EventHandler(this.calendarioToolStripMenuItem_Click);
            // 
            // salasToolStripMenuItem
            // 
            this.salasToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salasToolStripMenuItem.Name = "salasToolStripMenuItem";
            this.salasToolStripMenuItem.Size = new System.Drawing.Size(70, 25);
            this.salasToolStripMenuItem.Text = "Venda";
            this.salasToolStripMenuItem.Click += new System.EventHandler(this.salasToolStripMenuItem_Click);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(51, 25);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.Color.Maroon;
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(720, 144);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(721, 444);
            this.listBox1.TabIndex = 1;
            this.listBox1.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(1014, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 26);
            this.label1.TabIndex = 2;
            this.label1.Text = "Em Cartaz";
            this.label1.Visible = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Maroon;
            this.panel1.Controls.Add(this.txtDuracao);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.cmdConfirma);
            this.panel1.Controls.Add(this.cmdCancelar);
            this.panel1.Controls.Add(this.txtClassificacao);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtGenero);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtTitulo);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(151, 144);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(447, 459);
            this.panel1.TabIndex = 3;
            this.panel1.Visible = false;
            // 
            // txtDuracao
            // 
            this.txtDuracao.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDuracao.Location = new System.Drawing.Point(178, 211);
            this.txtDuracao.Name = "txtDuracao";
            this.txtDuracao.Size = new System.Drawing.Size(126, 28);
            this.txtDuracao.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(16, 214);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(160, 24);
            this.label6.TabIndex = 11;
            this.label6.Text = "Tempo Duração";
            // 
            // cmdConfirma
            // 
            this.cmdConfirma.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdConfirma.ForeColor = System.Drawing.Color.Maroon;
            this.cmdConfirma.Location = new System.Drawing.Point(269, 390);
            this.cmdConfirma.Name = "cmdConfirma";
            this.cmdConfirma.Size = new System.Drawing.Size(111, 36);
            this.cmdConfirma.TabIndex = 10;
            this.cmdConfirma.Text = "Confirmar";
            this.cmdConfirma.UseVisualStyleBackColor = true;
            this.cmdConfirma.Click += new System.EventHandler(this.cmdConfirma_Click);
            // 
            // cmdCancelar
            // 
            this.cmdCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdCancelar.ForeColor = System.Drawing.Color.Maroon;
            this.cmdCancelar.Location = new System.Drawing.Point(76, 390);
            this.cmdCancelar.Name = "cmdCancelar";
            this.cmdCancelar.Size = new System.Drawing.Size(91, 36);
            this.cmdCancelar.TabIndex = 9;
            this.cmdCancelar.Text = "Fechar";
            this.cmdCancelar.UseVisualStyleBackColor = true;
            this.cmdCancelar.Click += new System.EventHandler(this.cmdCancelar_Click);
            // 
            // txtClassificacao
            // 
            this.txtClassificacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClassificacao.Location = new System.Drawing.Point(178, 155);
            this.txtClassificacao.Name = "txtClassificacao";
            this.txtClassificacao.Size = new System.Drawing.Size(53, 28);
            this.txtClassificacao.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(40, 155);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(131, 24);
            this.label5.TabIndex = 5;
            this.label5.Text = "Classificação";
            // 
            // txtGenero
            // 
            this.txtGenero.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGenero.Location = new System.Drawing.Point(178, 103);
            this.txtGenero.Name = "txtGenero";
            this.txtGenero.Size = new System.Drawing.Size(126, 28);
            this.txtGenero.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(82, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 24);
            this.label4.TabIndex = 3;
            this.label4.Text = "Gênero";
            // 
            // txtTitulo
            // 
            this.txtTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTitulo.Location = new System.Drawing.Point(178, 50);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(240, 28);
            this.txtTitulo.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(92, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 24);
            this.label3.TabIndex = 1;
            this.label3.Text = "Titulo ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(122, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(177, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "Cadastre um filme";
            // 
            // cmdVoltar
            // 
            this.cmdVoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdVoltar.ForeColor = System.Drawing.Color.Maroon;
            this.cmdVoltar.Location = new System.Drawing.Point(632, 542);
            this.cmdVoltar.Name = "cmdVoltar";
            this.cmdVoltar.Size = new System.Drawing.Size(82, 46);
            this.cmdVoltar.TabIndex = 4;
            this.cmdVoltar.Text = "Voltar";
            this.cmdVoltar.UseVisualStyleBackColor = true;
            this.cmdVoltar.Visible = false;
            this.cmdVoltar.Click += new System.EventHandler(this.cmdVoltar_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProjetoCinema.Properties.Resources.fundomain;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1441, 632);
            this.Controls.Add(this.cmdVoltar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FrmMain";
            this.Text = "Cine for Fun";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cadastroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calendarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastraFilmeToolStripMenuItem;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button cmdConfirma;
        private System.Windows.Forms.Button cmdCancelar;
        private System.Windows.Forms.TextBox txtClassificacao;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtGenero;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDuracao;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button cmdVoltar;
    }
}