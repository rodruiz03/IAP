using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese su número");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingrese un número");
            int num2 = Convert.ToInt32(Console.ReadLine());

            int suma = (num1 + num2); 
            int resta= (num1 - num2);
            int multi= (num1 * num2);
            int divide= (num1 / num2);

            Console.WriteLine("El resultado de la suma es: " + suma);
            Console.WriteLine("El resultado de la resta es: " + resta);
            Console.WriteLine("El resultado de la multiplicación es: " + multi);
            Console.WriteLine("El resulado de la divicion de los numeros es: " + divide);

            Console.ReadLine();
        }
    }
}
