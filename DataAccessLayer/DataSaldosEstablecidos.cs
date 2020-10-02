using Entities;
using System;
using System.Data.SqlClient;

namespace DataAccessLayer
{
    public class DataSaldosEstablecidos : DataAccess
    {
        public int EstablecerSaldos(SaldosEstablecidos saldosEstablecidos)
        {
            int resultado = -1;

            try
            {
                Abrirconexion();
                string orden = @"Insert into SaldosEstablecidos (SaldoEmergencia,
                                                                 SaldoCritico,
                                                                 GastoPermitido) 
                                values (@SaldoEmergencia, @SaldoCritico, @GastoPermitido)"
                ;

                SqlParameter saldoEmergencia = new SqlParameter("@SaldoEmergencia", saldosEstablecidos.SaldoEmergencia);
                SqlParameter saldoCritico = new SqlParameter("@SaldoCritico", saldosEstablecidos.SaldoCritico);
                SqlParameter gastoPermitido = new SqlParameter("@GastoPermitido", saldosEstablecidos.GastoPermitido);

                SqlCommand cmd = new SqlCommand(orden, conexion);

                cmd.Parameters.Add(saldoEmergencia);
                cmd.Parameters.Add(saldoCritico);
                cmd.Parameters.Add(gastoPermitido);

                resultado = cmd.ExecuteNonQuery();

            }
            catch (Exception e)
            {

                throw new Exception("No se pude guardar la nota", e);
            }
            finally
            {
                Cerrarconexion();
            }

            return resultado;
        }


        public SaldosEstablecidos ConsultarSaldosEstablecidos()
        {
            SaldosEstablecidos saldosEstablecidos = new SaldosEstablecidos();

            try
            {
                Abrirconexion();
                string orden = @"Select *
                            From SaldosEstablecidos
                            where Id_SE = (select max (Id_SE) from SaldosEstablecidos)"
                ;

                SqlCommand cmd = new SqlCommand(orden, conexion);
                SqlDataReader readerSaldo = cmd.ExecuteReader();

                if (readerSaldo.Read())
                {
                    saldosEstablecidos.SaldoEmergencia = decimal.Parse(readerSaldo["SaldoEmergencia"].ToString());
                    saldosEstablecidos.SaldoCritico = decimal.Parse(readerSaldo["SaldoCritico"].ToString());
                    saldosEstablecidos.GastoPermitido = decimal.Parse(readerSaldo["GastoPermitido"].ToString());
                }
                else
                {
                    saldosEstablecidos.SaldoEmergencia = 0;
                    saldosEstablecidos.SaldoCritico = 0;
                    saldosEstablecidos.GastoPermitido = 0;
                }
                readerSaldo.Close();
                cmd.ExecuteNonQuery();
                cmd.Dispose();
            }
            catch (Exception e)
            {
                throw new Exception("Error al traer Saldo", e);
            }
            finally
            {
                Cerrarconexion();
            }
            return saldosEstablecidos;
        }
    }
}