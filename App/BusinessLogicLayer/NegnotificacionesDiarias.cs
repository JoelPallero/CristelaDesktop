using DataAccessLayer;
using Entities;

namespace BusinessLogicLayer
{
    public class NegnotificacionesDiarias
    {
        DataNotificacionesDiarias dataNotificacionesDiarias;
        public NegnotificacionesDiarias()
        {
            dataNotificacionesDiarias = new DataNotificacionesDiarias();
        }

        public int InsertHoraAlarmas(NotificacionesDiarias notificacionesDiarias)
        {
            return dataNotificacionesDiarias.InsertHoraAlarmas(notificacionesDiarias);
        }

        public NotificacionesDiarias GetAlarma(NotificacionesDiarias notificacionesDiarias)
        {
            return dataNotificacionesDiarias.GetAlarma(notificacionesDiarias);
        }
    }
}
