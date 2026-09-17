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
    public partial class Form1 : Form
    {
        static int f, c;
        //Sirve para mandar a llamar variables, matrices, etc;
        AlmacenamientoMatriz S1;
        

        //Almacenamiento de veces que se ejecuto el la prueba espacial
        public static int CanVec = 0;

        public static int VecesDer = 0;

        public static int combustible = 0;

        public static string NombreUser = "";
        public static char InialName = NombreUser[0];

        public static string infocom = "GUA" + InialName;
        public static int EdadUser = 0;

        public Form1()
        {
            InitializeComponent();
        }
        Form2 frm1 = new Form2();
        private void button1_Click(object sender, EventArgs e)
        {    
            frm1.Show();
        }

        //El metodo de Datos del Usuario
        public void DatosUsuario(string Nombre, int Edad)
        {
            NombreUser = Nombre;
            EdadUser = Edad;
        }


        public void DimensionesMatriz(int x, int y)
        {
            f = x;
            c = y;
            S1 = new AlmacenamientoMatriz(f, c);
            dataGridView1.ColumnCount = f;
            dataGridView1.RowCount = c;
            mostrar();
        }

        public static int cantAst;

        public void LlenadoAsteroidesPrinci(int aste)
        {
            cantAst = aste;
            LLenadoAsteriodes(aste);
            S1.matriz[0, 0] = "O";
            S1.matriz[f - 1, c - 1] = "TIERRA";
            mostrar();
        }

        public void METODOINCIDIO()
        {
            S1 = new AlmacenamientoMatriz(f, c);
            dataGridView1.ColumnCount = f;
            dataGridView1.RowCount = c;
            S1.matriz[0, 0] = "O";
            S1.matriz[f - 1, c - 1] = "TIERRA";
            mostrar();
            LlenadoAsteroidesPrinci(cantAst);
        }
        private void button6_Click(object sender, EventArgs e)
        {
            S1 = new AlmacenamientoMatriz(f, c);
            dataGridView1.ColumnCount = f;
            dataGridView1.RowCount = c;
            S1.matriz[0, 0] = "O";
            S1.matriz[f - 1, c - 1] = "TIERRA";
            mostrar();
            LlenadoAsteroidesPrinci(cantAst);
        }
       

        private void button2_Click(object sender, EventArgs e)
        {
            
            S1.ContadorMovimientos =+ 1;
            
            for (int i = 0; i < S1.fila; i++)
            {
                for (int j = 0; j < S1.columna; j++)
                {
                    if (S1.matriz[i, j] == "O")
                    {
                        if (S1.matriz[i + 1, j] == "ASTE")
                        {
                            METODOINCIDIO();
                            CanVec++;
                            label2.Text = Convert.ToString(CanVec);
                        }
                        else
                        {
                            S1.matriz[i + 1, j] = "O";
                            S1.matriz[i, j] = "*";
                            VecesDer ++;
                            label3.Text = Convert.ToString(VecesDer);
                        }
                        
                        i = S1.fila;
                        j = S1.columna;
                    }
                }
            }
            
            mostrar();
        }

        public void mostrar()
        {
            for(int i=0; i< S1.fila; i++)
            {
                for(int j =0; j<S1.columna; j++)
                {
                    if (S1.matriz[i, j] == "O")
                    {
                        Image imgprueba;
                        imgprueba = Image.FromFile(@"C:\Users\javie\Documents\Lab3_Estructura\IntroProyecto\IntroProyecto\Images\imgprueba.jpg");
                        DataGridViewImageCell cell = new DataGridViewImageCell();
                        cell.Value = imgprueba;
                        dataGridView1[i, j].Value = cell;
                    }
                    else
                    {
                        dataGridView1[i, j].Value = S1.matriz[i, j];
                        
                    }
                   
                }
            }
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            S1.ContadorMovimientos =+ 1;
            try
            {
                for (int i = 0; i < S1.fila; i++)
                {
                    for (int j = 0; j < S1.columna; j++)
                    {
                        if (S1.matriz[i, j] == "O")
                        {
                            if (S1.matriz[i - 1, j] == "ASTE")
                            {
                                METODOINCIDIO();
                                CanVec++;
                                label2.Text = Convert.ToString(CanVec);
                            }
                            else
                            {
                                S1.matriz[i - 1, j] = "O";
                                S1.matriz[i, j] = "*";
                            }

                            i = S1.fila;
                            j = S1.columna;
                        }
                    }
                }
                mostrar();
            }
            catch(Exception E)
            {
                MessageBox.Show("Simulacion con error");
                CanVec++;
                METODOINCIDIO();

            }
                

               
            
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            S1.ContadorMovimientos = +1;
            for (int i = 0; i < S1.fila; i++)
            {
                for (int j = 0; j < S1.columna; j++)
                {
                    if (S1.matriz[i, j] == "O")
                    {
                        if (S1.matriz[i, j+1] == "ASTE")
                        {
                            METODOINCIDIO();
                            CanVec++;
                            label2.Text = Convert.ToString(CanVec);
                        }
                        else
                        {
                            S1.matriz[i, j+1] = "O";
                            S1.matriz[i, j] = "*";
                        }

                        i = S1.fila;
                        j = S1.columna;
                    }
                }
            }

            mostrar();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            S1.ContadorMovimientos = +1;
            for (int i = 0; i < S1.fila; i++)
            {
                for (int j = 0; j < S1.columna; j++)
                {
                    if (S1.matriz[i, j] == "O")
                    {
                        if (S1.matriz[i, j - 1] == "ASTE")
                        {
                            METODOINCIDIO();
                            CanVec++;
                            label2.Text = Convert.ToString(CanVec);
                        }
                        else
                        {
                            S1.matriz[i, j - 1] = "O";
                            S1.matriz[i, j] = "*";
                        }

                        i = S1.fila;
                        j = S1.columna;
                    }
                }
            }

            mostrar();
        }


        public void AlmacenamientoTxt()
        {
            for (int i = 0; i < S1.fila; i++)
            {
                for (int j = 0; j < S1.columna; j++)
                {
                    if (S1.matriz[i, j] == "*")
                    {
                        S1.matriz[i,j] = "G";
                    }

                    if (S1.matriz[i, j] == "O")
                    {
                        S1.matriz[i, j] = "B";
                    }

                    if (S1.matriz[i, j] == "TIERRA")
                    {
                        S1.matriz[i, j] = "D";
                    }
                }
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public void LLenadoAsteriodes(int c)
        {
            Random rnd1 = new Random();
            Random rnd2 = new Random();

            int aste = 0;

            int r1 = 0;
            int r2 = 0;

            while (aste < c)
            {
                int c1 = 0;
                while (c1 <= c)
                {
                    r1 = rnd1.Next(0, S1.fila);
                    c1++;
                }

                int c2 = 0;
                while (c2 <= 2)
                {
                    r2 = rnd2.Next(0, S1.columna);
                    c2++;
                }

                if( r1==0 && r2 == 0 || r1 == (S1.fila - 1) && r2 == (S1.columna - 1))
                {
                    aste--;
                }
                else
                {
                   
                    S1.matriz[r1, r2] = "ASTE";
                    aste++;
                }


                
            }

            mostrar();

        }
    }
}
