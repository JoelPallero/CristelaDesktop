using System;

namespace Entities
{
    public class SaldosEstablecidos
    {
        private int id_SE;
        private decimal saldoEmergencia;
        private decimal saldoCritico;
        private decimal gastoPermitido;
        private DateTime fechaSaldos;
        public int Id_SE { get => id_SE; set => id_SE = value; }
        public decimal SaldoEmergencia { get => saldoEmergencia; set => saldoEmergencia = value; }
        public decimal SaldoCritico { get => saldoCritico; set => saldoCritico = value; }
        public decimal GastoPermitido { get => gastoPermitido; set => gastoPermitido = value; }
        public DateTime FechaSaldos { get => fechaSaldos; set => fechaSaldos = value; }
    }
}