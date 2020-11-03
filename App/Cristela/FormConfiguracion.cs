using BusinessLogicLayer;
using Entities;
using System;
using System.Windows.Forms;

namespace Cristela
{
    public partial class FormConfiguracion : Form
    {
        #region instancias

        private NegMovimientos _negMovimientos;
        private Movimientos _movimientos;
        private SaldosEstablecidos _saldosEstablecidos;
        private NegSaldosEstablecidos _negSaldosEstablecidos;
        private ActualizacionDeSaldoFinal _actualizacionDeSaldoFinal;
        private NotificacionesDiarias _notificacionesDiarias;
        private NegnotificacionesDiarias _negnotificacionesDiarias;
        private NotificacionesGTR _notificacionesGTR;

        public event EventHandler<ActualizacionDeSaldo> NotificarCambios;
        #endregion

        #region Loading
        public FormConfiguracion()
        {
            InitializeComponent();
            _negMovimientos = new NegMovimientos();
            _movimientos = new Movimientos();
            _saldosEstablecidos = new SaldosEstablecidos();
            _negSaldosEstablecidos = new NegSaldosEstablecidos();
            _actualizacionDeSaldoFinal = new ActualizacionDeSaldoFinal();
            _notificacionesDiarias = new NotificacionesDiarias();
            _negnotificacionesDiarias = new NegnotificacionesDiarias();
            _notificacionesGTR = new NotificacionesGTR();
        }

        private void FormConfiguracion_Load(object sender, EventArgs e)
        {
            MostrarSaldos();
        }

        #endregion

        #region Variables

        private bool vacio;
        private string accion = string.Empty;
        private DateTime FechaDesde;
        private DateTime FechaHasta;
        private bool TodosChecked;

        #endregion

        #region Métodos

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

        #endregion

        #region Métodos Para actualizar en TR

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

        protected virtual void OnNotificarCambios(object sender, ActualizacionDeSaldo e)
        {
            NotificarCambios?.Invoke(sender, e);
        }

        #endregion

        #region Eventos

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
            DialogResult dialogResult = MessageBox.Show("Va a eliminar datos de manera permanente. " +
                "¿Está seguro que quieres eliminarlos permanentemente?",
                "ADVERTENCIA", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (dialogResult == DialogResult.Yes)
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
        }

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
            if (RbNoti3.Checked)
            {
                InsertarAlarma1();
                InsertarAlarma2();
                InsertarAlarma3();
            }
            else
            {
                if (RbNoti2.Checked)
                {
                    InsertarAlarma1();
                    InsertarAlarma2();
                }
                else
                {
                    InsertarAlarma1();
                }
            }
        }

        private void InsertarAlarma1()
        {
            _notificacionesDiarias.HoraAlarma = DtpAlarma1.Value;
            _negnotificacionesDiarias.InsertHoraAlarmas(_notificacionesDiarias);
        }
        private void InsertarAlarma2()
        {
            _notificacionesDiarias.HoraAlarma = DtpAlarma2.Value;
            _negnotificacionesDiarias.InsertHoraAlarmas(_notificacionesDiarias);
        }
        private void InsertarAlarma3()
        {
            _notificacionesDiarias.HoraAlarma = DtpAlarma3.Value;
            _negnotificacionesDiarias.InsertHoraAlarmas(_notificacionesDiarias);
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

        #endregion
    }
}