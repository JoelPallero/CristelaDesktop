using BusinessLogicLayer;
using Entities;
using System.Data;

namespace Cristela
{
    public class ActualizacionDeSaldoFinal
    {
        private Movimientos _objMovimientos = new Movimientos();
        private NegMovimientos _objNegMovimientos = new NegMovimientos();
        private SaldosEstablecidos _objSaldosEstablecidos = new SaldosEstablecidos();
        private NegSaldosEstablecidos _objNegSaldosEstablecidos = new NegSaldosEstablecidos();

        public int IdSe;
        public decimal SaldoActual;
        public decimal PermitidoActual;
        public decimal Emergencia;
        public decimal Critico;
        public decimal SaldoPermitido;
        

        public DataSet DsTablaDeMovimientos = new DataSet();
        public string Buscar = string.Empty;

        public void GetSaldoActual()
        {
            _objMovimientos = _objNegMovimientos.ConsultarSaldo(_objMovimientos);
            GetSaldos();
            SaldoActual = _objMovimientos.SaldoActual - _objSaldosEstablecidos.GastoPermitido;
            PermitidoActual = _objMovimientos.GastoPermitido;
        }

        public void GetSaldos()
        {
            _objSaldosEstablecidos = _objNegSaldosEstablecidos.ConsultarSaldosEstablecidos();
            IdSe = _objSaldosEstablecidos.Id_SE;
            Emergencia = _objSaldosEstablecidos.SaldoEmergencia;
            Critico = _objSaldosEstablecidos.SaldoCritico;
            SaldoPermitido = _objSaldosEstablecidos.GastoPermitido;
        }

        public void CargarListaDemovimientos()
        {
            DsTablaDeMovimientos = _objNegMovimientos.MovementsList(Buscar);
        }

        public void CargarMovAgendados()
        {
            DsTablaDeMovimientos = _objNegMovimientos.MovAgendadosList();
        }
    }
}