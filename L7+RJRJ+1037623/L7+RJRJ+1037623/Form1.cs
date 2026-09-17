using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace L7_RJRJ_1037623
{
    public partial class Form1 : Form
    {

        int[] numero = new int[10];
        public Form1()
        {
            InitializeComponent();
            llenado();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public void llenado()
        {
            Random r = new Random();
            int promedio = 0;
            for (int i = 0; i < numero.Length; i++)
            {
                numero[i] = r.Next(1, 100);
                //MessageBox.Show(numero[i].ToString());
                lBDatos.Items.Add(numero[i]);
                promedio += numero[i];
            }
            promedio /= numero.Length;
            Lpromedio.Text = "Promedio: " + promedio.ToString();
            double desviacion = 0;
            for (int i = 0; i < numero.Length; i++)
            {
                desviacion += Math.Pow((numero[i] - promedio), 2);
            }
            desviacion /= numero.Length;
            desviacion = Math.Sqrt(desviacion);
            LDesviacion.Text = "Desviacion: " + Math.Round(desviacion, 2).ToString();
        }

        private void lBDatos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
