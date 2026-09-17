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
    public partial class Inicio : Form
    {
        //Asignacion de valores de las MaskedTxt a las variables
        double xtxt_tablero;
        double ytxt_tablero;
        double nast;
        double xpt;
        double ypt;
        double nOVNI;
        double xSP;
        double ySP;
        
        public Inicio()
        {
            InitializeComponent();
        }

        private void maskedTextBox3_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int numeroasteroides = Convert.ToInt32(asteroides.Text);
            int columnas = Convert.ToInt32(maskedTextBox2.Text);
            int filas = Convert.ToInt32(maskedTextBox1.Text);
            //Abrir la siguiente forms
            Form2 NP = new Form2(numeroasteroides, columnas, filas);
            NP.Show();
            this.Hide();
        }

        private void maskedTextBox1_Validated(object sender, EventArgs e)
        {
            if (maskedTextBox1.Text.Trim() == "")
            {
                ErrorG.SetError(maskedTextBox1, "Introduce el tamaño de la cuadricula en el eje x");
                maskedTextBox1.Focus();
            }
            else
            {
                ErrorG.Clear();
                xtxt_tablero = Convert.ToDouble(maskedTextBox1.Text);
                Datos.xtxt_tablero = maskedTextBox1.Text;
            }
        }

        private void maskedTextBox2_Validated(object sender, EventArgs e)
        {
            if (maskedTextBox2.Text.Trim() == "")
            {
                ErrorG.SetError(maskedTextBox2, "Introduce el tamaño de la cuadricula en el eje y");
                maskedTextBox2.Focus();
            }
            else
            {
                ErrorG.Clear();
                ytxt_tablero = Convert.ToDouble(maskedTextBox2.Text);
                Datos.ytxt_tablero = maskedTextBox2.Text;
            }
        }

        private void maskedTextBox4_Validated(object sender, EventArgs e)
        {
            if (asteroides.Text.Trim() == "")
            {
                ErrorG.SetError(asteroides, "Introduce el numero de asteroides que desea generar (Este numero debe ser entre 0-60% de la cuadricula)");
                asteroides.Focus();
            }
            else
            {
                ErrorG.Clear();
                nast = Convert.ToDouble(asteroides.Text);
                Datos.nast = asteroides.Text;
            }
        }

        private void maskedTextBox2_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
          
        }

        private void maskedTextBox4_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
           
        }

        private void maskedTextBox5_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            
        }

        private void maskedTextBox6_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
        
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double a = (xtxt_tablero * ytxt_tablero) * 0.20;

        }

        private void Inicio_Load(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void maskedTextBox3_Validated(object sender, EventArgs e)
        {
            if (maskedTextBox3.Text.Trim() == "")
            {
                ErrorG.SetError(maskedTextBox3, "Introduce la cordenada en x para generar la tierra");
                maskedTextBox3.Focus();
            }
            else
            {
                ErrorG.Clear();
                xpt = Convert.ToDouble(maskedTextBox3.Text);
                Datos.xpt = maskedTextBox3.Text;
            }
        }

        private void maskedTextBox5_Validated(object sender, EventArgs e)
        {
            if (maskedTextBox5.Text.Trim() == "")
            {
                ErrorG.SetError(maskedTextBox5, "Introduce la cordenada en y donde se generara la tierra");
                maskedTextBox5.Focus();
            }
            else
            {
                ErrorG.Clear();
                ypt = Convert.ToDouble(maskedTextBox5.Text);
                Datos.ypt = maskedTextBox5.Text;
            }
        }

        private void maskedTextBox6_Validated(object sender, EventArgs e)
        {
            if (maskedTextBox6.Text.Trim() == "")
            {
                ErrorG.SetError(maskedTextBox6, "Introduce el numero de OVNI que se desea generar (Este numero debe ser entre 0-20% de la cuadricula)");
                maskedTextBox6.Focus();
            }
            else
            {
                ErrorG.Clear();
                nOVNI = Convert.ToDouble(maskedTextBox6.Text);
                Datos.nOVNI = maskedTextBox6.Text;
            }
        }

        private void maskedTextBox8_Validated(object sender, EventArgs e)
        {
            if (maskedTextBox8.Text.Trim() == "")
            {
                ErrorG.SetError(maskedTextBox8, "Introduce la cordenada en x donde se generara la SpaceBox");
                maskedTextBox8.Focus();
            }
            else
            {
                ErrorG.Clear();
                xSP = Convert.ToDouble(maskedTextBox8.Text);
                Datos.xSP = maskedTextBox8.Text;
            }
        }

        private void maskedTextBox7_Validated(object sender, EventArgs e)
        {
            if (maskedTextBox7.Text.Trim() == "")
            {
                ErrorG.SetError(maskedTextBox7, "Introduce la cordenada en y donde se generara la SpaceBox");
                maskedTextBox7.Focus();
            }
            else
            {
                ErrorG.Clear();
                ySP = Convert.ToDouble(maskedTextBox7.Text);
                Datos.ySP = maskedTextBox7.Text;
            }
        }
    }
}
