using System;

namespace Entities
{
    public class Notas
    {
        private int id_Nota;
        private string tituloNota;
        private string msjNota;
        private DateTime fechaNota;

        public int Id_Nota => id_Nota;

        public string TituloNota { get => tituloNota; set => tituloNota = value; }
        public string MsjNota { get => msjNota; set => msjNota = value; }
        public DateTime FechaNota { get => fechaNota; set => fechaNota = value; }
    }
}
