using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace L5_RJRJ_1037623
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = Tabla.SelectedIndex;
        }

        private void tabPage4_Click(object sender, EventArgs e)
        {
            
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            {
                switch (comboBox1.SelectedIndex)
                {
                    case 0:
                        {
                            try
                            {
                                label2.Text = "";
                                int N = int.Parse(comboBox1.Text), suma = 0;
                                if (N > 0)
                                {
                                    for (int i = 1; i <= N; i++)
                                    {
                                        suma += i;
                                    }
                                    label2.Text = "La sumatoria es :" + suma.ToString();
                                }
                                else
                                {
                                    MessageBox.Show("El valor ingresado debe de ser mayor a 0");
                                }
                            }
                            catch
                            {
                                MessageBox.Show("Debe ingresar un numero entero");
                            }
                        }
                        break;

                        case 1:
                        {
                            try
                            {
                                label2.Text = "";
                                int N = int.Parse(comboBox1.Text), factorial = 0;
                                if (N > 0)
                                {
                                    for (int i = 1; i <= N; i++)
                                    {
                                        factorial *= i;
                                    }
                                    label2.Text = "La sumatoria es :" + factorial.ToString();
                                }
                                else
                                {
                                    MessageBox.Show("El valor ingresado debe de ser mayor a 0");
                                }
                            }
                            catch
                            {
                                MessageBox.Show("Debe ingresar un numero entero");
                            }
                        }
                        break;
                    default:
                        {
                            MessageBox.Show("Debe seleccionar una opcion");
                        }
                        break;
                }
            }
        }
    }
}
