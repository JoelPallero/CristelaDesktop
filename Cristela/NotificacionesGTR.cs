using BusinessLogicLayer;
using Entities;
using System;

namespace Cristela
{
    public class NotificacionesGTR
    {
        private NotificacionesDiarias _notificacionesDiarias = new NotificacionesDiarias();
        private NegnotificacionesDiarias _negnotificacionesDiarias = new NegnotificacionesDiarias();

        private int CantAlarmas = 0;
        public DateTime Alarma1;
        public DateTime Alarma2;
        public DateTime Alarma3;

        public void ActivarTmrAlarma()
        {
            FormInicio _formInicio = new FormInicio();
            _formInicio.TmrAlarma.Enabled = true;
            _formInicio.TmrAlarma.Start();
        }

        public void ConsultaDeAlarma()
        {
            _notificacionesDiarias = _negnotificacionesDiarias.CuantasAlarmas(_notificacionesDiarias);
            
        }


    }
}
