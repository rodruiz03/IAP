
Console.WriteLine(" Ingrese un número entre 0 y 999");
int num = Convert.ToInt32(Console.ReadLine());
int centenas, decenas, unidades;
int rescent;
string res = "";

if ((num > 0) && (num < 1000))
{
    centenas = num / 100;
    rescent = num % 100;
    decenas = rescent / 10;
    unidades = rescent % 10;

    switch (centenas)
    {
        case 1:
            res = "C";
            break;
        case 2:
            res = "CC";
            break;
        case 3:
            res = "CCC";
            break;
        case 4:
            res = "CD";
            break;
        case 5:
            res = "D";
            break;
        case 6:
            res = "DC";
            break;
        case 7:
            res = "DCC";
            break;
        case 8:
            res = "DCCC";
            break;
        case 9:
            res = "CM";
            break;
    }

    switch (decenas)
    {
        case 1:
            res += "X";
            break;
        case 2:
            res += "XX";
            break;
        case 3:
            res += "XXX";
            break;
        case 4:
            res += "XL";
            break;
        case 5:
            res += "L";
            break;
        case 6:
            res += "LX";
            break;
        case 7:
            res += "LXX";
            break;
        case 8:
            res += "LXXX";
            break;
        case 9:
            res += "XC";
            break;
    }
    switch (unidades)
    {
        case 1:
            res += "I";
            break;
        case 2:
            res += "II";
            break;
        case 3:
            res += "III";
            break;
        case 4:
            res += "IV";
            break;
        case 5:
            res += "V";
            break;
        case 6:
            res += "VI";
            break;
        case 7:
            res += "VII";
            break;
        case 8:
            res += "VI";
            break;
        case 9:
            res += "IX";
            break;


    }
    Console.WriteLine(res);


}
else
{
    Console.WriteLine("El numero no esta dentro de los valores establesidos");
}


public class Romanos
{
    

}