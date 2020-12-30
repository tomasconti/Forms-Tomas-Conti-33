using System;
using System.CodeDom;
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
    public partial class frmJogos : Form
    {
        Random sorteio = new Random();
        double player1;
        double contagemAcertos = 0;
        double contagemErros = 0;
        string nomee;
        int matematicoo;
        public frmJogos(int matematico, TextBox nomejogador)
        {
            InitializeComponent();
            NomedoJogador(nomejogador, matematico);
            lblResultado.Text = "";
            lblResultado.BorderStyle = BorderStyle.None;
        }

        private void btnvoltarconta_Click(object sender, EventArgs e)
        {
            DialogResult resposta;
            resposta = MessageBox.Show("Você quer mesmo voltar?", "Jogo das contas- Despedida", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resposta == DialogResult.Yes)
                this.Close();
        }

        private void btnsortearsoma_Click(object sender, EventArgs e)
        {
            SortearConta(picSoma);
            txtresultado.Focus();
            txtresultado.Clear();
            lblResultado.Text = "";
        }

        private void SortearConta(PictureBox imagemconta)
        {
            int valorconta = sorteio.Next(1, 10);

            imagemconta.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\imagens\\conta" + valorconta + ".png");

            player1 = valorconta;
        }

        private void btnmostrarresult_Click(object sender, EventArgs e)
        {
            if (txtresultado.Text == "")
            {
                DialogResult resposta;
                resposta = MessageBox.Show("Voce deixou o espaço em branco clique em OK para digitar novamente", "Jogo das contas", MessageBoxButtons.OK);
                if (resposta == DialogResult.OK)
                {
                    txtresultado.Clear();
                    txtresultado.Focus();
                    lblResultado.Text = "";
                }
            }

            else
            {
                float resultado = Convert.ToSingle(txtresultado.Text);
                if (player1 == 1)
                {
                    if (resultado == 121)
                    {
                        lblResultado.ForeColor = Color.Lime;
                        lblResultado.BorderStyle = BorderStyle.FixedSingle;
                        lblResultado.Text = "acertou";
                        contagemAcertos = contagemAcertos + 1;
                        txtresultado.Clear();
                        txtresultado.Focus();
                    }
                    else
                    {
                        lblResultado.ForeColor = Color.Red;
                        lblResultado.BorderStyle = BorderStyle.FixedSingle;
                        lblResultado.Text = "errou";
                        contagemErros = contagemErros + 1;
                        txtresultado.Clear();
                        txtresultado.Focus();
                    }
                }
                if (player1 == 2)
                {
                    if (resultado == 4970)
                    {
                        lblResultado.ForeColor = Color.Lime;
                        lblResultado.BorderStyle = BorderStyle.FixedSingle;
                        lblResultado.Text = "acertou";
                        contagemAcertos = contagemAcertos + 1;
                        txtresultado.Clear();
                        txtresultado.Focus();
                    }
                    else
                    {

                        lblResultado.ForeColor = Color.Red;
                        lblResultado.BorderStyle = BorderStyle.FixedSingle;
                        lblResultado.Text = "errou";
                        contagemErros = contagemErros + 1;
                        txtresultado.Clear();
                        txtresultado.Focus();
                    }
                }
                if (player1 == 3)
                {
                    if (resultado == 2100)
                    {
                        lblResultado.ForeColor = Color.Lime;
                        lblResultado.BorderStyle = BorderStyle.FixedSingle;
                        lblResultado.Text = "acertou";
                        contagemAcertos = contagemAcertos + 1;
                        txtresultado.Clear();
                        txtresultado.Focus();
                    }
                    else
                    {
                        lblResultado.ForeColor = Color.Red;
                        lblResultado.BorderStyle = BorderStyle.FixedSingle;
                        lblResultado.Text = "errou";
                        contagemErros = contagemErros + 1;
                        txtresultado.Clear();
                        txtresultado.Focus();
                    }

                }
                if (player1 == 4)
                {
                    if (resultado == 5)
                    {
                        lblResultado.ForeColor = Color.Lime;
                        lblResultado.BorderStyle = BorderStyle.FixedSingle;
                        lblResultado.Text = "acertou";
                        contagemAcertos = contagemAcertos + 1;
                        txtresultado.Clear();
                        txtresultado.Focus();
                    }
                    else
                    {
                        lblResultado.ForeColor = Color.Red;
                        lblResultado.BorderStyle = BorderStyle.FixedSingle;
                        lblResultado.Text = "errou";
                        txtresultado.Clear();
                        contagemErros = contagemErros + 1;
                        txtresultado.Focus();
                    }
                }
                if (player1 == 5)
                {
                    if (resultado == 80)
                    {
                        lblResultado.ForeColor = Color.Lime;
                        lblResultado.BorderStyle = BorderStyle.FixedSingle;
                        lblResultado.Text = "acertou";
                        contagemAcertos = contagemAcertos + 1;
                        txtresultado.Clear();
                        txtresultado.Focus();
                    }
                    else
                    {
                        lblResultado.ForeColor = Color.Red;
                        lblResultado.BorderStyle = BorderStyle.FixedSingle;
                        lblResultado.Text = "errou";
                        txtresultado.Clear();
                        contagemErros = contagemErros + 1;
                        txtresultado.Focus();
                    }
                }

                if (player1 == 6)
                {
                    if (resultado == 500)
                    {
                        lblResultado.ForeColor = Color.Lime;
                        lblResultado.BorderStyle = BorderStyle.FixedSingle;
                        lblResultado.Text = "acertou";
                        contagemAcertos = contagemAcertos + 1;
                        txtresultado.Clear();
                        txtresultado.Focus();
                    }
                    else
                    {
                        lblResultado.ForeColor = Color.Red;
                        lblResultado.BorderStyle = BorderStyle.FixedSingle;
                        lblResultado.Text = "errou";
                        txtresultado.Clear();
                        contagemErros = contagemErros + 1;
                        txtresultado.Focus();
                    }

                }
                if (player1 == 7)
                {
                    if (resultado == 5)
                    {
                        lblResultado.ForeColor = Color.Lime;
                        lblResultado.BorderStyle = BorderStyle.FixedSingle;
                        lblResultado.Text = "acertou";
                        contagemAcertos = contagemAcertos + 1;
                        txtresultado.Clear();
                        txtresultado.Focus();
                    }
                    else
                    {
                        lblResultado.ForeColor = Color.Red;
                        lblResultado.BorderStyle = BorderStyle.FixedSingle;
                        lblResultado.Text = "errou";
                        txtresultado.Clear();
                        contagemErros = contagemErros + 1;
                        txtresultado.Focus();
                    }
                }
                if (player1 == 8)
                {
                    if (resultado == 150)
                    {
                        lblResultado.ForeColor = Color.Lime;
                        lblResultado.BorderStyle = BorderStyle.FixedSingle;
                        lblResultado.Text = "acertou";
                        contagemAcertos = contagemAcertos + 1;
                        txtresultado.Clear();
                        txtresultado.Focus();
                    }
                    else
                    {
                        lblResultado.ForeColor = Color.Red;
                        lblResultado.BorderStyle = BorderStyle.FixedSingle;
                        lblResultado.Text = "errou";
                        txtresultado.Clear();
                        contagemErros = contagemErros + 1;
                        txtresultado.Focus();
                    }
                }
                if (player1 == 9)
                {
                    if (resultado == 23000)
                    {
                        lblResultado.ForeColor = Color.Lime;
                        lblResultado.BorderStyle = BorderStyle.FixedSingle;
                        lblResultado.Text = "acertou";
                        contagemAcertos = contagemAcertos + 1;
                        txtresultado.Clear();
                        txtresultado.Focus();
                    }
                    else
                    {
                        lblResultado.ForeColor = Color.Red;
                        lblResultado.BorderStyle = BorderStyle.FixedSingle;
                        lblResultado.Text = "errou";
                        txtresultado.Clear();
                        contagemErros = contagemErros + 1;
                        txtresultado.Focus();
                    }
                }

                txtpontuacao.Text = contagemAcertos.ToString();
                txterros.Text = contagemErros.ToString();

                if (contagemAcertos == 5)
                {
                    Finalizar();
                }
                if (contagemErros == 5)
                {
                    Perdeu();
                }
            }
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Instruções de uso: \n\n1) Para iniciar " +
                "clique no botão sortear conta: assim uma conta ira aparecer;" +
                "\n\n2) Depois digite o resultado da conta;" +
                "\n\n3) Para checar o resultado, clique no botão mostrar resultado" +
                "\n\n4) Se voce acertar 5 contas voce é o vencedor, " +
                "\n\n5) Se voce errar 5 contas voce perde, " +
                "\n\n6) para sair, clique no botão Voltar " +
                "\n(No canto inferior direito)" +
                "\n\n\nObrigado por utilizar meu jogo das contas!");
        }

        private void txtresultado_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.') && (e.KeyChar != '-'))
            {
                e.Handled = true;
            }
        }

        private void Finalizar()
        {
            contagemAcertos = 0;
            contagemErros = 0;
            txtpontuacao.Text = "0";
            txterros.Text = "0";
            picSoma.Image = null;
            lblResultado.Text = "";
            FrmVitoria vitoria = new FrmVitoria(matematicoo, nomee);
            this.Hide();
            vitoria.ShowDialog();
            this.Show();
        }

        private void Perdeu()
        {
            contagemAcertos = 0;
            contagemErros = 0;
            txtpontuacao.Text = "0";
            txterros.Text = "0";
            picSoma.Image = null;
            lblResultado.Text = "";
            FrmDerrota perdeu = new FrmDerrota(matematicoo, nomee);
            this.Hide();
            perdeu.ShowDialog();
            this.Show();
        }
        private void NomedoJogador (TextBox nomejogador, int matematico)
        {
            
            lblnome.Text = nomejogador.Text;
            matematicoo = matematico;
            nomee = nomejogador.Text;
            

        }


    }
}


