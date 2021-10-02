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
            string query = @"Insert into Notificaciones (HoraAlarma)
                            values (@HoraAlarma)"
            ;
            SqlParameter horaAlarma = new SqlParameter("@HoraAlarma", notificacionesDiarias.HoraAlarma);
            SqlCommand cmd = new SqlCommand(query, conexion);
            cmd.Parameters.Add(horaAlarma);

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

        public NotificacionesDiarias CuantasAlarmas(NotificacionesDiarias notificacionesDiarias)
        {
            string query = @"select * from Notificaciones";

            SqlCommand cmd = new SqlCommand(query, conexion);

            try
            {
                Abrirconexion();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    _ = int.Parse(reader["CuantasAlarmas"].ToString());
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