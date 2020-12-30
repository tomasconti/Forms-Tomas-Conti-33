namespace Forms_Tomas_Conti_33
{
    partial class frmMenu
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
            this.lblEscolha = new System.Windows.Forms.Label();
            this.lblJogos = new System.Windows.Forms.Label();
            this.btnJogos = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnCalcArea = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblMenu
            // 
            this.lblMenu.AutoSize = true;
            this.lblMenu.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblMenu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMenu.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblMenu.Location = new System.Drawing.Point(399, 26);
            this.lblMenu.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMenu.Name = "lblMenu";
            this.lblMenu.Size = new System.Drawing.Size(96, 38);
            this.lblMenu.TabIndex = 1;
            this.lblMenu.Text = "Menu";
            // 
            // lblEscolha
            // 
            this.lblEscolha.AutoSize = true;
            this.lblEscolha.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.lblEscolha.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEscolha.Location = new System.Drawing.Point(357, 131);
            this.lblEscolha.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEscolha.Name = "lblEscolha";
            this.lblEscolha.Size = new System.Drawing.Size(173, 36);
            this.lblEscolha.TabIndex = 2;
            this.lblEscolha.Text = "Bem vindo!";
            // 
            // lblJogos
            // 
            this.lblJogos.AutoSize = true;
            this.lblJogos.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.lblJogos.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJogos.Location = new System.Drawing.Point(242, 167);
            this.lblJogos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblJogos.Name = "lblJogos";
            this.lblJogos.Size = new System.Drawing.Size(404, 36);
            this.lblJogos.TabIndex = 3;
            this.lblJogos.Text = "Escolha o que quer utilizar ";
            // 
            // btnJogos
            // 
            this.btnJogos.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnJogos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnJogos.Location = new System.Drawing.Point(299, 328);
            this.btnJogos.Margin = new System.Windows.Forms.Padding(4);
            this.btnJogos.Name = "btnJogos";
            this.btnJogos.Size = new System.Drawing.Size(305, 64);
            this.btnJogos.TabIndex = 5;
            this.btnJogos.Text = "Jogo das contas";
            this.btnJogos.UseVisualStyleBackColor = false;
            this.btnJogos.Click += new System.EventHandler(this.btnJogos_Click);
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.Location = new System.Drawing.Point(299, 400);
            this.btnSair.Margin = new System.Windows.Forms.Padding(4);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(305, 64);
            this.btnSair.TabIndex = 6;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnCalcArea
            // 
            this.btnCalcArea.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnCalcArea.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcArea.Location = new System.Drawing.Point(299, 256);
            this.btnCalcArea.Margin = new System.Windows.Forms.Padding(4);
            this.btnCalcArea.Name = "btnCalcArea";
            this.btnCalcArea.Size = new System.Drawing.Size(305, 64);
            this.btnCalcArea.TabIndex = 7;
            this.btnCalcArea.Text = "Calculadora de área";
            this.btnCalcArea.UseVisualStyleBackColor = false;
            this.btnCalcArea.Click += new System.EventHandler(this.btnCalcArea_Click_1);
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(877, 524);
            this.Controls.Add(this.btnCalcArea);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnJogos);
            this.Controls.Add(this.lblJogos);
            this.Controls.Add(this.lblEscolha);
            this.Controls.Add(this.lblMenu);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmMenu";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMenu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMenu;
        private System.Windows.Forms.Label lblEscolha;
        private System.Windows.Forms.Label lblJogos;
        private System.Windows.Forms.Button btnJogos;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnCalcArea;
    }
}