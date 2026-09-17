using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba_de_clase
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ejercicio 1");
            Console.WriteLine("Ingrese un número");

            try
            {
                int mes = int.Parse(Console.ReadLine());
                switch (mes)
                {
                    case 1:
                        {
                            Console.WriteLine("Mes, enero");
                        }
                        break;
                    case 2:
                        {
                            Console.WriteLine("Mes, febrero");
                            Console.ReadLine();
                        }
                        break;
                    case 3:
                        {
                            Console.WriteLine("Mes, marzo");
                            Console.ReadLine();
                        }
                        break;
                    case 4:
                        {
                            Console.WriteLine("Mes, abril");
                            Console.ReadLine();
                        }
                        break;
                    case 5:
                        {
                            Console.WriteLine("Mes, mayo");
                            Console.ReadLine();
                        }
                        break;
                    case 6:
                        {
                            Console.WriteLine("Mes, junio");
                            Console.ReadLine();
                        }
                        break;
                    case 7:
                        {
                            Console.WriteLine("Mes, julio");
                            Console.ReadLine();
                        }
                        break;
                    case 8:
                        {
                            Console.WriteLine("Mes, agosto");
                            Console.ReadLine();
                        }
                        break;
                    case 9:
                        {
                            Console.WriteLine("Mes, septiembre");
                            Console.ReadLine();
                        }
                        break;
                    case 10:
                        {
                            Console.WriteLine("Mes, octubre");
                            Console.ReadLine();
                        }
                        break;
                    case 11:
                        {
                            Console.WriteLine("Mes, noviembre");
                            Console.ReadLine();
                        }
                        break;
                    case 12:
                        {
                            Console.WriteLine("Mes, diciembre");
                            Console.ReadLine();
                        }
                        break;

                    default:
                        {
                            Console.WriteLine(" El numero debe de estar entre 1 y 12");
                            Console.ReadLine();
                        }
                        break;
                }
            }
            catch
            {
                Console.WriteLine("El valor ingresado debe ser un numero entero");
                Console.ReadLine();
            }

            Console.WriteLine();
            Console.WriteLine("Ejercicio 2");

            Console.WriteLine("Ingrese el numero A");
            try
            {
                int A = int.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("El valor ingresado para A debe de ser un numero entero");
            }
        }
    }
}
