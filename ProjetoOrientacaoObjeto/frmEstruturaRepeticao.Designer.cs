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
            this.ltbListaEstados = new System.Windows.Forms.ListBox();
            this.lblListaEstados = new System.Windows.Forms.Label();
            this.btnCarregaEstado = new System.Windows.Forms.Button();
            this.btnCarregaListaEstados = new System.Windows.Forms.Button();
            this.lblDigiteEstado = new System.Windows.Forms.Label();
            this.txtInserirEstado = new System.Windows.Forms.TextBox();
            this.btnInserirEstado = new System.Windows.Forms.Button();
            this.btnLimparEstado = new System.Windows.Forms.Button();
            this.btnLimpaItemSelecionado = new System.Windows.Forms.Button();
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
            // ltbListaEstados
            // 
            this.ltbListaEstados.FormattingEnabled = true;
            this.ltbListaEstados.Location = new System.Drawing.Point(389, 31);
            this.ltbListaEstados.Name = "ltbListaEstados";
            this.ltbListaEstados.Size = new System.Drawing.Size(226, 238);
            this.ltbListaEstados.TabIndex = 2;
            // 
            // lblListaEstados
            // 
            this.lblListaEstados.AutoSize = true;
            this.lblListaEstados.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListaEstados.Location = new System.Drawing.Point(396, 8);
            this.lblListaEstados.Name = "lblListaEstados";
            this.lblListaEstados.Size = new System.Drawing.Size(128, 20);
            this.lblListaEstados.TabIndex = 3;
            this.lblListaEstados.Text = "Lista de Estados";
            // 
            // btnCarregaEstado
            // 
            this.btnCarregaEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCarregaEstado.Location = new System.Drawing.Point(169, 307);
            this.btnCarregaEstado.Name = "btnCarregaEstado";
            this.btnCarregaEstado.Size = new System.Drawing.Size(125, 59);
            this.btnCarregaEstado.TabIndex = 4;
            this.btnCarregaEstado.Text = "Carrega Estado";
            this.btnCarregaEstado.UseVisualStyleBackColor = true;
            this.btnCarregaEstado.Click += new System.EventHandler(this.btnCarregaEstado_Click);
            // 
            // btnCarregaListaEstados
            // 
            this.btnCarregaListaEstados.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCarregaListaEstados.Location = new System.Drawing.Point(398, 307);
            this.btnCarregaListaEstados.Name = "btnCarregaListaEstados";
            this.btnCarregaListaEstados.Size = new System.Drawing.Size(125, 59);
            this.btnCarregaListaEstados.TabIndex = 5;
            this.btnCarregaListaEstados.Text = "Carrega Lista Estados";
            this.btnCarregaListaEstados.UseVisualStyleBackColor = true;
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
            this.txtInserirEstado.Location = new System.Drawing.Point(50, 124);
            this.txtInserirEstado.Name = "txtInserirEstado";
            this.txtInserirEstado.Size = new System.Drawing.Size(186, 20);
            this.txtInserirEstado.TabIndex = 7;
            this.txtInserirEstado.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtInserirEstado_KeyDown);
            // 
            // btnInserirEstado
            // 
            this.btnInserirEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInserirEstado.Location = new System.Drawing.Point(50, 150);
            this.btnInserirEstado.Name = "btnInserirEstado";
            this.btnInserirEstado.Size = new System.Drawing.Size(98, 26);
            this.btnInserirEstado.TabIndex = 8;
            this.btnInserirEstado.Text = "Inserir Estado";
            this.btnInserirEstado.UseVisualStyleBackColor = true;
            this.btnInserirEstado.Click += new System.EventHandler(this.btnInserirEstado_Click);
            // 
            // btnLimparEstado
            // 
            this.btnLimparEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimparEstado.Location = new System.Drawing.Point(154, 150);
            this.btnLimparEstado.Name = "btnLimparEstado";
            this.btnLimparEstado.Size = new System.Drawing.Size(82, 26);
            this.btnLimparEstado.TabIndex = 9;
            this.btnLimparEstado.Text = "Limpar Estado";
            this.btnLimparEstado.UseVisualStyleBackColor = true;
            this.btnLimparEstado.Click += new System.EventHandler(this.btnLimparEstado_Click);
            // 
            // btnLimpaItemSelecionado
            // 
            this.btnLimpaItemSelecionado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpaItemSelecionado.Location = new System.Drawing.Point(53, 182);
            this.btnLimpaItemSelecionado.Name = "btnLimpaItemSelecionado";
            this.btnLimpaItemSelecionado.Size = new System.Drawing.Size(183, 26);
            this.btnLimpaItemSelecionado.TabIndex = 10;
            this.btnLimpaItemSelecionado.Text = "Limpa Item Selecionado";
            this.btnLimpaItemSelecionado.UseVisualStyleBackColor = true;
            this.btnLimpaItemSelecionado.Click += new System.EventHandler(this.btnLimpaItemSelecionado_Click);
            // 
            // frmEstruturaRepeticao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(723, 393);
            this.Controls.Add(this.btnLimpaItemSelecionado);
            this.Controls.Add(this.btnLimparEstado);
            this.Controls.Add(this.btnInserirEstado);
            this.Controls.Add(this.txtInserirEstado);
            this.Controls.Add(this.lblDigiteEstado);
            this.Controls.Add(this.btnCarregaListaEstados);
            this.Controls.Add(this.btnCarregaEstado);
            this.Controls.Add(this.lblListaEstados);
            this.Controls.Add(this.ltbListaEstados);
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
        private System.Windows.Forms.ListBox ltbListaEstados;
        private System.Windows.Forms.Label lblListaEstados;
        private System.Windows.Forms.Button btnCarregaEstado;
        private System.Windows.Forms.Button btnCarregaListaEstados;
        private System.Windows.Forms.Label lblDigiteEstado;
        private System.Windows.Forms.TextBox txtInserirEstado;
        private System.Windows.Forms.Button btnInserirEstado;
        private System.Windows.Forms.Button btnLimparEstado;
        private System.Windows.Forms.Button btnLimpaItemSelecionado;
    }
}