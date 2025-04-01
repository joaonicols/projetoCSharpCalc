namespace FolhaDePagamento
{
    partial class frmFolhaDePagamento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFolhaDePagamento));
            this.txtSalario = new System.Windows.Forms.TextBox();
            this.txtImpostoRenda = new System.Windows.Forms.TextBox();
            this.txtSalLiq = new System.Windows.Forms.TextBox();
            this.txtSalarioFolha = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.lblDataFolha = new System.Windows.Forms.Label();
            this.lblSalário = new System.Windows.Forms.Label();
            this.lblClubeLazer = new System.Windows.Forms.Label();
            this.lblSalarioFolha = new System.Windows.Forms.Label();
            this.lblImpRenda = new System.Windows.Forms.Label();
            this.lblSalLiq = new System.Windows.Forms.Label();
            this.chkPlanoSaude = new System.Windows.Forms.CheckBox();
            this.cbbClubeLazer = new System.Windows.Forms.ComboBox();
            this.cbbDataFolha = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // txtSalario
            // 
            this.txtSalario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSalario.Location = new System.Drawing.Point(44, 187);
            this.txtSalario.MaxLength = 10;
            this.txtSalario.Name = "txtSalario";
            this.txtSalario.Size = new System.Drawing.Size(133, 26);
            this.txtSalario.TabIndex = 1;
            // 
            // txtImpostoRenda
            // 
            this.txtImpostoRenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtImpostoRenda.Location = new System.Drawing.Point(370, 206);
            this.txtImpostoRenda.MaxLength = 10;
            this.txtImpostoRenda.Name = "txtImpostoRenda";
            this.txtImpostoRenda.Size = new System.Drawing.Size(133, 26);
            this.txtImpostoRenda.TabIndex = 3;
            // 
            // txtSalLiq
            // 
            this.txtSalLiq.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSalLiq.Location = new System.Drawing.Point(370, 324);
            this.txtSalLiq.MaxLength = 10;
            this.txtSalLiq.Name = "txtSalLiq";
            this.txtSalLiq.Size = new System.Drawing.Size(133, 26);
            this.txtSalLiq.TabIndex = 4;
            // 
            // txtSalarioFolha
            // 
            this.txtSalarioFolha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSalarioFolha.Location = new System.Drawing.Point(370, 99);
            this.txtSalarioFolha.MaxLength = 10;
            this.txtSalarioFolha.Name = "txtSalarioFolha";
            this.txtSalarioFolha.Size = new System.Drawing.Size(133, 26);
            this.txtSalarioFolha.TabIndex = 5;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.Image = ((System.Drawing.Image)(resources.GetObject("btnCalcular.Image")));
            this.btnCalcular.Location = new System.Drawing.Point(628, 108);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(138, 69);
            this.btnCalcular.TabIndex = 9;
            this.btnCalcular.Text = "&Calcular";
            this.btnCalcular.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCalcular.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.Image = ((System.Drawing.Image)(resources.GetObject("btnLimpar.Image")));
            this.btnLimpar.Location = new System.Drawing.Point(628, 194);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(138, 69);
            this.btnLimpar.TabIndex = 10;
            this.btnLimpar.Text = "&Limpar";
            this.btnLimpar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLimpar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLimpar.UseVisualStyleBackColor = true;
            // 
            // btnSair
            // 
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.Image = ((System.Drawing.Image)(resources.GetObject("btnSair.Image")));
            this.btnSair.Location = new System.Drawing.Point(628, 281);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(138, 69);
            this.btnSair.TabIndex = 11;
            this.btnSair.Text = "&Sair";
            this.btnSair.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSair.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSair.UseVisualStyleBackColor = true;
            // 
            // lblDataFolha
            // 
            this.lblDataFolha.AutoSize = true;
            this.lblDataFolha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataFolha.Location = new System.Drawing.Point(42, 59);
            this.lblDataFolha.Name = "lblDataFolha";
            this.lblDataFolha.Size = new System.Drawing.Size(110, 20);
            this.lblDataFolha.TabIndex = 12;
            this.lblDataFolha.Text = "Data da Folha";
            this.lblDataFolha.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblSalário
            // 
            this.lblSalário.AutoSize = true;
            this.lblSalário.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalário.Location = new System.Drawing.Point(42, 164);
            this.lblSalário.Name = "lblSalário";
            this.lblSalário.Size = new System.Drawing.Size(58, 20);
            this.lblSalário.TabIndex = 13;
            this.lblSalário.Text = "Salário";
            // 
            // lblClubeLazer
            // 
            this.lblClubeLazer.AutoSize = true;
            this.lblClubeLazer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClubeLazer.Location = new System.Drawing.Point(42, 298);
            this.lblClubeLazer.Name = "lblClubeLazer";
            this.lblClubeLazer.Size = new System.Drawing.Size(116, 20);
            this.lblClubeLazer.TabIndex = 14;
            this.lblClubeLazer.Text = "Clube de Lazer";
            // 
            // lblSalarioFolha
            // 
            this.lblSalarioFolha.AutoSize = true;
            this.lblSalarioFolha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalarioFolha.Location = new System.Drawing.Point(366, 76);
            this.lblSalarioFolha.Name = "lblSalarioFolha";
            this.lblSalarioFolha.Size = new System.Drawing.Size(102, 20);
            this.lblSalarioFolha.TabIndex = 15;
            this.lblSalarioFolha.Text = "Salário Folha";
            this.lblSalarioFolha.Click += new System.EventHandler(this.label4_Click);
            // 
            // lblImpRenda
            // 
            this.lblImpRenda.AutoSize = true;
            this.lblImpRenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImpRenda.Location = new System.Drawing.Point(366, 183);
            this.lblImpRenda.Name = "lblImpRenda";
            this.lblImpRenda.Size = new System.Drawing.Size(141, 20);
            this.lblImpRenda.TabIndex = 16;
            this.lblImpRenda.Text = "Imposto de Renda";
            this.lblImpRenda.Click += new System.EventHandler(this.label5_Click);
            // 
            // lblSalLiq
            // 
            this.lblSalLiq.AutoSize = true;
            this.lblSalLiq.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalLiq.Location = new System.Drawing.Point(366, 301);
            this.lblSalLiq.Name = "lblSalLiq";
            this.lblSalLiq.Size = new System.Drawing.Size(113, 20);
            this.lblSalLiq.TabIndex = 17;
            this.lblSalLiq.Text = "Salário Líquido";
            this.lblSalLiq.Click += new System.EventHandler(this.label6_Click);
            // 
            // chkPlanoSaude
            // 
            this.chkPlanoSaude.AutoSize = true;
            this.chkPlanoSaude.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkPlanoSaude.Location = new System.Drawing.Point(46, 236);
            this.chkPlanoSaude.Name = "chkPlanoSaude";
            this.chkPlanoSaude.Size = new System.Drawing.Size(131, 22);
            this.chkPlanoSaude.TabIndex = 18;
            this.chkPlanoSaude.Text = "Plano de Saúde";
            this.chkPlanoSaude.UseVisualStyleBackColor = true;
            // 
            // cbbClubeLazer
            // 
            this.cbbClubeLazer.FormattingEnabled = true;
            this.cbbClubeLazer.Items.AddRange(new object[] {
            "Clube A",
            "Clube B",
            "Clube C"});
            this.cbbClubeLazer.Location = new System.Drawing.Point(46, 321);
            this.cbbClubeLazer.Name = "cbbClubeLazer";
            this.cbbClubeLazer.Size = new System.Drawing.Size(139, 21);
            this.cbbClubeLazer.TabIndex = 19;
            // 
            // cbbDataFolha
            // 
            this.cbbDataFolha.FormattingEnabled = true;
            this.cbbDataFolha.Location = new System.Drawing.Point(38, 82);
            this.cbbDataFolha.Name = "cbbDataFolha";
            this.cbbDataFolha.Size = new System.Drawing.Size(139, 21);
            this.cbbDataFolha.TabIndex = 20;
            // 
            // frmFolhaDePagamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cbbDataFolha);
            this.Controls.Add(this.cbbClubeLazer);
            this.Controls.Add(this.chkPlanoSaude);
            this.Controls.Add(this.lblSalLiq);
            this.Controls.Add(this.lblImpRenda);
            this.Controls.Add(this.lblSalarioFolha);
            this.Controls.Add(this.lblClubeLazer);
            this.Controls.Add(this.lblSalário);
            this.Controls.Add(this.lblDataFolha);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtSalarioFolha);
            this.Controls.Add(this.txtSalLiq);
            this.Controls.Add(this.txtImpostoRenda);
            this.Controls.Add(this.txtSalario);
            this.Name = "frmFolhaDePagamento";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtSalario;
        private System.Windows.Forms.TextBox txtImpostoRenda;
        private System.Windows.Forms.TextBox txtSalLiq;
        private System.Windows.Forms.TextBox txtSalarioFolha;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Label lblDataFolha;
        private System.Windows.Forms.Label lblSalário;
        private System.Windows.Forms.Label lblClubeLazer;
        private System.Windows.Forms.Label lblSalarioFolha;
        private System.Windows.Forms.Label lblImpRenda;
        private System.Windows.Forms.Label lblSalLiq;
        private System.Windows.Forms.CheckBox chkPlanoSaude;
        private System.Windows.Forms.ComboBox cbbClubeLazer;
        private System.Windows.Forms.ComboBox cbbDataFolha;
    }
}