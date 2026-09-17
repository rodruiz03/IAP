using System;

namespace T9RJRJ1037623
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Programa para calcular áreas");
            Console.WriteLine("Ingrese la figura (círculo, cuadrado o triángulo): ");
            string figura = Console.ReadLine().ToLower();

            Console.ReadKey();

            switch (figura)
            {
                case "circulo":
                    double radio = PedirRadio();
                    double areaCirculo = CalcularAreaCirculo(radio);
                    Console.WriteLine("El área del círculo es: {0}", areaCirculo);
                    break;

                case "cuadrado":
                    double lado = PedirLado();
                    double areaCuadrado = CalcularAreaCuadrado(lado);
                    Console.WriteLine("El área del cuadrado es: {0}", areaCuadrado);
                    break;

                case "triangulo":
                    double baseTriangulo = PedirBase();
                    double alturaTriangulo = PedirAltura();
                    double areaTriangulo = CalcularAreaTriangulo(baseTriangulo, alturaTriangulo);
                    Console.WriteLine("El área del triángulo es: {0}", areaTriangulo);
                    break;

                default:
                    Console.WriteLine("Error: figura inválida.");
                    break;
            }

            Console.ReadKey();
            Console.WriteLine("Programa de los electrodomesticos");
            Console.WriteLine("Ingrese el precio base del electrodoméstico: ");
            double precioBase = double.Parse(Console.ReadLine());
            char consumoEnergetico = PedirConsumoEnergetico();
            string color = PedirColor();
            double peso = PedirPeso();
            double precioFinal = CalcularPrecioFinal(precioBase, consumoEnergetico, peso);
            Console.WriteLine($"El precio final del electrodoméstico es: Q{precioFinal}");
            Console.ReadKey();
            Console.WriteLine("Programa para calcular los divisores de un número");
            Console.Write("Ingrese un número: ");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.Write("Los divisores de " + num + " son: ");
            mostrarDivisores(num);
            Console.ReadKey();
        }
        static void mostrarDivisores(int num)
        {
            for (int i = 1; i <= num; i++)
            {
                if (num % i == 0)
                {
                    Console.Write(i + " ");
                }
            }
        }
        static double PedirRadio()
        {
            Console.Write("Ingrese el radio: ");
            double radio = double.Parse(Console.ReadLine());
            return radio;
        }

        static double PedirLado()
        {
            Console.Write("Ingrese el lado: ");
            double lado = double.Parse(Console.ReadLine());
            return lado;
        }

        static double PedirBase()
        {
            Console.Write("Ingrese la base: ");
            double basee = double.Parse(Console.ReadLine());
            return basee;
        }

        static double PedirAltura()
        {
            Console.Write("Ingrese la altura: ");
            double altura = double.Parse(Console.ReadLine());
            return altura;
        }

        static double CalcularAreaCirculo(double radio)
        {
            double area = Math.Pow(radio, 2) * Math.PI;
            return area;
        }

        static double CalcularAreaCuadrado(double lado)
        {
            double area = Math.Pow(lado, 2);
            return area;
        }

        static double CalcularAreaTriangulo(double basee, double altura)
        {
            double area = (basee * altura) / 2;
            return area;
        }

        static double PedirPrecioBase()
    {
        Console.Write("Ingrese el precio base del electrodoméstico: ");
        return double.Parse(Console.ReadLine());
    }

    static char PedirConsumoEnergetico()
    {
        Console.Write("Ingrese el consumo energético (letra de A a D): ");
        char consumo = char.Parse(Console.ReadLine().ToUpper());
        if (consumo < 'A' || consumo > 'D')
        {
            Console.WriteLine("Consumo energético inválido, se asignará automáticamente la letra 'F'.");
            return 'F';
        }
        return consumo;
    }

    static string PedirColor()
    {
        Console.Write("Ingrese el color del electrodoméstico: ");
        return Console.ReadLine();
    }

    static double PedirPeso()
    {
        Console.Write("Ingrese el peso del electrodoméstico en kg: ");
        return double.Parse(Console.ReadLine());
    }

    static double CalcularPrecioFinal(double precioBase, char consumoEnergetico, double peso)
    {
        double precioFinal = precioBase;
        switch (consumoEnergetico)
        {
            case 'A':
                precioFinal += 100;
                break;
            case 'B':
                precioFinal += 80;
                break;
            case 'C':
                precioFinal += 60;
                break;
            case 'D':
                precioFinal += 50;
                break;
            default:
                // Si la letra del consumo energético es inválida, se asume que es F y no se agrega ningún recargo.
                break;
        }
        if (peso > 20 && peso < 40)
        {
            precioFinal *= 1.05;
        }
        else if (peso >= 40)
        {
            precioFinal *= 1.1;
        }
        return precioFinal;
    }
    }
}
