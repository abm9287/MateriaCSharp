using System;

namespace AppConsola
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("NOMBRES COMPLETOS: ");
            string nombresCompletos = Console.ReadLine();

            Console.WriteLine("APELLIDOS COMPLETOS: ");
            string apellidosCompletos = Console.ReadLine();

            Console.WriteLine("C.I: ");
            int cedulaIdentidad = int.Parse(Console.ReadLine());

            Console.WriteLine("DIRECCIÓN DE DOMICILIO: ");
            string direccionDomicilio = Console.ReadLine();

            Console.WriteLine("TELÉFONO CONVENCIONAL:");
            int numeroConvencional = int.Parse(Console.ReadLine());

            Console.WriteLine("TELÉFONO CELULAR: ");
            int numeroCelular = int.Parse(Console.ReadLine());


            Console.WriteLine("---------------SUS DATOS SON LOS SIGUIENTES---------------");
            Console.WriteLine($"NOMBRES COMPLETOS: {nombresCompletos}");
            Console.WriteLine($"APELLIDOS COMPLETOS: {apellidosCompletos}");
            Console.WriteLine($"C.I: {cedulaIdentidad}");
            Console.WriteLine($"DIRECCIÓN DE DOMICILIO: {direccionDomicilio}");
            Console.WriteLine($"TELÉFONO CONVENCIONAL: {numeroConvencional}");
            Console.WriteLine($"TElÉFONO CELULAR: {numeroCelular}");

            Console.WriteLine("USTED INGRESÓ SUS DATOS COMPLETOS!");
        }
    }
}
