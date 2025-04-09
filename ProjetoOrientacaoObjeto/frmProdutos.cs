using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoOrientacaoObjeto
{
    public partial class frmProdutos : Form
    {
        public frmProdutos()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Produtos prod = new Produtos();

            //mostrar código
            prod.setCodigo(Convert.ToInt32(txtCodigo.Text));
            lblMostraCod.Text = prod.getCodigo().ToString();

            //mostrar descrição
            prod.setDescricao(txtDescricao.Text);
            lblMostraDesc.Text = prod.getDescricao();
        }
    }
}
