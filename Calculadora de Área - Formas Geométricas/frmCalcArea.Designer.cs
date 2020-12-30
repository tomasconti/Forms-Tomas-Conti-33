namespace Forms_Tomas_Conti_33
{
    partial class frmCalcArea
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
            this.radbtnTriangulo = new System.Windows.Forms.RadioButton();
            this.lblBase = new System.Windows.Forms.Label();
            this.lblAltura = new System.Windows.Forms.Label();
            this.txtBase = new System.Windows.Forms.TextBox();
            this.txtAltura = new System.Windows.Forms.TextBox();
            this.lblUnidMedidaBase = new System.Windows.Forms.Label();
            this.lblUnidMedidaAltura = new System.Windows.Forms.Label();
            this.grpboxFigura = new System.Windows.Forms.GroupBox();
            this.radbtnRetangulo = new System.Windows.Forms.RadioButton();
            this.grpboxUnidMedida = new System.Windows.Forms.GroupBox();
            this.radbtnM = new System.Windows.Forms.RadioButton();
            this.radbtnCm = new System.Windows.Forms.RadioButton();
            this.lblResposta = new System.Windows.Forms.Label();
            this.lblUnidMedidaResposta = new System.Windows.Forms.Label();
            this.lblR = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.grpboxButtons = new System.Windows.Forms.GroupBox();
            this.btnHelp = new System.Windows.Forms.Button();
            this.lbl2 = new System.Windows.Forms.Label();
            this.imgTriangulo = new System.Windows.Forms.PictureBox();
            this.imgRetangulo = new System.Windows.Forms.PictureBox();
            this.grpboxFigura.SuspendLayout();
            this.grpboxUnidMedida.SuspendLayout();
            this.grpboxButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgTriangulo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgRetangulo)).BeginInit();
            this.SuspendLayout();
            // 
            // radbtnTriangulo
            // 
            this.radbtnTriangulo.AutoSize = true;
            this.radbtnTriangulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radbtnTriangulo.Location = new System.Drawing.Point(32, 98);
            this.radbtnTriangulo.Margin = new System.Windows.Forms.Padding(4);
            this.radbtnTriangulo.Name = "radbtnTriangulo";
            this.radbtnTriangulo.Size = new System.Drawing.Size(208, 29);
            this.radbtnTriangulo.TabIndex = 1;
            this.radbtnTriangulo.Text = "Triângulo Retângulo";
            this.radbtnTriangulo.UseVisualStyleBackColor = true;
            this.radbtnTriangulo.CheckedChanged += new System.EventHandler(this.radbtnTriangulo_CheckedChanged);
            // 
            // lblBase
            // 
            this.lblBase.AutoSize = true;
            this.lblBase.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBase.Location = new System.Drawing.Point(28, 210);
            this.lblBase.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBase.Name = "lblBase";
            this.lblBase.Size = new System.Drawing.Size(195, 36);
            this.lblBase.TabIndex = 5;
            this.lblBase.Text = "Digite a base:";
            // 
            // lblAltura
            // 
            this.lblAltura.AutoSize = true;
            this.lblAltura.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAltura.Location = new System.Drawing.Point(20, 279);
            this.lblAltura.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAltura.Name = "lblAltura";
            this.lblAltura.Size = new System.Drawing.Size(205, 36);
            this.lblAltura.TabIndex = 6;
            this.lblAltura.Text = "Digite a altura:";
            // 
            // txtBase
            // 
            this.txtBase.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBase.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtBase.Location = new System.Drawing.Point(241, 207);
            this.txtBase.Margin = new System.Windows.Forms.Padding(4);
            this.txtBase.Name = "txtBase";
            this.txtBase.Size = new System.Drawing.Size(209, 41);
            this.txtBase.TabIndex = 2;
            this.txtBase.TextChanged += new System.EventHandler(this.txtBase_TextChanged);
            // 
            // txtAltura
            // 
            this.txtAltura.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAltura.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtAltura.Location = new System.Drawing.Point(241, 276);
            this.txtAltura.Margin = new System.Windows.Forms.Padding(4);
            this.txtAltura.Name = "txtAltura";
            this.txtAltura.Size = new System.Drawing.Size(209, 41);
            this.txtAltura.TabIndex = 3;
            this.txtAltura.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAltura_KeyPress);
            // 
            // lblUnidMedidaBase
            // 
            this.lblUnidMedidaBase.AutoSize = true;
            this.lblUnidMedidaBase.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnidMedidaBase.Location = new System.Drawing.Point(460, 210);
            this.lblUnidMedidaBase.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUnidMedidaBase.Name = "lblUnidMedidaBase";
            this.lblUnidMedidaBase.Size = new System.Drawing.Size(38, 36);
            this.lblUnidMedidaBase.TabIndex = 9;
            this.lblUnidMedidaBase.Text = "m";
            this.lblUnidMedidaBase.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblUnidMedidaAltura
            // 
            this.lblUnidMedidaAltura.AutoSize = true;
            this.lblUnidMedidaAltura.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnidMedidaAltura.Location = new System.Drawing.Point(460, 279);
            this.lblUnidMedidaAltura.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUnidMedidaAltura.Name = "lblUnidMedidaAltura";
            this.lblUnidMedidaAltura.Size = new System.Drawing.Size(38, 36);
            this.lblUnidMedidaAltura.TabIndex = 10;
            this.lblUnidMedidaAltura.Text = "m";
            // 
            // grpboxFigura
            // 
            this.grpboxFigura.Controls.Add(this.radbtnRetangulo);
            this.grpboxFigura.Controls.Add(this.radbtnTriangulo);
            this.grpboxFigura.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpboxFigura.Location = new System.Drawing.Point(372, 27);
            this.grpboxFigura.Margin = new System.Windows.Forms.Padding(4);
            this.grpboxFigura.Name = "grpboxFigura";
            this.grpboxFigura.Padding = new System.Windows.Forms.Padding(4);
            this.grpboxFigura.Size = new System.Drawing.Size(292, 148);
            this.grpboxFigura.TabIndex = 11;
            this.grpboxFigura.TabStop = false;
            this.grpboxFigura.Text = "Selecione a figura geométrica:";
            // 
            // radbtnRetangulo
            // 
            this.radbtnRetangulo.AutoSize = true;
            this.radbtnRetangulo.Checked = true;
            this.radbtnRetangulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radbtnRetangulo.Location = new System.Drawing.Point(32, 59);
            this.radbtnRetangulo.Margin = new System.Windows.Forms.Padding(4);
            this.radbtnRetangulo.Name = "radbtnRetangulo";
            this.radbtnRetangulo.Size = new System.Drawing.Size(121, 29);
            this.radbtnRetangulo.TabIndex = 0;
            this.radbtnRetangulo.TabStop = true;
            this.radbtnRetangulo.Text = "Retângulo";
            this.radbtnRetangulo.UseVisualStyleBackColor = true;
            this.radbtnRetangulo.CheckedChanged += new System.EventHandler(this.radbtnRetangulo_CheckedChanged);
            // 
            // grpboxUnidMedida
            // 
            this.grpboxUnidMedida.Controls.Add(this.radbtnM);
            this.grpboxUnidMedida.Controls.Add(this.radbtnCm);
            this.grpboxUnidMedida.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpboxUnidMedida.Location = new System.Drawing.Point(672, 27);
            this.grpboxUnidMedida.Margin = new System.Windows.Forms.Padding(4);
            this.grpboxUnidMedida.Name = "grpboxUnidMedida";
            this.grpboxUnidMedida.Padding = new System.Windows.Forms.Padding(4);
            this.grpboxUnidMedida.Size = new System.Drawing.Size(229, 148);
            this.grpboxUnidMedida.TabIndex = 12;
            this.grpboxUnidMedida.TabStop = false;
            this.grpboxUnidMedida.Text = "Selecione a Unidade de Medida:";
            // 
            // radbtnM
            // 
            this.radbtnM.AutoSize = true;
            this.radbtnM.Checked = true;
            this.radbtnM.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radbtnM.Location = new System.Drawing.Point(124, 73);
            this.radbtnM.Margin = new System.Windows.Forms.Padding(4);
            this.radbtnM.Name = "radbtnM";
            this.radbtnM.Size = new System.Drawing.Size(49, 29);
            this.radbtnM.TabIndex = 5;
            this.radbtnM.TabStop = true;
            this.radbtnM.Text = "m";
            this.radbtnM.UseVisualStyleBackColor = true;
            this.radbtnM.CheckedChanged += new System.EventHandler(this.radbtnM_CheckedChanged);
            // 
            // radbtnCm
            // 
            this.radbtnCm.AutoSize = true;
            this.radbtnCm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radbtnCm.Location = new System.Drawing.Point(39, 73);
            this.radbtnCm.Margin = new System.Windows.Forms.Padding(4);
            this.radbtnCm.Name = "radbtnCm";
            this.radbtnCm.Size = new System.Drawing.Size(59, 29);
            this.radbtnCm.TabIndex = 5;
            this.radbtnCm.Text = "cm";
            this.radbtnCm.UseVisualStyleBackColor = true;
            this.radbtnCm.CheckedChanged += new System.EventHandler(this.radbtnCm_CheckedChanged);
            // 
            // lblResposta
            // 
            this.lblResposta.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblResposta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblResposta.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResposta.Location = new System.Drawing.Point(241, 347);
            this.lblResposta.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblResposta.Name = "lblResposta";
            this.lblResposta.Size = new System.Drawing.Size(210, 43);
            this.lblResposta.TabIndex = 13;
            this.lblResposta.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblUnidMedidaResposta
            // 
            this.lblUnidMedidaResposta.AutoSize = true;
            this.lblUnidMedidaResposta.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnidMedidaResposta.Location = new System.Drawing.Point(460, 352);
            this.lblUnidMedidaResposta.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUnidMedidaResposta.Name = "lblUnidMedidaResposta";
            this.lblUnidMedidaResposta.Size = new System.Drawing.Size(38, 36);
            this.lblUnidMedidaResposta.TabIndex = 14;
            this.lblUnidMedidaResposta.Text = "m";
            // 
            // lblR
            // 
            this.lblR.AutoSize = true;
            this.lblR.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblR.Location = new System.Drawing.Point(80, 352);
            this.lblR.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblR.Name = "lblR";
            this.lblR.Size = new System.Drawing.Size(149, 36);
            this.lblR.TabIndex = 15;
            this.lblR.Text = "Resposta:";
            // 
            // btnCalcular
            // 
            this.btnCalcular.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.Location = new System.Drawing.Point(21, 23);
            this.btnCalcular.Margin = new System.Windows.Forms.Padding(4);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(128, 43);
            this.btnCalcular.TabIndex = 4;
            this.btnCalcular.Text = "&Calcular";
            this.btnCalcular.UseVisualStyleBackColor = false;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.Location = new System.Drawing.Point(21, 80);
            this.btnLimpar.Margin = new System.Windows.Forms.Padding(4);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(128, 43);
            this.btnLimpar.TabIndex = 6;
            this.btnLimpar.Text = "&Limpar";
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.Location = new System.Drawing.Point(21, 134);
            this.btnSair.Margin = new System.Windows.Forms.Padding(4);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(128, 43);
            this.btnSair.TabIndex = 7;
            this.btnSair.Text = "Voltar";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // grpboxButtons
            // 
            this.grpboxButtons.Controls.Add(this.btnCalcular);
            this.grpboxButtons.Controls.Add(this.btnSair);
            this.grpboxButtons.Controls.Add(this.btnLimpar);
            this.grpboxButtons.Location = new System.Drawing.Point(609, 196);
            this.grpboxButtons.Margin = new System.Windows.Forms.Padding(4);
            this.grpboxButtons.Name = "grpboxButtons";
            this.grpboxButtons.Padding = new System.Windows.Forms.Padding(4);
            this.grpboxButtons.Size = new System.Drawing.Size(177, 194);
            this.grpboxButtons.TabIndex = 19;
            this.grpboxButtons.TabStop = false;
            // 
            // btnHelp
            // 
            this.btnHelp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHelp.Location = new System.Drawing.Point(861, 367);
            this.btnHelp.Margin = new System.Windows.Forms.Padding(4);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(40, 38);
            this.btnHelp.TabIndex = 8;
            this.btnHelp.TabStop = false;
            this.btnHelp.Text = "?";
            this.btnHelp.UseVisualStyleBackColor = true;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2.Location = new System.Drawing.Point(489, 347);
            this.lbl2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(17, 18);
            this.lbl2.TabIndex = 20;
            this.lbl2.Text = "2";
            // 
            // imgTriangulo
            // 
            this.imgTriangulo.Image = global::Forms_Tomas_Conti_33.Properties.Resources.triangulo_retangulo;
            this.imgTriangulo.Location = new System.Drawing.Point(28, 27);
            this.imgTriangulo.Margin = new System.Windows.Forms.Padding(4);
            this.imgTriangulo.Name = "imgTriangulo";
            this.imgTriangulo.Size = new System.Drawing.Size(336, 148);
            this.imgTriangulo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgTriangulo.TabIndex = 4;
            this.imgTriangulo.TabStop = false;
            this.imgTriangulo.Visible = false;
            // 
            // imgRetangulo
            // 
            this.imgRetangulo.Image = global::Forms_Tomas_Conti_33.Properties.Resources.retangulo;
            this.imgRetangulo.Location = new System.Drawing.Point(28, 27);
            this.imgRetangulo.Margin = new System.Windows.Forms.Padding(4);
            this.imgRetangulo.Name = "imgRetangulo";
            this.imgRetangulo.Size = new System.Drawing.Size(336, 148);
            this.imgRetangulo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgRetangulo.TabIndex = 1;
            this.imgRetangulo.TabStop = false;
            // 
            // frmCalcArea
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(951, 420);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.grpboxButtons);
            this.Controls.Add(this.lblR);
            this.Controls.Add(this.lblUnidMedidaResposta);
            this.Controls.Add(this.lblResposta);
            this.Controls.Add(this.grpboxUnidMedida);
            this.Controls.Add(this.grpboxFigura);
            this.Controls.Add(this.lblUnidMedidaAltura);
            this.Controls.Add(this.lblUnidMedidaBase);
            this.Controls.Add(this.txtAltura);
            this.Controls.Add(this.txtBase);
            this.Controls.Add(this.lblAltura);
            this.Controls.Add(this.lblBase);
            this.Controls.Add(this.imgTriangulo);
            this.Controls.Add(this.imgRetangulo);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimizeBox = false;
            this.Name = "frmCalcArea";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculadora de Área - Formas Geométricas";
            this.TopMost = true;
            this.grpboxFigura.ResumeLayout(false);
            this.grpboxFigura.PerformLayout();
            this.grpboxUnidMedida.ResumeLayout(false);
            this.grpboxUnidMedida.PerformLayout();
            this.grpboxButtons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imgTriangulo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgRetangulo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox imgRetangulo;
        private System.Windows.Forms.RadioButton radbtnTriangulo;
        private System.Windows.Forms.PictureBox imgTriangulo;
        private System.Windows.Forms.Label lblBase;
        private System.Windows.Forms.Label lblAltura;
        private System.Windows.Forms.TextBox txtBase;
        private System.Windows.Forms.TextBox txtAltura;
        private System.Windows.Forms.Label lblUnidMedidaBase;
        private System.Windows.Forms.Label lblUnidMedidaAltura;
        private System.Windows.Forms.GroupBox grpboxFigura;
        private System.Windows.Forms.GroupBox grpboxUnidMedida;
        private System.Windows.Forms.RadioButton radbtnCm;
        private System.Windows.Forms.Label lblResposta;
        private System.Windows.Forms.Label lblUnidMedidaResposta;
        private System.Windows.Forms.Label lblR;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.GroupBox grpboxButtons;
        private System.Windows.Forms.Button btnHelp;
        private System.Windows.Forms.RadioButton radbtnRetangulo;
        private System.Windows.Forms.RadioButton radbtnM;
        private System.Windows.Forms.Label lbl2;
    }
}

