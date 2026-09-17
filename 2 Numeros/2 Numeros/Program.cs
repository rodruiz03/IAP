// See https://aka.ms/new-console-template for more information
Console.WriteLine("Ingrese un numero de inicio");
int ini = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Ingrese un numero final");
int fin = Convert.ToInt32(Console.ReadLine());
int can;

if (ini < fin)
{
    for(int i = ini; i <= fin; i++)
    {
        can = 0;
        for (int j = i; j <= i; j++)
        {
            if (i%j == 0)
            {
                can++;
            }
        }
        if (can >=5)
        {
            Console.WriteLine(i);
        }
    }
}

else
{
    Console.WriteLine("Eror en el rango de numeros");
}
