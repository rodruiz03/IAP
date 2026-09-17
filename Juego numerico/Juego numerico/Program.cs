// See https://aka.ms/new-console-template for more information
Console.WriteLine("Juego Numerico");
Random rand = new Random();
int valor = rand.Next(1,10);
int ingreso = 0;

while(ingreso != valor)
{
    Console.WriteLine("Intente adinivnar un nuemro entre 1 y 10");
    ingreso = Convert.ToInt32(Console.ReadLine());

    if(ingreso == valor)
    {

        Console.WriteLine("Gano");

    }
    else
    {

        Console.WriteLine("Intente de nuevo no gano dios no lo ama");

    }
}
