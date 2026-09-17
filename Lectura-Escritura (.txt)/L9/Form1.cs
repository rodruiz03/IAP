using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace L9
{
    public partial class LE : Form
    {
        public LE()
        {
            InitializeComponent();
        }

        private void btnAbrir_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofdAbrir = new OpenFileDialog(); //objeto para generar las ventanas de apertura de archivos
            ofdAbrir.Filter = "Text File |*.txt"; //filtro para que solo permita abrir archivos de texto (.txt)
            if (ofdAbrir.ShowDialog() == DialogResult.OK)//validación para que al mostrarse la ventana, únicamente se proceda si el usuario selecciona "OK" ("abrir").
            {
                StreamReader srArch = new StreamReader(ofdAbrir.FileName); //objeto para la apertura de un archivo de texto desde código
                string entrada = "";
                while (srArch.Peek() != -1) //ciclo que lee uno a uno los caracteres hasta que llega al final del archivo de texto y encuentra "-1" indicando el fin del archivo
                {
                    entrada+= srArch.ReadLine(); //concatenación de todas las líneas del archivo de texto en una sola cadena de caracteres
                    tBMostrar.Text = entrada; //toda la cadena de caracteres se muestra en Text Box
                }
                srArch.Close();//cierre del archivo de texto, para que no quede abierto en ejecución.
            }
            
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfdGuardar = new SaveFileDialog();//objeto para generar las ventanas de guardado de archivos
            sfdGuardar.Filter = "Text File |*.txt"; //filtro para que solo permita guardar archivos de texto (.txt)
            if (sfdGuardar.ShowDialog() == DialogResult.OK) //validación para que al mostrarse la ventana, únicamente se proceda si el usuario selecciona "OK" ("guardar").
            {
                
                StreamWriter swArch = new StreamWriter(sfdGuardar.FileName);//objeto para el guardado de un archivo de texto desde código
                swArch.WriteLine(tBMostrar.Text); //escritura en archivo de texto existente o generado
                swArch.Close();//cierre del archivo de texto, para que no quede abierto en ejecución.
            }

        }

        private void LE_Load(object sender, EventArgs e)
        {

        }
    }
}
