using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoArrays
{
    public partial class frmNumAleatorio : Form
    {
        public frmNumAleatorio()
        {
            InitializeComponent();
            //executando o método desativar campos
            desativarCampos();
        }

        Random rnd = new Random();
        int tamanho;

        private void btnGerar_Click(object sender, EventArgs e)
        {
            if(rdbInteirosAleatórios.Checked)
            {
                int num = rnd.Next();
                ltbMostraNumero.Items.Add(num);
                txtInsiraNumero.Clear();
                txtInsiraNumero.Focus();
            }

           if (rdbIntAleatoriosIntervalos.Checked)
           {
                txtInsiraNumero.Enabled = true;
                try
            {
                int valor = int.Parse(txtInsiraNumero.Text);
                int num = rnd.Next(valor);
                ltbMostraNumero.Items.Add(num);
                txtInsiraNumero.Clear();
                txtInsiraNumero.Focus();
            }
            catch (Exception)
            {
                MessageBox.Show("Favor inserir um número interiro");
                txtInsiraNumero.Clear();
                txtInsiraNumero.Focus();
            }
           }

           if (rdbGerarFloatsAleatorios.Checked)
            {
                double num = rnd.NextDouble();
                ltbMostraNumero.Items.Add(num);
                txtInsiraNumero.Clear();
                txtInsiraNumero.Focus();
            }
            if (rdbAleatoriosRepeticao.Checked)
            {
                int valor = int.Parse(txtInsiraNumero.Text);
                tamanho = Convert.ToInt32();
                for (int i = 0; i < tamanho; i++)
                {
                    ltbMostraNumero.Items.Add(rnd.Next(valor));
                }
            }
        }

        public void desativarCampos()
        {
            txtInsiraNumero.Enabled = false;
            txtNumeroMaximo.Enabled = false;
            txtNumeroMinimo.Enabled = false;
            rdbGerarFloatsAleatorios.Checked = false;
            rdbInteirosAleatórios.Checked = false;
            rdbIntAleatoriosIntervalos.Checked = false;
            rdbVariosIntAleatorios.Checked = false;
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            ltbMostraNumero.Items.Clear();
            txtInsiraNumero.Clear();
            txtInsiraNumero.Focus();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void rdbInteirosAleatórios_CheckedChanged(object sender, EventArgs e)
        {
            //não precisa ativar
        }

        private void rdbVariosIntAleatorios_CheckedChanged(object sender, EventArgs e)
        {
            txtInsiraNumero.Enabled = true;
            txtInsiraNumero.Focus();
        }

        private void rdbIntAleatoriosIntervalos_CheckedChanged(object sender, EventArgs e)
        {
            txtNumeroMaximo.Enabled = true;
            txtNumeroMinimo.Enabled = true;
            txtNumeroMinimo.Focus();
        }

        private void rdbGerarFloatsAleatorios_CheckedChanged(object sender, EventArgs e)
        {
            //não precisa ativar
        }

        private void rdbAleatoriosRepeticao_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
