namespace ProjetoOrientacaoObjeto
{
    partial class frmEstruturaRepeticao
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
            this.cbbEstado = new System.Windows.Forms.ComboBox();
            this.lblEstado = new System.Windows.Forms.Label();
            this.ltbListaDesejos = new System.Windows.Forms.ListBox();
            this.lblListaDesejos = new System.Windows.Forms.Label();
            this.btnCarregaEstado = new System.Windows.Forms.Button();
            this.btnCarregaListaDesejos = new System.Windows.Forms.Button();
            this.lblDigiteEstado = new System.Windows.Forms.Label();
            this.txtInserirEstado = new System.Windows.Forms.TextBox();
            this.btnInserirEstado = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbbEstado
            // 
            this.cbbEstado.FormattingEnabled = true;
            this.cbbEstado.Location = new System.Drawing.Point(50, 31);
            this.cbbEstado.Name = "cbbEstado";
            this.cbbEstado.Size = new System.Drawing.Size(159, 21);
            this.cbbEstado.TabIndex = 0;
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstado.Location = new System.Drawing.Point(49, 8);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(60, 20);
            this.lblEstado.TabIndex = 1;
            this.lblEstado.Text = "Estado";
            // 
            // ltbListaDesejos
            // 
            this.ltbListaDesejos.FormattingEnabled = true;
            this.ltbListaDesejos.Location = new System.Drawing.Point(400, 31);
            this.ltbListaDesejos.Name = "ltbListaDesejos";
            this.ltbListaDesejos.Size = new System.Drawing.Size(226, 238);
            this.ltbListaDesejos.TabIndex = 2;
            // 
            // lblListaDesejos
            // 
            this.lblListaDesejos.AutoSize = true;
            this.lblListaDesejos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListaDesejos.Location = new System.Drawing.Point(396, 8);
            this.lblListaDesejos.Name = "lblListaDesejos";
            this.lblListaDesejos.Size = new System.Drawing.Size(127, 20);
            this.lblListaDesejos.TabIndex = 3;
            this.lblListaDesejos.Text = "Lista de Desejos";
            // 
            // btnCarregaEstado
            // 
            this.btnCarregaEstado.Location = new System.Drawing.Point(169, 307);
            this.btnCarregaEstado.Name = "btnCarregaEstado";
            this.btnCarregaEstado.Size = new System.Drawing.Size(125, 59);
            this.btnCarregaEstado.TabIndex = 4;
            this.btnCarregaEstado.Text = "Carrega Estado";
            this.btnCarregaEstado.UseVisualStyleBackColor = true;
            this.btnCarregaEstado.Click += new System.EventHandler(this.btnCarregaEstado_Click);
            // 
            // btnCarregaListaDesejos
            // 
            this.btnCarregaListaDesejos.Location = new System.Drawing.Point(398, 307);
            this.btnCarregaListaDesejos.Name = "btnCarregaListaDesejos";
            this.btnCarregaListaDesejos.Size = new System.Drawing.Size(125, 59);
            this.btnCarregaListaDesejos.TabIndex = 5;
            this.btnCarregaListaDesejos.Text = "Carrega Lista Desejos";
            this.btnCarregaListaDesejos.UseVisualStyleBackColor = true;
            this.btnCarregaListaDesejos.Click += new System.EventHandler(this.btnCarregaListaDesejos_Click);
            // 
            // lblDigiteEstado
            // 
            this.lblDigiteEstado.AutoSize = true;
            this.lblDigiteEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDigiteEstado.Location = new System.Drawing.Point(46, 101);
            this.lblDigiteEstado.Name = "lblDigiteEstado";
            this.lblDigiteEstado.Size = new System.Drawing.Size(122, 20);
            this.lblDigiteEstado.TabIndex = 6;
            this.lblDigiteEstado.Text = "Digite o Estado:";
            // 
            // txtInserirEstado
            // 
            this.txtInserirEstado.Location = new System.Drawing.Point(50, 137);
            this.txtInserirEstado.Name = "txtInserirEstado";
            this.txtInserirEstado.Size = new System.Drawing.Size(159, 20);
            this.txtInserirEstado.TabIndex = 7;
            this.txtInserirEstado.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtInserirEstado_KeyDown);
            // 
            // btnInserirEstado
            // 
            this.btnInserirEstado.Location = new System.Drawing.Point(50, 183);
            this.btnInserirEstado.Name = "btnInserirEstado";
            this.btnInserirEstado.Size = new System.Drawing.Size(112, 46);
            this.btnInserirEstado.TabIndex = 8;
            this.btnInserirEstado.Text = "Inserir Estado";
            this.btnInserirEstado.UseVisualStyleBackColor = true;
            this.btnInserirEstado.Click += new System.EventHandler(this.btnInserirEstado_Click);
            // 
            // frmEstruturaRepeticao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(723, 393);
            this.Controls.Add(this.btnInserirEstado);
            this.Controls.Add(this.txtInserirEstado);
            this.Controls.Add(this.lblDigiteEstado);
            this.Controls.Add(this.btnCarregaListaDesejos);
            this.Controls.Add(this.btnCarregaEstado);
            this.Controls.Add(this.lblListaDesejos);
            this.Controls.Add(this.ltbListaDesejos);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.cbbEstado);
            this.Name = "frmEstruturaRepeticao";
            this.Text = "frmEstruturaRepeticao";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbbEstado;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.ListBox ltbListaDesejos;
        private System.Windows.Forms.Label lblListaDesejos;
        private System.Windows.Forms.Button btnCarregaEstado;
        private System.Windows.Forms.Button btnCarregaListaDesejos;
        private System.Windows.Forms.Label lblDigiteEstado;
        private System.Windows.Forms.TextBox txtInserirEstado;
        private System.Windows.Forms.Button btnInserirEstado;
    }
}