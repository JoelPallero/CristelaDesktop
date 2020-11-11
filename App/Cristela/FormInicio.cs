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
        #region Instancias

        private ActualizacionDeSaldoFinal _actualizacionDeSaldoFinal = new ActualizacionDeSaldoFinal();
        private NotificacionesGTR _notificacionesGTR = new NotificacionesGTR();

        #endregion

        #region Loading

        public FormInicio()
        {
            InitializeComponent();
            CargaDeSaldo();
            CambioDeColor();
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
        public bool FormHided;

        #endregion

        #region Close Minimized

        private void BtnClose_Click(object sender, EventArgs e)
        {
            FormHided = true;
            this.Hide();
        }

        private void BtnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        #endregion

        #region Actualización de datos.
        private void FormSaldosFinales_NotificarCambios(object sender, ActualizacionDeSaldo e)
        {
            BarSaldoActual.Text = e.SaldoFinal.ToString();
            BarGastoPermitido.Text = e.PermitidoFinal.ToString() + "/" + GastoPermitido.ToString();
            CambioDeColor();
            EnlistadoDTGV();
        }

        private void FormConfigSaldos_NotificarCambios(object sender, ActualizacionDeSaldo e)
        {
            SaldoEmergencia = e.SaldoDeEmergencia;
            SaldoCritico = e.SaldoDeCritico;
            GastoPermitido = e.SaldoPermitido;
            BarSaldoActual.Text = e.SaldoFinal.ToString();
            BarGastoPermitido.Text = e.PermitidoFinal.ToString() + "/" + GastoPermitido.ToString();
            CambioDeColor();
            EnlistadoDTGV();
        }

        #endregion

        #region Métodos        

        private void CargaDeSaldo()
        {
            _actualizacionDeSaldoFinal.GetSaldoActual();
            _actualizacionDeSaldoFinal.GetSaldos();
            SaldoEmergencia = _actualizacionDeSaldoFinal.Emergencia;
            SaldoCritico = _actualizacionDeSaldoFinal.Critico;
            GastoPermitido = _actualizacionDeSaldoFinal.SaldoPermitido;
            BarSaldoActual.Text = string.Format("{0:n}", _actualizacionDeSaldoFinal.SaldoActual);
            BarGastoPermitido.Text = _actualizacionDeSaldoFinal.PermitidoActual.ToString() + "/" + GastoPermitido.ToString();
            CambioDeColor();
        }

        private void CambioDeColor()
        {
            if (Convert.ToDecimal(BarSaldoActual.Text) > SaldoEmergencia)
            {
                BarSaldoActual.ProgressColor = Color.LawnGreen;
                BarSaldoActual.OuterColor = Color.LawnGreen;
            }
            else
            {
                if (Convert.ToDecimal(BarSaldoActual.Text) <= SaldoCritico)
                {
                    BarSaldoActual.ProgressColor = Color.Red;
                    BarSaldoActual.OuterColor = Color.Red;
                }
                else
                {
                    BarSaldoActual.ProgressColor = Color.Orange;
                    BarSaldoActual.OuterColor = Color.Orange;
                }
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
            hijoConEvento.NotificarCambios += FormConfigSaldos_NotificarCambios;

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
            if (FormHided == true)
            {
                this.Show();
            }
            ClickMovimientos();

            // Crear la instancia
            var hijoConEvento = new FormMovimientos();
            // Suscripción al evento
            hijoConEvento.NotificarCambios += FormSaldosFinales_NotificarCambios;

            AbrirFormHijo(formHijo: hijoConEvento);
            FormHided = false;
        }

        private void BtnAgenda_Click(object sender, EventArgs e)
        {
            ClickAgenda();
            // Crear la instancia
            var hijoConEvento = new FormPagosAgendados();
            // Suscripción al evento
            hijoConEvento.NotificarCambios += FormSaldosFinales_NotificarCambios;

            AbrirFormHijo(formHijo: hijoConEvento);
            FormHided = false;
        }

        private void BtnNotas_Click(object sender, EventArgs e)
        {
            FormNotas _formNotas = new FormNotas();
            _formNotas.ShowDialog();
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
            string DiaActual = Application.CurrentCulture.DateTimeFormat.GetDayName(DateTime.Now.DayOfWeek).ToString();
            string HoraActual = DateTime.Now.Hour.ToString();
            string MinutoACtual = DateTime.Now.Minute.ToString();

            _notificacionesGTR.ConsultaDeAlarma();

            
        }

        private void MostrarNotificacion()
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
                hijoConEvento.NotificarCambios += FormSaldosFinales_NotificarCambios;

                AbrirFormHijo(formHijo: hijoConEvento);
            }
            CambioDeColor();
        }

        
        private void DtgMovFinal_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ToString() != string.Empty)
            {
                DtgMovFinal.ShowCellToolTips = true;
            }
            else
            {
                DtgMovFinal.ShowCellToolTips = false;
            }
        }
    }
}