using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroProyecto
{
    internal class AlmacenamientoMatriz
    {
        public string[,] matriz;
        public int fila, columna;
        public int ContadorMovimientos = 0;
        public AlmacenamientoMatriz(int f, int c)
        {
            matriz = new string[f,c];
            fila = f;
            columna = c;
        }
    }
}
