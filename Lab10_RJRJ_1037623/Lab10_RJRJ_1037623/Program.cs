using System;

namespace Lab10_RJRJ_1037623 
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lab10_RJRJ_1037623");

            // Declaración del objeto TrianguloRectangulo
            TrianguloRectangulo objTriangulo;

            // Solicitar datos al usuario
            Console.Write("Ingrese la longitud del cateto A en metros: ");
            double catetoA = double.Parse(Console.ReadLine());

            Console.Write("Ingrese la amplitud en grados del ángulo opuesto al cateto A: ");
            double anguloOpuestoA = double.Parse(Console.ReadLine());

            // Crear el objeto TrianguloRectangulo con los datos ingresados
            objTriangulo = new TrianguloRectangulo(catetoA, anguloOpuestoA);

            // Mostrar los datos del triángulo rectángulo
            Console.WriteLine("\n=== Datos del triángulo rectángulo ===");
            Console.WriteLine("Cateto A: {0} metros", objTriangulo.ObtenerCatetoA());
            Console.WriteLine("Cateto B: {0} metros", objTriangulo.ObtenerCatetoB());
            Console.WriteLine("Hipotenusa: {0} metros", objTriangulo.ObtenerHipotenusa());
            Console.WriteLine("Ángulo opuesto a A: {0} grados", objTriangulo.ObtenerAnguloOpuestoA());
            Console.WriteLine("Ángulo opuesto a B: {0} grados", objTriangulo.ObtenerAnguloOpuestoB());
            Console.WriteLine("Área: {0} metros cuadrados", objTriangulo.ObtenerArea());

            Console.ReadKey(); // Esperar a que el usuario presione una tecla para cerrar la consola
        }
    }
}
