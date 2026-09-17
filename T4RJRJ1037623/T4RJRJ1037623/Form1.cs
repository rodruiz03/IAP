using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace T4RJRJ1037623
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int num1 = int.Parse(textBox1.Text);
                double res1 = 0;
                if (num1 <= 0)
                {
                    label8.Text = "El valor ingresado debe de ser mayor a 0";
                }
                else
                {
                    for (int i = 1;i <= num1;i++)
                    {
                        res1 = res1 + (1.0/i);
                    }
                    label8.Text = "El resultado de la serie es: " + res1;
                }
            }
            catch
            {
                label8.Text = "El valor ingresado no es un numero";
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                int num2 = int.Parse(textBox2.Text);
                double res2 = 0;
                if (num2 <= 0)
                {
                    label9.Text = "El valor ingresado debe de ser mayor a 0";
                }
                else
                {
                    for (int i = 1;i <= num2;i++)
                    {
                        res2 += 1.0 / Math.Pow(2, i);
                    }
                    label9.Text = "El resultado de la serie es: " + res2;
                }
            }
            catch
            {
                label9.Text = "El valor ingresado no es un numero";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                int num3 = int.Parse(textBox3.Text);
                int num4 = int.Parse(textBox4.Text);
                int num5 = int.Parse(textBox5.Text);

                if (num3 <= 0)
                {
                    label11.Text = "El valor ingresado debe de ser mayor a 0";
                }
                else
                {
                    for (int k = 0; k <= num3; k++)
                    {
                        int res3 = (int)Math.Pow(num3, k) * (int)Math.Pow(num4, num5 - k);
                        label11.Text = "El resultado de la serie es: " + res3;
                    }
                }
            }
            catch
            {
                label11.Text = "El valor ingresado no es un numero";
            }
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
