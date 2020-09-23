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
    public partial class FrmLogin : Form
    {
        List<Funcionario> listaF = new List<Funcionario>();
        public FrmLogin()
        {
            InitializeComponent();

        }

        private void cmdSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmdEntrar_Click(object sender, EventArgs e)
        {
            if (listaF.Count > 0)
            {
                foreach (Funcionario item in listaF)
                {
                    if (item.Nome == txtNome.Text && item.Senha == txtSenha.Text)
                    {
                        MessageBox.Show("Senha Correta!", "Verificação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtNome.Clear();
                        txtSenha.Clear();
                        FrmMain M = new FrmMain(listaF,item);
                        M.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Login não cadastrado, verifique seus dados!", "Verificação", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtNome.Clear();
                        txtSenha.Clear();
                    }
                }
            }
            else
                MessageBox.Show("Nenhum usuário cadastrado", "Verificação", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void cmdCadastra_Click(object sender, EventArgs e)
        {
            FrmCadastro C = new FrmCadastro(listaF);
            C.ShowDialog();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
