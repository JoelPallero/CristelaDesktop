using DataAccessLayer;
using Entities;

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
