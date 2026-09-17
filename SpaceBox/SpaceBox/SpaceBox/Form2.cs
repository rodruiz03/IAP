using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpaceBox
{
    public partial class Form2 : Form
    {
        double xtxt_tablero;
        double ytxt_tablero;

        public Form2()
        {
            InitializeComponent();
        }
        private int _numeroasteroides;
        private int _columnas;
        private int _filas;
        public Form2(int numeroasteroides, int columnas, int filas)
        {
            InitializeComponent();
            _numeroasteroides = numeroasteroides;
            _columnas = columnas;
            _filas = filas;
        }
        private void Form2_Load(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            Form3 NA = new Form3(_numeroasteroides, _columnas, _filas);
            NA.Show();
            this.Hide();
        }

        private void maskedTextBox1_Validated(object sender, EventArgs e)
        {
            if (maskedTextBox1.Text.Trim() == "")
            {
                ErrorDP.SetError(maskedTextBox1, "Introdusca su nombre porfavor");
                maskedTextBox1.Focus();
            }
            else
            {
                ErrorDP.Clear();
                xtxt_tablero = Convert.ToDouble(maskedTextBox1.Text);
            }
        }

        private void maskedTextBox2_Validated(object sender, EventArgs e)
        {
            if (maskedTextBox2.Text.Trim() == "")
            {
                ErrorDP.SetError(maskedTextBox2, "Introdusca su apellido porfavor");
                maskedTextBox2.Focus();
            }
            else
            {
                ErrorDP.Clear();
                ytxt_tablero = Convert.ToDouble(maskedTextBox2.Text);
            }
        }
    }
}
