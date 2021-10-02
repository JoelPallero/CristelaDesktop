using BusinessLogicLayer;
using Entities;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Cristela
{
    public partial class FormMovimientos : Form
    {
        #region Instancias

        private Movimientos _objMovimientos;
        private readonly NegMovimientos _objNegMovimientos;
        private ActualizacionDeSaldoFinal _actualizacionDeSaldoFinal = new ActualizacionDeSaldoFinal();
        public event EventHandler<ActualizacionDeSaldo> NotificarCambios;

        #endregion

        #region Form Load
        public FormMovimientos()
        {
            InitializeComponent();
            _objMovimientos = new Movimientos();
            _objNegMovimientos = new NegMovimientos();
            EnlistadoDTGV();
        }
        private void FormMovimientos_Load(object sender, EventArgs e)
        {
            InhabilitarRadioButtom();
            _actualizacionDeSaldoFinal.Buscar = "Registro";
            EnlistadoDTGV();
        }

        #endregion

        #region Variables

        private bool vacio;
        private readonly string Buscar = "Registro";
        private bool Establecido;
        private decimal IngresoSaldo;
        private decimal GastoPermitidoEstablecido;
        private decimal GastoPermitidoActual;
        private int NumDeCuota;
        private int CuotasPagas;

        #endregion

        #region Métodos

        private void ValidarCamposVacios()
        {
            if (string.IsNullOrEmpty(TxtImporte.Text) ||
                string.IsNullOrEmpty(cmbTransaccion.Text) ||
                string.IsNullOrEmpty(cmbCuotas.Text))
            {
                vacio = true;
            }
            else
            {
                vacio = false;
            }
        }

        private void InhabilitarRadioButtom()
        {
            cmbCuotas.SelectedItem = "1";
            cmbCuotas.Enabled = false;
        }

        private void ClearControls()
        {
            TxtImporte.Clear();
            cmbTransaccion.SelectedItem = null;
            TxtObservaciones.Clear();
            IngresoSaldo = 0;

            RbAgendaN.Checked = true;
        }

        private void CargarMovimiento()
        {
            _actualizacionDeSaldoFinal.GetSaldos();
            CalcularSaldoActual();
            _objMovimientos.Importe = IngresoSaldo;
            _objMovimientos.TipoMovimiento = Convert.ToString(cmbTransaccion.SelectedItem);
            _objMovimientos.FechaRealizada = Convert.ToDateTime(dtpFecha.Value);

            if (RbAgendaY.Checked && Convert.ToInt32(cmbCuotas.SelectedItem) > 1)
            {
                _objMovimientos.NumCuotaPaga = 1;
                _objMovimientos.PagoFinalizado = "No";
            }
            else
            {
                _objMovimientos.NumCuotaPaga = Convert.ToInt32(cmbCuotas.SelectedItem);
                _objMovimientos.PagoFinalizado = "Si";
            }

            _objMovimientos.CantCuotas = Convert.ToInt32(cmbCuotas.SelectedItem);
            _objMovimientos.Observaciones = Convert.ToString(TxtObservaciones.Text);
            _objMovimientos.SeId = _actualizacionDeSaldoFinal.IdSe;
            _objNegMovimientos.SaveMovement(_objMovimientos);
        }

        private void SaveMovimiento()
        {
            if (cmbTransaccion.SelectedItem.ToString() == "Gasto Permitido")
            {
                VerifyGastoPermitidoEstablecido();
            }
            else
            {
                CargarMovimiento();
            }
        }
        private void VerifyGastoPermitidoEstablecido()
        {
            _actualizacionDeSaldoFinal.GetSaldoActual();
            GastoPermitidoEstablecido = _actualizacionDeSaldoFinal.SaldoPermitido;
            GastoPermitidoActual = _actualizacionDeSaldoFinal.PermitidoActual;
            GastoPermitidoActual += Convert.ToDecimal(TxtImporte.Text);

            if (GastoPermitidoEstablecido <= 0)
            {
                Establecido = false;
                MessageBoxGastoPermitido();
            }
            else
            {
                if (GastoPermitidoActual > GastoPermitidoEstablecido)
                {
                    Establecido = false;
                    ClearControls();
                    MessageBoxGastoPermitido();
                }
                else
                {
                    CargarMovimiento();
                }
            }
        }

        private void MessageBoxGastoPermitido()
        {
            MessageBox.Show("El movimiento que quieres registrar, no se encuentra establecido o supera el máximo establecido. " +
                    "Para establecer un Gasto Permitido, ingresa al menú 'Ajustes'.",
                    "Inconsistencias de datos:",
                    MessageBoxButtons.OK);
        }
        private void EstablecerGastoPermitido()
        {
            DialogResult _dialogResult = MessageBox.Show("El movimiento que quieres registrar, no se encuentra establecido o supera el máximo establecido. " +
                "Para establecer un Gasto Permitido, Presiona 'Aceptar'.",
                "Inconsistencias en el Gasto Permitido",
                MessageBoxButtons.OKCancel);

            if (_dialogResult == DialogResult.OK)
            {
                FormInicio _formInicio = new FormInicio();
                _formInicio.ClickAjustes();
            }
        }

        private void CalcularSaldoActual()
        {
            switch (cmbTransaccion.SelectedItem)
            {
                case "Agua":
                    IngresoSaldo -= Convert.ToDecimal(TxtImporte.Text);
                    break;
                case "Alquiler":
                    IngresoSaldo -= Convert.ToDecimal(TxtImporte.Text);
                    break;
                case "Cobro":
                    IngresoSaldo += Convert.ToDecimal(TxtImporte.Text);
                    break;
                case "Compra":
                    IngresoSaldo -= Convert.ToDecimal(TxtImporte.Text);
                    break;
                case "Gas":
                    IngresoSaldo -= Convert.ToDecimal(TxtImporte.Text);
                    break;
                case "Gasto Permitido":
                    IngresoSaldo = Convert.ToDecimal(TxtImporte.Text);
                    break;
                case "Luz":
                    IngresoSaldo -= Convert.ToDecimal(TxtImporte.Text);
                    break;
                case "Pago":
                    IngresoSaldo -= Convert.ToDecimal(TxtImporte.Text);
                    break;
                case "Sueldo":
                    IngresoSaldo += Convert.ToDecimal(TxtImporte.Text);
                    break;
                case "SuperMercado":
                    IngresoSaldo -= Convert.ToDecimal(TxtImporte.Text);
                    break;
                case "Transferencia":
                    IngresoSaldo -= Convert.ToDecimal(TxtImporte.Text);
                    break;
            }
        }

        private void EnlistadoDTGV()
        {
            DtgMovFinal.Rows.Clear();
            _actualizacionDeSaldoFinal.CargarListaDemovimientos();
            if (_actualizacionDeSaldoFinal.DsTablaDeMovimientos.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow dr in _actualizacionDeSaldoFinal.DsTablaDeMovimientos.Tables[0].Rows)
                {
                    DtgMovFinal.Rows.Add(dr[0].ToString(), dr[1], dr[2], dr[3], dr[4], dr[5], dr[6]);
                }
            }
        }

        private void UpdateMovement()
        {
            if (cmbTransaccion.Text == "Gasto Permitido")
            {
                VerifyGastoPermitidoEstablecido();
                if (Establecido != false)
                {
                    EstablecerGastoPermitido();
                }
            }
            else
            {
                if (RbAgendaY.Checked && Convert.ToInt32(cmbCuotas.SelectedItem) < 2)
                {
                    MessageBox.Show("Para agendar pago debe seleccionar cuotas mayores a 1", "Agendar Pago", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                else
                {
                    CalcularSaldoActual(); //para saber si el importe va con - o si con +

                    _objMovimientos.Importe = Convert.ToDecimal(TxtImporte.Text);
                    _objMovimientos.TipoMovimiento = Convert.ToString(cmbTransaccion.SelectedItem);
                    _objMovimientos.FechaRealizada = Convert.ToDateTime(dtpFecha.Value);
                    _objMovimientos.CantCuotas = Convert.ToInt32(cmbCuotas.SelectedItem);
                    _objMovimientos.Observaciones = Convert.ToString(TxtObservaciones.Text);

                    if (Convert.ToInt32(cmbCuotas.SelectedItem) == 1)
                    {
                        _objMovimientos.PagoFinalizado = "Si";
                        _objMovimientos.NumCuotaPaga = CuotasPagas;
                    }
                    else
                    {
                        _objMovimientos.PagoFinalizado = "No";
                        _objMovimientos.NumCuotaPaga = CuotasPagas;
                    }

                    _objNegMovimientos.UpdateMovement(_objMovimientos);
                }
            }
        }

        private void CargaDeDatosOnLine()
        {
            TxtImporte.Text = DtgMovFinal.CurrentRow.Cells[1].Value.ToString();
            cmbTransaccion.SelectedItem = DtgMovFinal.CurrentRow.Cells[2].Value.ToString();
            dtpFecha.Value = Convert.ToDateTime(DtgMovFinal.CurrentRow.Cells[3].Value);
            CuotasPagas = int.Parse(DtgMovFinal.CurrentRow.Cells[4].Value.ToString());
            cmbCuotas.SelectedItem = DtgMovFinal.CurrentRow.Cells[5].Value.ToString();

            if (DtgMovFinal.CurrentRow.Cells[5].Value.ToString() == "1")
            {
                RbAgendaY.Checked = false;
                RbAgendaN.Checked = true;
            }
            else
            {
                RbAgendaY.Checked = true;
                RbAgendaN.Checked = false;
            }

            TxtObservaciones.Text = DtgMovFinal.CurrentRow.Cells[6].Value.ToString();
            BtnSave.Text = "Modificar";
        }

        private void ConsultarDatosDeMovimiento()
        {
            _objMovimientos.Id_Mov = Convert.ToInt32(DtgMovFinal.CurrentRow.Cells[0].Value);
            _objNegMovimientos.ConsultarDatosDeMovimiento(_objMovimientos);
        }

        #endregion

        #region Notificar Cambio para Actualizar saldo
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
        protected virtual void OnNotificarCambios(object sender, ActualizacionDeSaldo e)
        {
            NotificarCambios?.Invoke(sender, e);
        }

        #endregion

        #region Eventos

        private void TxtImporte_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Solo se teclean los digitos
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }

            //permitir teclas de control como retroceso
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsPunctuation(e.KeyChar))
            {
                if (TxtImporte.Text.Contains(",") || TxtImporte.Text.Contains("."))
                {
                    e.Handled = true;
                }
                else
                {
                    e.Handled = false;
                }
            }
            else
            {
                //con esto se desactivan todas las otras teclas no contempladas en las líneas anteriores
                e.Handled = true;
            }
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            ValidarCamposVacios();
            if (vacio)
            {
                MessageBox.Show("No puede haber campos vacíos para poder guardar el movimiento",
                                "Datos Incompletos",
                                MessageBoxButtons.OK);
            }
            else
            {
                if (BtnSave.Text == "Guardar")
                {                 
                    SaveMovimiento();
                }
                else
                {
                    UpdateMovement();
                    BtnSave.Text = "Guardar";
                }
                _actualizacionDeSaldoFinal.Buscar = Buscar;
                EnlistadoDTGV();
                InhabilitarRadioButtom();
                ActualizarSaldos();
                ClearControls();
            }
        }
        private void BtnCancel_Click(object sender, EventArgs e)
        {
            ClearControls();
        }
        private void DtgMovFinal_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ConsultarDatosDeMovimiento();
            CargaDeDatosOnLine();
            EnlistadoDTGV();
            ActualizarSaldos();
        }
        private void EditarMovimiento_Click(object sender, EventArgs e)
        {
            ConsultarDatosDeMovimiento();
            CargaDeDatosOnLine();
        }

        private void RbAgendaN_CheckedChanged(object sender, EventArgs e)
        {
            if (RbAgendaN.Checked)
            {
                InhabilitarRadioButtom();
            }
        }

        private void RbAgendaY_CheckedChanged(object sender, EventArgs e)
        {
            if (RbAgendaY.Checked)
            {
                cmbCuotas.Enabled = true;
            }
        }

        private void EliminarMovimiento_Click(object sender, EventArgs e)
        {
            _objMovimientos.Id_Mov = Convert.ToInt32(DtgMovFinal.CurrentRow.Cells[0].Value);
            _objNegMovimientos.DeleteMovement(_objMovimientos);
            ActualizarSaldos();
            EnlistadoDTGV();
        }

        private void DtgMovFinal_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                DtgMovFinal.CurrentCell = DtgMovFinal.Rows[e.RowIndex].Cells[e.ColumnIndex];
                DtgMovFinal.Rows[e.RowIndex].Selected = true;
                DtgMovFinal.Focus();
            }
        }
        #endregion        

        #region Filtrar DatagridView        

        private void TxtFiltro_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                _actualizacionDeSaldoFinal.Buscar = TxtFiltro.Text;
                EnlistadoDTGV();
            }
        }

        private void TxtFiltro_MouseEnter(object sender, EventArgs e)
        {
            PicFiltro.BackColor = Color.Black;
        }

        private void TxtFiltro_MouseLeave(object sender, EventArgs e)
        {
            PicFiltro.BackColor = Color.FromArgb(88, 88, 88);
        }

        private void TxtFiltro_Enter(object sender, EventArgs e)
        {
            TxtFiltro.ForeColor = Color.FromArgb(64, 64, 64);
            TxtFiltro.Clear();
        }
        private void TxtFiltro_Leave(object sender, EventArgs e)
        {
            TxtFiltro.ForeColor = Color.Gray;
            TxtFiltro.Text = "Buscar";
        }

        #endregion
    }
}