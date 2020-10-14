using BusinessLogicLayer;
using Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UIForms
{
    public class ActualizacionDeSaldoFinal
    {
        Movimientos _objMovimientos = new Movimientos();
        NegMovimientos _objNegMovimientos = new NegMovimientos();
        SaldosEstablecidos _objSaldosEstablecidos = new SaldosEstablecidos();
        NegSaldosEstablecidos _objNegSaldosEstablecidos = new NegSaldosEstablecidos();

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
            SaldoActual = _objMovimientos.SaldoActual;
            PermitidoActual = _objMovimientos.GastoPermitido;
        }

        public void GetSaldos()
        {
            _objSaldosEstablecidos = _objNegSaldosEstablecidos.ConsultarSaldosEstablecidos();
            Emergencia = _objSaldosEstablecidos.SaldoEmergencia;
            Critico = _objSaldosEstablecidos.SaldoCritico;
            SaldoPermitido = _objSaldosEstablecidos.GastoPermitido;
        }

        public void CargarListaDemovimientos()
        {
            DsTablaDeMovimientos = _objNegMovimientos.MovementsList(Buscar);
        }

    }
}
