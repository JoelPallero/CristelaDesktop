using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Movimientos
    {
        #region Atributos

        private int id_Mov;
        private decimal importe;
        private string tipoMovimiento;
        private DateTime fechaRealizada;
        private int numCuotaPaga;
        private int cantCuotas;
        private string observaciones;
        private int codMovimiento;
        private string pagoFinalizado;
        private decimal saldoActual;
        private decimal gastoPermitido;
        private int seId;

        #endregion

        #region Encapsulamiento de los atributos

        public int Id_Mov { get => id_Mov; set => id_Mov = value; }
        public decimal Importe { get => importe; set => importe = value; }
        public string TipoMovimiento { get => tipoMovimiento; set => tipoMovimiento = value; }
        public DateTime FechaRealizada { get => fechaRealizada; set => fechaRealizada = value; }
        public int NumCuotaPaga { get => numCuotaPaga; set => numCuotaPaga = value; }
        public int CantCuotas { get => cantCuotas; set => cantCuotas = value; }
        public string Observaciones { get => observaciones; set => observaciones = value; }
        public int CodMovimiento { get => codMovimiento; set => codMovimiento = value; }
        public string PagoFinalizado { get => pagoFinalizado; set => pagoFinalizado = value; }
        public decimal SaldoActual { get => saldoActual; set => saldoActual = value; }
        public decimal GastoPermitido { get => gastoPermitido; set => gastoPermitido = value; }
        public int SeId { get => seId; set => seId = value; }

        #endregion
    }
}
