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
    public partial class FrmDados : Form
    {
        public FrmDados(int matematico)
        {
            InitializeComponent();
            Foto(matematico);
            Dados(matematico);
        }

        private void lblbiografia_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Foto(int matematico)
        {
            if (matematico == 1)
            {
                lblNome.Text = "Albert Einsten";
                picMatematico.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\Matematicos\\matematico1.jpg");
            }
            if (matematico == 2)
            {
                lblNome.Text = "Stephen Hawking";
                picMatematico.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\Matematicos\\matematico2.jpg");
            }
            if (matematico == 3)
            {
                lblNome.Text = "Isaac Newton";
                picMatematico.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\Matematicos\\matematico3.jpg");
            }
            if (matematico == 4)
            {
                lblNome.Text = "Arquimedes";
                picMatematico.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\Matematicos\\matematico4.jpg");
            }
        }
        private void Dados(int matematico)
        {
            if (matematico == 1)
            {
                lblData2.Text = "1879-1955";
                lblbiografia.Text = "Albert Einsten  foi um físico e matemático alemão.";
                lblBiografia2.Text = " Entrou para o rol dos maiores gênios da humanidade ao desenvolver a Teoria da Relatividade.";
                lblbiografia3.Text = "Estabeleceu a relação entre massa e energia e formulou a equação que se tornou a mais famosa do mundo: E = mc².";
            }
            if (matematico == 2)
            {
                lblData2.Text = "1942-2018";
                lblbiografia.Text = "Stephen William Hawking, foi um físico teórico e cosmólogo britânico.";
                lblBiografia2.Text = "Reconhecido internacionalmente por sua contribuição à ciência, sendo um dos mais renomados cientistas do século.";
                lblbiografia3.Text = "Seus trabalhos científicos incluem um estudo da previsão que os buracos negros emitem radiação";
            }
            if(matematico==3)
            {
                lblData2.Text = "1643-1727";
                lblbiografia.Text = "Isaac Newton foi um astrônomo, alquimista, teólogo e cientista inglês, mais reconhecido como matemático. ";
                lblBiografia2.Text = "Sua obra, Princípios Matemáticos da Filosofia é considerada uma das mais influentes na história da ciência. ";
                lblbiografia3.Text = "Publicada em 1687, esta obra descreve a lei da gravitação universal e as três leis de Newton.";
            }
            if(matematico==4)
            {
                lblData2.Text = "287-212 AC";
                lblbiografia.Text = "Arquimedes de Siracusa foi um matemático, físico, engenheiro, inventor e astrônomo grego.";
                lblBiografia2.Text = "É considerado um dos principais cientistas da Antiguidade Clássica. ";
                lblbiografia3.Text = "Entre suas contribuições à Física, estão as fundações da hidrostática e da estática.";
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
