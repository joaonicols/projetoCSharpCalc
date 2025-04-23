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
    public partial class frmNotas : Form
    {
        public frmNotas()
        {
            InitializeComponent();
        }

        string [,] alunos = new string [3,3];
        double[,] prova1 = new double[3,3];
        double[,] prova2 = new double[3,3];
        double[,] prova3 = new double[3,3];
        double[,] trabalho = new double[3,3];
 

        
        
        
        private void btnCalcularNotas_Click(object sender, EventArgs e)
        {
            for (i = 0; i < 3; int++)
            {
                for (j = 0; j < 3; j++)

                alunos[i, j] = txtAluno.Text;
            } 
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            ltbNotas.Items.Clear();

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {

        }
    }
}
