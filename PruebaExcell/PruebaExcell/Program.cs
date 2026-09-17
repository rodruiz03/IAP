//Rodolfo Santa Cruz 1110023
//Rodrigo Ruiz 1037623
//Mario Calito 1093222
//Francisco Sandoval 1100723

Console.Write("Programa FizzBuzz");
Console.ReadLine();
string input = "";
while (input != "x")
{
    Console.Write("Ingrese un numero (o presione 'x' para salir): ");
    input = Console.ReadLine();

    if (input == "x")
    {
        break;
    }

    if (int.TryParse(input, out int num) && num > 0)
    {
        if (num % 3 == 0 && num % 5 == 0)
        {
            Console.WriteLine("FizzBuzz");
        }
        else if (num % 3 == 0)
        {
            Console.WriteLine("Fizz");
        }
        else if (num % 5 == 0)
        {
            Console.WriteLine("Buzz");
        }
        else
        {
            Console.WriteLine(num);
        }
    }
    else
    {
        Console.WriteLine("El valor ingresado no es un numero valido o no es un numero.");
    }
}