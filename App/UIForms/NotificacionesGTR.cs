using BusinessLogicLayer;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;

namespace Cristela
{
    public class NotificacionesGTR
    {
        private NotificacionesDiarias _notificacionesDiarias = new NotificacionesDiarias();
        private NegnotificacionesDiarias _negnotificacionesDiarias = new NegnotificacionesDiarias();

        public string horas;
        public string minutos;

        public void ActivarTmrAlarma()
        {
            FormInicio _formInicio = new FormInicio();
            _formInicio.TmrAlarma.Enabled = true;
            _formInicio.TmrAlarma.Start();
        }

        public void ConsultaDeAlarma()
        {
            _notificacionesDiarias = _negnotificacionesDiarias.GetAlarma(_notificacionesDiarias);
            horas = _notificacionesDiarias.HoraAlarma1;
            minutos = _notificacionesDiarias.MinutoAlarma1;
        }
    }
}
