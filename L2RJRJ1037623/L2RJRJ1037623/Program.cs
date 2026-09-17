using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L2RJRJ1037623
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ejercicio 1: operaciones aritméticas");
            int n1, n2;
            Console.WriteLine("Ingrese un numero");
            //n1 = int.Parse(Console.ReadLine());
            n1 = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Ingrese otro número");
            n2 = int.Parse(Console.ReadLine());
            int total, diferencia, producto, residuo, cociente;
            double cocientereal;
            total = n1 + n2;
            producto = n1 * n2;
            diferencia = n1 - n2;
            cocientereal = Convert.ToDouble(n1) / Convert.ToDouble(n2);
            cociente = n1 / n2;
            residuo = n1 % n2;

            Console.WriteLine(n1.ToString() + " + " + n2.ToString() + " x " + total.ToString());
            Console.WriteLine(n1.ToString() + " - " + n2.ToString() + " x " + diferencia.ToString());
            Console.WriteLine(n1.ToString() + " * " + n2.ToString() + " x " + producto.ToString());
            Console.WriteLine(n1.ToString() + " / " + n2.ToString() + " x " + total.ToString());
            Console.WriteLine(n1.ToString() + " Div " + n2.ToString() + " x " + total.ToString());
            Console.WriteLine(n1.ToString() + " MOD " + n2.ToString() + " x " + total.ToString());
        }
    }
}
