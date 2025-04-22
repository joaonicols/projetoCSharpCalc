namespace ProjetoArrays
{
    partial class frmMatrizes
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
            this.gpbMatrizes = new System.Windows.Forms.GroupBox();
            this.lblLinha = new System.Windows.Forms.Label();
            this.txtLinha = new System.Windows.Forms.TextBox();
            this.txtColuna = new System.Windows.Forms.TextBox();
            this.lblColuna = new System.Windows.Forms.Label();
            this.ltbListaMatriz = new System.Windows.Forms.ListBox();
            this.btnCarregaMatriz = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.gpbMatrizes.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpbMatrizes
            // 
            this.gpbMatrizes.Controls.Add(this.btnSair);
            this.gpbMatrizes.Controls.Add(this.btnLimpar);
            this.gpbMatrizes.Controls.Add(this.btnCarregaMatriz);
            this.gpbMatrizes.Controls.Add(this.ltbListaMatriz);
            this.gpbMatrizes.Controls.Add(this.txtColuna);
            this.gpbMatrizes.Controls.Add(this.lblColuna);
            this.gpbMatrizes.Controls.Add(this.txtLinha);
            this.gpbMatrizes.Controls.Add(this.lblLinha);
            this.gpbMatrizes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbMatrizes.Location = new System.Drawing.Point(22, 3);
            this.gpbMatrizes.Name = "gpbMatrizes";
            this.gpbMatrizes.Size = new System.Drawing.Size(761, 435);
            this.gpbMatrizes.TabIndex = 0;
            this.gpbMatrizes.TabStop = false;
            this.gpbMatrizes.Text = "Lista Matriz";
            // 
            // lblLinha
            // 
            this.lblLinha.AutoSize = true;
            this.lblLinha.Location = new System.Drawing.Point(34, 49);
            this.lblLinha.Name = "lblLinha";
            this.lblLinha.Size = new System.Drawing.Size(52, 20);
            this.lblLinha.TabIndex = 0;
            this.lblLinha.Text = "Linha:";
            // 
            // txtLinha
            // 
            this.txtLinha.Location = new System.Drawing.Point(99, 46);
            this.txtLinha.Name = "txtLinha";
            this.txtLinha.Size = new System.Drawing.Size(124, 26);
            this.txtLinha.TabIndex = 1;
            // 
            // txtColuna
            // 
            this.txtColuna.Location = new System.Drawing.Point(99, 127);
            this.txtColuna.Name = "txtColuna";
            this.txtColuna.Size = new System.Drawing.Size(124, 26);
            this.txtColuna.TabIndex = 3;
            // 
            // lblColuna
            // 
            this.lblColuna.AutoSize = true;
            this.lblColuna.Location = new System.Drawing.Point(34, 130);
            this.lblColuna.Name = "lblColuna";
            this.lblColuna.Size = new System.Drawing.Size(63, 20);
            this.lblColuna.TabIndex = 2;
            this.lblColuna.Text = "Coluna:";
            // 
            // ltbListaMatriz
            // 
            this.ltbListaMatriz.FormattingEnabled = true;
            this.ltbListaMatriz.ItemHeight = 20;
            this.ltbListaMatriz.Location = new System.Drawing.Point(550, 9);
            this.ltbListaMatriz.Name = "ltbListaMatriz";
            this.ltbListaMatriz.Size = new System.Drawing.Size(205, 304);
            this.ltbListaMatriz.TabIndex = 4;
            // 
            // btnCarregaMatriz
            // 
            this.btnCarregaMatriz.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCarregaMatriz.Location = new System.Drawing.Point(16, 362);
            this.btnCarregaMatriz.Name = "btnCarregaMatriz";
            this.btnCarregaMatriz.Size = new System.Drawing.Size(179, 58);
            this.btnCarregaMatriz.TabIndex = 5;
            this.btnCarregaMatriz.Text = "Carrega Matriz";
            this.btnCarregaMatriz.UseVisualStyleBackColor = true;
            this.btnCarregaMatriz.Click += new System.EventHandler(this.btnCarregaMatriz_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.Location = new System.Drawing.Point(256, 362);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(179, 58);
            this.btnLimpar.TabIndex = 6;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            // 
            // btnSair
            // 
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.Location = new System.Drawing.Point(505, 362);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(179, 58);
            this.btnSair.TabIndex = 7;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            // 
            // frmMatrizes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gpbMatrizes);
            this.Name = "frmMatrizes";
            this.Text = "frmMatrizes";
            this.gpbMatrizes.ResumeLayout(false);
            this.gpbMatrizes.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbMatrizes;
        private System.Windows.Forms.ListBox ltbListaMatriz;
        private System.Windows.Forms.TextBox txtColuna;
        private System.Windows.Forms.Label lblColuna;
        private System.Windows.Forms.TextBox txtLinha;
        private System.Windows.Forms.Label lblLinha;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnCarregaMatriz;
    }
}