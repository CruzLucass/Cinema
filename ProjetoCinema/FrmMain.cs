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
    public partial class FrmMain : Form
    {
        List<Funcionario> listaF = null;
        List<Filme> filmes = new List<Filme>();
        List<Button> listaB = new List<Button>();
        Filme filme = null;
        Funcionario f = null;
        public FrmMain(List<Funcionario> listaF, Funcionario f)
        {
            InitializeComponent();
            this.listaF = listaF;
            this.f = f;
        }

        private void cadastroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCadastro C = new FrmCadastro(listaF);
            C.ShowDialog();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void salasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmVenda V = new FrmVenda(listaF, filmes, listaB, f);
            V.ShowDialog();
        }

        private void calendarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label1.Visible = true;
            listBox1.Visible = true;
            cmdVoltar.Visible = true;
            foreach (Filme item in filmes)
            {
                listBox1.Items.Add(item.MostraFilme());
            }
        }

        private void cadastraFilmeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
        }

        private void cmdCancelar_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
        }

        private void cmdVoltar_Click(object sender, EventArgs e)
        {
            label1.Visible = false;
            listBox1.Visible = false;
            listBox1.Items.Clear();
            cmdVoltar.Visible = false;
        }

        private void cmdConfirma_Click(object sender, EventArgs e)
        {
            filme = new Filme();
            filme.Nomefilme = txtTitulo.Text;
            filme.Classificacao = Convert.ToInt32(txtClassificacao.Text);
            filme.Duracao = txtDuracao.Text;
            filme.Genero = txtGenero.Text;
            filmes.Add(filme);

            MessageBox.Show("Filme cadastrado com sucesso!", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);

            txtTitulo.Clear();
            txtClassificacao.Clear();
            txtDuracao.Clear();
            txtGenero.Clear();

        }
    }
}
