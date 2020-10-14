using BusinessLogicLayer;
using Entities;
using FrontEndLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UIForms
{
    public partial class FormConfiguracion : Form
    {

        private NegMovimientos _negMovimientos = new NegMovimientos();
        private Movimientos _movimientos = new Movimientos();
        private SaldosEstablecidos _saldosEstablecidos = new SaldosEstablecidos();
        private NegSaldosEstablecidos _negSaldosEstablecidos = new NegSaldosEstablecidos();
        private ActualizacionDeSaldoFinal actualizacionDeSaldoFinal = new ActualizacionDeSaldoFinal();

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

        #endregion

        private void MostrarSaldos()
        {
            _saldosEstablecidos = _negSaldosEstablecidos.ConsultarSaldosEstablecidos();
            LblEmergenciaActual.Text = "$" + Convert.ToString(_saldosEstablecidos.SaldoEmergencia);
            LblCriticoActual.Text = "$" + Convert.ToString(_saldosEstablecidos.SaldoCritico);
            LblPermitidoActual.Text = "$" + Convert.ToString(_saldosEstablecidos.GastoPermitido);
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
                    MessageBox.Show("No se ha seleccionado ningún item. Seleccione lo que quiera borrar.", "Seleccionar dato a borrar",MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            MostrarSaldos();
            vacio = false;
            actualizacionDeSaldoFinal.GetSaldoActual();
            actualizacionDeSaldoFinal.GetSaldos();


            var ActualizarSaldo = new ActualizacionDeSaldo()
            {
                SaldoFinal = actualizacionDeSaldoFinal.SaldoActual,
                PermitidoFinal = actualizacionDeSaldoFinal.PermitidoActual,
                SaldoDeEmergencia = actualizacionDeSaldoFinal.Emergencia,
                SaldoDeCritico = actualizacionDeSaldoFinal.Critico,
                SaldoPermitido = actualizacionDeSaldoFinal.SaldoPermitido
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

    }
}