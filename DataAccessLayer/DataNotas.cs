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
            string query = "Insert Into Notas (TituloNota, MsjNota) values (@TituloNota, @MsjNota)";

            SqlParameter tituloNota = new SqlParameter("@TituloNota", notas.TituloNota);
            SqlParameter msjNota = new SqlParameter("@MsjNota", notas.MsjNota);

            SqlCommand cmd = new SqlCommand(query, conexion);
            cmd.Parameters.Add(tituloNota);
            cmd.Parameters.Add(msjNota);

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
                query = "Select * from Notas where Id = (select max (Id) from Notas)";
                ;
            }
            else
            {
                query = @"select Id,
                                 TituloNota,
                                 MsjNota,
                        from Notas
                        where TituloNota LIKE @query 
                        or MsjNota LIKE @query
                        Order by Id Desc"
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
