using DataAccessLayer;
using Entities;
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

        public int UpdateMovement(Movimientos movimientos)
        {
            return _dataMovimientos.UpdateMovement(movimientos);
        }

        //public DataSet DateTimeFilter(string accion1, string accion2, bool busqueda)
        //{
        //    return _dataMovimientos.DateTimeFilter(accion1, accion2, busqueda);
        //}

        public DataSet MovementsList(string accion)
        {
            return _dataMovimientos.MovementsList(accion);
        }


        public Movimientos ConsultarSaldo(Movimientos movimientos)
        {
            return _dataMovimientos.ConsultarSaldo(movimientos);
        }

        public Movimientos ConsultarGastoPermitidoActual(Movimientos movimientos)
        {
            return _dataMovimientos.ConsultarGastoPermitidoActual(movimientos);
        }

        public Movimientos ConsultarDatosDeMovimiento(Movimientos movimientos)
        {
            return _dataMovimientos.ConsultarDatosDeMovimiento(movimientos);
        }

    }
}