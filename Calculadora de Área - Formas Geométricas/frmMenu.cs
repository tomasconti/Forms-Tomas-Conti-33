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
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void btnJogos_Click(object sender, EventArgs e)
        {
            FrmSelecao selecao= new FrmSelecao();
            this.Hide();
            selecao.ShowDialog();
            this.Show();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            DialogResult resposta;
            resposta = MessageBox.Show("Você quer mesmo sair?", "Programa- fase 2", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resposta == DialogResult.Yes)
                this.Close();
        }

        private void btnCalcArea_Click_1(object sender, EventArgs e)
        {
            frmCalcArea calc = new frmCalcArea();
            this.Hide();
            calc.ShowDialog();
            this.Show();
        }
    }
}
