using System;
using System.Data;
using System.Data.SqlClient;

namespace DataAccessLayer
{
    public class DataAccess
    {
        public SqlConnection conexion;
        public string CadenaDeConexion = @"Data Source=(LocalDB)\MSSQLLocalDB;
                                            AttachDbFilename=
                                            ""F:\Programación 2020\GitHub\CristelaDesktop\App\CristelaDesktop\App\CristellaDesktop\SampleDatabaseWalkthrough\SampleDatabaseWalkthrough.mdf"";
                                            Integrated Security=True"
        ;

        public DataAccess()
        {
            conexion = new SqlConnection(CadenaDeConexion);
        }

        #region Apertura y cierre de conexioón
        public void Abrirconexion()
        {
            try
            {
                if (conexion.State == ConnectionState.Broken || conexion.State ==
                ConnectionState.Closed)
                    conexion.Open();
            }
            catch (Exception e)
            {
                throw new Exception("Error al tratar de conectar con la base de datos", e);
            }
        }
        public void Cerrarconexion()
        {
            try
            {
                if (conexion.State == ConnectionState.Open)
                    conexion.Close();
            }
            catch (Exception e)
            {
                throw new Exception("Error al tratar de cerrar la conexión con la base de datos", e);
            }
        }

        #endregion
    }
}