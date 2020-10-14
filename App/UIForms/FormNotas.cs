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

namespace Cristela
{
    public partial class FormNotas : Form
    {
        #region Instancias
        private Notas _objNotas;
        private NegNotas _objNegNotas;

        #endregion
        public FormNotas()
        {
            InitializeComponent();
            _objNotas = new Notas();
            _objNegNotas = new NegNotas();
            EnlistarNotas();
        }

        #region Variables
        private string Buscar;

        #endregion


        #region Confirmación de Nota Guardada

        //public void IconoNotificacion()
        //{
        //    NotifIcon.BalloonTipTitle = mTítuloDeIcono;
        //    NotifIcon.BalloonTipText = mMensajeDeIcono;
        //    NotifIcon.BalloonTipIcon = ToolTipIcon.Info;
        //    NotifIcon.Visible = true;
        //    NotifIcon.ShowBalloonTip(1500);
        //}

        //private void timerNotif_Tick(object sender, EventArgs e)
        //{
        //    conteo++;
        //    lblConteo.Text = Convert.ToString(conteo);
        //    if (lblConteo.Text == "1")
        //    {
        //        IconoNotificacion();
        //        timerNotif.Stop();
        //    }
        //}

        #endregion

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TxtTitulo.Text) ||
                string.IsNullOrWhiteSpace(TxtNota.Text))
            {
                MessageBox.Show("Para guardar nota debe completar todos los campos requeridos","Campos vacíos", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                _objNotas.TituloNota = TxtTitulo.Text;
                _objNotas.MsjNota = TxtNota.Text;
                _objNotas.FechaNota = DateTime.Now;

                _objNegNotas.SaveNota(_objNotas);
                EnlistarNotas();
            }
        }

        private void EnlistarNotas()
        {
            DTGVNotas.Rows.Clear();
            DataSet ds = _objNegNotas.GetNotas(Buscar);
            if (ds.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    DTGVNotas.Rows.Add(dr[1].ToString(), dr[2]);
                }
            }
        }

        private void TxtFiltro_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                Buscar = TxtFiltro.Text;
                EnlistarNotas();
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

    }
}