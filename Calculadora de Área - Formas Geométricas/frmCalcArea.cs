using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forms_Tomas_Conti_33
{
    public partial class frmCalcArea : Form
    {
        public frmCalcArea()
        {
            InitializeComponent();
            txtBase.TabIndex = 0;
            txtAltura.TabIndex = 1;
            btnCalcular.TabIndex = 2;
        }

        private void radbtnTriangulo_CheckedChanged(object sender, EventArgs e)
        {
            if (radbtnTriangulo.Checked)
            {
                imgRetangulo.Visible = false;
                imgTriangulo.Visible = true;
            }
        }

        private void radbtnRetangulo_CheckedChanged(object sender, EventArgs e)
        {
            if(radbtnRetangulo.Checked)
            {
                imgRetangulo.Visible = true;
                imgTriangulo.Visible = false;
            }
        }

        private void radbtnCm_CheckedChanged(object sender, EventArgs e)
        {
            if(radbtnCm.Checked)
            {
                lblUnidMedidaBase.Text = "cm";
                lblUnidMedidaAltura.Text = "cm";
                lblUnidMedidaResposta.Text = "cm";
                lbl2.Location = new Point(379, 282);

                if (txtBase.Text != "")
                {
                    double B = 0;
                    B = double.Parse(txtBase.Text) * 100;
                    txtBase.Text = B.ToString();
                }

                if(txtAltura.Text != "")
                {
                    double H = 0;
                    H = double.Parse(txtAltura.Text) * 100;
                    txtAltura.Text = H.ToString();
                }

                if (lblResposta.Text != "")
                {
                    double R = 0;
                    R = double.Parse(lblResposta.Text) * 10000;
                    lblResposta.Text = R.ToString();
                }
            }
        }

        private void radbtnM_CheckedChanged(object sender, EventArgs e)
        {
            if(radbtnM.Checked)
            {
                lblUnidMedidaBase.Text = "m";
                lblUnidMedidaAltura.Text = "m";
                lblUnidMedidaResposta.Text = "m";
                lbl2.Location = new Point(367, 282);

                if (txtBase.Text != "")
                {
                    double B = 0;
                    B = double.Parse(txtBase.Text) / 100;
                    txtBase.Text = B.ToString();
                }

                if (txtAltura.Text != "")
                {
                    double H = 0;
                    H = double.Parse(txtAltura.Text) / 100;
                    txtAltura.Text = H.ToString();
                }

                if (lblResposta.Text != "")
                {
                    double R = 0;
                    R = double.Parse(lblResposta.Text) / 10000;
                    lblResposta.Text = R.ToString();
                }
            }
        }

       

        private void txtAltura_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.') && (e.KeyChar != '-'))
            {
                e.Handled = true;
            }
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double b = 0;
            double h = 0;
            double result = 0;
            DialogResult resposta;

            if(radbtnRetangulo.Checked)
            {
                if (txtBase.Text == "" || txtAltura.Text == "")
                {
                    resposta = MessageBox.Show("Percebi que você deixou de preencher algum campo. Deseja calcular assim mesmo? \n caso sua resposta seja sim, irei substituir o campo vazio por 0. Tudo bem pra você?", "Calculadora de Área - Atenção!", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (resposta == DialogResult.Yes)
                    {
                        if(txtBase.Text == "")
                        {
                            b = 0;
                            txtBase.Text = b.ToString();
                        }
                        if(txtAltura.Text == "")
                        {
                            h = 0;
                            txtAltura.Text = h.ToString();
                        }
                        h = double.Parse(txtAltura.Text);
                        b = double.Parse(txtBase.Text);

                        if (radbtnCm.Checked)
                        {
                            b = b / 100;
                            h = h / 100;
                            result = b * h;
                            lblResposta.Text = result.ToString();
                        }
                        else if (radbtnM.Checked)
                        {
                            result = b * h;
                            lblResposta.Text = result.ToString();
                        }
                    }
                    else
                    {
                        txtBase.Text = "";
                        txtAltura.Text = "";
                        lblResposta.Text = "";
                        txtBase.Focus();
                    }
                }
                else
                {
                    h = double.Parse(txtAltura.Text);
                    b = double.Parse(txtBase.Text);

                    if (radbtnCm.Checked)
                    {
                        result = b * h;
                        lblResposta.Text = result.ToString();
                    }
                    else if (radbtnM.Checked)
                    {
                        result = b * h;
                        lblResposta.Text = result.ToString();
                    }
                }
               
            }
            if (radbtnTriangulo.Checked)
            {
                if (txtBase.Text == "" || txtAltura.Text == "")
                {
                    resposta = MessageBox.Show("Percebi que você deixou de preencher algum campo. Deseja calcular assim mesmo? \n caso sua resposta seja sim, irei substituir o campo vazio por 0. Tudo bem pra você?", "Calculadora de Área - Atenção!", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (resposta == DialogResult.Yes)
                    {
                        if (txtBase.Text == "")
                        {
                            b = 0;
                        }
                        if (txtAltura.Text == "")
                        {
                            h = 0;
                        }
                        h = double.Parse(txtAltura.Text);
                        b = double.Parse(txtBase.Text);

                        if (radbtnCm.Checked)
                        {
                            b = b / 100;
                            h = h / 100;
                            result = (b * h) / 2;
                            lblResposta.Text = result.ToString();
                            btnLimpar.Focus();
                        }
                        else if (radbtnM.Checked)
                        {
                            result = (b * h) / 2;
                            lblResposta.Text = result.ToString();
                        }
                    }
                    else
                    {
                        lblResposta.Text = "";
                        txtBase.Text = "";
                        txtAltura.Text = "";
                        txtBase.Focus();
                    }
                }
                else
                {
                    h = double.Parse(txtAltura.Text);
                    b = double.Parse(txtBase.Text);

                    if (radbtnCm.Checked)
                    {
                       
                        result = (b * h) / 2;
                        lblResposta.Text = result.ToString();
                    }
                    else if (radbtnM.Checked)
                    {
                        result = (b * h) / 2;
                        lblResposta.Text = result.ToString();
                    }
                    btnLimpar.Focus();
                }
            }
            
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtAltura.Clear();
            txtBase.Clear();
            lblResposta.Text = "";
            txtBase.Focus();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            DialogResult resposta;
            resposta = MessageBox.Show("Você quer mesmo voltar?", "Calculadora de Área - Despedida", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resposta == DialogResult.Yes)
                this.Close();
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Instruções de uso: \n\n1) selecione a forma que " +
                "deseja calcular: 'Retângulo', 'Triângulo';" +
                "\n\n2) para calcular, clique no botão 'Calcular' ou ALT+C;" +
                "\n\n3) para converter, clique no botão 'cm' ou 'm'" +
                "\n\n4) para limpar a tela, clique no botão 'Limpar' ou ALT+L" +
                "\n\n5) para sair, clique no botão 'Sair', ou ALT+R ou no X vermelho " +
                "\n(canto superior direito)" +
                "\n\n\nObrigado por utilizar minha calculadora de Área!");
        }

        private void txtBase_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
