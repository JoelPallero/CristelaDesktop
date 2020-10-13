namespace UIForms
{
    partial class FormConfiguracion
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TabBorrarDatos = new System.Windows.Forms.TabControl();
            this.TabSaldos = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.BtnSave = new System.Windows.Forms.Button();
            this.TxtEmergencia = new System.Windows.Forms.TextBox();
            this.TxtPermitido = new System.Windows.Forms.TextBox();
            this.TxtCritico = new System.Windows.Forms.TextBox();
            this.LblEmergencia = new System.Windows.Forms.Label();
            this.LblPermitido = new System.Windows.Forms.Label();
            this.LblCritico = new System.Windows.Forms.Label();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.RbPeriodo = new System.Windows.Forms.RadioButton();
            this.RbOrigen = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.DtDesde = new System.Windows.Forms.DateTimePicker();
            this.DtHasta = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.RbTodo = new System.Windows.Forms.RadioButton();
            this.RbMovimientos = new System.Windows.Forms.RadioButton();
            this.RbSaldos = new System.Windows.Forms.RadioButton();
            this.SaldosActuales = new System.Windows.Forms.GroupBox();
            this.LblEmergenciaActual = new System.Windows.Forms.Label();
            this.LblCriticoActual = new System.Windows.Forms.Label();
            this.LblPermitidoActual = new System.Windows.Forms.Label();
            this.TabBorrarDatos.SuspendLayout();
            this.TabSaldos.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SaldosActuales.SuspendLayout();
            this.SuspendLayout();
            // 
            // TabBorrarDatos
            // 
            this.TabBorrarDatos.Controls.Add(this.TabSaldos);
            this.TabBorrarDatos.Controls.Add(this.tabPage2);
            this.TabBorrarDatos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabBorrarDatos.Location = new System.Drawing.Point(0, 0);
            this.TabBorrarDatos.Name = "TabBorrarDatos";
            this.TabBorrarDatos.SelectedIndex = 0;
            this.TabBorrarDatos.Size = new System.Drawing.Size(384, 211);
            this.TabBorrarDatos.TabIndex = 0;
            // 
            // TabSaldos
            // 
            this.TabSaldos.Controls.Add(this.SaldosActuales);
            this.TabSaldos.Controls.Add(this.LblCritico);
            this.TabSaldos.Controls.Add(this.LblPermitido);
            this.TabSaldos.Controls.Add(this.LblEmergencia);
            this.TabSaldos.Controls.Add(this.TxtCritico);
            this.TabSaldos.Controls.Add(this.TxtPermitido);
            this.TabSaldos.Controls.Add(this.TxtEmergencia);
            this.TabSaldos.Controls.Add(this.BtnSave);
            this.TabSaldos.Location = new System.Drawing.Point(4, 22);
            this.TabSaldos.Name = "TabSaldos";
            this.TabSaldos.Padding = new System.Windows.Forms.Padding(3);
            this.TabSaldos.Size = new System.Drawing.Size(376, 185);
            this.TabSaldos.TabIndex = 0;
            this.TabSaldos.Text = "Establecer Saldos";
            this.TabSaldos.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.DtHasta);
            this.tabPage2.Controls.Add(this.DtDesde);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.RbOrigen);
            this.tabPage2.Controls.Add(this.RbPeriodo);
            this.tabPage2.Controls.Add(this.BtnDelete);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(376, 185);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Borrar Datos";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // BtnSave
            // 
            this.BtnSave.BackColor = System.Drawing.SystemColors.Highlight;
            this.BtnSave.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BtnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSave.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.BtnSave.Location = new System.Drawing.Point(3, 139);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(370, 43);
            this.BtnSave.TabIndex = 62;
            this.BtnSave.Text = "Establecer Importes";
            this.BtnSave.UseVisualStyleBackColor = false;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // TxtEmergencia
            // 
            this.TxtEmergencia.Location = new System.Drawing.Point(134, 24);
            this.TxtEmergencia.Name = "TxtEmergencia";
            this.TxtEmergencia.Size = new System.Drawing.Size(100, 20);
            this.TxtEmergencia.TabIndex = 63;
            // 
            // TxtPermitido
            // 
            this.TxtPermitido.Location = new System.Drawing.Point(134, 96);
            this.TxtPermitido.Name = "TxtPermitido";
            this.TxtPermitido.Size = new System.Drawing.Size(100, 20);
            this.TxtPermitido.TabIndex = 64;
            // 
            // TxtCritico
            // 
            this.TxtCritico.Location = new System.Drawing.Point(134, 60);
            this.TxtCritico.Name = "TxtCritico";
            this.TxtCritico.Size = new System.Drawing.Size(100, 20);
            this.TxtCritico.TabIndex = 65;
            // 
            // LblEmergencia
            // 
            this.LblEmergencia.AutoSize = true;
            this.LblEmergencia.Location = new System.Drawing.Point(9, 30);
            this.LblEmergencia.Name = "LblEmergencia";
            this.LblEmergencia.Size = new System.Drawing.Size(113, 13);
            this.LblEmergencia.TabIndex = 66;
            this.LblEmergencia.Text = "Saldo De Emergencia:";
            // 
            // LblPermitido
            // 
            this.LblPermitido.AutoSize = true;
            this.LblPermitido.Location = new System.Drawing.Point(9, 96);
            this.LblPermitido.Name = "LblPermitido";
            this.LblPermitido.Size = new System.Drawing.Size(84, 13);
            this.LblPermitido.TabIndex = 67;
            this.LblPermitido.Text = "Gasto Permitido:";
            // 
            // LblCritico
            // 
            this.LblCritico.AutoSize = true;
            this.LblCritico.Location = new System.Drawing.Point(9, 63);
            this.LblCritico.Name = "LblCritico";
            this.LblCritico.Size = new System.Drawing.Size(71, 13);
            this.LblCritico.TabIndex = 68;
            this.LblCritico.Text = "Saldo Crítico:";
            // 
            // BtnDelete
            // 
            this.BtnDelete.BackColor = System.Drawing.SystemColors.Highlight;
            this.BtnDelete.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BtnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDelete.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.BtnDelete.Location = new System.Drawing.Point(3, 139);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(370, 43);
            this.BtnDelete.TabIndex = 63;
            this.BtnDelete.Text = "Eliminar Datos Seleccionados";
            this.BtnDelete.UseVisualStyleBackColor = false;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // RbPeriodo
            // 
            this.RbPeriodo.AutoSize = true;
            this.RbPeriodo.Location = new System.Drawing.Point(67, 25);
            this.RbPeriodo.Name = "RbPeriodo";
            this.RbPeriodo.Size = new System.Drawing.Size(93, 17);
            this.RbPeriodo.TabIndex = 64;
            this.RbPeriodo.Text = "Borrar período";
            this.RbPeriodo.UseVisualStyleBackColor = true;
            this.RbPeriodo.CheckedChanged += new System.EventHandler(this.RbPeriodo_CheckedChanged);
            // 
            // RbOrigen
            // 
            this.RbOrigen.AutoSize = true;
            this.RbOrigen.Checked = true;
            this.RbOrigen.Location = new System.Drawing.Point(200, 25);
            this.RbOrigen.Name = "RbOrigen";
            this.RbOrigen.Size = new System.Drawing.Size(109, 17);
            this.RbOrigen.TabIndex = 65;
            this.RbOrigen.TabStop = true;
            this.RbOrigen.Text = "Desde el principio";
            this.RbOrigen.UseVisualStyleBackColor = true;
            this.RbOrigen.CheckedChanged += new System.EventHandler(this.RbOrigen_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(115, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 13);
            this.label1.TabIndex = 68;
            this.label1.Text = "Seleccionar modo de borrado";
            // 
            // DtDesde
            // 
            this.DtDesde.Enabled = false;
            this.DtDesde.Location = new System.Drawing.Point(26, 67);
            this.DtDesde.Name = "DtDesde";
            this.DtDesde.Size = new System.Drawing.Size(158, 20);
            this.DtDesde.TabIndex = 69;
            // 
            // DtHasta
            // 
            this.DtHasta.Enabled = false;
            this.DtHasta.Location = new System.Drawing.Point(26, 105);
            this.DtHasta.Name = "DtHasta";
            this.DtHasta.Size = new System.Drawing.Size(158, 20);
            this.DtHasta.TabIndex = 70;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 71;
            this.label2.Text = "Hasta:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 72;
            this.label3.Text = "Desde:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.RbSaldos);
            this.groupBox1.Controls.Add(this.RbMovimientos);
            this.groupBox1.Controls.Add(this.RbTodo);
            this.groupBox1.Location = new System.Drawing.Point(207, 48);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(149, 85);
            this.groupBox1.TabIndex = 73;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Seleccionar Datos a borrar";
            // 
            // RbTodo
            // 
            this.RbTodo.AutoSize = true;
            this.RbTodo.Location = new System.Drawing.Point(35, 19);
            this.RbTodo.Name = "RbTodo";
            this.RbTodo.Size = new System.Drawing.Size(50, 17);
            this.RbTodo.TabIndex = 68;
            this.RbTodo.TabStop = true;
            this.RbTodo.Text = "Todo";
            this.RbTodo.UseVisualStyleBackColor = true;
            this.RbTodo.CheckedChanged += new System.EventHandler(this.RbTodo_CheckedChanged);
            // 
            // RbMovimientos
            // 
            this.RbMovimientos.AutoSize = true;
            this.RbMovimientos.Location = new System.Drawing.Point(35, 42);
            this.RbMovimientos.Name = "RbMovimientos";
            this.RbMovimientos.Size = new System.Drawing.Size(84, 17);
            this.RbMovimientos.TabIndex = 69;
            this.RbMovimientos.TabStop = true;
            this.RbMovimientos.Text = "Movimientos";
            this.RbMovimientos.UseVisualStyleBackColor = true;
            this.RbMovimientos.CheckedChanged += new System.EventHandler(this.RbMovimientos_CheckedChanged);
            // 
            // RbSaldos
            // 
            this.RbSaldos.AutoSize = true;
            this.RbSaldos.Location = new System.Drawing.Point(35, 64);
            this.RbSaldos.Name = "RbSaldos";
            this.RbSaldos.Size = new System.Drawing.Size(57, 17);
            this.RbSaldos.TabIndex = 70;
            this.RbSaldos.TabStop = true;
            this.RbSaldos.Text = "Saldos";
            this.RbSaldos.UseVisualStyleBackColor = true;
            this.RbSaldos.CheckedChanged += new System.EventHandler(this.RbSaldos_CheckedChanged);
            // 
            // SaldosActuales
            // 
            this.SaldosActuales.Controls.Add(this.LblPermitidoActual);
            this.SaldosActuales.Controls.Add(this.LblCriticoActual);
            this.SaldosActuales.Controls.Add(this.LblEmergenciaActual);
            this.SaldosActuales.Location = new System.Drawing.Point(250, 6);
            this.SaldosActuales.Name = "SaldosActuales";
            this.SaldosActuales.Size = new System.Drawing.Size(118, 120);
            this.SaldosActuales.TabIndex = 69;
            this.SaldosActuales.TabStop = false;
            this.SaldosActuales.Text = "Saldos actuales";
            // 
            // LblEmergenciaActual
            // 
            this.LblEmergenciaActual.AutoSize = true;
            this.LblEmergenciaActual.Location = new System.Drawing.Point(24, 23);
            this.LblEmergenciaActual.Name = "LblEmergenciaActual";
            this.LblEmergenciaActual.Size = new System.Drawing.Size(0, 13);
            this.LblEmergenciaActual.TabIndex = 70;
            // 
            // LblCriticoActual
            // 
            this.LblCriticoActual.AutoSize = true;
            this.LblCriticoActual.Location = new System.Drawing.Point(24, 57);
            this.LblCriticoActual.Name = "LblCriticoActual";
            this.LblCriticoActual.Size = new System.Drawing.Size(0, 13);
            this.LblCriticoActual.TabIndex = 71;
            // 
            // LblPermitidoActual
            // 
            this.LblPermitidoActual.AutoSize = true;
            this.LblPermitidoActual.Location = new System.Drawing.Point(24, 93);
            this.LblPermitidoActual.Name = "LblPermitidoActual";
            this.LblPermitidoActual.Size = new System.Drawing.Size(0, 13);
            this.LblPermitidoActual.TabIndex = 72;
            // 
            // FormConfiguracion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 211);
            this.Controls.Add(this.TabBorrarDatos);
            this.MaximumSize = new System.Drawing.Size(400, 250);
            this.MinimumSize = new System.Drawing.Size(400, 250);
            this.Name = "FormConfiguracion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormConfiguracion";
            this.Load += new System.EventHandler(this.FormConfiguracion_Load);
            this.TabBorrarDatos.ResumeLayout(false);
            this.TabSaldos.ResumeLayout(false);
            this.TabSaldos.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.SaldosActuales.ResumeLayout(false);
            this.SaldosActuales.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl TabBorrarDatos;
        private System.Windows.Forms.TabPage TabSaldos;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label LblCritico;
        private System.Windows.Forms.Label LblPermitido;
        private System.Windows.Forms.Label LblEmergencia;
        private System.Windows.Forms.TextBox TxtCritico;
        private System.Windows.Forms.TextBox TxtPermitido;
        private System.Windows.Forms.TextBox TxtEmergencia;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker DtHasta;
        private System.Windows.Forms.DateTimePicker DtDesde;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton RbOrigen;
        private System.Windows.Forms.RadioButton RbPeriodo;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton RbMovimientos;
        private System.Windows.Forms.RadioButton RbTodo;
        private System.Windows.Forms.RadioButton RbSaldos;
        private System.Windows.Forms.GroupBox SaldosActuales;
        private System.Windows.Forms.Label LblPermitidoActual;
        private System.Windows.Forms.Label LblCriticoActual;
        private System.Windows.Forms.Label LblEmergenciaActual;
    }
}