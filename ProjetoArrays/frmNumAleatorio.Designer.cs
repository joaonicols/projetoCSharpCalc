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
            this.label1 = new System.Windows.Forms.Label();
            this.rdbGerarFloatsAleatorios = new System.Windows.Forms.RadioButton();
            this.rdbIntAleatoriosIntervalos = new System.Windows.Forms.RadioButton();
            this.rdbVariosIntAleatorios = new System.Windows.Forms.RadioButton();
            this.rdbInteirosAleatórios = new System.Windows.Forms.RadioButton();
            this.txtNumeroMaximo = new System.Windows.Forms.TextBox();
            this.lblNumeroMaximo = new System.Windows.Forms.Label();
            this.txtNumeroMinimo = new System.Windows.Forms.TextBox();
            this.lblNumeroMinimo = new System.Windows.Forms.Label();
            this.ltbMostraNumero = new System.Windows.Forms.ListBox();
            this.txtInsiraNumero = new System.Windows.Forms.TextBox();
            this.lblNumero = new System.Windows.Forms.Label();
            this.btnGerar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.rdbAleatoriosRepeticao = new System.Windows.Forms.RadioButton();
            this.gpbAleatorio.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpbAleatorio
            // 
            this.gpbAleatorio.Controls.Add(this.rdbAleatoriosRepeticao);
            this.gpbAleatorio.Controls.Add(this.label1);
            this.gpbAleatorio.Controls.Add(this.rdbGerarFloatsAleatorios);
            this.gpbAleatorio.Controls.Add(this.rdbIntAleatoriosIntervalos);
            this.gpbAleatorio.Controls.Add(this.rdbVariosIntAleatorios);
            this.gpbAleatorio.Controls.Add(this.rdbInteirosAleatórios);
            this.gpbAleatorio.Controls.Add(this.txtNumeroMaximo);
            this.gpbAleatorio.Controls.Add(this.lblNumeroMaximo);
            this.gpbAleatorio.Controls.Add(this.txtNumeroMinimo);
            this.gpbAleatorio.Controls.Add(this.lblNumeroMinimo);
            this.gpbAleatorio.Controls.Add(this.ltbMostraNumero);
            this.gpbAleatorio.Controls.Add(this.txtInsiraNumero);
            this.gpbAleatorio.Controls.Add(this.lblNumero);
            this.gpbAleatorio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gpbAleatorio.Location = new System.Drawing.Point(12, 33);
            this.gpbAleatorio.Name = "gpbAleatorio";
            this.gpbAleatorio.Size = new System.Drawing.Size(745, 289);
            this.gpbAleatorio.TabIndex = 0;
            this.gpbAleatorio.TabStop = false;
            this.gpbAleatorio.Text = "Valores";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(250, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 18);
            this.label1.TabIndex = 11;
            this.label1.Text = "Selecione:";
            // 
            // rdbGerarFloatsAleatorios
            // 
            this.rdbGerarFloatsAleatorios.AutoSize = true;
            this.rdbGerarFloatsAleatorios.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbGerarFloatsAleatorios.Location = new System.Drawing.Point(264, 181);
            this.rdbGerarFloatsAleatorios.Name = "rdbGerarFloatsAleatorios";
            this.rdbGerarFloatsAleatorios.Size = new System.Drawing.Size(163, 20);
            this.rdbGerarFloatsAleatorios.TabIndex = 10;
            this.rdbGerarFloatsAleatorios.TabStop = true;
            this.rdbGerarFloatsAleatorios.Text = "Gerar Floats Aleatórios";
            this.rdbGerarFloatsAleatorios.UseVisualStyleBackColor = true;
            this.rdbGerarFloatsAleatorios.CheckedChanged += new System.EventHandler(this.rdbGerarFloatsAleatorios_CheckedChanged);
            // 
            // rdbIntAleatoriosIntervalos
            // 
            this.rdbIntAleatoriosIntervalos.AutoSize = true;
            this.rdbIntAleatoriosIntervalos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbIntAleatoriosIntervalos.Location = new System.Drawing.Point(264, 141);
            this.rdbIntAleatoriosIntervalos.Name = "rdbIntAleatoriosIntervalos";
            this.rdbIntAleatoriosIntervalos.Size = new System.Drawing.Size(192, 20);
            this.rdbIntAleatoriosIntervalos.TabIndex = 9;
            this.rdbIntAleatoriosIntervalos.TabStop = true;
            this.rdbIntAleatoriosIntervalos.Text = "Inteiros aleatórios intervalos";
            this.rdbIntAleatoriosIntervalos.UseVisualStyleBackColor = true;
            this.rdbIntAleatoriosIntervalos.CheckedChanged += new System.EventHandler(this.rdbIntAleatoriosIntervalos_CheckedChanged);
            // 
            // rdbVariosIntAleatorios
            // 
            this.rdbVariosIntAleatorios.AutoSize = true;
            this.rdbVariosIntAleatorios.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbVariosIntAleatorios.Location = new System.Drawing.Point(264, 107);
            this.rdbVariosIntAleatorios.Name = "rdbVariosIntAleatorios";
            this.rdbVariosIntAleatorios.Size = new System.Drawing.Size(173, 20);
            this.rdbVariosIntAleatorios.TabIndex = 8;
            this.rdbVariosIntAleatorios.TabStop = true;
            this.rdbVariosIntAleatorios.Text = "Vários inteiros aleatórios";
            this.rdbVariosIntAleatorios.UseVisualStyleBackColor = true;
            this.rdbVariosIntAleatorios.CheckedChanged += new System.EventHandler(this.rdbVariosIntAleatorios_CheckedChanged);
            // 
            // rdbInteirosAleatórios
            // 
            this.rdbInteirosAleatórios.AutoSize = true;
            this.rdbInteirosAleatórios.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbInteirosAleatórios.Location = new System.Drawing.Point(264, 72);
            this.rdbInteirosAleatórios.Name = "rdbInteirosAleatórios";
            this.rdbInteirosAleatórios.Size = new System.Drawing.Size(131, 20);
            this.rdbInteirosAleatórios.TabIndex = 7;
            this.rdbInteirosAleatórios.TabStop = true;
            this.rdbInteirosAleatórios.Text = "Inteiros aleatórios";
            this.rdbInteirosAleatórios.UseVisualStyleBackColor = true;
            this.rdbInteirosAleatórios.CheckedChanged += new System.EventHandler(this.rdbInteirosAleatórios_CheckedChanged);
            // 
            // txtNumeroMaximo
            // 
            this.txtNumeroMaximo.Location = new System.Drawing.Point(21, 221);
            this.txtNumeroMaximo.Name = "txtNumeroMaximo";
            this.txtNumeroMaximo.Size = new System.Drawing.Size(119, 20);
            this.txtNumeroMaximo.TabIndex = 6;
            // 
            // lblNumeroMaximo
            // 
            this.lblNumeroMaximo.AutoSize = true;
            this.lblNumeroMaximo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumeroMaximo.Location = new System.Drawing.Point(17, 198);
            this.lblNumeroMaximo.Name = "lblNumeroMaximo";
            this.lblNumeroMaximo.Size = new System.Drawing.Size(123, 20);
            this.lblNumeroMaximo.TabIndex = 5;
            this.lblNumeroMaximo.Text = "Número máximo";
            // 
            // txtNumeroMinimo
            // 
            this.txtNumeroMinimo.Location = new System.Drawing.Point(21, 141);
            this.txtNumeroMinimo.Name = "txtNumeroMinimo";
            this.txtNumeroMinimo.Size = new System.Drawing.Size(119, 20);
            this.txtNumeroMinimo.TabIndex = 4;
            // 
            // lblNumeroMinimo
            // 
            this.lblNumeroMinimo.AutoSize = true;
            this.lblNumeroMinimo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumeroMinimo.Location = new System.Drawing.Point(17, 118);
            this.lblNumeroMinimo.Name = "lblNumeroMinimo";
            this.lblNumeroMinimo.Size = new System.Drawing.Size(119, 20);
            this.lblNumeroMinimo.TabIndex = 3;
            this.lblNumeroMinimo.Text = "Número mínimo";
            // 
            // ltbMostraNumero
            // 
            this.ltbMostraNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ltbMostraNumero.FormattingEnabled = true;
            this.ltbMostraNumero.ItemHeight = 20;
            this.ltbMostraNumero.Location = new System.Drawing.Point(479, 28);
            this.ltbMostraNumero.Name = "ltbMostraNumero";
            this.ltbMostraNumero.Size = new System.Drawing.Size(228, 224);
            this.ltbMostraNumero.TabIndex = 2;
            // 
            // txtInsiraNumero
            // 
            this.txtInsiraNumero.Location = new System.Drawing.Point(21, 62);
            this.txtInsiraNumero.Name = "txtInsiraNumero";
            this.txtInsiraNumero.Size = new System.Drawing.Size(119, 20);
            this.txtInsiraNumero.TabIndex = 1;
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumero.Location = new System.Drawing.Point(17, 39);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(123, 20);
            this.lblNumero.TabIndex = 0;
            this.lblNumero.Text = "Insira o número:";
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
            // rdbAleatoriosRepeticao
            // 
            this.rdbAleatoriosRepeticao.AutoSize = true;
            this.rdbAleatoriosRepeticao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbAleatoriosRepeticao.Location = new System.Drawing.Point(264, 220);
            this.rdbAleatoriosRepeticao.Name = "rdbAleatoriosRepeticao";
            this.rdbAleatoriosRepeticao.Size = new System.Drawing.Size(152, 20);
            this.rdbAleatoriosRepeticao.TabIndex = 12;
            this.rdbAleatoriosRepeticao.TabStop = true;
            this.rdbAleatoriosRepeticao.Text = "Aleatórios Repetição";
            this.rdbAleatoriosRepeticao.UseVisualStyleBackColor = true;
            this.rdbAleatoriosRepeticao.CheckedChanged += new System.EventHandler(this.rdbAleatoriosRepeticao_CheckedChanged);
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
        private System.Windows.Forms.TextBox txtNumeroMaximo;
        private System.Windows.Forms.Label lblNumeroMaximo;
        private System.Windows.Forms.TextBox txtNumeroMinimo;
        private System.Windows.Forms.Label lblNumeroMinimo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rdbGerarFloatsAleatorios;
        private System.Windows.Forms.RadioButton rdbIntAleatoriosIntervalos;
        private System.Windows.Forms.RadioButton rdbVariosIntAleatorios;
        private System.Windows.Forms.RadioButton rdbInteirosAleatórios;
        private System.Windows.Forms.RadioButton rdbAleatoriosRepeticao;
    }
}