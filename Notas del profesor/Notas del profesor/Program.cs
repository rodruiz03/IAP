using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notas_del_profesor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int nota = Convert.ToInt32(Console.ReadLine());

            if ((nota >= 0) && (nota <= 100))

            {
                if (nota >= 65)
                {
                    Console.WriteLine("Aprobado");
                }

                else
                {
                    Console.WriteLine("Reprobado");
                }
            }

            Console.ReadLine(); 
        }
    }
}
