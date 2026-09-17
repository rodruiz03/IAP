//Rodrigo Ruiz- 1037623
string DivisionesEnBilletes(int numero)
{
    int[] denominaciones = { 100, 50, 20, 10, 5, 1 };
    int[] cantidades = new int[denominaciones.Length];
    string resultado = "";
    Console.ReadLine();

    for (int i = 0; i < denominaciones.Length; i++)
    {
        cantidades[i] = numero / denominaciones[i];
        numero %= denominaciones[i];
        resultado += $"Billetes de {denominaciones[i]} = {cantidades[i]}\n";
        Console.ReadLine();
    }
    Console.ReadLine();
    return resultado;
}

string DivisionesEnMonedas(int numero)
{
    int[] denominaciones = { 50, 25, 10, 5, 1 };
    int[] cantidades = new int[denominaciones.Length];
    string resultado = "";
    Console.ReadLine();

    for (int i = 0; i < denominaciones.Length; i++)
    {
        cantidades[i] = numero / denominaciones[i];
        numero %= denominaciones[i];
        resultado += $"Monedas de {denominaciones[i]} = {cantidades[i]}\n";
        Console.ReadLine();
    }
    Console.ReadLine();
    return resultado;
}

