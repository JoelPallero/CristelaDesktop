﻿using Entities;
using System;
using System.Data.SqlClient;

namespace DataAccessLayer
{
    public class DataSaldosEstablecidos : DataAccess
    {
        #region Alta y consulta de Saldos Establecidos

        public int EstablecerSaldos(SaldosEstablecidos saldosEstablecidos)
        {
            int resultado = -1;

            string orden = @"Insert into SaldosEstablecidos (SaldoEmergencia,
                                                                 SaldoCritico,
                                                                 GastoPermitido,
                                                                 Fecha) 
                                                         values (@SaldoEmergencia, 
                                                                 @SaldoCritico, 
                                                                 @GastoPermitido, 
                                                                 @Fecha)"
            ;

            SqlParameter saldoEmergencia = new SqlParameter("@SaldoEmergencia", saldosEstablecidos.SaldoEmergencia);
            SqlParameter saldoCritico = new SqlParameter("@SaldoCritico", saldosEstablecidos.SaldoCritico);
            SqlParameter gastoPermitido = new SqlParameter("@GastoPermitido", saldosEstablecidos.GastoPermitido);
            SqlParameter fecha = new SqlParameter("@Fecha", saldosEstablecidos.Fecha);

            SqlCommand cmd = new SqlCommand(orden, conexion);

            cmd.Parameters.Add(saldoEmergencia);
            cmd.Parameters.Add(saldoCritico);
            cmd.Parameters.Add(gastoPermitido);
            cmd.Parameters.Add(fecha);

            try
            {
                Abrirconexion();
                resultado = cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                throw new Exception("No se puede establecer los saldos", e);
            }
            finally
            {
                Cerrarconexion();
                cmd.Dispose();
            }

            return resultado;
        }


        public SaldosEstablecidos ConsultarSaldosEstablecidos()
        {
            SaldosEstablecidos saldosEstablecidos = new SaldosEstablecidos();

            string orden = @"Select *
                            From SaldosEstablecidos
                            where Id_SE = (select max (Id_SE) from SaldosEstablecidos)"
            ;

            SqlCommand cmd = new SqlCommand(orden, conexion);

            try
            {
                Abrirconexion();                
                SqlDataReader readerSaldo = cmd.ExecuteReader();

                if (readerSaldo.Read())
                {
                    saldosEstablecidos.Id_SE = int.Parse(readerSaldo["Id_SE"].ToString());
                    saldosEstablecidos.SaldoEmergencia = decimal.Parse(readerSaldo["SaldoEmergencia"].ToString());
                    saldosEstablecidos.SaldoCritico = decimal.Parse(readerSaldo["SaldoCritico"].ToString());
                    saldosEstablecidos.GastoPermitido = decimal.Parse(readerSaldo["GastoPermitido"].ToString());
                }
                else
                {
                    saldosEstablecidos.Id_SE = 1003;
                    saldosEstablecidos.SaldoEmergencia = 0;
                    saldosEstablecidos.SaldoCritico = 0;
                    saldosEstablecidos.GastoPermitido = 0;
                }
                readerSaldo.Close();
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                throw new Exception("Error al traer Saldo", e);
            }
            finally
            {
                Cerrarconexion();
                cmd.Dispose();
            }
            return saldosEstablecidos;
        }

        #endregion
    }
}