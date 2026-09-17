using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace L8_RJRJ_1037623
{
    public partial class Form1 : Form
    {
        int[,] num;
        int M, N;
        Random r = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnN_Click(object sender, EventArgs e)
        {
            try
            {
                N = int.Parse(mtbN.Text);
            }
            catch
            {
                MessageBox.Show("Debe de ingresar los valores de filas y numeros");
            }
        }

        private void BtnCrear_Click(object sender, EventArgs e)
        {
            num = new int[M, N];
            llenado();
            Mostrar();
        }

        private void btnDimenciones_Click(object sender, EventArgs e)
        {
            try
            {
                M = int.Parse(mtbM.Text);
            }
            catch
            {
                MessageBox.Show("Debe de ingresar los valores de filas y numeros");
            }

        }
        private void llenado()
        {
            try
            {
                for (int i = 0; i < M; i++)
                {
                    for (int j = 0; j < N; j++)
                    {
                        int temp = r.Next(0, 1001);
                        bool repetido = false;
                        for (int k = 0; k < i; k++)
                        {
                            if (temp == num[k, j])
                            {
                                k = i;
                                repetido = true;
                            }
                        }
                        if (!repetido)
                        {
                            for (int k = 0; k < i; k++)
                            {
                                if (temp == num[i, k])
                                {
                                    k = j;
                                    repetido = true;
                                }
                            }
                            
                        }
                        if (!repetido)
                        {
                            num[i, j] = temp;
                        }
                        else
                        {
                            j--;
                        }
                    }
                }
            }
            catch
            {
                MessageBox.Show("Debe de ingresar los valores de filas y columnas");
            }
        }
        private void Mostrar ()
        {
            for (int i = 0; i < M; i++)
            {
                dGVMostrar.Columns.Add("", "");
            }
            dGVMostrar.Rows.Add(M);
           for (int i = 0; i < M; i++)
           {
                for(int j = 0; j < N; j++)
                {
                    dGVMostrar.Rows[i].Cells[j].Value = num [i, j];
                }
           }
        }
    }
}
