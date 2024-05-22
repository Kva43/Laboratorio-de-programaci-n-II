using System.Text;

namespace Entidades
{
    //los miembros abstractos de Documento, se tiene que declarar acá también

    public class Libro : Documento 
    {
        private int numPaginas;

        public Libro(string titulo, string autor, int anio, string numNormalizado, string barcode, int numPaginas)
            : base(titulo, autor, anio, numNormalizado, barcode)
        {
            this.numPaginas = numPaginas;
        }

        public string ISBN { get => NumNormalizado; } 
        public int NumPaginas { get => numPaginas; }


        public static bool operator !=(Libro l1, Libro l2)
        {
            return !(l1 == l2);
        }

        // son iguales si tienen el mismo barcode, ISBN o autor y título
        public static bool operator ==(Libro l1, Libro l2)
        {
            return (l1.Barcode == l2.Barcode || 
                    l1.ISBN == l2.ISBN ||
                    (l1.Autor == l2.Autor && l1.Titulo == l2.Titulo));
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(base.ToString()); // Llama al método ToString de Documento
            sb.AppendLine($"ISBN: {ISBN}");
            sb.AppendLine($"Cód. de barras: {Barcode}");
            sb.AppendLine($"Número de páginas: {NumPaginas}");
            return sb.ToString();
        }
    }

}
