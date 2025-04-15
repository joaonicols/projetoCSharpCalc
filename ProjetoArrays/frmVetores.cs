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
    public partial class frmVetores : Form
    {
        public frmVetores()
        {
            InitializeComponent();
        }

        private void btnCarrega_Click(object sender, EventArgs e)
        {
            carregaVetores();
        }

        public void carregaVetores()
        {
            int tamanho = int.Parse(txtTamanho.Text);

            //criando um vetor ou uma array de linha
            string[] nome = new string[tamanho];

            //inserindo valores manualmente no vetor
            for (int i = 0; i < nome.Length; i++)
            {
                nome[i] = txtInsiraNome.Text;
            }

            //nome[0] = "Larissa";
            //nome[1] = "Dharla";
            //nome[2] = "Cauã";
            //nome[3] = "Eduardo";
            //nome[4] = "Letícia";
            //nome[5] = "Edna";
            //nome[6] = "Hugo";
            //nome[7] = "Pedro";
            //nome[8] = "João";
            //nome[9] = "Giovane";

            ltbNomes.Items.Clear();
            //percorrendo o vetor ou array de linha
            for (int i = 0; i < nome.Length; i++)
            {
                ltbNomes.Items.Add(nome[i]);
            }
        }

        

        private void btnInserir_Click(object sender, EventArgs e)
        {
            string [] nomes = new string[16];

            for (int i = 0; i < nomes.Length; i++)
            {
                nomes[i] = txtInsiraNome.Text;
                ltbNomes.Items.Add(txtInsiraNome.Text);
            }


            // criar fora do método (em cima do botão)
            //string[] nomes = new string[10];
            //int posicao = 0;
            //if (posicao < 10)
            //{
            //    nomes[posicao] = txtInsiraNome.Text;
            //    posicao++;

            //    ltbNomes.Items.Clear();

            //    for (int i = 0; i < posicao; i++)
            //    {
            //        ltbNomes.Items.Add(nomes[i]);
            //    }

            //    txtInsiraNome.Clear();
        }
    }
}
