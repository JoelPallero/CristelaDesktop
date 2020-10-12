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

namespace UIForms
{
    public partial class FormConfiguracion : Form
    {

        private NegMovimientos _negMovimientos = new NegMovimientos();
        private Movimientos _movimientos = new Movimientos();

        public FormConfiguracion()
        {
            InitializeComponent();
        }

        #region Variables

        private bool vacio;
        private string accion = string.Empty;

        #endregion

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

        private void BtnSave_Click(object sender, EventArgs e)
        {
            ValidarCamposVacios();
            if (vacio == false)
            {

            }
            else
            {
                MessageBox.Show("No puede haber campos vacíos. Si no registras dato en algún campo, puedes utilizar el 0", "Campos vacíos", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (RbPeriodo.Checked)
            {

            }
            else
            {
                if (RbOrigen.Checked)
                {
                    if (RbTodo.Checked)
                    {
                        accion = "Todo";
                    }
                    else
                    {
                        if (RbMovimientos.Checked)
                        {
                            accion = "Movimientos";
                        }
                        else
                        {
                            if (RbSaldos.Checked)
                            {
                                accion = "Saldos";
                            }
                            else
                            {
                                MessageBox.Show("Tienes que seleccionar los datos que deseas borrar.", "Sin datos seleccionados");
                            }
                        }
                    }


                }
            }
        }
    }
}
