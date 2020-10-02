using DataAccessLayer;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer
{
    public class NegSaldosEstablecidos
    {
        private readonly DataSaldosEstablecidos _dataSaldosEstablecidos;

        public NegSaldosEstablecidos()
        {
            _dataSaldosEstablecidos = new DataSaldosEstablecidos();
        }

        public SaldosEstablecidos ConsultarSaldosEstablecidos()
        {
            return _dataSaldosEstablecidos.ConsultarSaldosEstablecidos();
        }

        public int EstablecerSaldos(SaldosEstablecidos saldosEstablecidos)
        {
            return _dataSaldosEstablecidos.EstablecerSaldos(saldosEstablecidos);
        }
    }
}
