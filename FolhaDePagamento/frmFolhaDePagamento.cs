using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FolhaDePagamento
{
    public partial class frmFolhaDePagamento : Form
    {
        public frmFolhaDePagamento()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double salario;

            salario = Convert.ToDouble(txtSalario.Text);

            // verificar seu o usuário clicou no plano de saúde
            if(chkPlanoSaude.Checked)
            {
                salario = salario - 400;
            }

            // verificar seu o usuário clicou no clube de lazer
            if (cbbClubeLazer.SelectedIndex == 0)
            {
                salario = salario - 100;
            }

            if (cbbClubeLazer.SelectedIndex == 1)
            {
                salario = salario - 50;
            }

            if(cbbClubeLazer.SelectedIndex == 2)
            {
                salario = salario - 30;
            }

            //calculo do imposto de renda
            if(salario <= 2259.20)
            {
                salario = salario;
            }

            if (salario >= 2259.21 && salario <= 2826.65)
            {
                salario = salario - (salario * 7.5 / 100);                                                                                                      
            }

            txtSalLiq.Text = salario.ToString();
        }
    }
}
