using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace L6RJRJ1037623
{
    public partial class Form1 : Form
    {
        Automovil objAutomovil;
        public Form1()
        {
            InitializeComponent();
            Automovil objAutomovil = new Automovil();


        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                objAutomovil.DefinirModelo(int.Parse(tBModelo.Text));
            }
            catch
            {
                MessageBox.Show("El precio debe ser un numero real");
            }
            try
            {
                objAutomovil.DefinirPrecio(double.Parse(tBModelo.Text));
            }
            catch
            {
                MessageBox.Show("El precio debe de ser un numero real valido");
            }
            if (tBMarca.Text != " ")
            {
                objAutomovil.DefinirMarca(tBMarca.Text);
            }
            else
            {
                MessageBox.Show("La marca no debe de estar vacia");
            }
            try
            {
               objAutomovil.DefinirTipoCambio(double.Parse(tBTC.Text));
            }
            catch
            {

            }
        }
    }
}
