﻿using System;

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
        private string pagoAgendado;
        private decimal saldoActual;
        private decimal gastoPermitido;

        #endregion

        #region Encapsulamiento de los atributos

        public int Id_Mov { get => id_Mov; set => id_Mov = value; }
        public decimal Importe { get => importe; set => importe = value; }
        public string TipoMovimiento { get => tipoMovimiento; set => tipoMovimiento = value; }
        public DateTime FechaRealizada { get => fechaRealizada; set => fechaRealizada = value; }
        public int NumCuotaPaga { get => numCuotaPaga; set => numCuotaPaga = value; }
        public int CantCuotas { get => cantCuotas; set => cantCuotas = value; }
        public string Observaciones { get => observaciones; set => observaciones = value; }
        public string PagoAgendado { get => pagoAgendado; set => pagoAgendado = value; }
        public decimal SaldoActual { get => saldoActual; set => saldoActual = value; }
        public decimal GastoPermitido { get => gastoPermitido; set => gastoPermitido = value; }

        #endregion

    }
}
