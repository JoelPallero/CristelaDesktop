namespace Entities
{
    public class Notas
    {
        private readonly int id;
        private string tituloNota;
        private string msjNota;

        public int Id { get => Id; set => Id = value; }
        public string TituloNota { get => TituloNota; set => TituloNota = value; }
        public string MsjNota { get => MsjNota; set => MsjNota = value; }
    }
}
