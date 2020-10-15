using System;

namespace Entities
{
    public class Notas
    {
        private string tituloNota;
        private string msjNota;
        private DateTime fechaNota;


        public string TituloNota { get => tituloNota; set => tituloNota = value; }
        public string MsjNota { get => msjNota; set => msjNota = value; }
        public DateTime FechaNota { get => fechaNota; set => fechaNota = value; }
    }
}
