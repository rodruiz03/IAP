using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo_de_for
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tablas de multiplcar");

            Console.WriteLine("Con cual numero desea iniciar");

            Console.WriteLine("ingrese un numero positivo");
            int numbase = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Hasta que numero desea iniciar");
            int numt = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Hasta que numero desea finalizar");
            int numf = Convert.ToInt32(Console.ReadLine());

            if ((numf>0) && (numf>numt))
            {
                for (int i = numt; i <= numf; i++)

                {
                    Console.WriteLine(numbase + "x" + i + "=" + i * numbase);
                    Console.ReadLine();
                }
            }
            else
            {
                Console.WriteLine("Error ingresando el numero final");
            }

            
        }
    }
}
