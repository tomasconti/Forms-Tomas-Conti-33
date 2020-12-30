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
    public partial class FrmDerrota : Form
    {
        public FrmDerrota(int matematico, string nome)
        {
            InitializeComponent();
            Nome(nome, matematico);
            Foto(matematico);
        }

        private void lblPerdeu_Click(object sender, EventArgs e)
        {

        }

        private void Nome(string nome, int matematico)
        {
            lblNome.Text = nome;
            if (matematico == 1)
            {
                lblMatematico.Text = "Albert Eisten";
            }
            if (matematico == 2)
            {
                lblMatematico.Text = "Stephen Hawking";
            }
            if (matematico == 3)
            {
                lblMatematico.Text = "Isaac Newton";
            }
            if (matematico == 4)
            {
                lblMatematico.Text = "Arquimedes";
            }

        }

        private void Foto(int matematico)
        {
            if (matematico == 1)
            {
                picMatematico.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\Matematicos\\matematico1.jpg");
            }
            if (matematico == 2)
            {
                picMatematico.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\Matematicos\\matematico2.jpg");
            }
            if (matematico == 3)
            {
                picMatematico.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\Matematicos\\matematico3.jpg");
            }
            if (matematico == 4)
            {
                picMatematico.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\Matematicos\\matematico4.jpg");
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void picMatematico_Click(object sender, EventArgs e)
        {

        }
    }
}
