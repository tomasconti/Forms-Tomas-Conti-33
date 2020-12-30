namespace Forms_Tomas_Conti_33
{
    partial class FrmVitoria
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblParabens = new System.Windows.Forms.Label();
            this.lblNomedados = new System.Windows.Forms.Label();
            this.lblpersonagem = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblMatematico = new System.Windows.Forms.Label();
            this.lblClique = new System.Windows.Forms.Label();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.picMatematico = new System.Windows.Forms.PictureBox();
            this.pic1 = new System.Windows.Forms.PictureBox();
            this.pic2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picMatematico)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic2)).BeginInit();
            this.SuspendLayout();
            // 
            // lblParabens
            // 
            this.lblParabens.AutoSize = true;
            this.lblParabens.BackColor = System.Drawing.Color.LightGreen;
            this.lblParabens.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblParabens.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblParabens.Location = new System.Drawing.Point(82, 147);
            this.lblParabens.Name = "lblParabens";
            this.lblParabens.Size = new System.Drawing.Size(646, 37);
            this.lblParabens.TabIndex = 15;
            this.lblParabens.Text = "Parabens você Venceu o jogo das contas";
            // 
            // lblNomedados
            // 
            this.lblNomedados.AutoSize = true;
            this.lblNomedados.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.lblNomedados.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomedados.Location = new System.Drawing.Point(101, 206);
            this.lblNomedados.Name = "lblNomedados";
            this.lblNomedados.Size = new System.Drawing.Size(72, 24);
            this.lblNomedados.TabIndex = 16;
            this.lblNomedados.Text = "Nome:";
            // 
            // lblpersonagem
            // 
            this.lblpersonagem.AutoSize = true;
            this.lblpersonagem.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.lblpersonagem.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpersonagem.Location = new System.Drawing.Point(101, 248);
            this.lblpersonagem.Name = "lblpersonagem";
            this.lblpersonagem.Size = new System.Drawing.Size(134, 24);
            this.lblpersonagem.TabIndex = 17;
            this.lblpersonagem.Text = "Personagem:";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.lblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(179, 206);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(21, 24);
            this.lblNome.TabIndex = 18;
            this.lblNome.Text = "L";
            this.lblNome.Click += new System.EventHandler(this.lblNome_Click);
            // 
            // lblMatematico
            // 
            this.lblMatematico.AutoSize = true;
            this.lblMatematico.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.lblMatematico.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMatematico.Location = new System.Drawing.Point(241, 248);
            this.lblMatematico.Name = "lblMatematico";
            this.lblMatematico.Size = new System.Drawing.Size(15, 24);
            this.lblMatematico.TabIndex = 19;
            this.lblMatematico.Text = "l";
            // 
            // lblClique
            // 
            this.lblClique.AutoSize = true;
            this.lblClique.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.lblClique.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClique.Location = new System.Drawing.Point(255, 363);
            this.lblClique.Name = "lblClique";
            this.lblClique.Size = new System.Drawing.Size(284, 24);
            this.lblClique.TabIndex = 21;
            this.lblClique.Text = "Clique para Jogar novamente";
            // 
            // btnVoltar
            // 
            this.btnVoltar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnVoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar.Location = new System.Drawing.Point(275, 390);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(229, 52);
            this.btnVoltar.TabIndex = 22;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = false;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // picMatematico
            // 
            this.picMatematico.Location = new System.Drawing.Point(426, 197);
            this.picMatematico.Name = "picMatematico";
            this.picMatematico.Size = new System.Drawing.Size(203, 128);
            this.picMatematico.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picMatematico.TabIndex = 20;
            this.picMatematico.TabStop = false;
            this.picMatematico.Click += new System.EventHandler(this.picMatematico_Click);
            // 
            // pic1
            // 
            this.pic1.Image = global::Forms_Tomas_Conti_33.Properties.Resources.fogos2;
            this.pic1.Location = new System.Drawing.Point(585, 12);
            this.pic1.Name = "pic1";
            this.pic1.Size = new System.Drawing.Size(203, 118);
            this.pic1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic1.TabIndex = 1;
            this.pic1.TabStop = false;
            // 
            // pic2
            // 
            this.pic2.Image = global::Forms_Tomas_Conti_33.Properties.Resources.fogos;
            this.pic2.Location = new System.Drawing.Point(32, 12);
            this.pic2.Name = "pic2";
            this.pic2.Size = new System.Drawing.Size(203, 118);
            this.pic2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic2.TabIndex = 0;
            this.pic2.TabStop = false;
            // 
            // FrmVitoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(800, 489);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.lblClique);
            this.Controls.Add(this.picMatematico);
            this.Controls.Add(this.lblMatematico);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.lblpersonagem);
            this.Controls.Add(this.lblNomedados);
            this.Controls.Add(this.lblParabens);
            this.Controls.Add(this.pic1);
            this.Controls.Add(this.pic2);
            this.Name = "FrmVitoria";
            this.Text = "FrmVitoria";
            ((System.ComponentModel.ISupportInitialize)(this.picMatematico)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pic2;
        private System.Windows.Forms.PictureBox pic1;
        private System.Windows.Forms.Label lblParabens;
        private System.Windows.Forms.Label lblNomedados;
        private System.Windows.Forms.Label lblpersonagem;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblMatematico;
        private System.Windows.Forms.PictureBox picMatematico;
        private System.Windows.Forms.Label lblClique;
        private System.Windows.Forms.Button btnVoltar;
    }
}