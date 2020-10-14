using Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class DataNotificacionesDiarias : DataAccess
    {

        public int InsertHoraAlarmas(NotificacionesDiarias notificacionesDiarias)
        {
            int resultado = -1;
            string query = @"Insert into NotificacionesDiarias (HoraAlarma1,
                                                                MinutoAlarma1)
                            values (@HoraAlarma1, 
                                    @MinutoAlarma1)"
            ;

            SqlParameter horaAlarma1 = new SqlParameter("@HoraAlarma1", notificacionesDiarias.HoraAlarma1);
            SqlParameter minutoAlarma1 = new SqlParameter("@MinutoAlarma1", notificacionesDiarias.MinutoAlarma1);
            //SqlParameter horaAlarma2 = new SqlParameter("@HolaAlarma2", notificacionesDiarias.HolaAlarma2);
            //SqlParameter minutoAlarma2 = new SqlParameter("@MinutoAlarma2", notificacionesDiarias.MinutoAlarma2);
            //SqlParameter horaAlarma3 = new SqlParameter("@HolaAlarma3", notificacionesDiarias.HolaAlarma3);
            //SqlParameter minutoAlarma3 = new SqlParameter("@MinutoAlarma3", notificacionesDiarias.MinutoAlarma3);

            SqlCommand cmd = new SqlCommand(query, conexion);
            cmd.Parameters.Add(horaAlarma1);
            cmd.Parameters.Add(minutoAlarma1);
            //cmd.Parameters.Add(horaAlarma2);
            //cmd.Parameters.Add(minutoAlarma2);
            //cmd.Parameters.Add(horaAlarma3);
            //cmd.Parameters.Add(minutoAlarma3);

            try
            {
                Abrirconexion();
                resultado = cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                Cerrarconexion();
                cmd.Dispose();
            }
            return resultado;
        }

        //public NotificacionesDiarias GetHoraAlarmas(NotificacionesDiarias notificacionesDiarias)
        //{
            
        //}
    }
}