namespace ProjetoArrays
{
    partial class frmVetores
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
            this.gpbNomes = new System.Windows.Forms.GroupBox();
            this.btnInserir = new System.Windows.Forms.Button();
            this.txtInsiraNome = new System.Windows.Forms.TextBox();
            this.lblNomes = new System.Windows.Forms.Label();
            this.txtTamanho = new System.Windows.Forms.TextBox();
            this.lblTamanho = new System.Windows.Forms.Label();
            this.lblListaNomes = new System.Windows.Forms.Label();
            this.ltbNomes = new System.Windows.Forms.ListBox();
            this.btnCarrega = new System.Windows.Forms.Button();
            this.gpbNomes.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpbNomes
            // 
            this.gpbNomes.Controls.Add(this.btnInserir);
            this.gpbNomes.Controls.Add(this.txtInsiraNome);
            this.gpbNomes.Controls.Add(this.lblNomes);
            this.gpbNomes.Controls.Add(this.txtTamanho);
            this.gpbNomes.Controls.Add(this.lblTamanho);
            this.gpbNomes.Controls.Add(this.lblListaNomes);
            this.gpbNomes.Controls.Add(this.ltbNomes);
            this.gpbNomes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbNomes.Location = new System.Drawing.Point(39, 21);
            this.gpbNomes.Name = "gpbNomes";
            this.gpbNomes.Size = new System.Drawing.Size(1125, 403);
            this.gpbNomes.TabIndex = 0;
            this.gpbNomes.TabStop = false;
            this.gpbNomes.Text = "Nomes";
            // 
            // btnInserir
            // 
            this.btnInserir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInserir.Location = new System.Drawing.Point(40, 241);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(166, 36);
            this.btnInserir.TabIndex = 5;
            this.btnInserir.Text = "Inserir";
            this.btnInserir.UseVisualStyleBackColor = true;
            // 
            // txtInsiraNome
            // 
            this.txtInsiraNome.Location = new System.Drawing.Point(40, 185);
            this.txtInsiraNome.MaxLength = 100;
            this.txtInsiraNome.Name = "txtInsiraNome";
            this.txtInsiraNome.Size = new System.Drawing.Size(153, 26);
            this.txtInsiraNome.TabIndex = 3;
            // 
            // lblNomes
            // 
            this.lblNomes.AutoSize = true;
            this.lblNomes.Location = new System.Drawing.Point(36, 162);
            this.lblNomes.Name = "lblNomes";
            this.lblNomes.Size = new System.Drawing.Size(122, 20);
            this.lblNomes.TabIndex = 4;
            this.lblNomes.Text = "Insira um nome:";
            // 
            // txtTamanho
            // 
            this.txtTamanho.Location = new System.Drawing.Point(40, 65);
            this.txtTamanho.MaxLength = 3;
            this.txtTamanho.Name = "txtTamanho";
            this.txtTamanho.Size = new System.Drawing.Size(111, 26);
            this.txtTamanho.TabIndex = 0;
            // 
            // lblTamanho
            // 
            this.lblTamanho.AutoSize = true;
            this.lblTamanho.Location = new System.Drawing.Point(36, 42);
            this.lblTamanho.Name = "lblTamanho";
            this.lblTamanho.Size = new System.Drawing.Size(80, 20);
            this.lblTamanho.TabIndex = 2;
            this.lblTamanho.Text = "Tamanho:";
            // 
            // lblListaNomes
            // 
            this.lblListaNomes.AutoSize = true;
            this.lblListaNomes.Location = new System.Drawing.Point(833, 37);
            this.lblListaNomes.Name = "lblListaNomes";
            this.lblListaNomes.Size = new System.Drawing.Size(109, 20);
            this.lblListaNomes.TabIndex = 1;
            this.lblListaNomes.Text = "Lista de nome";
            // 
            // ltbNomes
            // 
            this.ltbNomes.FormattingEnabled = true;
            this.ltbNomes.ItemHeight = 20;
            this.ltbNomes.Location = new System.Drawing.Point(832, 85);
            this.ltbNomes.Name = "ltbNomes";
            this.ltbNomes.Size = new System.Drawing.Size(266, 264);
            this.ltbNomes.TabIndex = 0;
            // 
            // btnCarrega
            // 
            this.btnCarrega.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCarrega.Location = new System.Drawing.Point(39, 466);
            this.btnCarrega.Name = "btnCarrega";
            this.btnCarrega.Size = new System.Drawing.Size(193, 63);
            this.btnCarrega.TabIndex = 1;
            this.btnCarrega.Text = "Carrega";
            this.btnCarrega.UseVisualStyleBackColor = true;
            this.btnCarrega.Click += new System.EventHandler(this.btnCarrega_Click);
            // 
            // frmVetores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1176, 617);
            this.Controls.Add(this.btnCarrega);
            this.Controls.Add(this.gpbNomes);
            this.Name = "frmVetores";
            this.Text = "frmVetores";
            this.gpbNomes.ResumeLayout(false);
            this.gpbNomes.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbNomes;
        private System.Windows.Forms.Button btnCarrega;
        private System.Windows.Forms.Label lblListaNomes;
        private System.Windows.Forms.ListBox ltbNomes;
        private System.Windows.Forms.TextBox txtInsiraNome;
        private System.Windows.Forms.Label lblNomes;
        private System.Windows.Forms.TextBox txtTamanho;
        private System.Windows.Forms.Label lblTamanho;
        private System.Windows.Forms.Button btnInserir;
    }
}