using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forms_Tomas_Conti_33
{
    public partial class FrmSelecao : Form
    {
        int matematico = 1;
        public FrmSelecao()
        {
            InitializeComponent();
            txtNome.Text = "";
        }

        private void lblMatematico_Click(object sender, EventArgs e)
        {

        }

        private void btnPróximo_Click(object sender, EventArgs e)
        {
            matematico = matematico + 1;
            if(matematico==1)
            {
                picmatematico.Image = null;
                picmatematico.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\Matematicos\\matematico1.jpg");
                lblMatematico.Text = "Albert Einsten";
            }
            if(matematico==2)
            {
                picmatematico.Image = null;
                picmatematico.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\Matematicos\\matematico2.jpg");
                lblMatematico.Text = "Stephen Hawking";
            }
            if(matematico==3)
            {
                picmatematico.Image = null;
                picmatematico.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\Matematicos\\matematico3.jpg");
                lblMatematico.Text = "Isaac Newton";
            }
            if(matematico==4)
            {
                picmatematico.Image = null;
                picmatematico.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\Matematicos\\matematico4.jpg");
                lblMatematico.Text = "Arquimedes";
            }
            if(matematico==5)
            {
                matematico = 1;
                picmatematico.Image = null;
                picmatematico.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\Matematicos\\matematico1.jpg");
                lblMatematico.Text = "Albert Einsten";
            }

        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            matematico = matematico - 1;
            if (matematico == 1)
            {
                picmatematico.Image = null;
                picmatematico.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\Matematicos\\matematico1.jpg");
                lblMatematico.Text = "Albert Einsten";
            }
            if (matematico == 2)
            {
                picmatematico.Image = null;
                picmatematico.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\Matematicos\\matematico2.jpg");
                lblMatematico.Text = "Stephen Hawking";
            }
            if (matematico == 3)
            {
                picmatematico.Image = null;
                picmatematico.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\Matematicos\\matematico3.jpg");
                lblMatematico.Text = "Isaac Newton";
            }
            if (matematico == 4)
            {
                picmatematico.Image = null;
                picmatematico.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\Matematicos\\matematico4.jpg");
                lblMatematico.Text = "Arquimedes";
            }
            if(matematico==0)
            {
                matematico = 4;
                picmatematico.Image = null;
                picmatematico.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\Matematicos\\matematico4.jpg");
                lblMatematico.Text = "Arquimedes";
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnJogar_Click(object sender, EventArgs e)
        {
            if(txtNome.Text=="")
            {
                DialogResult resposta;
                resposta = MessageBox.Show("Voce deixou o nome em branco clique em OK para digitar novamente", "Jogo das contas", MessageBoxButtons.OK);
                if (resposta == DialogResult.OK)
                {
                    txtNome.Focus();
                }

            }
            else
            {
                frmJogos conta = new frmJogos(matematico, txtNome);
                this.Hide();
                conta.ShowDialog();
                this.Show();
            }
        }

        private void btnDados_Click(object sender, EventArgs e)
        {
            FrmDados dados = new FrmDados(matematico);
            this.Hide();
            dados.ShowDialog();
            this.Show();

        }
    }
}
