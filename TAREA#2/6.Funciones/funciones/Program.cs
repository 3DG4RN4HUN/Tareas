using System;

namespace funciones
{
    class Program
    {
        static void Main(string[] args)
        {
            Alumno a = new Alumno(1, "Bryan", "Zavala");
            Alumno b = new Alumno(2, "Waldina", "Zavala");

            a.inactivarAlumno();

            Console.WriteLine(a.nombreCompleto());
            Console.WriteLine(b.nombreCompleto());

            a.activarAlumno();

            Console.WriteLine(" ");
            
            Console.WriteLine(a.nombreCompleto());
            Console.WriteLine(b.nombreCompleto());


        }
    }
}
