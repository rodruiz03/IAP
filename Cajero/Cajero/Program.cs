using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cajero
{
    internal class Program
    {
        static void Main(string[] args)
        {
                Console.WriteLine("Ingrese el monto del producto");
                int costo = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingrese el monto a pagar");
            int pago = Convert.ToInt32(Console.ReadLine());

            int cambio = pago - costo;

            int bil100 = cambio / 100;
            int res100 = cambio % 100;
            int bil50 = res100 / 100;
            int res50 = res100 % 100;
            int bil20 = res50 / 100;
            int res20 = res50 % 100;
            int bil10 = res20 / 10;
            int res10 = res20 % 10;
            int bil5 = res10 / 5;
            int bil1 = res10 % 5;

            Console.WriteLine("En billetes de 100: " + bil100);
            Console.WriteLine("En billetes de 500: " + bil50);
            Console.WriteLine("En billetes de 20: " + bil20);
            Console.WriteLine("En billetes de 10: " + bil10);
            Console.WriteLine("En billetes de 5: " + bil5);
            Console.WriteLine("En monedas: " + bil1);

            Console.ReadLine();




        }
    }
}
