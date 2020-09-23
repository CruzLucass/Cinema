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
    public partial class FrmVenda : Form
    {
        List<Funcionario> listaF = null;
        List<Filme> filmes = null;
        List<Button> listaB = null;
        Funcionario f = new Funcionario();
        public FrmVenda(List<Funcionario> listaF, List<Filme> filmes, List<Button> listaB, Funcionario f)
        {
            InitializeComponent();
            this.listaF = listaF;
            this.filmes = filmes;
            this.listaB = listaB;
            this.f = f;
        }

        private void cmdcancelar_Click(object sender, EventArgs e)
        {
            this.FindForm();
            this.Close();
        }
        int contaPoltrona = 0;
        private void cmdA1_Click_1(object sender, EventArgs e)
        {            
            cmdA1.BackColor = Color.Red;
            cmdA1.Enabled = false;
            lbxQtdPoltrona.Items.Add(" A1");
            contaPoltrona++;
        }

        private void cmdA2_Click_1(object sender, EventArgs e)
        {
            cmdA2.BackColor = Color.Red;
            cmdA2.Enabled = false;
            lbxQtdPoltrona.Items.Add(" A2");
            contaPoltrona++;
        }

        private void cmdA3_Click_1(object sender, EventArgs e)
        {
            cmdA3.BackColor = Color.Red;
            cmdA3.Enabled = false;
            lbxQtdPoltrona.Items.Add(" A3");
            contaPoltrona++;
        }

        private void cmdA4_Click_1(object sender, EventArgs e)
        {
            cmdA4.BackColor = Color.Red;
            cmdA4.Enabled = false;
            lbxQtdPoltrona.Items.Add(" A4");
            contaPoltrona++;
        }

        private void cmdA5_Click_1(object sender, EventArgs e)
        {
            cmdA5.BackColor = Color.Red;
            cmdA5.Enabled = false;
            lbxQtdPoltrona.Items.Add(" A5");
            contaPoltrona++;
        }

        private void cmdA6_Click_1(object sender, EventArgs e)
        {
            cmdA6.BackColor = Color.Red;
            cmdA6.Enabled = false;
            lbxQtdPoltrona.Items.Add(" A6");
            contaPoltrona++;
        }

        private void cmdA7_Click_1(object sender, EventArgs e)
        {
            cmdA7.BackColor = Color.Red;
            cmdA7.Enabled = false;
            lbxQtdPoltrona.Items.Add(" A7");
            contaPoltrona++;
        }

        private void cmdB1_Click_1(object sender, EventArgs e)
        {
            cmdB1.BackColor = Color.Red;
            cmdB1.Enabled = false;
            lbxQtdPoltrona.Items.Add(" B1");
            contaPoltrona++;
        }

        private void cmdB2_Click_1(object sender, EventArgs e)
        {
            cmdB2.BackColor = Color.Red;
            cmdB2.Enabled = false;
            lbxQtdPoltrona.Items.Add(" B2");
            contaPoltrona++;
        }

        private void cmdB3_Click_1(object sender, EventArgs e)
        {
            cmdB3.BackColor = Color.Red;
            cmdB3.Enabled = false;
            lbxQtdPoltrona.Items.Add(" B3");
            contaPoltrona++;
        }

        private void cmdB4_Click_1(object sender, EventArgs e)
        {
            cmdB4.BackColor = Color.Red;
            cmdB4.Enabled = false;
            lbxQtdPoltrona.Items.Add(" B4");
            contaPoltrona++;
        }

        private void cmdB5_Click_1(object sender, EventArgs e)
        {
            cmdB5.BackColor = Color.Red;
            cmdB5.Enabled = false;
            lbxQtdPoltrona.Items.Add(" B5");
            contaPoltrona++;
        }

        private void cmdB6_Click_1(object sender, EventArgs e)
        {
            cmdB6.BackColor = Color.Red;
            cmdB6.Enabled = false;
            lbxQtdPoltrona.Items.Add(" B6");
            contaPoltrona++;
        }

        private void cmdB7_Click_1(object sender, EventArgs e)
        {
            cmdB7.BackColor = Color.Red;
            cmdB7.Enabled = false;
            lbxQtdPoltrona.Items.Add(" B7");
            contaPoltrona++;
        }

        private void cmdC1_Click_1(object sender, EventArgs e)
        {
            cmdC1.BackColor = Color.Red;
            cmdC1.Enabled = false;
            lbxQtdPoltrona.Items.Add(" C1");
            contaPoltrona++;
        }

        private void cmdC2_Click_1(object sender, EventArgs e)
        {
            cmdC2.BackColor = Color.Red;
            cmdC2.Enabled = false;
            lbxQtdPoltrona.Items.Add(" C2");
            contaPoltrona++;
        }

        private void cmdC3_Click_1(object sender, EventArgs e)
        {
            cmdC3.BackColor = Color.Red;
            cmdC3.Enabled = false;
            lbxQtdPoltrona.Items.Add(" C3");
            contaPoltrona++;
        }

        private void cmdC4_Click_1(object sender, EventArgs e)
        {
            cmdC4.BackColor = Color.Red;
            cmdC4.Enabled = false;
            lbxQtdPoltrona.Items.Add(" C4");
            contaPoltrona++;
        }

        private void cmdC5_Click_1(object sender, EventArgs e)
        {
            cmdC5.BackColor = Color.Red;
            cmdC5.Enabled = false;
            lbxQtdPoltrona.Items.Add(" C5");
            contaPoltrona++;
        }

        private void cmdC6_Click_1(object sender, EventArgs e)
        {
            cmdC6.BackColor = Color.Red;
            cmdC6.Enabled = false;
            lbxQtdPoltrona.Items.Add(" C6");
            contaPoltrona++;
        }

        private void cmdC7_Click_1(object sender, EventArgs e)
        {
            cmdC7.BackColor = Color.Red;
            cmdC7.Enabled = false;
            lbxQtdPoltrona.Items.Add(" C7");
            contaPoltrona++;
        }

        private void cmdD1_Click_1(object sender, EventArgs e)
        {
            cmdD1.BackColor = Color.Red;
            cmdD1.Enabled = false;
            lbxQtdPoltrona.Items.Add(" D1");
            contaPoltrona++;
        }

        private void cmdD2_Click_1(object sender, EventArgs e)
        {
            cmdD2.BackColor = Color.Red;
            cmdD2.Enabled = false;
            lbxQtdPoltrona.Items.Add(" D2");
            contaPoltrona++;
        }

        private void cmdD3_Click_1(object sender, EventArgs e)
        {
            cmdD3.BackColor = Color.Red;
            cmdD3.Enabled = false;
            lbxQtdPoltrona.Items.Add(" D3");
            contaPoltrona++;
        }

        private void cmdD4_Click_1(object sender, EventArgs e)
        {
            cmdD4.BackColor = Color.Red;
            cmdD4.Enabled = false;
            lbxQtdPoltrona.Items.Add(" D4");
            contaPoltrona++;
        }

        private void cmdD5_Click_1(object sender, EventArgs e)
        {
            cmdD5.BackColor = Color.Red;
            cmdD5.Enabled = false;
            lbxQtdPoltrona.Items.Add(" D5");
            contaPoltrona++;
        }

        private void cmdD6_Click_1(object sender, EventArgs e)
        {
            cmdD6.BackColor = Color.Red;
            cmdD6.Enabled = false;
            lbxQtdPoltrona.Items.Add(" D6");
            contaPoltrona++;
        }

        private void cmdD7_Click_1(object sender, EventArgs e)
        {
            cmdD7.BackColor = Color.Red;
            cmdD7.Enabled = false;
            lbxQtdPoltrona.Items.Add(" D7");
            contaPoltrona++;
        }

        private void cmdE1_Click_1(object sender, EventArgs e)
        {
            cmdE1.BackColor = Color.Red;
            cmdE1.Enabled = false;
            lbxQtdPoltrona.Items.Add(" E1");
            contaPoltrona++;
        }

        private void cmdE2_Click_1(object sender, EventArgs e)
        {
            cmdE2.BackColor = Color.Red;
            cmdE2.Enabled = false;
            lbxQtdPoltrona.Items.Add(" E2");
            contaPoltrona++;
        }

        private void cmdE3_Click_1(object sender, EventArgs e)
        {
            cmdE3.BackColor = Color.Red;
            cmdE3.Enabled = false;
            lbxQtdPoltrona.Items.Add(" E3");
            contaPoltrona++;
        }

        private void cmdE4_Click_1(object sender, EventArgs e)
        {
            cmdE4.BackColor = Color.Red;
            cmdE4.Enabled = false;
            lbxQtdPoltrona.Items.Add(" E4");
            contaPoltrona++;
        }

        private void cmdE5_Click_1(object sender, EventArgs e)
        {
            cmdE5.BackColor = Color.Red;
            cmdE5.Enabled = false;
            lbxQtdPoltrona.Items.Add(" E5");
            contaPoltrona++;
        }

        private void cmdE6_Click_1(object sender, EventArgs e)
        {
            cmdE6.BackColor = Color.Red;
            cmdE6.Enabled = false;
            lbxQtdPoltrona.Items.Add(" E6");
            contaPoltrona++;
        }

        private void cmdE7_Click_1(object sender, EventArgs e)
        {
            cmdE7.BackColor = Color.Red;
            cmdE7.Enabled = false;
            lbxQtdPoltrona.Items.Add(" E7");
            contaPoltrona++;
        }
        private void cmdLimpa_Click(object sender, EventArgs e)
        {
            foreach(Button item in gbPoltronas.Controls)
            {
                item.BackColor = Color.LimeGreen;
                item.Enabled = true;
                lbxQtdPoltrona.Items.Clear();
                contaPoltrona = 0;
            }
            valorPoltrona = 0;
            lblValor.Text = "";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblHorafilme.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void FrmVenda_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            foreach (Filme item in filmes)
            {
                cbxEscolhaFilme.Items.Add(item.Nomefilme);
            }
            foreach(Button item in gbPoltronas.Controls)
            {
                foreach (Button itemx in listaB)
                {
                    if(item.Text == itemx.Text)
                    {
                        item.Enabled = false;
                        item.BackColor = Color.Red;
                    }
                }
            }

        }
        TimeSpan time = new TimeSpan();
        private void cbxEscolhaSala_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (Filme item in filmes)
            {
                if (cbxEscolhaFilme.Text == item.Nomefilme)
                {
                    lblNomeFilme.Text = "Nome: " + item.Nomefilme + "  Genero: " + item.Genero + "  Duração: " + item.Duracao + "  Classificação: " + item.Classificacao + " anos";
                    time = TimeSpan.Parse(item.Duracao);
                    TimeSpan time2 = new TimeSpan();
                    time2 = TimeSpan.Parse(lblHorafilme.Text);
                    time = time.Add(time2);
                    lblTermino.Text = time.Hours + ":" + time.Minutes + ":" + time.Seconds;
                }
            }
        }

        private void cmdProximo_Click(object sender, EventArgs e)
        {
            foreach (Button item in gbPoltronas.Controls)
            {
                if(item.Enabled is false)
                {
                    listaB.Add(item);
                }
            }
            tabControl1.SelectedTab = tabPage2;
            progressBar1.Value = 50;
        }

        private void cmdVoltar_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage1;
        }

        private void cmdFinalizar_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage3;
            lblInfoFilme.Text = lblNomeFilme.Text;
            lblValorP.Text = lblValor.Text;
            lblVtc.Text = lblValorConv.Text;
            lblInfoFunc.Text = f.MostraFunc();
            progressBar1.Value = 75;
        }

        double valorTotal = 0;
        double valorConv = 0;
        double valorPoltrona = 0;
        private void cmdSomar_Click(object sender, EventArgs e)
        {
            valorTotal = valorConv + valorPoltrona;
            lblTotal.Text = valorTotal.ToString("R$0.00");
            lblTotal.Visible = true;
        }

        private void cmdCalculaTroco_Click(object sender, EventArgs e)
        {
            double aux = double.Parse(txtValorPago.Text);
            double troco = aux - valorTotal;
            lblTroco.Text = troco.ToString("R$0.00");
            lblTroco.Visible = true;
            progressBar1.Value = 100;
        }

        private void cmdEsc_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmdValor_Click(object sender, EventArgs e)
        {
            foreach (RadioButton item in gbTicket.Controls)
            {
                if (rbInteira.Checked is true)
                {
                    valorPoltrona = contaPoltrona * 20;
                }
                else if(rbMeia.Checked is true)
                    valorPoltrona = contaPoltrona * 10;
            }
            lblValor.Text = valorPoltrona.ToString("R$0.00");
            lblValor.Visible = true;
        }

        private void cmdVConv_Click(object sender, EventArgs e)
        {
            foreach (CheckBox item in gbBebidas.Controls)
            {
                if (item.Checked == true)
                {
                    if (item.Text == "Água")
                        valorConv += 1.50;
                    if (item.Text == "Suco")
                        valorConv += 3.00;
                    if (item.Text == "Refrigerante")
                        valorConv += 3.50;
                    if (item.Text == "Cerveja")
                        valorConv += 4.00;
                }
            }
            foreach (RadioButton item in gbPipoca.Controls)
            {
                if (item.Checked == true)
                {
                    if (item.Text == "Pequena")
                        valorConv += 8.00;
                    if (item.Text == "Média")
                        valorConv += 11.00;
                    if (item.Text == "Grande")
                        valorConv += 14.00;
                    if (item.Text == "Extra Grande")
                        valorConv += 16.50;
                }
            }
            foreach (CheckBox item in gbDoce.Controls)
            {
                if (item.Checked == true)
                {
                    if (item.Text == "Chocolate")
                        valorConv += 2.00;
                    if (item.Text == "Halls")
                        valorConv += 1.75;
                    if (item.Text == "Trident")
                        valorConv += 2.25;
                    if (item.Text == "Bala Goma")
                        valorConv += 1.90;
                }
            }
            lblValorConv.Visible = true;
            lblValorConv.Text = valorConv.ToString("R$0.00");
        }
    }
}