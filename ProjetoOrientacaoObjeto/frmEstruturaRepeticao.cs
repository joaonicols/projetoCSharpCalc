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

        private void btnCarregaListaEstados_Click(object sender, EventArgs e)
        {
            ltbListaEstados.Items.Clear();
            ltbListaEstados.Items.Add("Santo Amaro");

        }
        public void inserirEstadocbb()
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
           if(txtInserirEstado.Text.Equals(""))
            {
                MessageBox.Show("Favor inserir um estado");
            }else
            { 
            inserirEstadocbb();
            }
        }

        public void inserirEstadoltb()
        {
            ltbListaEstados.Items.Add(txtInserirEstado.Text);
            txtInserirEstado.Clear();
            txtInserirEstado.Focus();
        }

        private void txtInserirEstado_KeyDown(object sender, KeyEventArgs e)
        {
            if(txtInserirEstado.Text.Equals(""))
            {
                MessageBox.Show("Favor inserir um estado");
            }
            else if (e.KeyCode == Keys.Enter)
            {
                inserirEstadocbb();
            }
        }

        private void btnLimparEstado_Click(object sender, EventArgs e)
        {
            ltbListaEstados.Items.Clear();
        }

        private void btnLimpaItemSelecionado_Click(object sender, EventArgs e)
        {
            try
            { 
            ltbListaEstados.Items.RemoveAt(ltbListaEstados.SelectedIndex);
            } catch (Exception) 
            {
                MessageBox.Show("Selecione um item da lista");
            }
        }
    }
}
