int[,] temperatura = new int[5, 5];
int sumatoria = 0;
int contador = 0; 
int Mfrio = 0;  
int Mcaliente = 0;
int num35 = 0;

for (int i = 0; i < 5; i++)
{
    for(int j = 0; j < 5; j++)
    {
        Console.WriteLine("Ingrese un valor para la temperarura");
        temperatura[i, j] = Convert.ToInt32(Console.ReadLine());
    }
}

//Para calcular el promedio
for (int i = 0; i < 5; i++)
{
    for(int j = 0; j < 5; j++)
    {
        sumatoria = sumatoria + temperatura[i, j];
        contador = contador + 1;
    }
}
Console.WriteLine("La temperatura promedio es " + sumatoria / contador);

//Imprimir matriz
//En caso de querer alreves los valores invertir las letras

for (int i = 0; i < 5; i++)
{
    for (int j = 0; j < 5; j++)
    {
        Console.Write(temperatura[i, j] + "   ");
    }
    Console.WriteLine(" ");
}

//Para calcular el mas frio
for (int i = 0; i < 5; i++)
{
    for (int j = 0; j < 5; j++)
    {
        if (i == 0 && j == 0)
        {
            Mfrio = temperatura [i, j];
        }
        else
        {
            if(temperatura [i, j] < Mfrio)
            {
                Mfrio = temperatura [i, j];
            }
        }
    }
}
Console.WriteLine("La temperatura menor es " + Mfrio);

//Para calcular el mas caliente
for (int i = 0; i < 5; i++)
{
    for (int j = 0; j < 5; j++)
    {
        if (i == 0 && j == 0)
        {
            Mcaliente = temperatura[i, j];
        }
        else
        {
            if (temperatura[i, j] > Mcaliente)
            {
                Mcaliente = temperatura[i, j];
            }
        }
    }
}
Console.WriteLine("La temperatura mayor es " + Mcaliente);

//calcular cuales fueron mayores a 35 grados
for (int i = 0; i < 5; i++)
{
    for (int j = 0; j < 5; j++)
    {
        if (i == 0 && j == 0)
        {   
            num35 = temperatura[i, j];
        }
        else
        {
            if (temperatura[i, j] < 35)
            {
                num35++; 
            }
        }
    }
}
Console.WriteLine("Hay  " + num35 + " Con mas de 35 grados");