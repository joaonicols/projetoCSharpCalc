using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoOrientacaoObjeto
{
    public partial class frmEstruturaRepeticao : Form
    {
        //método construtor da classe
        public frmEstruturaRepeticao()
        {
            InitializeComponent();
            //executa o método carrega comboEstados
            carregaCombo();


        }

        private void btnCarregaEstado_Click(object sender, EventArgs e)
        {
            //executando o método carrega combo
            //carregaCombo();
        }

        //criando o método carrega combo
        public void carregaCombo() 
        {
            //cbbEstado.Items.Clear();
            //cbbEstado.Items.Add("Capão Redondo");
            //cbbEstado.Items.Add("São Luiz");
            //cbbEstado.Items.Add("Campo Grande");
            //cbbEstado.Items.Add("Piraporinha");
            //cbbEstado.Items.Add("Jardim Ângela");
            //cbbEstado.Items.Add("Vila Remo");
            //cbbEstado.Items.Add("Capelinha");
            //cbbEstado.Items.Add("Campo Limpo");
            //cbbEstado.Items.Add("Jardim Jacira");
            //cbbEstado.Items.Add("Jardim Nakamura");
        }

        private void btnCarregaListaDesejos_Click(object sender, EventArgs e)
        {
            ltbListaDesejos.Items.Clear();
            ltbListaDesejos.Items.Add("Santo Amaro");

        }
        public void inserirEstado()
        {
            try
            {
                cbbEstado.Items.Add(txtInserirEstado.Text);
                txtInserirEstado.Clear();
                txtInserirEstado.Focus();
            }
            catch (Exception)
            {
                MessageBox.Show("Favor inserir os valores.");
                txtInserirEstado.Clear();
                txtInserirEstado.Focus();
            }
        }

        private void btnInserirEstado_Click(object sender, EventArgs e)
        {
            inserirEstado();

        }

        private void txtInserirEstado_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                inserirEstado();
            }
        }
    }
}
