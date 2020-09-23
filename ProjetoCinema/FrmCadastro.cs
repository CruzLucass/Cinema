using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoCinema
{
    public partial class FrmCadastro : Form
    {
        List<Funcionario> listaF = null;
        Funcionario F = null;
        public FrmCadastro(List<Funcionario> listaF)
        {
            InitializeComponent();
            this.listaF = listaF;
        }

        private void cmdConfirmaCadastro_Click(object sender, EventArgs e)
        {
            F = new Funcionario();
            F.Nome = txtNomeFunc.Text;
            F.Senha = txtSenhaFunc.Text;
            F.Turno = cbxTurno.Text;
            listaF.Add(F);
            MessageBox.Show("Cadastro Realizado com sucesso!", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
            txtNomeFunc.Clear();
            txtSenhaFunc.Clear();
            cbxTurno.Text = null;

            this.FindForm();
            this.Close();
        }

        private void cmdCancelaCadastro_Click(object sender, EventArgs e)
        {
            this.FindForm();
            this.Close();
        }
    }
}
