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
            int resultado = -1;
            string orden = @"Insert into Movimientos (Importe, 
                                                     TipoMovimiento,   
                                                     FechaRealizada, 
                                                     NumCuotaPaga, 
                                                     CantCuotas, 
                                                     Observaciones,
                                                     PagoFinalizado)       
                            values (@Importe, 
                                    @TipoMovimiento,   
                                    @FechaRealizada, 
                                    @NumCuotaPaga, 
                                    @CantCuotas, 
                                    @Observaciones,
                                    @PagoFinalizado)"
            ;

            SqlParameter importe = new SqlParameter("@Importe", movimientos.Importe);
            SqlParameter tipoMovimiento = new SqlParameter("@TipoMovimiento", movimientos.TipoMovimiento);
            SqlParameter fechaRealizada = new SqlParameter("@FechaRealizada", movimientos.FechaRealizada);
            SqlParameter numCuotaPaga = new SqlParameter("@NumCuotaPaga", movimientos.NumCuotaPaga);
            SqlParameter cantCuotas = new SqlParameter("@CantCuotas", movimientos.CantCuotas);
            SqlParameter observaciones = new SqlParameter("@Observaciones", movimientos.Observaciones);
            SqlParameter pagoFinalizado = new SqlParameter("@PagoFinalizado", movimientos.PagoFinalizado);

            SqlCommand cmd = new SqlCommand(orden, conexion);
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
            ;

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
                                                     PagoFinalizado = @PagoFinalizado                             
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
                orden = @"select Id_Mov,
                                 Importe, 
                                 TipoMovimiento,
                                 FechaRealizada, 
                                 NumCuotaPaga, 
                                 CantCuotas, 
                                 Observaciones
                        from Movimientos
                        Order by Id_Mov asc"
                ;
            }
            else
            {
                orden = @"SET LANGUAGE ESPAÑOL;
                          select Id_Mov,
                                 Importe,
                                 TipoMovimiento,
                                 FechaRealizada,
                                 NumCuotaPaga,
                                 CantCuotas,
                                 Observaciones
                        from Movimientos
                        where Importe LIKE @query 
                        or TipoMovimiento LIKE @query
                        or FechaRealizada LIKE @query
                        or NumCuotaPaga LIKE @query
                        or CantCuotas LIKE @query
                        or Observaciones LIKE @query
                        Order by Id_Mov Desc"
                ;
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

        //public DataSet DateTimeFilter(string accion1, string accion2, bool busqueda)
        //{
        //    //string orden;


        //    //if (busqueda)
        //    //{
        //    //    orden = @"SET SET LANGUAGE 'español' go
        //    //              select Id_Mov,
        //    //                     Importe,
        //    //                     TipoMovimiento,
        //    //                     FechaCreacion, 
        //    //                     AgendarPago,
        //    //                     CantCuotas,
        //    //                     Observaciones
        //    //            from Movimientos
        //    //            where FechaCreacion LIKE '" + Convert.ToDateTime(accion1) + "'; "
        //    //    ;

        //    //    SqlCommand cmd = new SqlCommand(orden, conexion);                
        //    //    cmd.CommandType = CommandType.Text;

        //    //    cmd.Parameters.Add(new SqlParameter()
        //    //    {
        //    //        ParameterName = "@query",
        //    //        SqlDbType = SqlDbType.DateTime,
        //    //        Value = string.Format("%{0}%", accion1)
        //    //    });
        //    //}
        //    //else
        //    //{
        //    //    orden = @"select Id_Mov,
        //    //                     Importe,
        //    //                     TipoMovimiento,
        //    //                     FechaCreacion, 
        //    //                     AgendarPago,
        //    //                     CantCuotas,
        //    //                     Observaciones
        //    //             from Movimientos
        //    //             where FechaCreacion BETWEEN '" + accion1 + " AND '" + accion2 + "'; "
        //    //    ;
        //    //}

        //    //DataSet ds = new DataSet();
        //    //SqlDataAdapter da = new SqlDataAdapter();

        //    //try
        //    //{
        //    //    Abrirconexion();
        //    //    cmd.ExecuteNonQuery();
        //    //    da.SelectCommand = cmd;
        //    //    da.Fill(ds);
        //    //}
        //    //catch (Exception e)
        //    //{
        //    //    throw new Exception("Error al listar Movimientos", e);
        //    //}
        //    //finally
        //    //{
        //    //    Cerrarconexion();
        //    //    cmd.Dispose();
        //    //}
        //    //return ds;
        //}

        #endregion


        #region Traer el último movimiento

        public Movimientos ConsultarDatosDeMovimiento(Movimientos movimientos)
        {
            string orden = @"select *
                        from Movimientos
                        where Importe = '" + movimientos.Importe + "'" +
                        "and TipoMovimiento = '" + movimientos.TipoMovimiento + "'" +
                        "and CantCuotas = '" + movimientos.CantCuotas + "'" +
                        "and Observaciones = '" + movimientos.Observaciones + "';"
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

        public Movimientos ConsultarGastoPermitidoActual(Movimientos movimientos)
        {
            //string query = "execute sp_SaldoActualizado";

            //SqlCommand cmd = new SqlCommand(query, conexion);

            //try
            //{
            //    Abrirconexion();

            //    SqlDataReader reader = cmd.ExecuteReader();

            //    if (reader.Read())
            //    {
            //        movimientos.SaldoActual = decimal.Parse(reader["SumaTotal"].ToString());
            //    }
            //    reader.Close();
            //    cmd.ExecuteReader();
            //}
            //catch (Exception e)
            //{

            //    throw new Exception("No se pudo traer el Saldo Atualizado", e);
            //}
            //finally
            //{
            //    Cerrarconexion();
            //    cmd.Dispose();
            //}
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
                    movimientos.SaldoActual = decimal.Parse(reader["SumaTotal"].ToString());
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
    }
}