
    Console.WriteLine("Ingrese un numero");
    int valor = Convert.ToInt32(Console.ReadLine());
    int sumatoria = 0;

if (valor<=0)
{
    Console.WriteLine("Error, numero no valido");
}
else
{
    for(int i = 1; i < valor; i++)
    {
        if(valor%i==0)
        {
            sumatoria += i;
        }
    }

    if(sumatoria==valor)
    {
        Console.WriteLine("Numro exacto");
    }
    else
    {
        Console.WriteLine("Numero no exacto");
    }
}
