using DataAccessLayer;
using Entities;
using System;
using System.Data;

namespace BusinessLogicLayer
{
    public class NegMovimientos
    {
        private readonly DataMovimientos _dataMovimientos;

        public NegMovimientos()
        {
            _dataMovimientos = new DataMovimientos();
        }

        public int SaveMovement(Movimientos movimientos)
        {
            return _dataMovimientos.SaveMovement(movimientos);
        }

        public int DeleteMovement(Movimientos movimientos)
        {
            return _dataMovimientos.DeleteMovement(movimientos);
        }

        public Movimientos DeletePeriodo(DateTime FechaDesde, DateTime FechaHasta, Movimientos movimientos)
        {
            return _dataMovimientos.DeletePeriodo(FechaDesde, FechaHasta, movimientos);
        }

        public Movimientos DeleteAll(string accion, Movimientos movimientos)
        {
            return _dataMovimientos.DeleteAll(accion, movimientos);
        }

        public int UpdateMovement(Movimientos movimientos)
        {
            return _dataMovimientos.UpdateMovement(movimientos);
        }

        public DataSet MovAgendadosList()
        {
            return _dataMovimientos.MovAgendadosList();
        }

        public DataSet MovementsList(string accion)
        {
            return _dataMovimientos.MovementsList(accion);
        }


        public Movimientos ConsultarSaldo(Movimientos movimientos)
        {
            return _dataMovimientos.ConsultarSaldo(movimientos);
        }

        public Movimientos ConsultarDatosDeMovimiento(Movimientos movimientos)
        {
            return _dataMovimientos.ConsultarDatosDeMovimiento(movimientos);
        }

        public int RegistrarPagoAgendado(Movimientos movimientos)
        {
            return _dataMovimientos.RegistrarPagoAgendado(movimientos);
        }

    }
}