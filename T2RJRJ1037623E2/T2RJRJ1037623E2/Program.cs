

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Andres De Leon - 1221023");
        
        Console.Write("Ingrese una cantidad en Quetzales (0 a 999.99): ");
        double monto = double.Parse(Console.ReadLine());

        int bil100 = (int)monto / 100;
        monto %= 100;

        int bill50 = (int)monto / 50;
        monto %= 50;

        int bill20 = (int)monto / 20;
        monto %= 20;

        int bill10 = (int)monto / 10;
        monto %= 10;

        int bill5 = (int)monto / 5;
        monto %= 5;

        int mon1 = (int)monto;
        monto %= 1;

        int mon25 = (int)(monto / 0.25);
        monto %= 0.25;

        int mon1c = (int)(monto / 0.01);
        monto %= 0.01;

        Console.WriteLine("Billetes de 100 Quetzales: " + bil100);

        Console.WriteLine("Billetes de 50 Quetzales: " + bill50);

        Console.WriteLine("Billetes de 20 Quetzales: " + bill20);

        Console.WriteLine("Billetes de 10 Quetzales: " + bill10);

        Console.WriteLine("Billetes de 5 Quetzales: " + bill5);

        Console.WriteLine("Monedas de 1 Quetzales: " + mon1);

        Console.WriteLine("Monedas de 25 centavos: " + mon25);

        Console.WriteLine("Monedas de 1 centavo: " + mon1c);

    }
}

