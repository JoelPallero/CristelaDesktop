using BusinessLogicLayer;
using Entities;
using System;
using System.Data;
using System.Windows.Forms;

namespace Cristela
{
    public partial class FormPagosAgendados : Form
    {
        #region Instancias de Clases

        private Movimientos _objMovimientos = new Movimientos();
        private NegMovimientos _objNegMovimientos = new NegMovimientos();
        private ActualizacionDeSaldoFinal _actualizacionDeSaldoFinal = new ActualizacionDeSaldoFinal();
        public event EventHandler<ActualizacionDeSaldo> NotificarCambios;

        #endregion

        #region Loading Form
        public FormPagosAgendados()
        {
            InitializeComponent();
        }

        private void FormPagosAgendados_Load(object sender, EventArgs e)
        {
            EnlistadoDTGV();
        }

        #endregion

        #region Carga de Pagos Agendados
        private void EnlistadoDTGV()
        {
            DtgMovAgendados.Rows.Clear();
            _actualizacionDeSaldoFinal.CargarMovAgendados();
            if (_actualizacionDeSaldoFinal.DsTablaDeMovimientos.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow dr in _actualizacionDeSaldoFinal.DsTablaDeMovimientos.Tables[0].Rows)
                {
                    DtgMovAgendados.Rows.Add(dr[0].ToString(), dr[7], dr[1], dr[2], dr[4], dr[5], dr[6]);
                }
            }
        }

        #region Notificar Cambio para Actualizar saldo

        protected virtual void OnNotificarCambios(object sender, ActualizacionDeSaldo e)
        {
            NotificarCambios?.Invoke(sender, e);
        }

        #endregion

        #endregion

        #region Registro de pagos Agendados
        private void DtgMovAgendados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewButtonCell cell = (DataGridViewButtonCell)DtgMovAgendados.Rows[e.RowIndex].Cells[e.ColumnIndex];

            if (cell.Value.ToString() != string.Empty)
            {
                _objMovimientos.NumCuotaPaga = int.Parse(DtgMovAgendados.Rows[e.RowIndex].Cells[4].Value.ToString()) + 1;
                _objMovimientos.CantCuotas = int.Parse(DtgMovAgendados.Rows[e.RowIndex].Cells[5].Value.ToString());
                _objMovimientos.Observaciones = DtgMovAgendados.Rows[e.RowIndex].Cells[6].Value.ToString();

                if (string.IsNullOrEmpty(DtgMovAgendados.Rows[e.RowIndex].Cells[1].Value.ToString()))
                {
                    _objMovimientos.CodMovimiento = int.Parse(DtgMovAgendados.Rows[e.RowIndex].Cells[0].Value.ToString());
                }
                else
                {
                    _objMovimientos.CodMovimiento = int.Parse(DtgMovAgendados.Rows[e.RowIndex].Cells[1].Value.ToString());
                }

                _objMovimientos.Importe = decimal.Parse(DtgMovAgendados.Rows[e.RowIndex].Cells[2].Value.ToString());
                _objMovimientos.TipoMovimiento = DtgMovAgendados.Rows[e.RowIndex].Cells[3].Value.ToString();
                _objMovimientos.FechaRealizada = DateTime.Now;

                if (_objMovimientos.NumCuotaPaga == _objMovimientos.CantCuotas)
                {
                    _objMovimientos.PagoFinalizado = "Si";
                }
                else
                {
                    _objMovimientos.PagoFinalizado = "No";
                }

                _objNegMovimientos.RegistrarPagoAgendado(_objMovimientos);

                EnlistadoDTGV();
                ActualizarSaldos();
            }
        }

        private void ActualizarSaldos()
        {
            _actualizacionDeSaldoFinal.GetSaldoActual();

            // Primero creo la instancia con toda la información que voy a enviar al FormInicial
            var ActualizarSaldo = new ActualizacionDeSaldo()
            {
                SaldoFinal = _actualizacionDeSaldoFinal.SaldoActual,
                PermitidoFinal = _actualizacionDeSaldoFinal.PermitidoActual
            };

            //Y luego disparo el evento enviando los datos que hay en "ActualizarSaldo" (arriba)
            OnNotificarCambios(this, ActualizarSaldo);
        }

        #endregion
    }
}