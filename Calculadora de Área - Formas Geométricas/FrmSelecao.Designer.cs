namespace Forms_Tomas_Conti_33
{
    partial class FrmSelecao
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
            this.lblMenu = new System.Windows.Forms.Label();
            this.btnPróximo = new System.Windows.Forms.Button();
            this.btnAnterior = new System.Windows.Forms.Button();
            this.lblMatematico = new System.Windows.Forms.Label();
            this.btnDados = new System.Windows.Forms.Button();
            this.lblNome = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.btnJogar = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.picmatematico = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picmatematico)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMenu
            // 
            this.lblMenu.AutoSize = true;
            this.lblMenu.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblMenu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMenu.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblMenu.Location = new System.Drawing.Point(264, 9);
            this.lblMenu.Name = "lblMenu";
            this.lblMenu.Size = new System.Drawing.Size(303, 31);
            this.lblMenu.TabIndex = 2;
            this.lblMenu.Text = "Seleçâo de Personagem";
            // 
            // btnPróximo
            // 
            this.btnPróximo.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnPróximo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPróximo.Location = new System.Drawing.Point(519, 187);
            this.btnPróximo.Margin = new System.Windows.Forms.Padding(2);
            this.btnPróximo.Name = "btnPróximo";
            this.btnPróximo.Size = new System.Drawing.Size(83, 34);
            this.btnPróximo.TabIndex = 9;
            this.btnPróximo.Text = "Proximo";
            this.btnPróximo.UseVisualStyleBackColor = false;
            this.btnPróximo.Click += new System.EventHandler(this.btnPróximo_Click);
            // 
            // btnAnterior
            // 
            this.btnAnterior.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnAnterior.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnterior.Location = new System.Drawing.Point(209, 187);
            this.btnAnterior.Margin = new System.Windows.Forms.Padding(2);
            this.btnAnterior.Name = "btnAnterior";
            this.btnAnterior.Size = new System.Drawing.Size(83, 34);
            this.btnAnterior.TabIndex = 10;
            this.btnAnterior.Text = "Anterior";
            this.btnAnterior.UseVisualStyleBackColor = false;
            this.btnAnterior.Click += new System.EventHandler(this.btnAnterior_Click);
            // 
            // lblMatematico
            // 
            this.lblMatematico.AutoSize = true;
            this.lblMatematico.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMatematico.Location = new System.Drawing.Point(334, 224);
            this.lblMatematico.Name = "lblMatematico";
            this.lblMatematico.Size = new System.Drawing.Size(149, 29);
            this.lblMatematico.TabIndex = 12;
            this.lblMatematico.Text = "Albert Eisten";
            this.lblMatematico.Click += new System.EventHandler(this.lblMatematico_Click);
            // 
            // btnDados
            // 
            this.btnDados.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnDados.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDados.Location = new System.Drawing.Point(285, 256);
            this.btnDados.Name = "btnDados";
            this.btnDados.Size = new System.Drawing.Size(229, 52);
            this.btnDados.TabIndex = 13;
            this.btnDados.Text = "Dados sobre matemático";
            this.btnDados.UseVisualStyleBackColor = false;
            this.btnDados.Click += new System.EventHandler(this.btnDados_Click);
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.lblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(92, 346);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(168, 24);
            this.lblNome.TabIndex = 14;
            this.lblNome.Text = "Digite seu nome:";
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtNome.Location = new System.Drawing.Point(264, 346);
            this.txtNome.Margin = new System.Windows.Forms.Padding(2);
            this.txtNome.MaxLength = 8;
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(138, 27);
            this.txtNome.TabIndex = 16;
            // 
            // btnJogar
            // 
            this.btnJogar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnJogar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnJogar.Location = new System.Drawing.Point(545, 321);
            this.btnJogar.Name = "btnJogar";
            this.btnJogar.Size = new System.Drawing.Size(229, 52);
            this.btnJogar.TabIndex = 17;
            this.btnJogar.Text = "Jogar!!";
            this.btnJogar.UseVisualStyleBackColor = false;
            this.btnJogar.Click += new System.EventHandler(this.btnJogar_Click);
            // 
            // btnVoltar
            // 
            this.btnVoltar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnVoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar.Location = new System.Drawing.Point(3, 413);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(182, 47);
            this.btnVoltar.TabIndex = 18;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = false;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // picmatematico
            // 
            this.picmatematico.Image = global::Forms_Tomas_Conti_33.Properties.Resources.matematico1;
            this.picmatematico.Location = new System.Drawing.Point(297, 58);
            this.picmatematico.Name = "picmatematico";
            this.picmatematico.Size = new System.Drawing.Size(217, 163);
            this.picmatematico.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picmatematico.TabIndex = 11;
            this.picmatematico.TabStop = false;
            // 
            // FrmSelecao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(800, 472);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnJogar);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.btnDados);
            this.Controls.Add(this.lblMatematico);
            this.Controls.Add(this.picmatematico);
            this.Controls.Add(this.btnAnterior);
            this.Controls.Add(this.btnPróximo);
            this.Controls.Add(this.lblMenu);
            this.Name = "FrmSelecao";
            this.Text = "Selecao de Personagem";
            ((System.ComponentModel.ISupportInitialize)(this.picmatematico)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMenu;
        private System.Windows.Forms.Button btnPróximo;
        private System.Windows.Forms.Button btnAnterior;
        private System.Windows.Forms.PictureBox picmatematico;
        private System.Windows.Forms.Label lblMatematico;
        private System.Windows.Forms.Button btnDados;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Button btnJogar;
        private System.Windows.Forms.Button btnVoltar;
    }
}