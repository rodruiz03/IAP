using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace T7_RJRJ_1037623
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int[] desplazamiento = new int[] { 751, 552, 680, 965, 81, 994, 754, 981, 383, 427 };
        int[] tiempo = new int[] { 59, 40, 14, 6, 30, 45, 16, 50, 41, 12 };
        int[] Vinst = new int[10];
        int[] tAelatorio = new int[10];

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[] numeros = new int[] { 1, 2, 3, 4, 5 };
            char[] letras = new char[] { 'a', 'e', 'i', 'o', 'u' };

            label1.Text = "";

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    label1.Text = label1.Text + numeros[i].ToString() + letras[j] + ",";
                }
                label1.Text = label1.Text + "\n";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int suma = 0;
            if (label2.Text != "")
            {

                for (int i = 0; i < 10; i++)
                {
                    suma = suma + Vinst[i];
                }

                label3.Text = "Promedio de velocidades es: " + (suma / 10).ToString();

            }
            else
            {
                MessageBox.Show("debe calcular primero las velocidades instantaneas");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 10; i++)
            {
                Vinst[i] = desplazamiento[i] / tiempo[i];

            }

            label2.Text = "El promedio de velocidades es: ";

            for (int i = 0; i < 10; i++)
            {
                label2.Text = label2.Text + Vinst[i] + ",";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Random rd = new Random();



            for(int i = 0; i<10; i++)
            {  
                tAelatorio[i] = rd.Next(1, 100);
            }

            label4.Text = "Los tiempos aleatorios son: ";

            for (int i = 0; i < 10; i++)
            {
                label4.Text = label4.Text + tAelatorio[i] + ",";
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            double[] aceleracion = new double[10];

            if (label3.Text != "" && label4.Text != "")
            {

                label5.Text = "Las aceleraciones son: ";
                for (int i = 0; i < 10; i++)
                {
                    aceleracion[i] = Convert.ToDouble(Vinst[i] / tAelatorio[i]);
                }

                for (int i = 0; i < 10; i++)
                {
                    label5.Text = label5.Text + aceleracion[i].ToString() + ",";
                }
            }
            else
            {
                MessageBox.Show("debe generar las velocidades instantaneas y los tiempos aleatorios primero.");
            }
        }
    }
}
