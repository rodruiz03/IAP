using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10_RJRJ_1037623
{
    class TrianguloRectangulo
    {
        private double catetoA;
        private double anguloOpuestoA;

        public TrianguloRectangulo(double catetoA, double anguloOpuestoA)
        {
            this.catetoA = catetoA;
            this.anguloOpuestoA = anguloOpuestoA;
        }

        public double ObtenerCatetoA()
        {
            return catetoA;
        }

        public double ObtenerCatetoB()
        {
            double catetoB = catetoA * Math.Tan(anguloOpuestoA * Math.PI / 180.0);
            return Math.Round(catetoB, 3);
        }

        public double ObtenerHipotenusa()
        {
            double hipotenusa = catetoA / Math.Cos(anguloOpuestoA * Math.PI / 180.0);
            return Math.Round(hipotenusa, 3);
        }

        public double ObtenerAnguloOpuestoA()
        {
            return anguloOpuestoA;
        }

        public double ObtenerAnguloOpuestoB()
        {
            return Math.Round(90 - anguloOpuestoA, 3);
        }

        public double ObtenerArea()
        {
            return Math.Round(catetoA * ObtenerCatetoB() / 2, 3);
        }
    }
}
