using BusinessLogicLayer;
using Entities;
using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace FrontEndLayer
{
    public partial class FormInicio : Form
    {
        #region Instanciamientos de Clases

        private SaldosEstablecidos _objSaldosEstablecidos;
        private readonly NegSaldosEstablecidos _objNegSaldosEstablecidos;
        private Movimientos _objMovimientos;
        private readonly NegMovimientos _objNegMovimientos;

        #endregion

        #region Load

        public FormInicio()
        {
            InitializeComponent();

            _objNegSaldosEstablecidos = new NegSaldosEstablecidos();
            _objSaldosEstablecidos = new SaldosEstablecidos();
            _objMovimientos = new Movimientos();
            _objNegMovimientos = new NegMovimientos();

            ClickInicio();
        }

        public void FormInicio_Load(object sender, EventArgs e)
        {
            CargaDeSaldo();
            EnlistadoDTGV();
        }

        #endregion

        #region Variables
        ////publicas de Actualización de saldo
        private decimal SaldoActual;


        ////Saldos Preestablecidos
        private decimal SaldoEmergencia;
        private decimal SaldoCritico;
        private decimal GastoPermitido;
        private int GastoPermitidoEntero;

        private string Buscar = string.Empty;

        #endregion

        #region Close Minimized

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        #endregion

        #region Métodos Generales Encapsulados


        public void CargaDeSaldo()
        {
            _objMovimientos = _objNegMovimientos.ConsultarSaldo(_objMovimientos);
            SaldoActual = _objMovimientos.SaldoActual;
            _objSaldosEstablecidos = _objNegSaldosEstablecidos.ConsultarSaldosEstablecidos();
            SaldoEmergencia = _objSaldosEstablecidos.SaldoEmergencia;
            SaldoCritico = _objSaldosEstablecidos.SaldoCritico;
            if (_objSaldosEstablecidos.GastoPermitido >= 0)
            {
                GastoPermitidoEntero = Convert.ToInt32(_objSaldosEstablecidos.GastoPermitido);
                LblGastoPermitido.Text = "0" + "/" + Convert.ToString(GastoPermitidoEntero);
            }
            else
            {
                GastoPermitido = _objSaldosEstablecidos.GastoPermitido; 
                LblGastoPermitido.Text = "0" + "/" + Convert.ToString(GastoPermitido);

            }

            LblSaldoActual.Text = "$" + Convert.ToString(SaldoActual);

            if (SaldoActual > SaldoEmergencia)
            {
                LblSaldoActual.BackColor = Color.LawnGreen;
            }
            else
            {
                if (SaldoActual <= SaldoCritico)
                {
                    LblSaldoActual.BackColor = Color.Red;
                }
                else
                {
                    LblSaldoActual.BackColor = Color.Orange;
                }
            }
            
            LblSaldoActual.Refresh();
        }

        private void EnlistadoDTGV()
        {
            DtgMovFinal.Rows.Clear();
            DataSet ds = _objNegMovimientos.MovementsList(Buscar);
            if (ds.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    DtgMovFinal.Rows.Add(dr[1].ToString(), dr[2], dr[3], dr[4], dr[5], dr[6]);
                }

                lblTitulo.Text = "Movimientos Registrados";
            }
            else
            {
                //lblTitulo.Text = "No hay movimientos guardados";
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
            BtnInicio.ForeColor = Color.FromArgb(60, 60 ,60);
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
            //FormConfiguracion _formConfiguracion = new FormConfiguracion();
            //_formConfiguracion.ShowDialog();
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
            AbrirFormHijo(formHijo: new FormMovimientos());
        }

        private void BtnAgenda_Click(object sender, EventArgs e)
        {
            ClickAgenda();
        }

        private void BtnNotas_Click(object sender, EventArgs e)
        {
            //FormNotas _formNotas = new FormNotas();
            //_formNotas.ShowDialog();

            AbrirFormHijo(formHijo: new FormNotas());
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
                Buscar = TxtFiltro.Text;
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

    }
}