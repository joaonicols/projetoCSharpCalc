namespace ProjetoArrays
{
    partial class frmNotas
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
            this.gpbNotas = new System.Windows.Forms.GroupBox();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnCalcularNotas = new System.Windows.Forms.Button();
            this.ltbNotas = new System.Windows.Forms.ListBox();
            this.txtTrabalho = new System.Windows.Forms.TextBox();
            this.lblTrabalho = new System.Windows.Forms.Label();
            this.txtP3 = new System.Windows.Forms.TextBox();
            this.lblTerceiraProva = new System.Windows.Forms.Label();
            this.txtP1 = new System.Windows.Forms.TextBox();
            this.lblPrimeiraProva = new System.Windows.Forms.Label();
            this.txtP2 = new System.Windows.Forms.TextBox();
            this.lblSegundaProva = new System.Windows.Forms.Label();
            this.txtAluno = new System.Windows.Forms.TextBox();
            this.lblAluno = new System.Windows.Forms.Label();
            this.gpbNotas.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpbNotas
            // 
            this.gpbNotas.Controls.Add(this.btnAdicionar);
            this.gpbNotas.Controls.Add(this.btnSair);
            this.gpbNotas.Controls.Add(this.btnLimpar);
            this.gpbNotas.Controls.Add(this.btnCalcularNotas);
            this.gpbNotas.Controls.Add(this.ltbNotas);
            this.gpbNotas.Controls.Add(this.txtTrabalho);
            this.gpbNotas.Controls.Add(this.lblTrabalho);
            this.gpbNotas.Controls.Add(this.txtP3);
            this.gpbNotas.Controls.Add(this.lblTerceiraProva);
            this.gpbNotas.Controls.Add(this.txtP1);
            this.gpbNotas.Controls.Add(this.lblPrimeiraProva);
            this.gpbNotas.Controls.Add(this.txtP2);
            this.gpbNotas.Controls.Add(this.lblSegundaProva);
            this.gpbNotas.Controls.Add(this.txtAluno);
            this.gpbNotas.Controls.Add(this.lblAluno);
            this.gpbNotas.Location = new System.Drawing.Point(12, 12);
            this.gpbNotas.Name = "gpbNotas";
            this.gpbNotas.Size = new System.Drawing.Size(776, 435);
            this.gpbNotas.TabIndex = 0;
            this.gpbNotas.TabStop = false;
            this.gpbNotas.Text = "Notas";
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdicionar.Location = new System.Drawing.Point(282, 240);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(149, 43);
            this.btnAdicionar.TabIndex = 14;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // btnSair
            // 
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.Location = new System.Drawing.Point(531, 362);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(179, 58);
            this.btnSair.TabIndex = 13;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.Location = new System.Drawing.Point(282, 362);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(179, 58);
            this.btnLimpar.TabIndex = 12;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnCalcularNotas
            // 
            this.btnCalcularNotas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcularNotas.Location = new System.Drawing.Point(42, 362);
            this.btnCalcularNotas.Name = "btnCalcularNotas";
            this.btnCalcularNotas.Size = new System.Drawing.Size(179, 58);
            this.btnCalcularNotas.TabIndex = 11;
            this.btnCalcularNotas.Text = "Calcular Notas";
            this.btnCalcularNotas.UseVisualStyleBackColor = true;
            this.btnCalcularNotas.Click += new System.EventHandler(this.btnCalcularNotas_Click);
            // 
            // ltbNotas
            // 
            this.ltbNotas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ltbNotas.FormattingEnabled = true;
            this.ltbNotas.ItemHeight = 16;
            this.ltbNotas.Location = new System.Drawing.Point(513, 19);
            this.ltbNotas.Name = "ltbNotas";
            this.ltbNotas.Size = new System.Drawing.Size(224, 324);
            this.ltbNotas.TabIndex = 10;
            // 
            // txtTrabalho
            // 
            this.txtTrabalho.Location = new System.Drawing.Point(86, 249);
            this.txtTrabalho.Name = "txtTrabalho";
            this.txtTrabalho.Size = new System.Drawing.Size(135, 20);
            this.txtTrabalho.TabIndex = 9;
            // 
            // lblTrabalho
            // 
            this.lblTrabalho.AutoSize = true;
            this.lblTrabalho.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTrabalho.Location = new System.Drawing.Point(19, 251);
            this.lblTrabalho.Name = "lblTrabalho";
            this.lblTrabalho.Size = new System.Drawing.Size(70, 18);
            this.lblTrabalho.TabIndex = 8;
            this.lblTrabalho.Text = "Trabalho:";
            // 
            // txtP3
            // 
            this.txtP3.Location = new System.Drawing.Point(86, 193);
            this.txtP3.Name = "txtP3";
            this.txtP3.Size = new System.Drawing.Size(135, 20);
            this.txtP3.TabIndex = 7;
            // 
            // lblTerceiraProva
            // 
            this.lblTerceiraProva.AutoSize = true;
            this.lblTerceiraProva.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTerceiraProva.Location = new System.Drawing.Point(19, 195);
            this.lblTerceiraProva.Name = "lblTerceiraProva";
            this.lblTerceiraProva.Size = new System.Drawing.Size(65, 18);
            this.lblTerceiraProva.TabIndex = 6;
            this.lblTerceiraProva.Text = "3° Prova";
            // 
            // txtP1
            // 
            this.txtP1.Location = new System.Drawing.Point(86, 87);
            this.txtP1.Name = "txtP1";
            this.txtP1.Size = new System.Drawing.Size(135, 20);
            this.txtP1.TabIndex = 5;
            // 
            // lblPrimeiraProva
            // 
            this.lblPrimeiraProva.AutoSize = true;
            this.lblPrimeiraProva.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrimeiraProva.Location = new System.Drawing.Point(19, 89);
            this.lblPrimeiraProva.Name = "lblPrimeiraProva";
            this.lblPrimeiraProva.Size = new System.Drawing.Size(65, 18);
            this.lblPrimeiraProva.TabIndex = 4;
            this.lblPrimeiraProva.Text = "1° Prova";
            // 
            // txtP2
            // 
            this.txtP2.Location = new System.Drawing.Point(86, 139);
            this.txtP2.Name = "txtP2";
            this.txtP2.Size = new System.Drawing.Size(135, 20);
            this.txtP2.TabIndex = 3;
            // 
            // lblSegundaProva
            // 
            this.lblSegundaProva.AutoSize = true;
            this.lblSegundaProva.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSegundaProva.Location = new System.Drawing.Point(19, 139);
            this.lblSegundaProva.Name = "lblSegundaProva";
            this.lblSegundaProva.Size = new System.Drawing.Size(65, 18);
            this.lblSegundaProva.TabIndex = 2;
            this.lblSegundaProva.Text = "2° Prova";
            // 
            // txtAluno
            // 
            this.txtAluno.Location = new System.Drawing.Point(86, 21);
            this.txtAluno.Name = "txtAluno";
            this.txtAluno.Size = new System.Drawing.Size(135, 20);
            this.txtAluno.TabIndex = 1;
            // 
            // lblAluno
            // 
            this.lblAluno.AutoSize = true;
            this.lblAluno.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAluno.Location = new System.Drawing.Point(19, 23);
            this.lblAluno.Name = "lblAluno";
            this.lblAluno.Size = new System.Drawing.Size(49, 18);
            this.lblAluno.TabIndex = 0;
            this.lblAluno.Text = "Aluno:";
            // 
            // frmNotas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gpbNotas);
            this.Name = "frmNotas";
            this.Text = "frmNotas";
            this.gpbNotas.ResumeLayout(false);
            this.gpbNotas.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbNotas;
        private System.Windows.Forms.Label lblAluno;
        private System.Windows.Forms.TextBox txtAluno;
        private System.Windows.Forms.TextBox txtP1;
        private System.Windows.Forms.Label lblPrimeiraProva;
        private System.Windows.Forms.TextBox txtP2;
        private System.Windows.Forms.Label lblSegundaProva;
        private System.Windows.Forms.TextBox txtTrabalho;
        private System.Windows.Forms.Label lblTrabalho;
        private System.Windows.Forms.TextBox txtP3;
        private System.Windows.Forms.Label lblTerceiraProva;
        private System.Windows.Forms.ListBox ltbNotas;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnCalcularNotas;
        private System.Windows.Forms.Button btnAdicionar;
    }
}