namespace Arreglos_semana_12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Asignar variables
            Estudiante[] Est = new Estudiante[15];
            int cantidad;
            int i = 0;
            char resp = 'S';
            int hombres = 0;
            int mujeres = 0;
            int sumatoriaEdadMujeres = 0;
            int sumatoriaEdadHombres = 0;
            string registros = "";

            Console.WriteLine("Semana_12_RJRJ_1037623");
            //Comienzo del registro
            do
            {
                //Numero de registro
                cantidad = i + 1;
                Console.WriteLine("Registro numero " + cantidad);
                Est[i] = new Estudiante();

                //Asignacion de nombre
                Console.WriteLine("Ingrese un nombre");
                Est[i].Nombre = Console.ReadLine();
                registros += Est[i].Nombre + ", ";

                //Asignar genero
                do
                {
                    //Asignacion de edad
                    Console.WriteLine("Ingrese la edad");
                    Est[i].Edad = Convert.ToInt32(Console.ReadLine());

                    //Programacion defensiva
                    if (Est[i].Edad >= 120)
                    {
                        Console.WriteLine("Ingreso una edad no valida, nadie vive mas de 120 años");
                    }
                }
                while (Est[i].Edad >= 120);
               

                //Asignar genero
                do
                {
                    Console.WriteLine("Ingrese el genero (H/M)");
                    try
                    {
                        Est[i].Genero = Convert.ToChar(Console.ReadLine().ToUpper());
                        if (Est[i].Genero != 'H' && Est[i].Genero != 'M')
                        {
                            throw new ArgumentException("Utilice solamente las letras H o M");
                        }
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Utilizo un caracter no valido");
                    }
                    catch (ArgumentException ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }
                while (Est[i].Genero != 'H' && Est[i].Genero != 'M');

                //Sumatoria para el promedio de los generos
                if (Est[i].Genero == 'H')
                {
                    hombres++;
                    sumatoriaEdadHombres += Est[i].Edad;
                }
                else
                {
                    mujeres++;
                    sumatoriaEdadMujeres += Est[i].Edad;
                }

                //Opcion para asignar mas registros
                Console.WriteLine("Desea asignar otro registro (S/N)");
                resp = Convert.ToChar(Console.ReadLine());
                i++;
            } while ((resp == 'S') && (cantidad <= 15));

            //Declaracion de cantidades de encuestados de ambos sexos
            Console.WriteLine("Cantidad de hombres en el registro: " + hombres);
            Console.WriteLine("Cantidad de mujeres en el registro: " + mujeres);

            //Declaracion de Promedio de las edades de los sexos
            if (hombres > 0)
            {
                Console.WriteLine("El promedio de edad de los hombres es: " + sumatoriaEdadHombres / hombres);
            }

            if (mujeres > 0)
            {
                Console.WriteLine("El promedio de edad de las mujeres es: " + sumatoriaEdadMujeres / mujeres);
            }

            //Declaracion de nombre de los registros
            Console.WriteLine("Los registros ingresados son: " + registros.TrimEnd(',', ' '));
        }
    }
    //Se declaran las variables publicas
    public class Estudiante
    {
        public string Nombre;
        public int Edad;
        public char Genero;
    }
}
