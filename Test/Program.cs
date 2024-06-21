using Entidades;

namespace Test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // LIBROS
            // Caminos felices
            Libro libro1 = new Libro("Yerma", "García Lorca, Federico", 1995, "11111", "22222", 100);
            Libro libro2 = new Libro("Bodas de sangre", "García Lorca, Federico", 1997, "11112", "22223", 200);
            // Barcode repetido
            Libro libro3 = new Libro("Codebar repetido", "García Lorca, Federico", 2003, "11113", "22222", 3);
            // ISBN repetido
            Libro libro4 = new Libro("ISBN repetido", "García Lorca, Federico", 2003, "11112", "22224", 2);
            // Título-autor repetido
            Libro libro5 = new Libro("Yerma", "García Lorca, Federico", 2003, "55555", "66666", 1);

            //MAPAS 
            // Caminos felices
            Mapa mapa1 = new Mapa("Buenos Aires", "Instituto Geográfico de Buenos Aires", 2005, "", "99999", 30, 15); //450
            Mapa mapa2 = new Mapa("Mendoza", "Instituto Geográfico de Mendoza", 2008, "", "99990", 100, 30); //300
            Mapa mapa3 = new Mapa("Santa Fe", "Instituto Geográfico de Santa Fe", 2010, "", "99991", 80, 30); //2400
            Mapa mapa4 = new Mapa("Corrientes", "Instituto Geográfico de Corrientes", 2013, "", "99992", 50, 25); //1250
            // Barcode repetido
            Mapa mapa5 = new Mapa("Barcode repetido", "Instituto Geográfico", 2015, "", "99999", 40, 15);//600
            // Título - autor - superficie
            Mapa mapa6 = new Mapa("Buenos Aires", "Instituto Geográfico de Buenos Aires", 2005, "", "99993", 30, 15);//200

            //ESCANERS
            Escaner escanerLibro = new Escaner("HP", Escaner.TipoDoc.libro);
            Escaner escanerMapa = new Escaner("HP", Escaner.TipoDoc.mapa);

            bool pudo = escanerLibro + libro1;
            pudo = escanerLibro + libro2;
            pudo = escanerLibro + libro3;
            pudo = escanerLibro + libro4;
            pudo = escanerLibro + libro5;
            pudo = escanerMapa + mapa1;
            pudo = escanerMapa + mapa2;
            pudo = escanerMapa + mapa3;
            pudo = escanerMapa + mapa4;
            pudo = escanerMapa + mapa5;
            pudo = escanerMapa + mapa6;
            pudo = escanerMapa + libro1;
            pudo = escanerLibro + mapa1;

            libro1.AvanzarEstado();
            libro1.AvanzarEstado();
            libro2.AvanzarEstado();
            libro2.AvanzarEstado();
            mapa2.AvanzarEstado();
            mapa3.AvanzarEstado();
            mapa3.AvanzarEstado();
            mapa3.AvanzarEstado();
            mapa4.AvanzarEstado();
            mapa4.AvanzarEstado();
            mapa4.AvanzarEstado();
            mapa4.AvanzarEstado();
            mapa4.AvanzarEstado();

            Informes.MostrarDistribuidos(escanerLibro, out int extensionLibroDistr, out int cantidadLibroDistr, out string resumenLibroDistr);
            Informes.MostrarEnEscaner(escanerLibro, out int extensionLibroEnEsc, out int cantidadLibroEnEsc, out string resumenLibroEnEsc);
            Informes.MostrarEnRevision(escanerLibro, out int extensionLibroEnRev, out int cantidadLibroEnRev, out string resumenLibroEnRev);
            Informes.MostrarTerminados(escanerLibro, out int extensionLibroTerminado, out int cantidadLibroTerminado, out string resumenLibroTerminado);

            Informes.MostrarDistribuidos(escanerMapa, out int extensionMapaDistr, out int cantidadMapaDistr, out string resumenMapaDistr);
            Informes.MostrarEnEscaner(escanerMapa, out int extensionMapaEnEsc, out int cantidadMapaEnEsc, out string resumenMapaEnEsc); ;
            Informes.MostrarEnRevision(escanerMapa, out int extensionMapaEnRev, out int cantidadMapaEnRev, out string resumenMapaEnRev);
            Informes.MostrarTerminados(escanerMapa, out int extensionMapaTerminado, out int cantidadMapaTerminado, out string resumenMapaTerminado);

            int puntos = 0;

            if (extensionLibroDistr == 0) { puntos += 3; }
            if (cantidadLibroDistr == 0) { puntos += 1; }
            if (resumenLibroDistr == "") { puntos += 1; }

            if (extensionLibroEnEsc == 0) { puntos += 3; }
            if (cantidadLibroEnEsc == 0) { puntos += 1; }
            if (resumenLibroEnEsc == "") { puntos += 1; }

            if (extensionLibroEnRev == libro1.NumPaginas + libro2.NumPaginas) { puntos += 3; }
            if (cantidadLibroEnRev == 2) { puntos += 1; }
            if (resumenLibroEnRev == libro1.ToString() + libro2.ToString()) { puntos += 1; }

            if (extensionLibroTerminado == 0) { puntos += 3; }
            if (cantidadLibroTerminado == 0) { puntos += 1; }
            if (resumenLibroTerminado == "") { puntos += 1; }

            if (extensionMapaDistr == mapa1.Superficie) { puntos += 3; }
            if (cantidadMapaDistr == 1) { puntos += 1; }
            if (resumenMapaDistr == mapa1.ToString()) { puntos += 1; }

            if (extensionMapaEnEsc == mapa2.Superficie) { puntos += 3; }
            if (cantidadMapaEnEsc == 1) { puntos += 1; }
            if (resumenMapaEnEsc == mapa2.ToString()) { puntos += 1; }

            if (extensionMapaEnRev == 0) { puntos += 3; }
            if (cantidadMapaEnRev == 0) { puntos += 1; }
            if (resumenMapaEnRev == "") { puntos += 1; }

            if (extensionMapaTerminado == mapa3.Superficie + mapa4.Superficie) { puntos += 3; }
            if (cantidadMapaTerminado == 2) { puntos += 1; }
            if (resumenMapaTerminado == mapa3.ToString() + mapa4.ToString()) { puntos += 1; }

            Console.WriteLine($"Puntos: {puntos} / 40");

            Console.WriteLine("LIBROS DISTRIBUIDOS");
            Console.WriteLine($"Cantidad de libros ya distribuidos: {cantidadLibroDistr}.");
            Console.WriteLine($"Cantidad de páginas ya distribuidas: {extensionLibroDistr}.");
            Console.WriteLine(resumenLibroDistr);
            Console.WriteLine("---------------------");

            Console.WriteLine("LIBROS EN ESCANER");
            Console.WriteLine($"Cantidad de libros en el escáner: {cantidadLibroEnEsc}.");
            Console.WriteLine($"Cantidad de páginas en el escáner: {extensionLibroEnEsc}.");
            Console.WriteLine(resumenLibroEnEsc);
            Console.WriteLine("---------------------");

            Console.WriteLine("LIBROS EN REVISIÓN");
            Console.WriteLine($"Cantidad de libros en el escáner: {cantidadLibroEnRev}.");
            Console.WriteLine($"Cantidad de páginas en el escáner: {extensionLibroEnRev}.");
            Console.WriteLine(resumenLibroEnRev);
            Console.WriteLine("---------------------");

            Console.WriteLine("LIBROS TERMINADOS");
            Console.WriteLine($"Cantidad de mapas en el escáner: {cantidadLibroTerminado}.");
            Console.WriteLine($"Cantidad de cm2 en el escáner: {extensionLibroTerminado}.");
            Console.WriteLine(resumenLibroTerminado);
            Console.WriteLine("---------------------");

            Console.WriteLine("MAPAS DISTRIBUIDOS");
            Console.WriteLine($"Cantidad de mapas ya distribuidos: {cantidadMapaDistr}.");
            Console.WriteLine($"Cantidad de cm2 ya distribuidos: {extensionMapaDistr}.");
            Console.WriteLine(resumenMapaDistr);
            Console.WriteLine("---------------------");

            Console.WriteLine("MAPAS EN ESCANER");
            Console.WriteLine($"Cantidad de mapas en el escáner: {cantidadMapaEnEsc}.");
            Console.WriteLine($"Cantidad de cm2 en el escáner: {extensionMapaEnEsc}.");
            Console.WriteLine(resumenMapaEnEsc);
            Console.WriteLine("---------------------");

            Console.WriteLine("MAPAS EN REVISIÓN");
            Console.WriteLine($"Cantidad de mapas en el escáner: {cantidadMapaEnRev}.");
            Console.WriteLine($"Cantidad de cm2 en el escáner: {extensionMapaEnRev}.");
            Console.WriteLine(resumenMapaEnRev);
            Console.WriteLine("---------------------");

            Console.WriteLine("MAPAS TERMINADOS");
            Console.WriteLine($"Cantidad de mapas en el escáner: {cantidadMapaTerminado}.");
            Console.WriteLine($"Cantidad de cm2 en el escáner: {extensionMapaTerminado}.");
            Console.WriteLine(resumenMapaTerminado);
            Console.WriteLine("---------------------");

            Console.ReadKey();
        }
    }
}
