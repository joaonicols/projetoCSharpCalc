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

        string[] alunos = new string[10];
        double[,] prova1 = new double[3, 3];
        double[,] prova2 = new double[3, 3];
        double[,] prova3 = new double[3, 3];
        double[,] trabalho = new double[3, 3];
        int linha = 0, coluna = 0;


        private void btnCalcularNotas_Click(object sender, EventArgs e)
        {
            ltbNotas.Items.Clear();
            int contador = 0;

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (alunos[contador] != null)
                    {
                        double p1 = prova1[i,j];
                        double p2 = prova1[i, j];
                        double p3 = prova1[i, j];
                        double trab = trabalho[i, j];
                        double media = (p1 + p2 + p3 + trab) / 4;


                        string situacao = "";

                        if (media >= 7)
                        {
                            situacao = "Aprovado";
                        }
                        else if (media >= 5)
                        {
                            situacao = "Recuperação";
                        }
                        else
                        {
                            situacao = "Reprovado";
                        }

                        ltbNotas.Items.Add($"Aluno: {alunos[contador]}");
                        ltbNotas.Items.Add($"Notas: Primeira Prova= {p1}");
                        ltbNotas.Items.Add($"Segunda Prova = {p2}");
                        ltbNotas.Items.Add($"Terceira Prova = {p3}");
                        ltbNotas.Items.Add($"Trabalho = {trab}");
                        ltbNotas.Items.Add($"Média: {media:F2} - Situação: {situacao}");
                        ltbNotas.Items.Add("----------------------------------");
                    }
                    contador++;
                }
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            ltbNotas.Items.Clear();
            linha = 0;
            coluna = 0;
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            if (linha >= 3)
                return;

            string nome = txtAluno.Text;
            double p1 = Convert.ToDouble(txtP1.Text);
            double p2 = Convert.ToDouble(txtP2.Text);
            double p3 = Convert.ToDouble(txtP3.Text);
            double trab = Convert.ToDouble(txtTrabalho.Text);

            int contador = linha * 3 + coluna;
            alunos[contador] = nome;

            prova1[linha, coluna] = p1;
            prova2[linha, coluna] = p2;
            prova3[linha, coluna] = p3;
            trabalho[linha, coluna] = trab;

            coluna++;
            if (coluna == 3)
            {
                coluna = 0;
                linha++;
            }

            txtAluno.Clear();
            txtP1.Clear();
            txtP2.Clear();
            txtP3.Clear();
            txtTrabalho.Clear();
            txtAluno.Focus();
        }
    }
}
