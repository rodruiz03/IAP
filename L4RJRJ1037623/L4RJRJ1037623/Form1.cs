using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace L4RJRJ1037623
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void butt_mostrar_fibonacci_Click(object sender, EventArgs e)
        {
            try
            {
                int N = int.Parse(txt_numero_ingresado.Text);
                if (N <= 0)
                {
                    lb_resultado.Text = "El valor ingresado debe de ser mayor a 0";
                }
                else
                {
                    int A = 0, B = 1, C = 0, i = 2;
                    string resultado = "";
                    if (N > 0)
                    {
                        resultado = A.ToString();
                        if (N > 1)
                        {
                            resultado += ("," + B.ToString());
                            while (i < N)
                            {
                                C = A + B;
                                resultado += ("," + C.ToString());
                                A = B;
                                B = C;  
                                i++;
                            }
                            lb_resultado.Text = resultado;
                        }
                        else
                        {
                            lb_resultado.Text = resultado;
                        }
                    }
                    else
                    {
                        lb_resultado.Text = resultado;
                    }  

                }
            }
            catch
            {
                lb_resultado.Text = "El valor ingresado debe de ser numerico";
            }
        }
    }
}
