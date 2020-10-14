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
            this.TabEliminarDatos = new System.Windows.Forms.TabPage();
            this.TabNotificaciones = new System.Windows.Forms.TabPage();
            this.TabEstablecerSaldos = new System.Windows.Forms.TabPage();
            this.BtnSave = new System.Windows.Forms.Button();
            this.TxtEmergencia = new System.Windows.Forms.TextBox();
            this.TxtPermitido = new System.Windows.Forms.TextBox();
            this.TxtCritico = new System.Windows.Forms.TextBox();
            this.LblEmergencia = new System.Windows.Forms.Label();
            this.LblPermitido = new System.Windows.Forms.Label();
            this.LblCritico = new System.Windows.Forms.Label();
            this.SaldosActuales = new System.Windows.Forms.GroupBox();
            this.LblEmergenciaActual = new System.Windows.Forms.Label();
            this.LblCriticoActual = new System.Windows.Forms.Label();
            this.LblPermitidoActual = new System.Windows.Forms.Label();
            this.TabEliminacion = new System.Windows.Forms.TabControl();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.RbSaldos = new System.Windows.Forms.RadioButton();
            this.RbMovimientos = new System.Windows.Forms.RadioButton();
            this.RbTodo = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.DtHasta = new System.Windows.Forms.DateTimePicker();
            this.DtDesde = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.RbOrigen = new System.Windows.Forms.RadioButton();
            this.RbPeriodo = new System.Windows.Forms.RadioButton();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.GBNotificaciones = new System.Windows.Forms.GroupBox();
            this.RbNoti3 = new System.Windows.Forms.RadioButton();
            this.RbNoti2 = new System.Windows.Forms.RadioButton();
            this.RbNoti1 = new System.Windows.Forms.RadioButton();
            this.DtpAlarma1 = new System.Windows.Forms.DateTimePicker();
            this.DtpAlarma2 = new System.Windows.Forms.DateTimePicker();
            this.DtpAlarma3 = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.TabEliminarDatos.SuspendLayout();
            this.TabNotificaciones.SuspendLayout();
            this.TabEstablecerSaldos.SuspendLayout();
            this.SaldosActuales.SuspendLayout();
            this.TabEliminacion.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.GBNotificaciones.SuspendLayout();
            this.SuspendLayout();
            // 
            // TabEliminarDatos
            // 
            this.TabEliminarDatos.Controls.Add(this.groupBox1);
            this.TabEliminarDatos.Controls.Add(this.label3);
            this.TabEliminarDatos.Controls.Add(this.label2);
            this.TabEliminarDatos.Controls.Add(this.DtHasta);
            this.TabEliminarDatos.Controls.Add(this.DtDesde);
            this.TabEliminarDatos.Controls.Add(this.label1);
            this.TabEliminarDatos.Controls.Add(this.RbOrigen);
            this.TabEliminarDatos.Controls.Add(this.RbPeriodo);
            this.TabEliminarDatos.Controls.Add(this.BtnDelete);
            this.TabEliminarDatos.Location = new System.Drawing.Point(4, 22);
            this.TabEliminarDatos.Name = "TabEliminarDatos";
            this.TabEliminarDatos.Padding = new System.Windows.Forms.Padding(3);
            this.TabEliminarDatos.Size = new System.Drawing.Size(376, 185);
            this.TabEliminarDatos.TabIndex = 2;
            this.TabEliminarDatos.Text = "Borrar Datos";
            this.TabEliminarDatos.UseVisualStyleBackColor = true;
            // 
            // TabNotificaciones
            // 
            this.TabNotificaciones.Controls.Add(this.button1);
            this.TabNotificaciones.Controls.Add(this.label7);
            this.TabNotificaciones.Controls.Add(this.label6);
            this.TabNotificaciones.Controls.Add(this.label5);
            this.TabNotificaciones.Controls.Add(this.DtpAlarma3);
            this.TabNotificaciones.Controls.Add(this.DtpAlarma2);
            this.TabNotificaciones.Controls.Add(this.DtpAlarma1);
            this.TabNotificaciones.Controls.Add(this.GBNotificaciones);
            this.TabNotificaciones.Controls.Add(this.label4);
            this.TabNotificaciones.Location = new System.Drawing.Point(4, 22);
            this.TabNotificaciones.Name = "TabNotificaciones";
            this.TabNotificaciones.Padding = new System.Windows.Forms.Padding(3);
            this.TabNotificaciones.Size = new System.Drawing.Size(376, 185);
            this.TabNotificaciones.TabIndex = 1;
            this.TabNotificaciones.Text = "Notificaciones Diarias";
            this.TabNotificaciones.UseVisualStyleBackColor = true;
            // 
            // TabEstablecerSaldos
            // 
            this.TabEstablecerSaldos.Controls.Add(this.SaldosActuales);
            this.TabEstablecerSaldos.Controls.Add(this.LblCritico);
            this.TabEstablecerSaldos.Controls.Add(this.LblPermitido);
            this.TabEstablecerSaldos.Controls.Add(this.LblEmergencia);
            this.TabEstablecerSaldos.Controls.Add(this.TxtCritico);
            this.TabEstablecerSaldos.Controls.Add(this.TxtPermitido);
            this.TabEstablecerSaldos.Controls.Add(this.TxtEmergencia);
            this.TabEstablecerSaldos.Controls.Add(this.BtnSave);
            this.TabEstablecerSaldos.Location = new System.Drawing.Point(4, 22);
            this.TabEstablecerSaldos.Name = "TabEstablecerSaldos";
            this.TabEstablecerSaldos.Padding = new System.Windows.Forms.Padding(3);
            this.TabEstablecerSaldos.Size = new System.Drawing.Size(376, 185);
            this.TabEstablecerSaldos.TabIndex = 0;
            this.TabEstablecerSaldos.Text = "Establecer Saldos";
            this.TabEstablecerSaldos.UseVisualStyleBackColor = true;
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
            this.BtnSave.TabIndex = 3;
            this.BtnSave.Text = "Establecer Importes";
            this.BtnSave.UseVisualStyleBackColor = false;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // TxtEmergencia
            // 
            this.TxtEmergencia.Location = new System.Drawing.Point(134, 24);
            this.TxtEmergencia.Name = "TxtEmergencia";
            this.TxtEmergencia.Size = new System.Drawing.Size(100, 20);
            this.TxtEmergencia.TabIndex = 0;
            // 
            // TxtPermitido
            // 
            this.TxtPermitido.Location = new System.Drawing.Point(134, 96);
            this.TxtPermitido.Name = "TxtPermitido";
            this.TxtPermitido.Size = new System.Drawing.Size(100, 20);
            this.TxtPermitido.TabIndex = 2;
            // 
            // TxtCritico
            // 
            this.TxtCritico.Location = new System.Drawing.Point(134, 60);
            this.TxtCritico.Name = "TxtCritico";
            this.TxtCritico.Size = new System.Drawing.Size(100, 20);
            this.TxtCritico.TabIndex = 1;
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
            // TabEliminacion
            // 
            this.TabEliminacion.Controls.Add(this.TabEstablecerSaldos);
            this.TabEliminacion.Controls.Add(this.TabNotificaciones);
            this.TabEliminacion.Controls.Add(this.TabEliminarDatos);
            this.TabEliminacion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabEliminacion.Location = new System.Drawing.Point(0, 0);
            this.TabEliminacion.Name = "TabEliminacion";
            this.TabEliminacion.SelectedIndex = 0;
            this.TabEliminacion.Size = new System.Drawing.Size(384, 211);
            this.TabEliminacion.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.RbSaldos);
            this.groupBox1.Controls.Add(this.RbMovimientos);
            this.groupBox1.Controls.Add(this.RbTodo);
            this.groupBox1.Location = new System.Drawing.Point(207, 48);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(149, 85);
            this.groupBox1.TabIndex = 82;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Seleccionar Datos a borrar";
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 81;
            this.label3.Text = "Desde:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 80;
            this.label2.Text = "Hasta:";
            // 
            // DtHasta
            // 
            this.DtHasta.Enabled = false;
            this.DtHasta.Location = new System.Drawing.Point(26, 105);
            this.DtHasta.Name = "DtHasta";
            this.DtHasta.Size = new System.Drawing.Size(158, 20);
            this.DtHasta.TabIndex = 79;
            // 
            // DtDesde
            // 
            this.DtDesde.Enabled = false;
            this.DtDesde.Location = new System.Drawing.Point(26, 67);
            this.DtDesde.Name = "DtDesde";
            this.DtDesde.Size = new System.Drawing.Size(158, 20);
            this.DtDesde.TabIndex = 78;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(115, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 13);
            this.label1.TabIndex = 77;
            this.label1.Text = "Seleccionar modo de borrado";
            // 
            // RbOrigen
            // 
            this.RbOrigen.AutoSize = true;
            this.RbOrigen.Checked = true;
            this.RbOrigen.Location = new System.Drawing.Point(200, 25);
            this.RbOrigen.Name = "RbOrigen";
            this.RbOrigen.Size = new System.Drawing.Size(109, 17);
            this.RbOrigen.TabIndex = 76;
            this.RbOrigen.TabStop = true;
            this.RbOrigen.Text = "Desde el principio";
            this.RbOrigen.UseVisualStyleBackColor = true;
            this.RbOrigen.CheckedChanged += new System.EventHandler(this.RbOrigen_CheckedChanged);
            // 
            // RbPeriodo
            // 
            this.RbPeriodo.AutoSize = true;
            this.RbPeriodo.Location = new System.Drawing.Point(67, 25);
            this.RbPeriodo.Name = "RbPeriodo";
            this.RbPeriodo.Size = new System.Drawing.Size(93, 17);
            this.RbPeriodo.TabIndex = 75;
            this.RbPeriodo.Text = "Borrar período";
            this.RbPeriodo.UseVisualStyleBackColor = true;
            this.RbPeriodo.CheckedChanged += new System.EventHandler(this.RbPeriodo_CheckedChanged);
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
            this.BtnDelete.TabIndex = 74;
            this.BtnDelete.Text = "Eliminar Datos Seleccionados";
            this.BtnDelete.UseVisualStyleBackColor = false;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(46, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(291, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Elegir la cantidad de notificaciones diarias que quiere recibir:";
            // 
            // GBNotificaciones
            // 
            this.GBNotificaciones.Controls.Add(this.RbNoti3);
            this.GBNotificaciones.Controls.Add(this.RbNoti2);
            this.GBNotificaciones.Controls.Add(this.RbNoti1);
            this.GBNotificaciones.Location = new System.Drawing.Point(49, 41);
            this.GBNotificaciones.Name = "GBNotificaciones";
            this.GBNotificaciones.Size = new System.Drawing.Size(95, 93);
            this.GBNotificaciones.TabIndex = 83;
            this.GBNotificaciones.TabStop = false;
            this.GBNotificaciones.Text = "Por día";
            // 
            // RbNoti3
            // 
            this.RbNoti3.AutoSize = true;
            this.RbNoti3.Location = new System.Drawing.Point(35, 64);
            this.RbNoti3.Name = "RbNoti3";
            this.RbNoti3.Size = new System.Drawing.Size(31, 17);
            this.RbNoti3.TabIndex = 70;
            this.RbNoti3.Text = "3";
            this.RbNoti3.UseVisualStyleBackColor = true;
            this.RbNoti3.CheckedChanged += new System.EventHandler(this.RbNoti3_CheckedChanged);
            // 
            // RbNoti2
            // 
            this.RbNoti2.AutoSize = true;
            this.RbNoti2.Location = new System.Drawing.Point(35, 42);
            this.RbNoti2.Name = "RbNoti2";
            this.RbNoti2.Size = new System.Drawing.Size(31, 17);
            this.RbNoti2.TabIndex = 69;
            this.RbNoti2.Text = "2";
            this.RbNoti2.UseVisualStyleBackColor = true;
            this.RbNoti2.CheckedChanged += new System.EventHandler(this.RbNoti2_CheckedChanged);
            // 
            // RbNoti1
            // 
            this.RbNoti1.AutoSize = true;
            this.RbNoti1.Checked = true;
            this.RbNoti1.Location = new System.Drawing.Point(35, 19);
            this.RbNoti1.Name = "RbNoti1";
            this.RbNoti1.Size = new System.Drawing.Size(31, 17);
            this.RbNoti1.TabIndex = 68;
            this.RbNoti1.TabStop = true;
            this.RbNoti1.Text = "1";
            this.RbNoti1.UseVisualStyleBackColor = true;
            this.RbNoti1.CheckedChanged += new System.EventHandler(this.RbNoti1_CheckedChanged);
            // 
            // DtpAlarma1
            // 
            this.DtpAlarma1.CustomFormat = "HH:mm";
            this.DtpAlarma1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DtpAlarma1.Location = new System.Drawing.Point(169, 56);
            this.DtpAlarma1.Name = "DtpAlarma1";
            this.DtpAlarma1.ShowUpDown = true;
            this.DtpAlarma1.Size = new System.Drawing.Size(90, 20);
            this.DtpAlarma1.TabIndex = 84;
            // 
            // DtpAlarma2
            // 
            this.DtpAlarma2.CustomFormat = "HH:mm";
            this.DtpAlarma2.Enabled = false;
            this.DtpAlarma2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DtpAlarma2.Location = new System.Drawing.Point(265, 55);
            this.DtpAlarma2.Name = "DtpAlarma2";
            this.DtpAlarma2.ShowUpDown = true;
            this.DtpAlarma2.Size = new System.Drawing.Size(90, 20);
            this.DtpAlarma2.TabIndex = 85;
            // 
            // DtpAlarma3
            // 
            this.DtpAlarma3.CustomFormat = "HH:mm";
            this.DtpAlarma3.Enabled = false;
            this.DtpAlarma3.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DtpAlarma3.Location = new System.Drawing.Point(169, 105);
            this.DtpAlarma3.Name = "DtpAlarma3";
            this.DtpAlarma3.ShowUpDown = true;
            this.DtpAlarma3.Size = new System.Drawing.Size(90, 20);
            this.DtpAlarma3.TabIndex = 86;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(172, 41);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 13);
            this.label5.TabIndex = 87;
            this.label5.Text = "Alarma 1";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(268, 40);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 13);
            this.label6.TabIndex = 88;
            this.label6.Text = "Alarma 2";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(172, 90);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 13);
            this.label7.TabIndex = 89;
            this.label7.Text = "Alarma 3";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Highlight;
            this.button1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.button1.Location = new System.Drawing.Point(3, 139);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(370, 43);
            this.button1.TabIndex = 90;
            this.button1.Text = "Establecer notificaciones diarias";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // FormConfiguracion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 211);
            this.Controls.Add(this.TabEliminacion);
            this.MaximumSize = new System.Drawing.Size(400, 250);
            this.MinimumSize = new System.Drawing.Size(400, 250);
            this.Name = "FormConfiguracion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Ajustes";
            this.Load += new System.EventHandler(this.FormConfiguracion_Load);
            this.TabEliminarDatos.ResumeLayout(false);
            this.TabEliminarDatos.PerformLayout();
            this.TabNotificaciones.ResumeLayout(false);
            this.TabNotificaciones.PerformLayout();
            this.TabEstablecerSaldos.ResumeLayout(false);
            this.TabEstablecerSaldos.PerformLayout();
            this.SaldosActuales.ResumeLayout(false);
            this.SaldosActuales.PerformLayout();
            this.TabEliminacion.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.GBNotificaciones.ResumeLayout(false);
            this.GBNotificaciones.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage TabEliminarDatos;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton RbSaldos;
        private System.Windows.Forms.RadioButton RbMovimientos;
        private System.Windows.Forms.RadioButton RbTodo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker DtHasta;
        private System.Windows.Forms.DateTimePicker DtDesde;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton RbOrigen;
        private System.Windows.Forms.RadioButton RbPeriodo;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.TabPage TabNotificaciones;
        private System.Windows.Forms.TabPage TabEstablecerSaldos;
        private System.Windows.Forms.GroupBox SaldosActuales;
        private System.Windows.Forms.Label LblPermitidoActual;
        private System.Windows.Forms.Label LblCriticoActual;
        private System.Windows.Forms.Label LblEmergenciaActual;
        private System.Windows.Forms.Label LblCritico;
        private System.Windows.Forms.Label LblPermitido;
        private System.Windows.Forms.Label LblEmergencia;
        private System.Windows.Forms.TextBox TxtCritico;
        private System.Windows.Forms.TextBox TxtPermitido;
        private System.Windows.Forms.TextBox TxtEmergencia;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.TabControl TabEliminacion;
        private System.Windows.Forms.DateTimePicker DtpAlarma3;
        private System.Windows.Forms.DateTimePicker DtpAlarma2;
        private System.Windows.Forms.DateTimePicker DtpAlarma1;
        private System.Windows.Forms.GroupBox GBNotificaciones;
        private System.Windows.Forms.RadioButton RbNoti3;
        private System.Windows.Forms.RadioButton RbNoti2;
        private System.Windows.Forms.RadioButton RbNoti1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
    }
}