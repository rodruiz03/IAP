Console.WriteLine("Hoja de trabajo No.06");
Console.WriteLine("Rodrigo Ruiz-1037623");
Console.WriteLine("Ejercicio No.01");

//Inicio ejercicio No.01 
int num;

do
{
    Console.Write("Ingrese un entero positivo (99 para finalizar esta seccion del programa): ");
    num = Convert.ToInt32(Console.ReadLine());

    if (num % 2 == 0)
    {
        Console.WriteLine("{0} es un número par.", num);
    }
} while (num != 99);

Console.WriteLine("Fin del programa.");
//Fin ejercicio No.01

//Inicio ejercicio No.02
Console.WriteLine("");
Console.WriteLine("Ejercicio No.02");

int filas;

Console.Write("Ingrese el número de filas: ");
filas = Convert.ToInt32(Console.ReadLine());

for (int i = 1; i <= filas; i++)
{
    for (int j = 1; j <= i; j++)
    {
        Console.Write("{0} ", j);
    }
    Console.WriteLine();
}
//Fin ejercicio No.02

//Inicio ejercicio No.03
Console.WriteLine("");
Console.WriteLine("Ejercicio No.03");

int suma = 0;

for (int b = 100; b <= 200; b++)
{
    if (b % 9 == 0)
    {
        suma += b;
        Console.Write("{0} ", b);
    }
}
Console.WriteLine("\nLa suma de los números divisibles entre 9 es: {0}", suma);
//Fin ejercicio No.03

//Inicio ejercicio No.04
Console.WriteLine("");
Console.WriteLine("Ejercicio No.04");

int back;

Console.Write("Ingrese un número entero positivo del 1 al 10: ");
back = Convert.ToInt32(Console.ReadLine());

for (int a = 1; a <= back; a++)
{
    Console.WriteLine("Tabla de multiplicar del {0}:", a);
    for (int c = 1; c <= 10; c++)
    {
        Console.WriteLine("{0} x {1} = {2}", a, c, a * c);
    }
    Console.WriteLine();
}
//Fin ejercicio No.04
