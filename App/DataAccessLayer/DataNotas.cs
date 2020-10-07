using Entities;
using System;
using System.Data;
using System.Data.SqlClient;

namespace DataAccessLayer
{
    public class DataNotas : DataAccess
    {
        public int SaveNota(Notas notas)
        {
            int resultado = -1;
            string query = "Insert Into Notas (TituloNota, MsjNota, FechaNota) values (@TituloNota, @MsjNota, @FechaNota)";

            SqlParameter tituloNota = new SqlParameter("@TituloNota", notas.TituloNota);
            SqlParameter msjNota = new SqlParameter("@MsjNota", notas.MsjNota);
            SqlParameter fechaNota = new SqlParameter("@FechaNota", notas.FechaNota);

            SqlCommand cmd = new SqlCommand(query, conexion);
            cmd.Parameters.Add(tituloNota);
            cmd.Parameters.Add(msjNota);
            cmd.Parameters.Add(fechaNota);

            try
            {
                Abrirconexion();
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {

                throw new Exception("Error al guardar nueva nota", e);
            }
            finally
            {
                Cerrarconexion();
                cmd.Dispose();
            }

            return resultado;
        }

        public DataSet GetNotas(string accion)
        {
            string query;

            if (string.IsNullOrEmpty(accion))
            {
                query = "Select * from Notas order by FechaNota desc";
                ;
            }
            else
            {
                query = @"select Id_Nota,
                                 TituloNota,
                                 MsjNota,
                        from Notas
                        where TituloNota LIKE @query 
                        or MsjNota LIKE @query
                        order by FechaNota desc"
                ;
            }

            SqlCommand cmd = new SqlCommand(query, conexion)
            {
                CommandType = CommandType.Text
            };
            cmd.Parameters.Add(new SqlParameter()
            {
                ParameterName = "@query",
                SqlDbType = SqlDbType.NVarChar,
                Value = string.Format("%{0}%", accion)
            });

            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter();

            try
            {
                Abrirconexion();
                cmd.ExecuteNonQuery();
                da.SelectCommand = cmd;
                da.Fill(ds);
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                Cerrarconexion();
            }

            return ds;
        }
    }
}
