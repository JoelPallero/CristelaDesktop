using BusinessLogicLayer;
using Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrontEndLayer
{
    public partial class FormPagosAgendados : Form
    {
        #region Instancias de Clases

        private Movimientos _objMovimientos = new Movimientos();
        private NegMovimientos _objNegMovimientos = new NegMovimientos();


        #endregion

        #region Variables
        private int IdMovimiento;
        private decimal ImporteAgenda;
        private string TipoMovimientoAgenda;
        private DateTime FechaRealizadaAgenda;
        private int NumCuotaPagaAgenda;
        private int CantCuotasAgenda;
        private string ObservacionesAgenda;

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
            DataSet ds = _objNegMovimientos.MovAgendadosList(_objMovimientos);
            if (ds.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    DtgMovAgendados.Rows.Add(dr[1].ToString(), dr[2], dr[3], dr[4], dr[5], dr[6]);
                }
            }
        }

        #endregion

        private void DtgMovAgendados_MouseEnter(object sender, EventArgs e)
        {

        }

        private void DtgMovAgendados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewButtonCell cell = (DataGridViewButtonCell)DtgMovAgendados.Rows[e.RowIndex].Cells[e.ColumnIndex];

            if (cell.Value.ToString() == "Registrar")
            {
                ImporteAgenda = decimal.Parse(DtgMovAgendados.Rows[e.RowIndex].Cells[0].Value.ToString());
                TipoMovimientoAgenda = DtgMovAgendados.Rows[e.RowIndex].Cells[1].Value.ToString();
                FechaRealizadaAgenda = DateTime.Parse(DtgMovAgendados.Rows[e.RowIndex].Cells[2].Value.ToString());
                NumCuotaPagaAgenda = int.Parse(DtgMovAgendados.Rows[e.RowIndex].Cells[3].Value.ToString());
                CantCuotasAgenda = int.Parse(DtgMovAgendados.Rows[e.RowIndex].Cells[4].Value.ToString());
                ObservacionesAgenda = DtgMovAgendados.Rows[e.RowIndex].Cells[5].Value.ToString();

                ConsultarDatosDemovimiento();
                RegistrarPagosAgendados();
                ClearVariables();
                EnlistadoDTGV();
            }
        }

        private void ConsultarDatosDemovimiento()
        {
            _objMovimientos.Importe = ImporteAgenda;
            _objMovimientos.TipoMovimiento = TipoMovimientoAgenda;
            _objMovimientos.FechaRealizada = FechaRealizadaAgenda;
            _objMovimientos.NumCuotaPaga = NumCuotaPagaAgenda;
            _objMovimientos.CantCuotas = CantCuotasAgenda;
            _objMovimientos.Observaciones = ObservacionesAgenda;
            _objNegMovimientos.ConsultarDatosDeMovimiento(_objMovimientos);

            IdMovimiento = _objMovimientos.Id_Mov;
        }

        private void RegistrarPagosAgendados()
        {
            _objMovimientos.CodMovimiento = IdMovimiento;
            _objMovimientos.NumCuotaPaga = NumCuotaPagaAgenda + 1;
            _objMovimientos.FechaRealizada = FechaRealizadaAgenda.AddMonths(1);
            if (_objMovimientos.NumCuotaPaga < _objMovimientos.CantCuotas)
            {
                _objMovimientos.PagoFinalizado = "No";
            }
            else
            {
                _objMovimientos.PagoFinalizado = "Si";
                //FinalizarCuotasDePagos();
            }
            _objNegMovimientos.RegistrarPagoAgendado(_objMovimientos);
        }

        private void ClearVariables()
        {
            IdMovimiento = 0;
            ImporteAgenda = 0;
            TipoMovimientoAgenda = string.Empty;
            NumCuotaPagaAgenda = 0;
            CantCuotasAgenda = 0;
            ObservacionesAgenda = string.Empty;
        }

        private void FinalizarCuotasDePagos()
        {

        }
    }
}