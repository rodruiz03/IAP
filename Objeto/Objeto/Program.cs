// See https://aka.ms/new-console-template for more information

Calculadora Calc = new Calculadora();

Console.WriteLine("Ingrese un numero");
int valor1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Ingrese un numero");
int valor2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Suma");
Console.WriteLine(Calc.Sumar(valor1, valor2));

Console.WriteLine("Resta");
Console.WriteLine(Calc.Restar(valor1, valor2));

Console.WriteLine("Multiplicacion");
Console.WriteLine(Calc.Multiplicar(valor1, valor2));

Console.WriteLine("Divicion");
Console.WriteLine(Calc.Dividir(valor1, valor2));

public class Calculadora
{
    public int Sumar(int n1, int n2)
    {
        int res;
        res = n1 + n2;
        return res;
    }

    public int Restar(int n1, int n2)
    {
        int res;
        res = n1 - n2;
        return res;
    }

    public int Multiplicar(int n1, int n2)
    {
        int res;
        res = n1 * n2;
        return res;
    }

    public double Dividir(int n1, int n2)
    {
        
        double res;
        res = Convert.ToDouble(n1)/Convert.ToDouble(n2);
        return res;
    }
}