using BusinessLogicLayer;
using Entities;
using System;
using System.Windows.Forms;

namespace Cristela
{
    public partial class FormConfiguracion : Form
    {

        private NegMovimientos _negMovimientos = new NegMovimientos();
        private Movimientos _movimientos = new Movimientos();
        private SaldosEstablecidos _saldosEstablecidos = new SaldosEstablecidos();
        private NegSaldosEstablecidos _negSaldosEstablecidos = new NegSaldosEstablecidos();
        private ActualizacionDeSaldoFinal _actualizacionDeSaldoFinal = new ActualizacionDeSaldoFinal();
        private NotificacionesDiarias _notificacionesDiarias = new NotificacionesDiarias();
        private NegnotificacionesDiarias _negnotificacionesDiarias = new NegnotificacionesDiarias();
        private NotificacionesGTR _notificacionesGTR = new NotificacionesGTR();

        public event EventHandler<ActualizacionDeSaldo> NotificarCambios;

        public FormConfiguracion()
        {
            InitializeComponent();
        }

        private void FormConfiguracion_Load(object sender, EventArgs e)
        {
            MostrarSaldos();
        }

        #region Variables

        private bool vacio;
        private string accion = string.Empty;
        private DateTime FechaDesde;
        private DateTime FechaHasta;
        private bool TodosChecked;

        #endregion

        private void MostrarSaldos()
        {
            _saldosEstablecidos = _negSaldosEstablecidos.ConsultarSaldosEstablecidos();
            LblEmergenciaActual.Text = "$" + _saldosEstablecidos.SaldoEmergencia.ToString("G29");
            LblCriticoActual.Text = "$" + _saldosEstablecidos.SaldoCritico.ToString("G29");
            LblPermitidoActual.Text = "$" + _saldosEstablecidos.GastoPermitido.ToString("G29");
        }

        private void ValidarCamposVacios()
        {
            if (string.IsNullOrEmpty(TxtEmergencia.Text) ||
                string.IsNullOrEmpty(TxtCritico.Text) ||
                string.IsNullOrEmpty(TxtPermitido.Text))
            {
                vacio = true;
            }
            else
            {
                vacio = false;
            }
        }

        private void ClearText()
        {
            TxtEmergencia.Text = string.Empty;
            TxtCritico.Text = string.Empty;
            TxtPermitido.Text = string.Empty;
            vacio = false;
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            ValidarCamposVacios();
            if (vacio == false)
            {
                _saldosEstablecidos.SaldoEmergencia = Convert.ToDecimal(TxtEmergencia.Text);
                _saldosEstablecidos.SaldoCritico = Convert.ToDecimal(TxtCritico.Text);
                _saldosEstablecidos.GastoPermitido = Convert.ToDecimal(TxtPermitido.Text);
                _saldosEstablecidos.Fecha = DateTime.Now;
                _negSaldosEstablecidos.EstablecerSaldos(_saldosEstablecidos);
                ClearText();
                MostrarSaldos();
                ActualizacionDeSaldos();
            }
            else
            {
                MessageBox.Show("No puede haber campos vacíos. Si no registras dato en algún campo, puedes utilizar el 0", "Campos vacíos", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void RbPeriodo_CheckedChanged(object sender, EventArgs e)
        {
            DtDesde.Enabled = true;
            DtHasta.Enabled = true;
        }

        private void RbOrigen_CheckedChanged(object sender, EventArgs e)
        {
            DtDesde.Enabled = false;
            DtHasta.Enabled = false;
        }

        private void RbTodo_CheckedChanged(object sender, EventArgs e)
        {
            if (RbTodo.Checked)
            {
                accion = "Todo";
                vacio = true;
            }
        }

        private void RbMovimientos_CheckedChanged(object sender, EventArgs e)
        {
            if (RbMovimientos.Checked)
            {
                accion = "Movimientos";
                vacio = true;
            }
        }

        private void RbSaldos_CheckedChanged(object sender, EventArgs e)
        {
            if (RbSaldos.Checked)
            {
                accion = "Saldos";
                vacio = true;
            }
        }


        private void RbNotas_CheckedChanged(object sender, EventArgs e)
        {
            if (RbNotas.Checked)
            {
                accion = "Notas";
                vacio = true;
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (RbPeriodo.Checked)
            {
                FechaDesde = DtDesde.Value;
                FechaHasta = DtHasta.Value;
                _movimientos = _negMovimientos.DeletePeriodo(FechaDesde, FechaHasta, _movimientos);
            }
            else
            {
                if (vacio)
                {
                    _movimientos = _negMovimientos.DeleteAll(accion, _movimientos);
                }
                else
                {
                    MessageBox.Show("No se ha seleccionado ningún item. Seleccione lo que quiera borrar.", "Seleccionar dato a borrar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            MostrarSaldos();
            vacio = false;
            ActualizacionDeSaldos();
        }

        private void ActualizacionDeSaldos()
        {
            _actualizacionDeSaldoFinal.GetSaldoActual();
            _actualizacionDeSaldoFinal.GetSaldos();


            var ActualizarSaldo = new ActualizacionDeSaldo()
            {
                SaldoFinal = _actualizacionDeSaldoFinal.SaldoActual,
                PermitidoFinal = _actualizacionDeSaldoFinal.PermitidoActual,
                SaldoDeEmergencia = _actualizacionDeSaldoFinal.Emergencia,
                SaldoDeCritico = _actualizacionDeSaldoFinal.Critico,
                SaldoPermitido = _actualizacionDeSaldoFinal.SaldoPermitido
            };

            // Y luego disparas el evento
            OnNotificarCambios(this, ActualizarSaldo);
        }

        #region Notificar Cambio para Actualizar saldo

        protected virtual void OnNotificarCambios(object sender, ActualizacionDeSaldo e)
        {
            NotificarCambios?.Invoke(sender, e);
        }

        #endregion

        #region Notificaciones

        #endregion

        private void RbNoti1_CheckedChanged(object sender, EventArgs e)
        {
            DtpAlarma1.Enabled = true;
            DtpAlarma2.Enabled = false;
            DtpAlarma3.Enabled = false;
        }

        private void RbNoti2_CheckedChanged(object sender, EventArgs e)
        {
            DtpAlarma1.Enabled = true;
            DtpAlarma2.Enabled = true;
            DtpAlarma3.Enabled = false;
        }

        private void RbNoti3_CheckedChanged(object sender, EventArgs e)
        {
            DtpAlarma1.Enabled = true;
            DtpAlarma2.Enabled = true;
            DtpAlarma3.Enabled = true;
        }

        private void BtnEstablecerNotis_Click(object sender, EventArgs e)
        {
            if (RbNoti1.Checked)
            {
                _notificacionesDiarias.HoraAlarma1 = DtpAlarma1.Value.Hour.ToString("00");
                _notificacionesDiarias.MinutoAlarma1 = DtpAlarma1.Value.Minute.ToString("00");
            }
            else
            {
                if (RbNoti2.Checked)
                {
                    _notificacionesDiarias.HoraAlarma1 = DtpAlarma1.Value.Hour.ToString();
                    _notificacionesDiarias.MinutoAlarma1 = DtpAlarma1.Value.Minute.ToString();

                    _notificacionesDiarias.HolaAlarma2 = DtpAlarma2.Value.Hour.ToString();
                    _notificacionesDiarias.MinutoAlarma2 = DtpAlarma2.Value.Minute.ToString();

                }
                else
                {
                    _notificacionesDiarias.HoraAlarma1 = DtpAlarma1.Value.Hour.ToString();
                    _notificacionesDiarias.MinutoAlarma1 = DtpAlarma1.Value.Minute.ToString();

                    _notificacionesDiarias.HolaAlarma2 = DtpAlarma2.Value.Hour.ToString();
                    _notificacionesDiarias.MinutoAlarma2 = DtpAlarma2.Value.Minute.ToString();

                    _notificacionesDiarias.HolaAlarma3 = DtpAlarma3.Value.Hour.ToString();
                    _notificacionesDiarias.MinutoAlarma3 = DtpAlarma3.Value.Minute.ToString();


                }
            }
            _negnotificacionesDiarias.InsertHoraAlarmas(_notificacionesDiarias);
            _notificacionesGTR.ActivarTmrAlarma();
        }

        private void RbTodos_CheckedChanged(object sender, EventArgs e)
        {
            if (RbTodos.Checked)
            {
                ChkLunes.Checked = true;
                ChkMartes.Checked = true;
                ChkMiercoles.Checked = true;
                ChkJueves.Checked = true;
                ChkViernes.Checked = true;
                ChkSabado.Checked = true;
                ChkDomingo.Checked = true;

                TodosChecked = true;
            }
            else
            {
                ChkLunes.Checked = false;
                ChkMartes.Checked = false;
                ChkMiercoles.Checked = false;
                ChkJueves.Checked = false;
                ChkViernes.Checked = false;
                ChkSabado.Checked = false;
                ChkDomingo.Checked = false;
            }
        }

    }
}