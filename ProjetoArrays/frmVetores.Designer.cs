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
            this.lblListaNomes = new System.Windows.Forms.Label();
            this.ltbNomes = new System.Windows.Forms.ListBox();
            this.btnCarrega = new System.Windows.Forms.Button();
            this.gpbNomes.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpbNomes
            // 
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
    }
}