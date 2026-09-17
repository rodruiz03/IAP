using System;

public class NumeroPerfecto
{
    
    private int numero;

    public NumeroPerfecto(int numero)
    {
        this.numero = numero;
    }

    public int CalcularSumaDivisores()
    {
        int suma = 0;

        for (int i = 1; i <= numero / 2; i++)
        {
            if (numero % i == 0)
            {
                suma += i;
            }
        }

        return suma;
    }

    public bool EsNumeroPerfecto()
    {
        return CalcularSumaDivisores() == numero;
    }

    public int[] ObtenerMultiplos(int cantidad)
    {
        int[] multiplos = new int[cantidad];

        int contador = 0;
        int numeroMultiplo = numero;

        while (contador < cantidad)
        {
            if (EsNumeroPerfecto())
            {
                multiplos[contador] = numeroMultiplo;
                contador++;
            }

            numeroMultiplo += numero;
        }

        return multiplos;
    }
}

public class Program
{
    public static void Main()
    {
        NumeroPerfecto numeroPerfecto = new NumeroPerfecto(6);
        int[] multiplos = numeroPerfecto.ObtenerMultiplos(10);

        Console.WriteLine("Los primeros 10 múltiplos del número perfecto 6 son:");
        foreach (int multiplo in multiplos)
        {
            Console.WriteLine(multiplo);
        }
    }
}

