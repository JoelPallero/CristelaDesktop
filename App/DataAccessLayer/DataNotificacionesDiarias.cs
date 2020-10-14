using Entities;
using System;
using System.Data.SqlClient;

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

        public NotificacionesDiarias GetAlarma(NotificacionesDiarias notificacionesDiarias)
        {
            string query = @"select * from NotificacionesDiarias where Id = (select max(Id) from NotificacionesDiarias)";

            SqlCommand cmd = new SqlCommand(query, conexion);

            try
            {
                Abrirconexion();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    notificacionesDiarias.HoraAlarma1 = reader["HoraAlarma1"].ToString();
                    notificacionesDiarias.MinutoAlarma1 = reader["MinutoAlarma1"].ToString();
                }
                reader.Close();
                cmd.ExecuteNonQuery();
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

            return notificacionesDiarias;
        }
    }
}