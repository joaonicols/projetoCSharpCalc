namespace ProjetoArrays
{
    partial class frmNumAleatorio
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
            this.gpbAleatorio = new System.Windows.Forms.GroupBox();
            this.btnGerar = new System.Windows.Forms.Button();
            this.lblNumero = new System.Windows.Forms.Label();
            this.txtInsiraNumero = new System.Windows.Forms.TextBox();
            this.ltbMostraNumero = new System.Windows.Forms.ListBox();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.gpbAleatorio.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpbAleatorio
            // 
            this.gpbAleatorio.Controls.Add(this.ltbMostraNumero);
            this.gpbAleatorio.Controls.Add(this.txtInsiraNumero);
            this.gpbAleatorio.Controls.Add(this.lblNumero);
            this.gpbAleatorio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gpbAleatorio.Location = new System.Drawing.Point(35, 33);
            this.gpbAleatorio.Name = "gpbAleatorio";
            this.gpbAleatorio.Size = new System.Drawing.Size(609, 275);
            this.gpbAleatorio.TabIndex = 0;
            this.gpbAleatorio.TabStop = false;
            this.gpbAleatorio.Text = "Valores";
            // 
            // btnGerar
            // 
            this.btnGerar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGerar.Location = new System.Drawing.Point(46, 345);
            this.btnGerar.Name = "btnGerar";
            this.btnGerar.Size = new System.Drawing.Size(191, 71);
            this.btnGerar.TabIndex = 1;
            this.btnGerar.Text = "Gerar";
            this.btnGerar.UseVisualStyleBackColor = true;
            this.btnGerar.Click += new System.EventHandler(this.btnGerar_Click);
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumero.Location = new System.Drawing.Point(32, 40);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(123, 20);
            this.lblNumero.TabIndex = 0;
            this.lblNumero.Text = "Insira o número:";
            // 
            // txtInsiraNumero
            // 
            this.txtInsiraNumero.Location = new System.Drawing.Point(36, 63);
            this.txtInsiraNumero.Name = "txtInsiraNumero";
            this.txtInsiraNumero.Size = new System.Drawing.Size(203, 20);
            this.txtInsiraNumero.TabIndex = 1;
            // 
            // ltbMostraNumero
            // 
            this.ltbMostraNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ltbMostraNumero.FormattingEnabled = true;
            this.ltbMostraNumero.ItemHeight = 20;
            this.ltbMostraNumero.Location = new System.Drawing.Point(352, 28);
            this.ltbMostraNumero.Name = "ltbMostraNumero";
            this.ltbMostraNumero.Size = new System.Drawing.Size(228, 224);
            this.ltbMostraNumero.TabIndex = 2;
            // 
            // btnLimpar
            // 
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.Location = new System.Drawing.Point(296, 345);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(191, 71);
            this.btnLimpar.TabIndex = 2;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnSair
            // 
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.Location = new System.Drawing.Point(540, 345);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(191, 71);
            this.btnSair.TabIndex = 3;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // frmNumAleatorio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnGerar);
            this.Controls.Add(this.gpbAleatorio);
            this.Name = "frmNumAleatorio";
            this.Text = "Aleatorio";
            this.gpbAleatorio.ResumeLayout(false);
            this.gpbAleatorio.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbAleatorio;
        private System.Windows.Forms.Button btnGerar;
        private System.Windows.Forms.ListBox ltbMostraNumero;
        private System.Windows.Forms.TextBox txtInsiraNumero;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnSair;
    }
}