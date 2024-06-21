using System.Text;

namespace Entidades
{
    public class Mapa : Documento
    {
        private int alto;
        private int ancho;

        public Mapa(string titulo, string autor, int anio, string numNormalizado, string barcode, int alto, int ancho)
            : base(titulo, autor, anio, numNormalizado, barcode)
        {
            this.alto = alto;
            this.ancho = ancho;
        }

        public int Alto { get => alto; }
        public int Ancho { get => ancho; }
        public int Superficie { get { return alto * ancho; } }


        public static bool operator !=(Mapa m1, Mapa m2)
        {
            return !(m1 == m2);
        }

        public static bool operator ==(Mapa m1, Mapa m2)
        {
            return (m1.Barcode == m2.Barcode ||
                    (m1.Titulo == m2.Titulo && m1.Autor == m2.Autor &&  m1.Anio == m2.Anio && m1.Superficie == m2.Superficie));
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.ToString()); // Llama al método ToString de Documento
            sb.AppendLine($"Alto: {alto}");
            sb.AppendLine($"Ancho: {ancho}");
            sb.AppendLine($"Superficie: {Superficie}");
            return sb.ToString();
        }
    }
}