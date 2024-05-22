using System.Text;

namespace Entidades
{
    public abstract class Documento
    {
        private int anio;
        private string autor;
        private string barcode;
        private Paso estado;
        protected string numNormalizado;
        private string titulo;

        public Documento(string titulo, string autor, int anio , string barcode)
        {
            this.titulo = titulo;
            this.autor = autor;
            this.anio = anio;
            this.numNormalizado = " ";
            this.barcode = barcode;
            this.estado = Paso.Inicio;
        }

        public Documento(string titulo, string autor, int anio, string numNormalizado, string barcode)
        {
            this.titulo = titulo;
            this.autor = autor;
            this.anio = anio;
            this.numNormalizado = numNormalizado;
            this.barcode = barcode;
            this.estado = Paso.Inicio;
        }


        public int Anio { get => anio; }
        public string Autor { get => autor; }
        public string Barcode { get => barcode; }
        public Paso Estado { get => estado; }
        protected string NumNormalizado { get => numNormalizado; }
        public string Titulo { get => titulo; }

        public bool AvanzarEstado()
        {
            if (estado == Paso.Terminado)
            {
                return false;
            }

            estado = estado + 1;
            return true;
        }

        public override string ToString() //override para sobreescribir el método
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Título: {titulo}");
            sb.AppendLine($"Autor: {autor}");
            sb.AppendLine($"Año: {anio}");
            return sb.ToString();
        }
    }

    public enum Paso
    {
        Inicio, Distribuido, EnEscaner, EnRevision, Terminado
    }
}