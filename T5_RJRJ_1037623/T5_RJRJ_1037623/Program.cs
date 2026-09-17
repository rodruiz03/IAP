
Console.Write("Rodrigo Ruiz - 1037623");

Console.Write("Ingrese el monto de la compra: ");
string input = Console.ReadLine();
double monto;

if (double.TryParse(input, out monto))// TryParse se utiliza para convertir a decimal
{
    double descuento = 0;

    if (monto < 400)//No hay descuento
    {
        Console.WriteLine("No hay descuento.");
    }
    else if (monto <= 1000)//7% de descuento
    {
        descuento = monto * 0.07;
    }
    else if (monto <= 5000)//10% de descuento
    {
        descuento = monto * 0.10;
    }
    else if (monto <= 15000)//15% de descuento
    {
        descuento = monto * 0.15;
    }
    else //25% de descuento
    {
        descuento = monto * 0.25;
    }

    Console.Write("Ingrese el código de descuento (si no tiene, deje vacío): ");//Codigo de descuento si tiene
    string codigo = Console.ReadLine();

    if (codigo != "")
    {
        descuento += monto * 0.05;
    }

    Console.WriteLine("El descuento es de: Q{0}", descuento);
    Console.WriteLine("El total a pagar es de: Q{0}", monto - descuento);
}
else
{
    Console.WriteLine("No se ha asignado monto.");
}