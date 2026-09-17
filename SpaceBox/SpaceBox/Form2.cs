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
        string name = "";
        string mname = "";

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form NA = new Form3();
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
                name = Convert.ToString(maskedTextBox1.Text);
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
                mname = Convert.ToString(maskedTextBox2.Text);
            }
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void maskedTextBox2_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}
