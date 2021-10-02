using System;

namespace Entities
{
    public class NotificacionesDiarias
    {
        private int id;
        private DateTime horaAlarma;

        private DateTime Alarma1;
        private DateTime Alarma2;
        private DateTime Alarma3;

        public int Id { get => id; set => id = value; }
        public DateTime HoraAlarma { get => horaAlarma; set => horaAlarma = value; }
        public DateTime Alarma11 { get => Alarma1; set => Alarma1 = value; }
        public DateTime Alarma21 { get => Alarma2; set => Alarma2 = value; }
        public DateTime Alarma31 { get => Alarma3; set => Alarma3 = value; }
    }
}
