namespace ProjetoOrientacaoObjeto
{
    partial class frmExecutaPessoa
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
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.lblNome = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.gpbMostraRegistro = new System.Windows.Forms.GroupBox();
            this.lblMostraIdade = new System.Windows.Forms.Label();
            this.lblMostraTel = new System.Windows.Forms.Label();
            this.lblMostraCPF = new System.Windows.Forms.Label();
            this.lblMostraEmail = new System.Windows.Forms.Label();
            this.lblMostrarNome = new System.Windows.Forms.Label();
            this.gpbDadosPessoais = new System.Windows.Forms.GroupBox();
            this.mtbTelefone = new System.Windows.Forms.MaskedTextBox();
            this.mtbCpf = new System.Windows.Forms.MaskedTextBox();
            this.txtIdade = new System.Windows.Forms.TextBox();
            this.lbl_Idade = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCPF = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.gpbMostraRegistro.SuspendLayout();
            this.gpbDadosPessoais.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrar.Location = new System.Drawing.Point(618, 339);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(136, 80);
            this.btnCadastrar.TabIndex = 0;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(16, 29);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(55, 20);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Nome:";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(82, 29);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(150, 20);
            this.txtNome.TabIndex = 1;
            // 
            // gpbMostraRegistro
            // 
            this.gpbMostraRegistro.Controls.Add(this.lblMostraIdade);
            this.gpbMostraRegistro.Controls.Add(this.lblMostraTel);
            this.gpbMostraRegistro.Controls.Add(this.lblMostraCPF);
            this.gpbMostraRegistro.Controls.Add(this.lblMostraEmail);
            this.gpbMostraRegistro.Controls.Add(this.lblMostrarNome);
            this.gpbMostraRegistro.Location = new System.Drawing.Point(229, 199);
            this.gpbMostraRegistro.Name = "gpbMostraRegistro";
            this.gpbMostraRegistro.Size = new System.Drawing.Size(251, 220);
            this.gpbMostraRegistro.TabIndex = 2;
            this.gpbMostraRegistro.TabStop = false;
            this.gpbMostraRegistro.Text = "Mostrar Registros";
            // 
            // lblMostraIdade
            // 
            this.lblMostraIdade.AutoSize = true;
            this.lblMostraIdade.Location = new System.Drawing.Point(17, 185);
            this.lblMostraIdade.Name = "lblMostraIdade";
            this.lblMostraIdade.Size = new System.Drawing.Size(37, 13);
            this.lblMostraIdade.TabIndex = 5;
            this.lblMostraIdade.Text = "Idade:";
            // 
            // lblMostraTel
            // 
            this.lblMostraTel.AutoSize = true;
            this.lblMostraTel.Location = new System.Drawing.Point(16, 140);
            this.lblMostraTel.Name = "lblMostraTel";
            this.lblMostraTel.Size = new System.Drawing.Size(52, 13);
            this.lblMostraTel.TabIndex = 3;
            this.lblMostraTel.Text = "Telefone:";
            // 
            // lblMostraCPF
            // 
            this.lblMostraCPF.AutoSize = true;
            this.lblMostraCPF.Location = new System.Drawing.Point(16, 101);
            this.lblMostraCPF.Name = "lblMostraCPF";
            this.lblMostraCPF.Size = new System.Drawing.Size(30, 13);
            this.lblMostraCPF.TabIndex = 2;
            this.lblMostraCPF.Text = "CPF:";
            // 
            // lblMostraEmail
            // 
            this.lblMostraEmail.AutoSize = true;
            this.lblMostraEmail.Location = new System.Drawing.Point(16, 64);
            this.lblMostraEmail.Name = "lblMostraEmail";
            this.lblMostraEmail.Size = new System.Drawing.Size(38, 13);
            this.lblMostraEmail.TabIndex = 1;
            this.lblMostraEmail.Text = "E-mail:";
            // 
            // lblMostrarNome
            // 
            this.lblMostrarNome.AutoSize = true;
            this.lblMostrarNome.Location = new System.Drawing.Point(16, 25);
            this.lblMostrarNome.Name = "lblMostrarNome";
            this.lblMostrarNome.Size = new System.Drawing.Size(38, 13);
            this.lblMostrarNome.TabIndex = 0;
            this.lblMostrarNome.Text = "Nome:";
            // 
            // gpbDadosPessoais
            // 
            this.gpbDadosPessoais.Controls.Add(this.mtbTelefone);
            this.gpbDadosPessoais.Controls.Add(this.mtbCpf);
            this.gpbDadosPessoais.Controls.Add(this.txtIdade);
            this.gpbDadosPessoais.Controls.Add(this.lbl_Idade);
            this.gpbDadosPessoais.Controls.Add(this.label1);
            this.gpbDadosPessoais.Controls.Add(this.lblCPF);
            this.gpbDadosPessoais.Controls.Add(this.txtEmail);
            this.gpbDadosPessoais.Controls.Add(this.lblEmail);
            this.gpbDadosPessoais.Controls.Add(this.txtNome);
            this.gpbDadosPessoais.Controls.Add(this.lblNome);
            this.gpbDadosPessoais.Location = new System.Drawing.Point(12, 20);
            this.gpbDadosPessoais.Name = "gpbDadosPessoais";
            this.gpbDadosPessoais.Size = new System.Drawing.Size(776, 155);
            this.gpbDadosPessoais.TabIndex = 4;
            this.gpbDadosPessoais.TabStop = false;
            this.gpbDadosPessoais.Text = "DadosPessoais";
            // 
            // mtbTelefone
            // 
            this.mtbTelefone.Location = new System.Drawing.Point(171, 94);
            this.mtbTelefone.Mask = "(00) 00000-0000";
            this.mtbTelefone.Name = "mtbTelefone";
            this.mtbTelefone.Size = new System.Drawing.Size(100, 20);
            this.mtbTelefone.TabIndex = 11;
            this.mtbTelefone.ValidatingType = typeof(int);
            // 
            // mtbCpf
            // 
            this.mtbCpf.Location = new System.Drawing.Point(606, 29);
            this.mtbCpf.Mask = "000.000.000-00";
            this.mtbCpf.Name = "mtbCpf";
            this.mtbCpf.Size = new System.Drawing.Size(87, 20);
            this.mtbCpf.TabIndex = 10;
            this.mtbCpf.ValidatingType = typeof(int);
            // 
            // txtIdade
            // 
            this.txtIdade.Location = new System.Drawing.Point(449, 94);
            this.txtIdade.Name = "txtIdade";
            this.txtIdade.Size = new System.Drawing.Size(150, 20);
            this.txtIdade.TabIndex = 9;
            // 
            // lbl_Idade
            // 
            this.lbl_Idade.AutoSize = true;
            this.lbl_Idade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Idade.Location = new System.Drawing.Point(383, 94);
            this.lbl_Idade.Name = "lbl_Idade";
            this.lbl_Idade.Size = new System.Drawing.Size(54, 20);
            this.lbl_Idade.TabIndex = 8;
            this.lbl_Idade.Text = "Idade:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(90, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Telefone:";
            // 
            // lblCPF
            // 
            this.lblCPF.AutoSize = true;
            this.lblCPF.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCPF.Location = new System.Drawing.Point(556, 29);
            this.lblCPF.Name = "lblCPF";
            this.lblCPF.Size = new System.Drawing.Size(44, 20);
            this.lblCPF.TabIndex = 4;
            this.lblCPF.Text = "CPF:";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(339, 29);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(150, 20);
            this.txtEmail.TabIndex = 3;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(273, 29);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(57, 20);
            this.lblEmail.TabIndex = 2;
            this.lblEmail.Text = "E-mail:";
            // 
            // frmExecutaPessoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gpbDadosPessoais);
            this.Controls.Add(this.gpbMostraRegistro);
            this.Controls.Add(this.btnCadastrar);
            this.Name = "frmExecutaPessoa";
            this.Text = "frmExecutaPessoa";
            this.gpbMostraRegistro.ResumeLayout(false);
            this.gpbMostraRegistro.PerformLayout();
            this.gpbDadosPessoais.ResumeLayout(false);
            this.gpbDadosPessoais.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.GroupBox gpbMostraRegistro;
        private System.Windows.Forms.Label lblMostrarNome;
        private System.Windows.Forms.GroupBox gpbDadosPessoais;
        private System.Windows.Forms.Label lblCPF;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtIdade;
        private System.Windows.Forms.Label lbl_Idade;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblMostraIdade;
        private System.Windows.Forms.Label lblMostraTel;
        private System.Windows.Forms.Label lblMostraCPF;
        private System.Windows.Forms.Label lblMostraEmail;
        private System.Windows.Forms.MaskedTextBox mtbCpf;
        private System.Windows.Forms.MaskedTextBox mtbTelefone;
    }
}