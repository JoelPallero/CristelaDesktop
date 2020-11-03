using DataAccessLayer;
using Entities;

namespace BusinessLogicLayer
{
    public class NegnotificacionesDiarias
    {
        private readonly DataNotificacionesDiarias dataNotificacionesDiarias;
        public NegnotificacionesDiarias()
        {
            dataNotificacionesDiarias = new DataNotificacionesDiarias();
        }

        public int InsertHoraAlarmas(NotificacionesDiarias notificacionesDiarias)
        {
            return dataNotificacionesDiarias.InsertHoraAlarmas(notificacionesDiarias);
        }

        public NotificacionesDiarias CuantasAlarmas(NotificacionesDiarias notificacionesDiarias)
        {
            return dataNotificacionesDiarias.CuantasAlarmas(notificacionesDiarias);
        }
    }
}
