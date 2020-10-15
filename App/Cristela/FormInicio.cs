using BusinessLogicLayer;
using Entities;
using System;
using System.Data;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Cristela
{
    public partial class FormInicio : Form
    {
        #region Instanciamientos de Clases

        private SaldosEstablecidos _objSaldosEstablecidos = new SaldosEstablecidos();
        private readonly NegSaldosEstablecidos _objNegSaldosEstablecidos = new NegSaldosEstablecidos();
        private Movimientos _objMovimientos = new Movimientos();
        private readonly NegMovimientos _objNegMovimientos = new NegMovimientos();
        private ActualizacionDeSaldoFinal _actualizacionDeSaldoFinal = new ActualizacionDeSaldoFinal();
        private NotificacionesGTR _notificacionesGTR = new NotificacionesGTR();

        #endregion

        #region Load

        public FormInicio()
        {
            InitializeComponent();
            CargaDeSaldo();
            ClickInicio();
            EnlistadoDTGV();
        }

        public void FormInicio_Load(object sender, EventArgs e)
        {
            CargaDeSaldo();
            EnlistadoDTGV();
        }

        #endregion

        #region Variables

        ////Saldos Preestablecidos
        private decimal SaldoEmergencia;
        private decimal SaldoCritico;
        private decimal GastoPermitido;



        //Form Notas Abierto
        public bool NotaAbierta;

        #endregion

        #region Close Minimized

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void BtnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        #endregion

        #region Métodos

        private void formSaldosFinales_NotificarCambios(object sender, ActualizacionDeSaldo e)
        {
            LblSaldoActual.Text = e.SaldoFinal.ToString("G29");
            LblGastoPermitido.Text = e.PermitidoFinal.ToString("G29") + "/" + GastoPermitido.ToString("G29");
            EnlistadoDTGV();
        }

        private void formConfigSaldos_NotificarCambios(object sender, ActualizacionDeSaldo e)
        {
            SaldoEmergencia = e.SaldoDeEmergencia;
            SaldoCritico = e.SaldoDeCritico;
            GastoPermitido = e.SaldoPermitido;

            LblSaldoActual.Text = e.SaldoFinal.ToString("G29");
            LblGastoPermitido.Text = e.PermitidoFinal.ToString("G29") + "/" + GastoPermitido.ToString("G29");

            EnlistadoDTGV();
        }

        private void CargaDeSaldo()
        {
            _actualizacionDeSaldoFinal.GetSaldoActual();

            _actualizacionDeSaldoFinal.GetSaldos();
            SaldoEmergencia = _actualizacionDeSaldoFinal.Emergencia;
            SaldoCritico = _actualizacionDeSaldoFinal.Critico;
            GastoPermitido = _actualizacionDeSaldoFinal.SaldoPermitido;

            LblSaldoActual.Text = _actualizacionDeSaldoFinal.SaldoActual.ToString("G29");
            LblGastoPermitido.Text = _actualizacionDeSaldoFinal.PermitidoActual.ToString("G29") + "/" + GastoPermitido.ToString("G29");

        }

        private void LblSaldoActual_TextChanged(object sender, EventArgs e)
        {

        }

        private void EnlistadoDTGV()
        {
            DtgMovFinal.Rows.Clear();
            _actualizacionDeSaldoFinal.CargarListaDemovimientos();
            if (_actualizacionDeSaldoFinal.DsTablaDeMovimientos.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow dr in _actualizacionDeSaldoFinal.DsTablaDeMovimientos.Tables[0].Rows)
                {
                    DtgMovFinal.Rows.Add(dr[1].ToString(), dr[2], dr[3], dr[4], dr[5], dr[6]);
                }

                lblTitulo.Text = "Movimientos Registrados";
            }
        }

        public void ClickInicio()
        {
            MostrarInicio();
            EnlistadoDTGV();
            lblTitulo.Text = "Movimientos";
            BtnInicio.BackColor = Color.BurlyWood;
            BtnInicio.ForeColor = Color.SaddleBrown;
            BtnMovimientos.BackColor = Color.Transparent;
            BtnMovimientos.ForeColor = Color.FromArgb(60, 60, 60);
            BtnAgenda.BackColor = Color.Transparent;
            BtnAgenda.ForeColor = Color.FromArgb(60, 60, 60);
            BtnNotas.BackColor = Color.Transparent;
            BtnNotas.ForeColor = Color.FromArgb(60, 60, 60);
            BtnAjustes.BackColor = Color.Transparent;
            BtnAjustes.ForeColor = Color.FromArgb(60, 60, 60);
        }
        public void ClickMovimientos()
        {
            OcultarInicio();
            lblTitulo.Text = "Agregar Movimientos";
            BtnInicio.BackColor = Color.Transparent;
            BtnInicio.ForeColor = Color.FromArgb(60, 60, 60);
            BtnMovimientos.BackColor = Color.CornflowerBlue;
            BtnMovimientos.ForeColor = Color.White;
            BtnAgenda.BackColor = Color.Transparent;
            BtnAgenda.ForeColor = Color.FromArgb(60, 60, 60);
            BtnNotas.BackColor = Color.Transparent;
            BtnNotas.ForeColor = Color.FromArgb(60, 60, 60);
            BtnAjustes.BackColor = Color.Transparent;
            BtnAjustes.ForeColor = Color.FromArgb(60, 60, 60);
        }

        private void ClickAgenda()
        {
            OcultarInicio();
            lblTitulo.Text = "Agenda";
            BtnInicio.BackColor = Color.Transparent;
            BtnInicio.ForeColor = Color.FromArgb(60, 60, 60);
            BtnMovimientos.BackColor = Color.Transparent;
            BtnMovimientos.ForeColor = Color.FromArgb(60, 60, 60);
            BtnAgenda.BackColor = Color.LightGreen;
            BtnAgenda.ForeColor = Color.DarkGreen;
            BtnNotas.BackColor = Color.Transparent;
            BtnNotas.ForeColor = Color.FromArgb(60, 60, 60);
            BtnAjustes.BackColor = Color.Transparent;
            BtnAjustes.ForeColor = Color.FromArgb(60, 60, 60);
        }

        public void ClickAjustes()
        {
            // Crear la instancia
            var hijoConEvento = new FormConfiguracion();
            // Suscripción al evento
            hijoConEvento.NotificarCambios += formConfigSaldos_NotificarCambios;

            hijoConEvento.ShowDialog();
        }

        private void AbrirFormHijo(object formHijo)
        {
            if (this.pnlForms.Controls.Count > 0)
            {
                this.pnlForms.Controls.RemoveAt(0);
            }
            Form fh = formHijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.pnlForms.Controls.Add(fh);
            this.pnlForms.Tag = fh;
            fh.Show();
        }

        private void OcultarInicio()
        {
            DtgMovFinal.Visible = false;
            TxtFiltro.Visible = false;
            PicFiltro.Visible = false;
            pnlForms.Visible = true;
        }

        private void MostrarInicio()
        {
            DtgMovFinal.Visible = true;
            TxtFiltro.Visible = true;
            PicFiltro.Visible = true;
            pnlForms.Visible = false;
        }

        #endregion

        #region Menú

        private void BtnInicio_Click(object sender, EventArgs e)
        {
            ClickInicio();
        }

        private void BtnMovimientos_Click(object sender, EventArgs e)
        {
            ClickMovimientos();

            // Crear la instancia
            var hijoConEvento = new FormMovimientos();
            // Suscripción al evento
            hijoConEvento.NotificarCambios += formSaldosFinales_NotificarCambios;

            AbrirFormHijo(formHijo: hijoConEvento);
        }

        private void BtnAgenda_Click(object sender, EventArgs e)
        {
            ClickAgenda();
            AbrirFormHijo(formHijo: new FormPagosAgendados());
        }

        private void BtnNotas_Click(object sender, EventArgs e)
        {
            if (NotaAbierta == false)
            {
                FormNotas _formNotas = new FormNotas();
                _formNotas.ShowDialog();
                NotaAbierta = true;
            }
        }

        private void BtnAjustes_Click(object sender, EventArgs e)
        {
            ClickAjustes();
        }

        #endregion

        #region Filtro
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

        #region Arrastrar Form

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void PnlTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }



        #endregion

        private void ExitCristela_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void TmrAlarma_Tick(object sender, EventArgs e)
        {
            string diaActual = Application.CurrentCulture.DateTimeFormat.GetDayName(DateTime.Now.DayOfWeek).ToString();
            string horaActual = DateTime.Now.Hour.ToString();
            string minutoACtual = DateTime.Now.Minute.ToString();

            _notificacionesGTR.ConsultaDeAlarma();

            if (horaActual == _notificacionesGTR.horas && minutoACtual == _notificacionesGTR.minutos)
            {
                mostrarNotificacion();
                TmrAlarma.Stop();
            }
        }

        private void mostrarNotificacion()
        {
            ConsultaNuevosMov.Visible = true;
            ConsultaNuevosMov.ShowBalloonTip(5000);
        }

        private void ConsultaNuevosMov_BalloonTipShown(object sender, EventArgs e)
        {
            ConsultaNuevosMov.ShowBalloonTip(8000);
        }

        private void ConsultaNuevosMov_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                MenuSalirIcono.Show();
            }
            else
            {
                ClickMovimientos();

                // Crear la instancia
                var hijoConEvento = new FormMovimientos();
                // Suscripción al evento
                hijoConEvento.NotificarCambios += formSaldosFinales_NotificarCambios;

                AbrirFormHijo(formHijo: hijoConEvento);
            }
            ColorDeAviso();
        }

        private void ColorDeAviso()
        {
            if (_actualizacionDeSaldoFinal.SaldoActual > SaldoEmergencia)
            {
                LblSaldoActual.BackColor = Color.LawnGreen;
            }
            else
            {
                if (_actualizacionDeSaldoFinal.SaldoActual <= SaldoCritico)
                {
                    LblSaldoActual.BackColor = Color.Red;
                }
                else
                {
                    LblSaldoActual.BackColor = Color.Orange;
                }
            }
        }
    }
}