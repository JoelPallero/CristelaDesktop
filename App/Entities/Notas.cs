namespace Entities
{
    public class Notas
    {
        private readonly int id;
        private string tituloNota;
        private string msjNota;

        public int Id => id;

        public string TituloNota { get => tituloNota; set => tituloNota = value; }
        public string MsjNota { get => msjNota; set => msjNota = value; }
    }
}
