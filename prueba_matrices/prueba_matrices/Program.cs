using System;

class Program
{
    static void Main()
    {
        int mayor = 0;

        int[] edades = new int[20];

        for (int i = 0; i < edades.Length; i++)
        {
            Console.WriteLine("Ingrese una edad");
            edades[i] = Convert.ToInt32(Console.ReadLine());
        }

        Console.WriteLine("Desea seguir ingresando valores?");
        string respuesta = Console.ReadLine();

        for (int i = 0; i < edades.Length; i++)
        {
            if (i == 0)
            {
                mayor = edades[i];
            }
            else
            {
                if (mayor < edades[i])
                {
                    mayor = edades[i];
                }
            }
        }

        Console.WriteLine("La edad mas grande es: " + mayor);
    }
}

