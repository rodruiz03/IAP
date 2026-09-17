using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IntroProyecto
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Declaro el Form1 para meter info mediante metodos
            Form1 frm1 = new Form1();

            //Se pide la informacion
            string nombre = textBox1.Text;
            int edad = Convert.ToInt32(textBox2.Text);
            //Mando a llamar el metodo Para registar informacion
            frm1.DatosUsuario(nombre,edad);


            int f = Convert.ToInt32(textBox3.Text);
            int c = Convert.ToInt32(textBox4.Text);
            //Mando a llamar metodo de matriz, Para llenarla con un valor 
            frm1.DimensionesMatriz(f, c);

            int AST = Convert.ToInt32(textBox5.Text);
            //Mando a llamar metodo para asteroides, que solo tiene un parametro
            frm1.LlenadoAsteroidesPrinci(AST);

            

            this.Close();
        }





        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
