using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notas_20_20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese un numero");
            int nota = Convert.ToInt32(Console.ReadLine());

            if ((nota >= 0) && (nota <= 100))
            {
                if (nota <= 20)
                {
                    Console.WriteLine("Arquitectura");
                }

                if (nota <= 40)
                {
                    Console.WriteLine("Desarrollo");
                }

                if (nota >= 60)
                {
                    Console.WriteLine("Gastronomia");
                }

                if (nota >= 80)
                {
                    Console.WriteLine("Humanidades");
                }

                if (nota > 100)
                {
                    Console.WriteLine("Ingenieria");
                }
                else
                {
                    
                    Console.WriteLine("No aplica el criterio");


                }

                Console.ReadLine();
            }
        }
    }
}
