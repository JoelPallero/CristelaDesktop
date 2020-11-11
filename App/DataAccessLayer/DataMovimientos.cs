using Entities;
using System;
using System.Data;
using System.Data.SqlClient;

namespace DataAccessLayer
{
    public class DataMovimientos : DataAccess
    {
        #region ABM de movimientos.
        public int SaveMovement(Movimientos movimientos)
        {
            SaldosEstablecidos saldosEstablecidos = new SaldosEstablecidos();
            int resultado = -1;
            string orden = @"Insert into Movimientos (Importe, 
                                                     TipoMovimiento,   
                                                     FechaRealizada, 
                                                     NumCuotaPaga, 
                                                     CantCuotas, 
                                                     Observaciones,
                                                     PagoFinalizado,
                                                     SeId) 
                                                     values (@Importe, 
                                                             @TipoMovimiento, 
                                                             @FechaRealizada,
                                                             @NumCuotaPaga, 
                                                             @CantCuotas,
                                                             @Observaciones,
                                                             @PagoFinalizado,
                                                             @SeId)"
            ;

            SqlParameter importe = new SqlParameter("@Importe", movimientos.Importe);
            SqlParameter tipoMovimiento = new SqlParameter("@TipoMovimiento", movimientos.TipoMovimiento);
            SqlParameter fechaRealizada = new SqlParameter("@FechaRealizada", movimientos.FechaRealizada);
            SqlParameter numCuotaPaga = new SqlParameter("@NumCuotaPaga", movimientos.NumCuotaPaga);
            SqlParameter cantCuotas = new SqlParameter("@CantCuotas", movimientos.CantCuotas);
            SqlParameter observaciones = new SqlParameter("@Observaciones", movimientos.Observaciones);
            SqlParameter pagoFinalizado = new SqlParameter("@PagoFinalizado", movimientos.PagoFinalizado);
            SqlParameter seId = new SqlParameter("@SeId", movimientos.SeId);

            SqlCommand cmd = new SqlCommand(orden, conexion);
            cmd.Parameters.Add(importe);
            cmd.Parameters.Add(tipoMovimiento);
            cmd.Parameters.Add(fechaRealizada);
            cmd.Parameters.Add(numCuotaPaga);
            cmd.Parameters.Add(cantCuotas);
            cmd.Parameters.Add(observaciones);
            cmd.Parameters.Add(pagoFinalizado);
            cmd.Parameters.Add(seId);

            try
            {
                Abrirconexion();
                resultado = cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                throw new Exception("Error al tratar de guardar Movimientos", e);
            }
            finally
            {
                Cerrarconexion();
                cmd.Dispose();
            }
            return resultado;
        }

        public int DeleteMovement(Movimientos movimientos)
        {
            int resultado = -1;

            string orden = "Delete Movimientos where Id_Mov = @Id_Mov";
            

            SqlParameter id_Mov = new SqlParameter("@Id_Mov", movimientos.Id_Mov);

            SqlCommand cmd = new SqlCommand(orden, conexion);
            cmd.Parameters.Add(id_Mov);

            try
            {
                Abrirconexion();
                resultado = cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                throw new Exception("Error al tratar de Eliminar Movimientos", e);
            }
            finally
            {
                Cerrarconexion();
                cmd.Dispose();
            }
            return resultado;
        }

        public int UpdateMovement(Movimientos movimientos)
        {
            int resultado = -1;
            string orden = @"update Movimientos set Importe = @Importe, 
                                                     TipoMovimiento = @TipoMovimiento,   
                                                     FechaRealizada = @FechaRealizada,
                                                     NumCuotaPaga = @NumCuotaPaga,
                                                     CantCuotas = @CantCuotas, 
                                                     Observaciones = @Observaciones,
                                                     PagoFinalizado = @pagoFinalizado
                                               Where Id_Mov = @Id_Mov"
            ;

            SqlParameter id_Mov = new SqlParameter("@Id_Mov", movimientos.Id_Mov);
            SqlParameter importe = new SqlParameter("@Importe", movimientos.Importe);
            SqlParameter tipoMovimiento = new SqlParameter("@TipoMovimiento", movimientos.TipoMovimiento);
            SqlParameter fechaRealizada = new SqlParameter("@FechaRealizada", movimientos.FechaRealizada);
            SqlParameter numCuotaPaga = new SqlParameter("@NumCuotaPaga", movimientos.NumCuotaPaga);
            SqlParameter cantCuotas = new SqlParameter("@CantCuotas", movimientos.CantCuotas);
            SqlParameter observaciones = new SqlParameter("@Observaciones", movimientos.Observaciones);
            SqlParameter pagoFinalizado = new SqlParameter("@PagoFinalizado", movimientos.PagoFinalizado);

            SqlCommand cmd = new SqlCommand(orden, conexion);

            cmd.Parameters.Add(id_Mov);
            cmd.Parameters.Add(importe);
            cmd.Parameters.Add(tipoMovimiento);
            cmd.Parameters.Add(fechaRealizada);
            cmd.Parameters.Add(numCuotaPaga);
            cmd.Parameters.Add(cantCuotas);
            cmd.Parameters.Add(observaciones);
            cmd.Parameters.Add(pagoFinalizado);

            try
            {
                Abrirconexion();
                resultado = cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                throw new Exception("Error al tratar de Modificar Movimientos", e);
            }
            finally
            {
                Cerrarconexion();
                cmd.Dispose();
            }
            return resultado;
        }


        #endregion

        #region Mostrar Listado de Movimientos

        public DataSet MovementsList(string accion)
        {
            string orden;

            if (string.IsNullOrEmpty(accion))
            {
                orden = @"select *
                        from Movimientos
                        WHERE MONTH(FechaRealizada) = MONTH(GETDATE())
                        Order by FechaRealizada desc"
                ;
            }
            else
            {
                if (accion == "Registro")
                {
                    orden = @"select *
                        from Movimientos
                        WHERE FechaRealizada BETWEEN GETDATE()-1 AND GETDATE()
                        Order by FechaRealizada desc"
                    ;
                }
                else
                {
                    orden = @"Select *
                        from Movimientos
                        where Id_Mov LIKE @query 
                        or Importe LIKE @query 
                        or TipoMovimiento LIKE @query
                        or NumCuotaPaga LIKE @query
                        or CantCuotas LIKE @query
                        or Observaciones LIKE @query
                        or PagoFinalizado LIKE @query
                        Order by Id_Mov Desc"
                    ;
                }
            }

            SqlCommand cmd = new SqlCommand(orden, conexion)
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
            catch (Exception e)
            {
                throw new Exception("Error al listar Movimientos", e);
            }
            finally
            {
                Cerrarconexion();
                cmd.Dispose();
            }
            return ds;
        }


        #endregion

        #region Traer el último movimiento

        public Movimientos ConsultarDatosDeMovimiento(Movimientos movimientos)
        {
            string orden = @"select *
                        from Movimientos
                        where Id_Mov = '" + movimientos.Id_Mov + "';"
            ;

            SqlCommand cmd = new SqlCommand(orden, conexion);

            try
            {
                Abrirconexion();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    movimientos.Id_Mov = int.Parse(reader["Id_Mov"].ToString());
                    movimientos.NumCuotaPaga = int.Parse(reader["NumCuotaPaga"].ToString());
                }
                reader.Close();
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                throw new Exception("Error al listar Movimientos", e);
            }
            finally
            {
                Cerrarconexion();
                cmd.Dispose();
            }
            return movimientos;
        }

        public Movimientos ConsultarSaldo(Movimientos movimientos)
        {

            string query = @"sp_SaldoActual";
            SqlCommand cmd = new SqlCommand(query, conexion);

            try
            {
                Abrirconexion();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    movimientos.SaldoActual = decimal.Parse(reader["SumaSaldo"].ToString());
                    movimientos.GastoPermitido = decimal.Parse(reader["SumaPermitido"].ToString());
                }
                reader.Close();
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                throw new Exception("No se pudo realizar el cálculo requerido", e);
            }
            finally
            {
                Cerrarconexion();
                cmd.Dispose();
            }

            return movimientos;
        }


        #endregion

        #region Movimientos Agendados
        public DataSet MovAgendadosList()
        {
            string orden = @"exec sp_SiguienteCuota";

            SqlCommand cmd = new SqlCommand(orden, conexion);
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter();

            try
            {
                Abrirconexion();
                cmd.ExecuteNonQuery();
                da.SelectCommand = cmd;
                da.Fill(ds);
            }
            catch (Exception e)
            {
                throw new Exception("Error al listar Movimientos", e);
            }
            finally
            {
                Cerrarconexion();
                cmd.Dispose();
            }
            return ds;
        }

        public int RegistrarPagoAgendado(Movimientos movimientos)
        {
            int resultado = -1;
            string orden = @"Insert into Movimientos (Importe, 
                                                     TipoMovimiento,   
                                                     FechaRealizada, 
                                                     NumCuotaPaga, 
                                                     CantCuotas, 
                                                     Observaciones,
                                                     CodMovimiento,
                                                     PagoFinalizado)       
                            values (@Importe, 
                                    @TipoMovimiento,   
                                    @FechaRealizada, 
                                    @NumCuotaPaga, 
                                    @CantCuotas, 
                                    @Observaciones,
                                    @CodMovimiento,
                                    @PagoFinalizado)"
            ;

            SqlParameter importe = new SqlParameter("@Importe", movimientos.Importe);
            SqlParameter tipoMovimiento = new SqlParameter("@TipoMovimiento", movimientos.TipoMovimiento);
            SqlParameter fechaRealizada = new SqlParameter("@FechaRealizada", movimientos.FechaRealizada);
            SqlParameter numCuotaPaga = new SqlParameter("@NumCuotaPaga", movimientos.NumCuotaPaga);
            SqlParameter cantCuotas = new SqlParameter("@CantCuotas", movimientos.CantCuotas);
            SqlParameter observaciones = new SqlParameter("@Observaciones", movimientos.Observaciones);
            SqlParameter codMovimiento = new SqlParameter("@CodMovimiento", movimientos.CodMovimiento);
            SqlParameter pagoFinalizado = new SqlParameter("@PagoFinalizado", movimientos.PagoFinalizado);

            SqlCommand cmd = new SqlCommand(orden, conexion);
            cmd.Parameters.Add(importe);
            cmd.Parameters.Add(tipoMovimiento);
            cmd.Parameters.Add(fechaRealizada);
            cmd.Parameters.Add(numCuotaPaga);
            cmd.Parameters.Add(cantCuotas);
            cmd.Parameters.Add(observaciones);
            cmd.Parameters.Add(codMovimiento);
            cmd.Parameters.Add(pagoFinalizado);

            try
            {
                Abrirconexion();
                resultado = cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                throw new Exception("Error al tratar de guardar Movimientos", e);
            }
            finally
            {
                Cerrarconexion();
                cmd.Dispose();
            }
            return resultado;
        }

        public int FinalizarCuotasDePagos(Movimientos movimientos)
        {
            int resultado = -1;

            string query = @"update set Movimientos PagoFinalizado = @PagoFinalizado where Id_Mov = @Id_Mov";

            SqlParameter pagoFinalizado = new SqlParameter("@PagoFinalizado", movimientos.PagoFinalizado);
            SqlCommand cmd = new SqlCommand(query, conexion);
            cmd.Parameters.Add(pagoFinalizado);

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

        #endregion

        #region Reset de los datos.

        public Movimientos DeletePeriodo(DateTime FechaDesde, DateTime FechaHasta, Movimientos movimientos)
        {
            string query = @"Delete Movimientos 
                            Where FechaRealizada >= '" + FechaDesde + "' and FechaRealizada <= '" + FechaHasta + "';";

            SqlCommand cmd = new SqlCommand(query, conexion);

            try
            {
                Abrirconexion();
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

            return movimientos;
        }

        public Movimientos DeleteAll(string accion, Movimientos movimientos)
        {
            string query = string.Empty;

            switch (accion)
            {
                case "Todo":
                    query = @"truncate table Movimientos;
                              delete SaldosEstablecidos where Id_SE != 1000;
                              truncate table Notas"
                    ;
                    break;
                case "Movimientos":
                    query = "truncate table Movimientos";
                    break;
                case "Saldos":
                    query = "delete SaldosEstablecidos where Id_SE != 1000";
                    break;
                case "Notas":
                    query = "truncate table Notas";
                    break;
            }

            SqlCommand cmd = new SqlCommand(query, conexion);
            try
            {
                Abrirconexion();
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

            return movimientos;
        }
        #endregion
    }
}