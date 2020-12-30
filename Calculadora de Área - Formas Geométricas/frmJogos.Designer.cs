namespace Forms_Tomas_Conti_33
{
    partial class frmJogos
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
            this.lbljogodasoma = new System.Windows.Forms.Label();
            this.btnsortearsoma = new System.Windows.Forms.Button();
            this.lblEscrevaResultado = new System.Windows.Forms.Label();
            this.txtresultado = new System.Windows.Forms.TextBox();
            this.btnmostrarresult = new System.Windows.Forms.Button();
            this.btnvoltarconta = new System.Windows.Forms.Button();
            this.lblResultado = new System.Windows.Forms.Label();
            this.btnHelp = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txterros = new System.Windows.Forms.TextBox();
            this.lblerros = new System.Windows.Forms.Label();
            this.lblacertos = new System.Windows.Forms.Label();
            this.txtpontuacao = new System.Windows.Forms.TextBox();
            this.lblCreditos = new System.Windows.Forms.Label();
            this.lblnome = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.picSoma = new System.Windows.Forms.PictureBox();
            this.lblPos = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSoma)).BeginInit();
            this.SuspendLayout();
            // 
            // lbljogodasoma
            // 
            this.lbljogodasoma.AutoSize = true;
            this.lbljogodasoma.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbljogodasoma.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbljogodasoma.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbljogodasoma.Location = new System.Drawing.Point(284, 7);
            this.lbljogodasoma.Name = "lbljogodasoma";
            this.lbljogodasoma.Size = new System.Drawing.Size(179, 31);
            this.lbljogodasoma.TabIndex = 9;
            this.lbljogodasoma.Text = "Jogo da conta";
            // 
            // btnsortearsoma
            // 
            this.btnsortearsoma.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnsortearsoma.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsortearsoma.Location = new System.Drawing.Point(194, 212);
            this.btnsortearsoma.Name = "btnsortearsoma";
            this.btnsortearsoma.Size = new System.Drawing.Size(357, 52);
            this.btnsortearsoma.TabIndex = 0;
            this.btnsortearsoma.Text = "Sortear conta";
            this.btnsortearsoma.UseVisualStyleBackColor = false;
            this.btnsortearsoma.Click += new System.EventHandler(this.btnsortearsoma_Click);
            // 
            // lblEscrevaResultado
            // 
            this.lblEscrevaResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEscrevaResultado.Location = new System.Drawing.Point(194, 280);
            this.lblEscrevaResultado.Name = "lblEscrevaResultado";
            this.lblEscrevaResultado.Size = new System.Drawing.Size(124, 49);
            this.lblEscrevaResultado.TabIndex = 4;
            this.lblEscrevaResultado.Text = "Escreva o resultado:";
            this.lblEscrevaResultado.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtresultado
            // 
            this.txtresultado.BackColor = System.Drawing.SystemColors.Menu;
            this.txtresultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtresultado.Location = new System.Drawing.Point(324, 287);
            this.txtresultado.Name = "txtresultado";
            this.txtresultado.Size = new System.Drawing.Size(184, 37);
            this.txtresultado.TabIndex = 1;
            this.txtresultado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtresultado_KeyPress_1);
            // 
            // btnmostrarresult
            // 
            this.btnmostrarresult.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnmostrarresult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmostrarresult.Location = new System.Drawing.Point(602, 212);
            this.btnmostrarresult.Name = "btnmostrarresult";
            this.btnmostrarresult.Size = new System.Drawing.Size(137, 54);
            this.btnmostrarresult.TabIndex = 2;
            this.btnmostrarresult.Text = "Mostrar se está correto";
            this.btnmostrarresult.UseVisualStyleBackColor = false;
            this.btnmostrarresult.Click += new System.EventHandler(this.btnmostrarresult_Click);
            // 
            // btnvoltarconta
            // 
            this.btnvoltarconta.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnvoltarconta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnvoltarconta.Location = new System.Drawing.Point(602, 273);
            this.btnvoltarconta.Name = "btnvoltarconta";
            this.btnvoltarconta.Size = new System.Drawing.Size(137, 41);
            this.btnvoltarconta.TabIndex = 10;
            this.btnvoltarconta.Text = "Voltar";
            this.btnvoltarconta.UseVisualStyleBackColor = false;
            this.btnvoltarconta.Click += new System.EventHandler(this.btnvoltarconta_Click);
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultado.ForeColor = System.Drawing.Color.Red;
            this.lblResultado.Location = new System.Drawing.Point(318, 347);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(25, 38);
            this.lblResultado.TabIndex = 12;
            this.lblResultado.Text = "l";
            // 
            // btnHelp
            // 
            this.btnHelp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHelp.Location = new System.Drawing.Point(710, 384);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(30, 31);
            this.btnHelp.TabIndex = 13;
            this.btnHelp.TabStop = false;
            this.btnHelp.Text = "?";
            this.btnHelp.UseVisualStyleBackColor = true;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(598, 388);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 24);
            this.label1.TabIndex = 14;
            this.label1.Text = "instruções:";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Controls.Add(this.txterros);
            this.groupBox1.Controls.Add(this.lblerros);
            this.groupBox1.Controls.Add(this.lblacertos);
            this.groupBox1.Controls.Add(this.txtpontuacao);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(10, 212);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(136, 120);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pontuação";
            // 
            // txterros
            // 
            this.txterros.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txterros.ForeColor = System.Drawing.Color.Red;
            this.txterros.Location = new System.Drawing.Point(101, 73);
            this.txterros.Name = "txterros";
            this.txterros.Size = new System.Drawing.Size(19, 31);
            this.txterros.TabIndex = 5;
            this.txterros.Text = "0";
            this.txterros.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblerros
            // 
            this.lblerros.AutoSize = true;
            this.lblerros.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.lblerros.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblerros.Location = new System.Drawing.Point(40, 83);
            this.lblerros.Name = "lblerros";
            this.lblerros.Size = new System.Drawing.Size(49, 16);
            this.lblerros.TabIndex = 8;
            this.lblerros.Text = "Erros:";
            // 
            // lblacertos
            // 
            this.lblacertos.AutoSize = true;
            this.lblacertos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblacertos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblacertos.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblacertos.Location = new System.Drawing.Point(26, 46);
            this.lblacertos.Name = "lblacertos";
            this.lblacertos.Size = new System.Drawing.Size(65, 16);
            this.lblacertos.TabIndex = 7;
            this.lblacertos.Text = "Acertos:";
            // 
            // txtpontuacao
            // 
            this.txtpontuacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpontuacao.ForeColor = System.Drawing.Color.Lime;
            this.txtpontuacao.Location = new System.Drawing.Point(101, 36);
            this.txtpontuacao.Name = "txtpontuacao";
            this.txtpontuacao.Size = new System.Drawing.Size(19, 31);
            this.txtpontuacao.TabIndex = 6;
            this.txtpontuacao.Text = "0";
            this.txtpontuacao.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblCreditos
            // 
            this.lblCreditos.AutoSize = true;
            this.lblCreditos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreditos.Location = new System.Drawing.Point(10, 397);
            this.lblCreditos.Name = "lblCreditos";
            this.lblCreditos.Size = new System.Drawing.Size(178, 17);
            this.lblCreditos.TabIndex = 18;
            this.lblCreditos.Text = "Developed by Tomas Conti";
            // 
            // lblnome
            // 
            this.lblnome.AutoSize = true;
            this.lblnome.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnome.Location = new System.Drawing.Point(395, 54);
            this.lblnome.Name = "lblnome";
            this.lblnome.Size = new System.Drawing.Size(21, 24);
            this.lblnome.TabIndex = 19;
            this.lblnome.Text = "L";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Forms_Tomas_Conti_33.Properties.Resources.contas1;
            this.pictureBox2.Location = new System.Drawing.Point(10, 24);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(163, 125);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 16;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Forms_Tomas_Conti_33.Properties.Resources.contas;
            this.pictureBox1.Location = new System.Drawing.Point(562, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(177, 125);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // picSoma
            // 
            this.picSoma.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.picSoma.Location = new System.Drawing.Point(194, 120);
            this.picSoma.Name = "picSoma";
            this.picSoma.Size = new System.Drawing.Size(349, 59);
            this.picSoma.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picSoma.TabIndex = 4;
            this.picSoma.TabStop = false;
            // 
            // lblPos
            // 
            this.lblPos.AutoSize = true;
            this.lblPos.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPos.Location = new System.Drawing.Point(211, 54);
            this.lblPos.Name = "lblPos";
            this.lblPos.Size = new System.Drawing.Size(184, 24);
            this.lblPos.TabIndex = 20;
            this.lblPos.Text = "Nome do Jogador:";
            // 
            // frmJogos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(749, 421);
            this.Controls.Add(this.lblPos);
            this.Controls.Add(this.lblnome);
            this.Controls.Add(this.lblCreditos);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.btnvoltarconta);
            this.Controls.Add(this.btnmostrarresult);
            this.Controls.Add(this.txtresultado);
            this.Controls.Add(this.lblEscrevaResultado);
            this.Controls.Add(this.btnsortearsoma);
            this.Controls.Add(this.picSoma);
            this.Controls.Add(this.lbljogodasoma);
            this.Name = "frmJogos";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Formjogos";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSoma)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbljogodasoma;
        private System.Windows.Forms.PictureBox picSoma;
        private System.Windows.Forms.Button btnsortearsoma;
        private System.Windows.Forms.Label lblEscrevaResultado;
        private System.Windows.Forms.TextBox txtresultado;
        private System.Windows.Forms.Button btnmostrarresult;
        private System.Windows.Forms.Button btnvoltarconta;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Button btnHelp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtpontuacao;
        private System.Windows.Forms.TextBox txterros;
        private System.Windows.Forms.Label lblerros;
        private System.Windows.Forms.Label lblacertos;
        private System.Windows.Forms.Label lblCreditos;
        private System.Windows.Forms.Label lblnome;
        private System.Windows.Forms.Label lblPos;
    }
}