using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace SpaceBox
{
    public partial class Form3 : Form
    {
        public Form3(int numeroasteroides, int filas, int columnas)
        {
            InitializeComponent();
            _numeroasteroides = numeroasteroides;
            lascolumnas = columnas;
            lasfilas = filas;

            this.Load += new System.EventHandler(this.Form1_Load);
        }

        private TableLayoutPanelCellPosition posicioninicial;

        private void Form1_Load(object sender, EventArgs e)
        {

            tableLayoutPanel1.RowCount = lasfilas;
            tableLayoutPanel1.ColumnCount = lascolumnas;
            posicioninicial = tableLayoutPanel1.GetCellPosition(Sonda);
            Posiciontierra();
            Posicionspacebox();
            Crearasteroides();
        }

        private void Sonda_Click(object sender, EventArgs e)
        {

        }

        private Keys key;
        private void Form3_KeyDown(object sender, KeyEventArgs e)
        {
            key = e.KeyCode;
            bool repetir = false;
            int columnatierra = tableLayoutPanel1.GetColumn(Tierra);
            int filatierra = tableLayoutPanel1.GetRow(Tierra);
            int ancho = 546 / lascolumnas;
            int largo = 441 / lasfilas;
            do
            {
                bool letrapress = false;
                while (letrapress == false)
                {
                    switch (key)
                    {
                        case Keys.D:

                            TableLayoutPanelCellPosition newPosition = new TableLayoutPanelCellPosition(posicioninicial.Column + 1, posicioninicial.Row);

                            if (tableLayoutPanel1.Controls.ContainsKey("Sonda"))
                            {
                                tableLayoutPanel1.Controls.RemoveByKey("Sonda");
                            }

                            PictureBox nuevospacebox = new PictureBox();
                            nuevospacebox.Image = Properties.Resources.spacebox;
                            nuevospacebox.SizeMode = PictureBoxSizeMode.StretchImage;
                            nuevospacebox.Size = new Size(ancho, largo);
                            nuevospacebox.Name = "Sonda";

                            tableLayoutPanel1.SetRow(nuevospacebox, newPosition.Row);
                            tableLayoutPanel1.SetColumn(nuevospacebox, newPosition.Column);
                            tableLayoutPanel1.Controls.Add(nuevospacebox);

                            posicioninicial = newPosition;

                            if (posicioninicial.Column >= tableLayoutPanel1.ColumnCount)
                            {
                                MessageBox.Show("La spacebox se ha perdido por el espacio no explorado");
                                Reiniciar();
                            }


                            break;
                        case Keys.A:

                            newPosition = new TableLayoutPanelCellPosition(posicioninicial.Column - 1, posicioninicial.Row);

                            if (tableLayoutPanel1.Controls.ContainsKey("Sonda"))
                            {
                                tableLayoutPanel1.Controls.RemoveByKey("Sonda");
                            }

                            nuevospacebox = new PictureBox();
                            nuevospacebox.Image = Properties.Resources.spacebox;
                            nuevospacebox.SizeMode = PictureBoxSizeMode.StretchImage;
                            nuevospacebox.Size = new Size(ancho, largo);
                            nuevospacebox.Name = "Sonda";

                            tableLayoutPanel1.SetRow(nuevospacebox, newPosition.Row);
                            tableLayoutPanel1.SetColumn(nuevospacebox, newPosition.Column);
                            tableLayoutPanel1.Controls.Add(nuevospacebox);

                            posicioninicial = newPosition;

                            if (posicioninicial.Column < 0)
                            {
                                MessageBox.Show("La spacebox se ha perdido por el espacio no explorado");
                                Reiniciar();
                            }


                            break;
                        case Keys.S:

                            newPosition = new TableLayoutPanelCellPosition(posicioninicial.Column, posicioninicial.Row + 1);

                            if (tableLayoutPanel1.Controls.ContainsKey("Sonda"))
                            {
                                tableLayoutPanel1.Controls.RemoveByKey("Sonda");
                            }

                            nuevospacebox = new PictureBox();
                            nuevospacebox.Image = Properties.Resources.spacebox;
                            nuevospacebox.SizeMode = PictureBoxSizeMode.StretchImage;
                            nuevospacebox.Size = new Size(ancho, largo);
                            nuevospacebox.Name = "Sonda";

                            tableLayoutPanel1.SetRow(nuevospacebox, newPosition.Row);
                            tableLayoutPanel1.SetColumn(nuevospacebox, newPosition.Column);
                            tableLayoutPanel1.Controls.Add(nuevospacebox);

                            posicioninicial = newPosition;

                            if (posicioninicial.Row >= tableLayoutPanel1.RowCount)
                            {
                                MessageBox.Show("La spacebox se ha perdido por el espacio no explorado");
                                    Reiniciar();
                            }


                            break;
                        case Keys.W:

                            newPosition = new TableLayoutPanelCellPosition(posicioninicial.Column, posicioninicial.Row - 1);

                            if (tableLayoutPanel1.Controls.ContainsKey("Sonda"))
                            {
                                tableLayoutPanel1.Controls.RemoveByKey("Sonda");
                            }

                            nuevospacebox = new PictureBox();
                            nuevospacebox.Image = Properties.Resources.spacebox;
                            nuevospacebox.SizeMode = PictureBoxSizeMode.StretchImage;
                            nuevospacebox.Size = new Size(ancho, largo);
                            nuevospacebox.Name = "Sonda";

                            tableLayoutPanel1.SetRow(nuevospacebox, newPosition.Row);
                            tableLayoutPanel1.SetColumn(nuevospacebox, newPosition.Column);
                            foreach (Control control in tableLayoutPanel1.Controls)
                            {
                                if (control is PictureBox && control.Name.StartsWith("RUTA"))
                                {
                                    PictureBox cuadruta = (PictureBox)control;
                                    if (tableLayoutPanel1.GetCellPosition(cuadruta) == newPosition)
                                    {
                                        tableLayoutPanel1.Controls.Remove(cuadruta);
                                    }
                                }
                            }

                            tableLayoutPanel1.Controls.Add(nuevospacebox);

                            posicioninicial = newPosition;

                            if (posicioninicial.Row < 0)
                            {
                                MessageBox.Show("La spacebox se ha perdido por el espacio no explorado");
                                    Reiniciar();
                            }
                            break;
                        case Keys.X:
                            Environment.Exit(0);
                            break;
                        case Keys.R:
                            Reiniciar();
                            break;
                        default:
                            break;
                    }

                    Colisiones();

                    if (posicioninicial.Column == columnatierra && posicioninicial.Row == filatierra)
                    {
                        Tierra.Enabled = false;
                        Tierra.Visible = false;
                        MessageBox.Show("¡Ruta exitosa!");
                        DialogResult = MessageBox.Show("¿Quiere grabar la simulación?", "", MessageBoxButtons.OKCancel);
                        if (DialogResult == DialogResult.OK)
                        {
                            Simulacion();
                            MessageBox.Show("Simulacion grabada", "", MessageBoxButtons.OK);
                            Environment.Exit(0);
                        }
                        else
                        {
                            Environment.Exit(0);
                        }
                    }

                    char keypress;
                    keypress = e.KeyCode.ToString()[0];
                    Application.DoEvents();
                    if (e.KeyCode != Keys.None && Char.IsLetter((char)keypress))
                    {
                        letrapress = true;
                    }
                    Thread.Sleep(500);
                    letrapress = false;
                }

            } while (repetir == false);

        }
        private void Reiniciar()
        {
            Borrarasteroides();
            Posiciontierra();
            Posicionspacebox();
            Crearasteroides();
            posicioninicial = tableLayoutPanel1.GetCellPosition(Sonda);
            key = Keys.P;
        }

        private void Posiciontierra()
        {
            int ancho = 546 / lascolumnas;
            int largo = 441 / lasfilas;
            Tierra.Size = new Size(ancho, largo);
            Random random = new Random();
            int columna = random.Next(0, lascolumnas);
            int fila = random.Next(0, lasfilas);
            tableLayoutPanel1.SetColumn(Tierra, columna);
            tableLayoutPanel1.SetRow(Tierra, fila);
        }
        private void Posicionspacebox()
        {

            int ancho = 546 / lascolumnas;
            int largo = 441 / lasfilas;
            if (tableLayoutPanel1.Controls.ContainsKey("Sonda"))
            {
                tableLayoutPanel1.Controls.RemoveByKey("Sonda");
            }

            Random random = new Random();
            int columna = random.Next(0, lascolumnas);
            int fila = random.Next(0, lasfilas);
            TableLayoutPanelCellPosition newpos = new TableLayoutPanelCellPosition(columna, fila);
            tableLayoutPanel1.SetCellPosition(Sonda, newpos);
            Sonda.Size = new Size(ancho, largo);
            tableLayoutPanel1.Controls.Add(Sonda);
        }
        private void Simulacion()
        {
            using (StreamWriter simulacion = new StreamWriter("Simulaciongrabada.txt"))
            {
                for (int i = 0; i < lasfilas; i++)
                {
                    for (int j = 0; j < lascolumnas; j++)
                    {
                        Control con = tableLayoutPanel1.GetControlFromPosition(j, i);
                        if (con == null)
                        {
                            simulacion.Write("A");
                        }
                        else if (con is PictureBox && con.Name.StartsWith("asteroide"))
                        {
                            simulacion.Write("C");
                        }
                        else if (con is PictureBox && con.Name.StartsWith("Tierra"))
                        {
                            simulacion.Write("D");
                        }
                        else if (con is PictureBox && con.Name.StartsWith("Sonda"))
                        {
                            simulacion.Write("B");
                        }
                    }
                    simulacion.Write('\n');
                }
            }
        }
        private int _numeroasteroides;
        private int lascolumnas;
        private int lasfilas;


        private void Crearasteroides()
        {

            int ancho = 546 / lascolumnas;
            int largo = 441 / lasfilas;
            TableLayoutPanelCellPosition posiciontierra = tableLayoutPanel1.GetCellPosition(Tierra);
            TableLayoutPanelCellPosition posicionspacebox = tableLayoutPanel1.GetCellPosition(Sonda);

            List<TableLayoutPanelCellPosition> posicionesValidas = new List<TableLayoutPanelCellPosition>();
            for (int col = 1; col < lascolumnas; col++)
            {
                for (int row = 1; row < lasfilas; row++)
                {
                    if (col != posiciontierra.Column || row != posiciontierra.Row || col != posicionspacebox.Column || row != posicionspacebox.Row)
                    {
                        posicionesValidas.Add(new TableLayoutPanelCellPosition(col, row));
                    }
                }
            }

            PictureBox[] asteroides = new PictureBox[_numeroasteroides];
            if (astcreado == false)
            {
                for (int i = 0; i < asteroides.Length; i++)
                {
                    Random ran = new Random();
                    int posIndex = ran.Next(posicionesValidas.Count);
                    TableLayoutPanelCellPosition astPos = posicionesValidas[posIndex];
                    posicionesValidas.RemoveAt(posIndex);
                    asteroides[i] = new PictureBox();
                    asteroides[i].Size = new Size(102, 80);
                    asteroides[i].SizeMode = PictureBoxSizeMode.StretchImage;
                    asteroides[i].Image = Properties.Resources.asteroide;
                    asteroides[i].Name = "asteroide" + i;
                    tableLayoutPanel1.Controls.Add(asteroides[i], astPos.Column, astPos.Row);
                    astcreado = true;
                }
            }
        }
        private bool astcreado = false;

        private void Borrarasteroides()
        {
            List<PictureBox> eliminar = new List<PictureBox>();

            foreach (Control control in tableLayoutPanel1.Controls)
            {
                if (control is PictureBox && control.Name.StartsWith("asteroide"))
                {
                    PictureBox ast = (PictureBox)control;

                    if (ast.Name != null)
                    {
                        eliminar.Add(ast);
                    }
                }
            }

            foreach (PictureBox asteroide in eliminar)
            {
                tableLayoutPanel1.Controls.Remove(asteroide);
            }
            astcreado = false;
        }
        private void Colisiones()
        {
            foreach (Control control in tableLayoutPanel1.Controls)
            {
                if (control is PictureBox && control.Name.StartsWith("asteroide"))
                {
                    PictureBox asteroide = (PictureBox)control;
                    TableLayoutPanelCellPosition astPos = tableLayoutPanel1.GetCellPosition(asteroide);

                    if (astPos.Column == posicioninicial.Column && astPos.Row == posicioninicial.Row)
                    {
                        asteroide.Enabled = false;
                        asteroide.Visible = false;
                        MessageBox.Show("La spacebox ha chocado con un asteroide");
                        Reiniciar();
                    }
                }
            }
        }
    }
}

