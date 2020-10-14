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
        #region Instancias de las Clases.

        private Movimientos _objMovimientos;
        private readonly NegMovimientos _objNegMovimientos;
        private SaldosEstablecidos _objSaldosEstablecidos;
        private readonly NegSaldosEstablecidos _objNegSaldosEstablecidos;
        private ActualizacionDeSaldoFinal actualizacionDeSaldoFinal = new ActualizacionDeSaldoFinal();

        public event EventHandler<ActualizacionDeSaldo> NotificarCambios;


        #endregion

        #region Form Load
        public FormMovimientos()
        {
            InitializeComponent();
            _objMovimientos = new Movimientos();
            _objNegMovimientos = new NegMovimientos();
            _objSaldosEstablecidos = new SaldosEstablecidos();
            _objNegSaldosEstablecidos = new NegSaldosEstablecidos();
        }
        private void FormMovimientos_Load(object sender, EventArgs e)
        {
            InhabilitarRadioButtom();
            EnlistadoDTGV();
        }

        #endregion

        #region Variables

        private bool vacio;
        private readonly string Buscar = string.Empty;
        private bool Establecido;
        private decimal IngresoSaldo;
        private decimal GastoPermitidoEstablecido;
        private decimal GastoPermitidoActual;
        private int IdMovimiento;
        private int NumDeCuota;
        //private string mNotificacionRegistro;
        //private string notifyText;
        //private string notifyTitle;

        #endregion

        #region Métodos Generales del Form

        //private void ConfirmacionDeRegistro()
        //{
        //notifyMovement.Text = mNotificacionRegistro;
        //notifyMovement.BalloonTipTitle = notifyTitle;
        //notifyMovement.BalloonTipText = notifyText;
        //notifyMovement.BalloonTipIcon = ToolTipIcon.Info;
        //notifyMovement.Visible = true;
        //notifyMovement.ShowBalloonTip(5000);
        //}

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

        private void ClearFormAndVaraibles()
        {
            TxtImporte.Clear();
            cmbTransaccion.SelectedItem = null;
            TxtObservaciones.Clear();

            IdMovimiento = 0;
            NumDeCuota = 0;
            IngresoSaldo = 0;

            RbAgendaN.Checked = true;
        }
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
        #endregion

        #region Notificar Cambio para Actualizar saldo

        protected virtual void OnNotificarCambios(object sender, ActualizacionDeSaldo e)
        {
            NotificarCambios?.Invoke(sender, e);
        }

        #endregion

        #region Método Para Guardar Movimiento

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

                EnlistadoDTGV();
                ClearFormAndVaraibles();
                InhabilitarRadioButtom();
                actualizacionDeSaldoFinal.GetSaldoActual();

                // Primero creas la instancia con toda la información que enviarás al padre
                var ActualizarSaldo = new ActualizacionDeSaldo()
                {
                    SaldoFinal = actualizacionDeSaldoFinal.SaldoActual,
                    PermitidoFinal = actualizacionDeSaldoFinal.PermitidoActual
                };

                // Y luego disparas el evento
                OnNotificarCambios(this, ActualizarSaldo);
            }

        }

        

        private void SaveMovimiento()
        {
            VerifyGastoPermitidoEstablecido();

            if (cmbTransaccion.Text == "Gasto Permitido" && Establecido == false)
            {
                EstablecerGastoPermitido();
            }
            else
            {
                CalcularSaldoActual();

                _objMovimientos.Importe = IngresoSaldo;
                _objMovimientos.TipoMovimiento = Convert.ToString(cmbTransaccion.SelectedItem);
                _objMovimientos.FechaRealizada = Convert.ToDateTime(dtpFecha.Value);

                if (RbAgendaY.Checked && Convert.ToInt32(cmbCuotas.SelectedItem) > 1)
                {
                    _objMovimientos.NumCuotaPaga = 1;
                    //Convert.ToInt32(cmbCuotas.SelectedItem) - (Convert.ToInt32(cmbCuotas.SelectedItem) - 1);
                    _objMovimientos.PagoFinalizado = "No";
                }
                else
                {
                    _objMovimientos.NumCuotaPaga = Convert.ToInt32(cmbCuotas.SelectedItem);
                    _objMovimientos.PagoFinalizado = "Si";
                }

                _objMovimientos.CantCuotas = Convert.ToInt32(cmbCuotas.SelectedItem);
                _objMovimientos.Observaciones = Convert.ToString(TxtObservaciones.Text);

                _objNegMovimientos.SaveMovement(_objMovimientos);
            }
        }
        private void VerifyGastoPermitidoEstablecido()
        {
            actualizacionDeSaldoFinal.GetSaldos();
            GastoPermitidoEstablecido = actualizacionDeSaldoFinal.SaldoPermitido;
            actualizacionDeSaldoFinal.GetSaldoActual();
            GastoPermitidoActual = actualizacionDeSaldoFinal.SaldoPermitido;

            if (GastoPermitidoEstablecido == 0)
            {
                Establecido = false;
            }
            else
            {
                //if (GastoPermitido > GastoPermitidoActual)
                //{
                //    Establecido = false;
                //}
                Establecido = true;
            }


        }
        private void EstablecerGastoPermitido()
        {
            DialogResult _dialogResult = MessageBox.Show("Para registrar este movimiento debes tener preestablecido el Importe de Gasto Permitido, ya que actualmente es de 0. ¿Quieres Establecer el Gasto Permitido ahora? Si es así, dale al botón OK",
                "No hay Gasto Permitido Establecido",
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
                case "Venta dolares":
                    IngresoSaldo += Convert.ToDecimal(TxtImporte.Text);
                    break;
                case "Otros":
                    IngresoSaldo -= Convert.ToDecimal(TxtImporte.Text);
                    break;
            }
        }


        private void EnlistadoDTGV()
        {
            DtgMovFinal.Rows.Clear();
            actualizacionDeSaldoFinal.CargarListaDemovimientos();
            if (actualizacionDeSaldoFinal.DsTablaDeMovimientos.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow dr in actualizacionDeSaldoFinal.DsTablaDeMovimientos.Tables[0].Rows)
                {
                    DtgMovFinal.Rows.Add(dr[1].ToString(), dr[2], dr[3], dr[4], dr[5], dr[6]);
                }
            }
        }

        private void UpdateMovement()
        {
            VerifyGastoPermitidoEstablecido();

            if (cmbTransaccion.Text == "Gasto Permitido" && Establecido == false)
            {
                EstablecerGastoPermitido();
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
                        _objMovimientos.NumCuotaPaga = 1;
                    }
                    else
                    {
                        _objMovimientos.PagoFinalizado = "No";
                        _objMovimientos.NumCuotaPaga = NumDeCuota;
                    }

                    _objNegMovimientos.UpdateMovement(_objMovimientos);
                }
            }
        }
        private void BtnCancel_Click(object sender, EventArgs e)
        {
            ClearFormAndVaraibles();
        }

        #endregion        

        #region Filtrar DatagridView        

        private void TxtFiltro_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                actualizacionDeSaldoFinal.Buscar = TxtFiltro.Text;
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

        #region RadioButtom
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
        #endregion

        #region Editar Movimiento
        private void DtgMovFinal_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ConsultarDatosDeMovimiento();
            CargaDeDatosOnLine();
            EnlistadoDTGV();
        }

        private void CargaDeDatosOnLine()
        {

            IdMovimiento = _objMovimientos.Id_Mov;
            NumDeCuota = _objMovimientos.NumCuotaPaga;

            TxtImporte.Text = Convert.ToString(DtgMovFinal.CurrentRow.Cells[0].Value);
            cmbTransaccion.SelectedItem = Convert.ToString(DtgMovFinal.CurrentRow.Cells[1].Value);
            dtpFecha.Value = Convert.ToDateTime(DtgMovFinal.CurrentRow.Cells[2].Value);

            if (DtgMovFinal.CurrentRow.Cells[3].Value.ToString() == "Si")
            {
                RbAgendaY.Checked = true;
                RbAgendaN.Checked = false;
            }
            else
            {
                RbAgendaY.Checked = false;
                RbAgendaN.Checked = true;
            }

            cmbCuotas.SelectedItem = Convert.ToInt32(DtgMovFinal.CurrentRow.Cells[4].Value);
            TxtObservaciones.Text = Convert.ToString(DtgMovFinal.CurrentRow.Cells[5].Value);

            BtnSave.Text = "Modificar";
        }

        private void ConsultarDatosDeMovimiento()
        {
            _objMovimientos.Importe = Convert.ToDecimal(DtgMovFinal.CurrentRow.Cells[0].Value);
            _objMovimientos.TipoMovimiento = Convert.ToString(DtgMovFinal.CurrentRow.Cells[1].Value);
            _objMovimientos.FechaRealizada = Convert.ToDateTime(DtgMovFinal.CurrentRow.Cells[2].Value);
            _objMovimientos.NumCuotaPaga = Convert.ToInt32(DtgMovFinal.CurrentRow.Cells[3].Value);
            _objMovimientos.CantCuotas = Convert.ToInt32(DtgMovFinal.CurrentRow.Cells[4].Value);
            _objMovimientos.Observaciones = Convert.ToString(DtgMovFinal.CurrentRow.Cells[5].Value);

            _objNegMovimientos.ConsultarDatosDeMovimiento(_objMovimientos);
        }

        private void EditarMovimiento_Click(object sender, EventArgs e)
        {
            ConsultarDatosDeMovimiento();
            CargaDeDatosOnLine();
        }
        #endregion

        #region Eliminar Movimiento
        private void EliminarMovimiento_Click(object sender, EventArgs e)
        {
            ConsultarDatosDeMovimiento();
            _objNegMovimientos.DeleteMovement(_objMovimientos);
            EnlistadoDTGV();
        }
        #endregion

        #region Capturar Click derecho del mouse en el dtgv
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
    }
}