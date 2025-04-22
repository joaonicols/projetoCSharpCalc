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
            this.lblAluno = new System.Windows.Forms.Label();
            this.txtNomes = new System.Windows.Forms.TextBox();
            this.txtSegundaProva = new System.Windows.Forms.TextBox();
            this.lblSegundaProva = new System.Windows.Forms.Label();
            this.txtPrimeiraProva = new System.Windows.Forms.TextBox();
            this.lblPrimeiraProva = new System.Windows.Forms.Label();
            this.txtTerceiraProva = new System.Windows.Forms.TextBox();
            this.lblTerceiraProva = new System.Windows.Forms.Label();
            this.txtTrabalho = new System.Windows.Forms.TextBox();
            this.lblTrabalho = new System.Windows.Forms.Label();
            this.ltbNotas = new System.Windows.Forms.ListBox();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnCalcularNotas = new System.Windows.Forms.Button();
            this.gpbNotas.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpbNotas
            // 
            this.gpbNotas.Controls.Add(this.btnSair);
            this.gpbNotas.Controls.Add(this.btnLimpar);
            this.gpbNotas.Controls.Add(this.btnCalcularNotas);
            this.gpbNotas.Controls.Add(this.ltbNotas);
            this.gpbNotas.Controls.Add(this.txtTrabalho);
            this.gpbNotas.Controls.Add(this.lblTrabalho);
            this.gpbNotas.Controls.Add(this.txtTerceiraProva);
            this.gpbNotas.Controls.Add(this.lblTerceiraProva);
            this.gpbNotas.Controls.Add(this.txtPrimeiraProva);
            this.gpbNotas.Controls.Add(this.lblPrimeiraProva);
            this.gpbNotas.Controls.Add(this.txtSegundaProva);
            this.gpbNotas.Controls.Add(this.lblSegundaProva);
            this.gpbNotas.Controls.Add(this.txtNomes);
            this.gpbNotas.Controls.Add(this.lblAluno);
            this.gpbNotas.Location = new System.Drawing.Point(28, 12);
            this.gpbNotas.Name = "gpbNotas";
            this.gpbNotas.Size = new System.Drawing.Size(743, 426);
            this.gpbNotas.TabIndex = 0;
            this.gpbNotas.TabStop = false;
            this.gpbNotas.Text = "Notas";
            // 
            // lblAluno
            // 
            this.lblAluno.AutoSize = true;
            this.lblAluno.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAluno.Location = new System.Drawing.Point(30, 48);
            this.lblAluno.Name = "lblAluno";
            this.lblAluno.Size = new System.Drawing.Size(49, 18);
            this.lblAluno.TabIndex = 0;
            this.lblAluno.Text = "Aluno:";
            // 
            // txtNomes
            // 
            this.txtNomes.Location = new System.Drawing.Point(97, 46);
            this.txtNomes.Name = "txtNomes";
            this.txtNomes.Size = new System.Drawing.Size(135, 20);
            this.txtNomes.TabIndex = 1;
            // 
            // txtSegundaProva
            // 
            this.txtSegundaProva.Location = new System.Drawing.Point(97, 164);
            this.txtSegundaProva.Name = "txtSegundaProva";
            this.txtSegundaProva.Size = new System.Drawing.Size(135, 20);
            this.txtSegundaProva.TabIndex = 3;
            // 
            // lblSegundaProva
            // 
            this.lblSegundaProva.AutoSize = true;
            this.lblSegundaProva.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSegundaProva.Location = new System.Drawing.Point(30, 164);
            this.lblSegundaProva.Name = "lblSegundaProva";
            this.lblSegundaProva.Size = new System.Drawing.Size(65, 18);
            this.lblSegundaProva.TabIndex = 2;
            this.lblSegundaProva.Text = "2° Prova";
            // 
            // txtPrimeiraProva
            // 
            this.txtPrimeiraProva.Location = new System.Drawing.Point(97, 112);
            this.txtPrimeiraProva.Name = "txtPrimeiraProva";
            this.txtPrimeiraProva.Size = new System.Drawing.Size(135, 20);
            this.txtPrimeiraProva.TabIndex = 5;
            // 
            // lblPrimeiraProva
            // 
            this.lblPrimeiraProva.AutoSize = true;
            this.lblPrimeiraProva.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrimeiraProva.Location = new System.Drawing.Point(30, 114);
            this.lblPrimeiraProva.Name = "lblPrimeiraProva";
            this.lblPrimeiraProva.Size = new System.Drawing.Size(65, 18);
            this.lblPrimeiraProva.TabIndex = 4;
            this.lblPrimeiraProva.Text = "1° Prova";
            // 
            // txtTerceiraProva
            // 
            this.txtTerceiraProva.Location = new System.Drawing.Point(97, 218);
            this.txtTerceiraProva.Name = "txtTerceiraProva";
            this.txtTerceiraProva.Size = new System.Drawing.Size(135, 20);
            this.txtTerceiraProva.TabIndex = 7;
            // 
            // lblTerceiraProva
            // 
            this.lblTerceiraProva.AutoSize = true;
            this.lblTerceiraProva.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTerceiraProva.Location = new System.Drawing.Point(30, 220);
            this.lblTerceiraProva.Name = "lblTerceiraProva";
            this.lblTerceiraProva.Size = new System.Drawing.Size(65, 18);
            this.lblTerceiraProva.TabIndex = 6;
            this.lblTerceiraProva.Text = "3° Prova";
            // 
            // txtTrabalho
            // 
            this.txtTrabalho.Location = new System.Drawing.Point(97, 274);
            this.txtTrabalho.Name = "txtTrabalho";
            this.txtTrabalho.Size = new System.Drawing.Size(135, 20);
            this.txtTrabalho.TabIndex = 9;
            // 
            // lblTrabalho
            // 
            this.lblTrabalho.AutoSize = true;
            this.lblTrabalho.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTrabalho.Location = new System.Drawing.Point(30, 276);
            this.lblTrabalho.Name = "lblTrabalho";
            this.lblTrabalho.Size = new System.Drawing.Size(70, 18);
            this.lblTrabalho.TabIndex = 8;
            this.lblTrabalho.Text = "Trabalho:";
            // 
            // ltbNotas
            // 
            this.ltbNotas.FormattingEnabled = true;
            this.ltbNotas.Location = new System.Drawing.Point(513, 19);
            this.ltbNotas.Name = "ltbNotas";
            this.ltbNotas.Size = new System.Drawing.Size(224, 329);
            this.ltbNotas.TabIndex = 10;
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
        private System.Windows.Forms.TextBox txtNomes;
        private System.Windows.Forms.TextBox txtPrimeiraProva;
        private System.Windows.Forms.Label lblPrimeiraProva;
        private System.Windows.Forms.TextBox txtSegundaProva;
        private System.Windows.Forms.Label lblSegundaProva;
        private System.Windows.Forms.TextBox txtTrabalho;
        private System.Windows.Forms.Label lblTrabalho;
        private System.Windows.Forms.TextBox txtTerceiraProva;
        private System.Windows.Forms.Label lblTerceiraProva;
        private System.Windows.Forms.ListBox ltbNotas;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnCalcularNotas;
    }
}