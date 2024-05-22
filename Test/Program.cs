using System;
using System.Text;
using Entidades;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            // Crear instancias de libros para probar
            Libro libro1 = new Libro(       "Yerma",         "Garcia Lorca, Federico",  1995, "1114", "22222", 27);
            Libro libro2 = new Libro("Cien años de soledad", "Garcia Marquez, Gabriel", 1967, "2225", "33333", 368);

            // Mostrar información de los libros
            Console.WriteLine(libro1.ToString());

            Console.WriteLine(libro2);

            // Verificar igualdad entre los libros
            Console.WriteLine("\n¿Son iguales los libros?");
            Console.WriteLine(libro1 == libro2 ? "Sí" : "No");
        }
    }
}
