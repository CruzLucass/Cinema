namespace ProjetoCinema
{
    partial class FrmCadastro
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.cmdCancelaCadastro = new System.Windows.Forms.Button();
            this.cmdConfirmaCadastro = new System.Windows.Forms.Button();
            this.cbxTurno = new System.Windows.Forms.ComboBox();
            this.txtSenhaFunc = new System.Windows.Forms.TextBox();
            this.txtNomeFunc = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::ProjetoCinema.Properties.Resources.teste;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(296, 11);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(75, 41);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(375, 28);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(126, 24);
            this.label10.TabIndex = 10;
            this.label10.Text = "Cine for Fun";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(302, 94);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(191, 24);
            this.label11.TabIndex = 22;
            this.label11.Text = "Cadastro Vendedor";
            // 
            // cmdCancelaCadastro
            // 
            this.cmdCancelaCadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdCancelaCadastro.ForeColor = System.Drawing.Color.Maroon;
            this.cmdCancelaCadastro.Location = new System.Drawing.Point(267, 341);
            this.cmdCancelaCadastro.Margin = new System.Windows.Forms.Padding(2);
            this.cmdCancelaCadastro.Name = "cmdCancelaCadastro";
            this.cmdCancelaCadastro.Size = new System.Drawing.Size(118, 40);
            this.cmdCancelaCadastro.TabIndex = 21;
            this.cmdCancelaCadastro.Text = "Cancelar";
            this.cmdCancelaCadastro.UseVisualStyleBackColor = true;
            this.cmdCancelaCadastro.Click += new System.EventHandler(this.cmdCancelaCadastro_Click);
            // 
            // cmdConfirmaCadastro
            // 
            this.cmdConfirmaCadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdConfirmaCadastro.ForeColor = System.Drawing.Color.Maroon;
            this.cmdConfirmaCadastro.Location = new System.Drawing.Point(451, 341);
            this.cmdConfirmaCadastro.Margin = new System.Windows.Forms.Padding(2);
            this.cmdConfirmaCadastro.Name = "cmdConfirmaCadastro";
            this.cmdConfirmaCadastro.Size = new System.Drawing.Size(118, 40);
            this.cmdConfirmaCadastro.TabIndex = 20;
            this.cmdConfirmaCadastro.Text = "Confirmar";
            this.cmdConfirmaCadastro.UseVisualStyleBackColor = true;
            this.cmdConfirmaCadastro.Click += new System.EventHandler(this.cmdConfirmaCadastro_Click);
            // 
            // cbxTurno
            // 
            this.cbxTurno.AutoCompleteCustomSource.AddRange(new string[] {
            "Diurno",
            "Noturno"});
            this.cbxTurno.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbxTurno.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxTurno.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxTurno.FormattingEnabled = true;
            this.cbxTurno.Items.AddRange(new object[] {
            "Diurno",
            "Noturno"});
            this.cbxTurno.Location = new System.Drawing.Point(337, 240);
            this.cbxTurno.Margin = new System.Windows.Forms.Padding(2);
            this.cbxTurno.Name = "cbxTurno";
            this.cbxTurno.Size = new System.Drawing.Size(134, 32);
            this.cbxTurno.TabIndex = 16;
            // 
            // txtSenhaFunc
            // 
            this.txtSenhaFunc.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSenhaFunc.Location = new System.Drawing.Point(337, 182);
            this.txtSenhaFunc.Margin = new System.Windows.Forms.Padding(2);
            this.txtSenhaFunc.Name = "txtSenhaFunc";
            this.txtSenhaFunc.Size = new System.Drawing.Size(134, 29);
            this.txtSenhaFunc.TabIndex = 18;
            this.txtSenhaFunc.UseSystemPasswordChar = true;
            // 
            // txtNomeFunc
            // 
            this.txtNomeFunc.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeFunc.Location = new System.Drawing.Point(337, 129);
            this.txtNomeFunc.Margin = new System.Windows.Forms.Padding(2);
            this.txtNomeFunc.Name = "txtNomeFunc";
            this.txtNomeFunc.Size = new System.Drawing.Size(190, 29);
            this.txtNomeFunc.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(263, 241);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 24);
            this.label4.TabIndex = 14;
            this.label4.Text = "Turno";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(263, 187);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 24);
            this.label3.TabIndex = 13;
            this.label3.Text = "Senha";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(263, 134);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 24);
            this.label2.TabIndex = 12;
            this.label2.Text = "Nome";
            // 
            // FrmCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(784, 474);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.cmdCancelaCadastro);
            this.Controls.Add(this.cmdConfirmaCadastro);
            this.Controls.Add(this.cbxTurno);
            this.Controls.Add(this.txtSenhaFunc);
            this.Controls.Add(this.txtNomeFunc);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label10);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmCadastro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button cmdCancelaCadastro;
        private System.Windows.Forms.Button cmdConfirmaCadastro;
        private System.Windows.Forms.ComboBox cbxTurno;
        private System.Windows.Forms.TextBox txtSenhaFunc;
        private System.Windows.Forms.TextBox txtNomeFunc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}