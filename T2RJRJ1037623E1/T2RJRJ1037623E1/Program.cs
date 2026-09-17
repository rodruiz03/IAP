using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Andres De Leon - 1221023");
        Console.WriteLine("Este archivo utiliza las medidas del sistema Internacional");

        Console.Write("Ingrese la velocidad inicial (m/s): ");
        double vo = Convert.ToDouble(Console.ReadLine());

        Console.Write("Ingrese la aceleración (m/s^2): ");
        double a = Convert.ToDouble(Console.ReadLine());

        Console.Write("Ingrese el tiempo (s): ");
        double t = Convert.ToDouble(Console.ReadLine());

        double vf = vo + (a * t);

        Console.WriteLine("La velocidad final es: {0} m/s", vf);
    }
}

