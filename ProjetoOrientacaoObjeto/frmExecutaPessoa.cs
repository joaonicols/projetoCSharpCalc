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
    public partial class frmExecutaPessoa : Form
    {
        public frmExecutaPessoa()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Pessoa ps = new Pessoa();

            //Mostrar Nome
            ps.setNome(txtNome.Text);
            lblMostrarNome.Text = ps.getNome();

            //Mostrar Email
            ps.setEmail(txtEmail.Text);
            lblMostraEmail.Text = ps.getEmail();

            //Mostrar CPF
            ps.setCPF(mtbCpf.Text);
            lblMostraCPF.Text = ps.getCPF();

            //Mostrar Telefone
            ps.setTelefone(mtbTelefone.Text);
            lblMostraTel.Text = ps.getTelefone();

            //Mostrar Idade
            ps.setIdade(Convert.ToInt32(txtIdade.Text));
            lblMostraIdade.Text = ps.getIdade().ToString();
        }
    }
}
