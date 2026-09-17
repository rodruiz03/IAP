
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("T11-RJRJ-1037623");
        Console.WriteLine("Ejercicio No.01");

        int[] valores = { 8, 5, 9, 6, 6, 5, 7, 0, 5, 5, 4, 5, 6, 2, 9, 5, 7, 4, 10, 0, 7, 4, 8, 3, 9, 3 };

        // Posiciones de los valores primos
        Console.WriteLine("Posiciones de los valores primos:");

        for (int i = 0; i < valores.Length; i++)
        {
            bool esPrimo = true;

            for (int j = 2; j <= Math.Sqrt(valores[i]); j++)
            {
                if (valores[i] % j == 0)
                {
                    esPrimo = false;
                    break;
                }
            }

            if (esPrimo)
            {
                Console.WriteLine($"Posición {i}: {valores[i]}");
            }
        }

        // Posiciones de los valores múltiplos de 5
        Console.WriteLine("Posiciones de los valores múltiplos de 5:");

        for (int i = 0; i < valores.Length; i++)
        {
            if (valores[i] % 5 == 0)
            {
                Console.WriteLine($"Posición {i}: {valores[i]}");
            }
        }

        // El menor valor del arreglo
        int menor = valores[0];

        for (int i = 1; i < valores.Length; i++)
        {
            if (valores[i] < menor)
            {
                menor = valores[i];
            }
        }

        Console.WriteLine($"El menor valor del arreglo es: {menor}");
        Console.WriteLine("");
        Console.ReadLine();

        // Cuántos valores están en los rangos: 0-5, 6-10, 11-15, 16-20
        int[] rangos = new int[4];

        for (int i = 0; i < valores.Length; i++)
        {
            if (valores[i] >= 0 && valores[i] <= 5)
            {
                rangos[0]++;
            }
            else if (valores[i] >= 6 && valores[i] <= 10)
            {
                rangos[1]++;
            }
            else if (valores[i] >= 11 && valores[i] <= 15)
            {
                rangos[2]++;
            }
            else if (valores[i] >= 16 && valores[i] <= 20)
            {
                rangos[3]++;
            }
        }

        Console.WriteLine("Ejercicio No.02");
        Console.WriteLine($"Valores en el rango 0-5: {rangos[0]}");
        Console.WriteLine($"Valores en el rango 6-10: {rangos[1]}");
        Console.WriteLine($"Valores en el rango 11-15: {rangos[2]}");
        Console.WriteLine($"Valores en el rango 16-20: {rangos[3]}");
        Console.ReadLine();

        Console.WriteLine("Ejercicio No.03");
        // vector de calificaciones de las 3 evaluaciones del curso
        double[] notasEvaluacion1 = { 8, 9, 7, 6, 10, 8, 9, 6, 7, 10, 8, 9, 7, 6, 10, 8, 9, 7, 6, 10, 8, 9, 7, 6, 10 };
        double[] notasEvaluacion2 = { 7, 6, 8, 9, 7, 6, 10, 8, 9, 7, 6, 10, 8, 9, 7, 6, 10, 8, 9, 7, 6, 10, 8, 9, 7 };
        double[] notasEvaluacion3 = { 10, 9, 8, 7, 6, 10, 8, 9, 7, 6, 10, 8, 9, 7, 6, 10, 8, 9, 7, 6, 10, 8, 9, 7, 6 };

        double[] notasFinales = CalcularNotasFinales(notasEvaluacion1, notasEvaluacion2, notasEvaluacion3);

        Console.WriteLine("Calificaciones finales:");

        for (int i = 0; i < notasFinales.Length; i++)
        {
            Console.WriteLine("Estudiante {0}: {1}", i + 1, notasFinales[i]);
        }

        Console.ReadKey();
    }

    static double[] CalcularNotasFinales(double[] notasEvaluacion1, double[] notasEvaluacion2, double[] notasEvaluacion3)
    {
        double[] notasFinales = new double[notasEvaluacion1.Length];

        for (int i = 0; i < notasEvaluacion1.Length; i++)
        {
            double notaFinal = (notasEvaluacion1[i] * 0.3) + (notasEvaluacion2[i] * 0.3) + (notasEvaluacion3[i] * 0.4);
            notasFinales[i] = notaFinal;
        }

        return notasFinales;

    }

}

