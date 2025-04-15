namespace ProjetoArrays
{
    partial class frmVetorNomes
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
            this.btnCarregarNomes = new System.Windows.Forms.Button();
            this.lblNomes = new System.Windows.Forms.Label();
            this.txtNomes = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnCarregarNomes
            // 
            this.btnCarregarNomes.Location = new System.Drawing.Point(34, 356);
            this.btnCarregarNomes.Name = "btnCarregarNomes";
            this.btnCarregarNomes.Size = new System.Drawing.Size(214, 62);
            this.btnCarregarNomes.TabIndex = 0;
            this.btnCarregarNomes.Text = "Carregar Nomes";
            this.btnCarregarNomes.UseVisualStyleBackColor = true;
            this.btnCarregarNomes.Click += new System.EventHandler(this.btnCarregarNomes_Click);
            // 
            // lblNomes
            // 
            this.lblNomes.AutoSize = true;
            this.lblNomes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomes.Location = new System.Drawing.Point(57, 58);
            this.lblNomes.Name = "lblNomes";
            this.lblNomes.Size = new System.Drawing.Size(128, 20);
            this.lblNomes.TabIndex = 1;
            this.lblNomes.Text = "Digite seu nome:";
            // 
            // txtNomes
            // 
            this.txtNomes.Location = new System.Drawing.Point(61, 81);
            this.txtNomes.Name = "txtNomes";
            this.txtNomes.Size = new System.Drawing.Size(153, 20);
            this.txtNomes.TabIndex = 2;
            // 
            // frmVetorNomes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtNomes);
            this.Controls.Add(this.lblNomes);
            this.Controls.Add(this.btnCarregarNomes);
            this.Name = "frmVetorNomes";
            this.Text = "frmVetorNomes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCarregarNomes;
        private System.Windows.Forms.Label lblNomes;
        private System.Windows.Forms.TextBox txtNomes;
    }
}