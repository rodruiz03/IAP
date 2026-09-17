using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L1RJRJ1037623
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese su nombre: ");
            string name = Console.ReadLine();

            Console.WriteLine("Hola mundo");
            Console.WriteLine("Soy " + name);

            /*Cuando se utiliza WriteLine se pondra el texto dentro de las "" por linea,
             mientras que si se utiliza write esta seguiran de corrido sin importar la linea 
            y se pondran todas juntas hasta que se declare lo crontrario*/

            Console.Write("Hola mundo ");
            Console.Write("Soy " + name);
            Console.ReadKey(); 
        }
    }
}
