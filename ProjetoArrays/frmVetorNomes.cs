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
    public partial class frmVetorNomes : Form
    {
        public frmVetorNomes()
        {
            InitializeComponent();
        }
        int i = 0;
        int a = 0;
        string[] nomes = new string[5];
        private void btnCarregarNomes_Click(object sender, EventArgs e)
        {
            nomes[a] = txtNomes.Text;

            txtNomes.Clear();
            txtNomes.Focus();
            if (a == 4)
            {
                for (int i = 0; i < nomes.Length; i++)
                {
                    ltbNomes.Items.Add(nomes[i]);
                }
            }
            a++;





        }
    }
}
