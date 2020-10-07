namespace FrontEndLayer
{
    partial class FormMovimientos
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            this.GroupDTGV = new System.Windows.Forms.GroupBox();
            this.PicFiltro = new System.Windows.Forms.PictureBox();
            this.TxtFiltro = new System.Windows.Forms.TextBox();
            this.DtgMovFinal = new System.Windows.Forms.DataGridView();
            this.Importe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Transaccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumCuotaPaga = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cuotas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Observaciones = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MenuEdicion = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.EditarMovimiento = new System.Windows.Forms.ToolStripMenuItem();
            this.EliminarMovimiento = new System.Windows.Forms.ToolStripMenuItem();
            this.GroupMovimientos = new System.Windows.Forms.GroupBox();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.BtnSave = new System.Windows.Forms.Button();
            this.cmbCuotas = new System.Windows.Forms.ComboBox();
            this.RbAgendaN = new System.Windows.Forms.RadioButton();
            this.RbAgendaY = new System.Windows.Forms.RadioButton();
            this.cmbTransaccion = new System.Windows.Forms.ComboBox();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.lblObservaciones = new System.Windows.Forms.Label();
            this.lblCuotas = new System.Windows.Forms.Label();
            this.lblAgendar = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblTransaccion = new System.Windows.Forms.Label();
            this.lblImporte = new System.Windows.Forms.Label();
            this.TxtObservaciones = new System.Windows.Forms.TextBox();
            this.TxtImporte = new System.Windows.Forms.TextBox();
            this.notifyMovement = new System.Windows.Forms.NotifyIcon(this.components);
            this.GroupDTGV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicFiltro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DtgMovFinal)).BeginInit();
            this.MenuEdicion.SuspendLayout();
            this.GroupMovimientos.SuspendLayout();
            this.SuspendLayout();
            // 
            // GroupDTGV
            // 
            this.GroupDTGV.BackColor = System.Drawing.SystemColors.Control;
            this.GroupDTGV.Controls.Add(this.PicFiltro);
            this.GroupDTGV.Controls.Add(this.TxtFiltro);
            this.GroupDTGV.Controls.Add(this.DtgMovFinal);
            this.GroupDTGV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupDTGV.Location = new System.Drawing.Point(5, 193);
            this.GroupDTGV.Name = "GroupDTGV";
            this.GroupDTGV.Size = new System.Drawing.Size(823, 312);
            this.GroupDTGV.TabIndex = 48;
            this.GroupDTGV.TabStop = false;
            this.GroupDTGV.Text = "Vista Previa";
            // 
            // PicFiltro
            // 
            this.PicFiltro.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.PicFiltro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(88)))), ((int)(((byte)(88)))));
            this.PicFiltro.Location = new System.Drawing.Point(294, 40);
            this.PicFiltro.Name = "PicFiltro";
            this.PicFiltro.Size = new System.Drawing.Size(234, 2);
            this.PicFiltro.TabIndex = 39;
            this.PicFiltro.TabStop = false;
            // 
            // TxtFiltro
            // 
            this.TxtFiltro.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtFiltro.BackColor = System.Drawing.SystemColors.Control;
            this.TxtFiltro.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtFiltro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtFiltro.ForeColor = System.Drawing.Color.Gray;
            this.TxtFiltro.Location = new System.Drawing.Point(298, 19);
            this.TxtFiltro.MinimumSize = new System.Drawing.Size(150, 20);
            this.TxtFiltro.Name = "TxtFiltro";
            this.TxtFiltro.Size = new System.Drawing.Size(234, 15);
            this.TxtFiltro.TabIndex = 38;
            this.TxtFiltro.Text = "Buscar";
            // 
            // DtgMovFinal
            // 
            this.DtgMovFinal.AllowUserToAddRows = false;
            this.DtgMovFinal.AllowUserToDeleteRows = false;
            this.DtgMovFinal.AllowUserToResizeRows = false;
            this.DtgMovFinal.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.DtgMovFinal.BackgroundColor = System.Drawing.SystemColors.Control;
            this.DtgMovFinal.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DtgMovFinal.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.DtgMovFinal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DtgMovFinal.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Importe,
            this.Transaccion,
            this.Fecha,
            this.NumCuotaPaga,
            this.Cuotas,
            this.Observaciones});
            this.DtgMovFinal.ContextMenuStrip = this.MenuEdicion;
            this.DtgMovFinal.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle16.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle16.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DtgMovFinal.DefaultCellStyle = dataGridViewCellStyle16;
            this.DtgMovFinal.EnableHeadersVisualStyles = false;
            this.DtgMovFinal.Location = new System.Drawing.Point(3, 50);
            this.DtgMovFinal.Name = "DtgMovFinal";
            this.DtgMovFinal.ReadOnly = true;
            this.DtgMovFinal.RowHeadersVisible = false;
            this.DtgMovFinal.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.DtgMovFinal.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.DtgMovFinal.RowTemplate.ReadOnly = true;
            this.DtgMovFinal.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.DtgMovFinal.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DtgMovFinal.Size = new System.Drawing.Size(816, 256);
            this.DtgMovFinal.TabIndex = 33;
            this.DtgMovFinal.TabStop = false;
            this.DtgMovFinal.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DtgMovFinal_CellDoubleClick);
            this.DtgMovFinal.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DtgMovFinal_CellMouseDown);
            // 
            // Importe
            // 
            this.Importe.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.Format = "C2";
            dataGridViewCellStyle10.NullValue = "0";
            this.Importe.DefaultCellStyle = dataGridViewCellStyle10;
            this.Importe.HeaderText = "Importe";
            this.Importe.Name = "Importe";
            this.Importe.ReadOnly = true;
            this.Importe.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Importe.Width = 120;
            // 
            // Transaccion
            // 
            this.Transaccion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.NullValue = null;
            this.Transaccion.DefaultCellStyle = dataGridViewCellStyle11;
            this.Transaccion.HeaderText = "Transacción";
            this.Transaccion.Name = "Transaccion";
            this.Transaccion.ReadOnly = true;
            this.Transaccion.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Transaccion.Width = 120;
            // 
            // Fecha
            // 
            this.Fecha.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle12.Format = "d";
            dataGridViewCellStyle12.NullValue = null;
            this.Fecha.DefaultCellStyle = dataGridViewCellStyle12;
            this.Fecha.HeaderText = "Fecha";
            this.Fecha.Name = "Fecha";
            this.Fecha.ReadOnly = true;
            this.Fecha.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Fecha.Width = 120;
            // 
            // NumCuotaPaga
            // 
            this.NumCuotaPaga.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle13.NullValue = null;
            this.NumCuotaPaga.DefaultCellStyle = dataGridViewCellStyle13;
            this.NumCuotaPaga.HeaderText = "Cuotas Pagas";
            this.NumCuotaPaga.Name = "NumCuotaPaga";
            this.NumCuotaPaga.ReadOnly = true;
            this.NumCuotaPaga.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.NumCuotaPaga.Width = 120;
            // 
            // Cuotas
            // 
            this.Cuotas.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle14.Format = "N0";
            dataGridViewCellStyle14.NullValue = "1";
            this.Cuotas.DefaultCellStyle = dataGridViewCellStyle14;
            this.Cuotas.HeaderText = "Cuotas Totales";
            this.Cuotas.Name = "Cuotas";
            this.Cuotas.ReadOnly = true;
            this.Cuotas.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Cuotas.Width = 80;
            // 
            // Observaciones
            // 
            this.Observaciones.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle15.NullValue = "-";
            this.Observaciones.DefaultCellStyle = dataGridViewCellStyle15;
            this.Observaciones.HeaderText = "Observaciones";
            this.Observaciones.Name = "Observaciones";
            this.Observaciones.ReadOnly = true;
            this.Observaciones.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Observaciones.Width = 254;
            // 
            // MenuEdicion
            // 
            this.MenuEdicion.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.EditarMovimiento,
            this.EliminarMovimiento});
            this.MenuEdicion.Name = "MenuEdicion";
            this.MenuEdicion.Size = new System.Drawing.Size(118, 48);
            // 
            // EditarMovimiento
            // 
            this.EditarMovimiento.Name = "EditarMovimiento";
            this.EditarMovimiento.Size = new System.Drawing.Size(117, 22);
            this.EditarMovimiento.Text = "Editar";
            this.EditarMovimiento.Click += new System.EventHandler(this.EditarMovimiento_Click);
            // 
            // EliminarMovimiento
            // 
            this.EliminarMovimiento.Name = "EliminarMovimiento";
            this.EliminarMovimiento.Size = new System.Drawing.Size(117, 22);
            this.EliminarMovimiento.Text = "Eliminar";
            this.EliminarMovimiento.Click += new System.EventHandler(this.EliminarMovimiento_Click);
            // 
            // GroupMovimientos
            // 
            this.GroupMovimientos.BackColor = System.Drawing.SystemColors.Control;
            this.GroupMovimientos.Controls.Add(this.BtnCancel);
            this.GroupMovimientos.Controls.Add(this.BtnSave);
            this.GroupMovimientos.Controls.Add(this.cmbCuotas);
            this.GroupMovimientos.Controls.Add(this.RbAgendaN);
            this.GroupMovimientos.Controls.Add(this.RbAgendaY);
            this.GroupMovimientos.Controls.Add(this.cmbTransaccion);
            this.GroupMovimientos.Controls.Add(this.dtpFecha);
            this.GroupMovimientos.Controls.Add(this.lblObservaciones);
            this.GroupMovimientos.Controls.Add(this.lblCuotas);
            this.GroupMovimientos.Controls.Add(this.lblAgendar);
            this.GroupMovimientos.Controls.Add(this.lblFecha);
            this.GroupMovimientos.Controls.Add(this.lblTransaccion);
            this.GroupMovimientos.Controls.Add(this.lblImporte);
            this.GroupMovimientos.Controls.Add(this.TxtObservaciones);
            this.GroupMovimientos.Controls.Add(this.TxtImporte);
            this.GroupMovimientos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupMovimientos.Location = new System.Drawing.Point(5, 6);
            this.GroupMovimientos.Name = "GroupMovimientos";
            this.GroupMovimientos.Size = new System.Drawing.Size(823, 182);
            this.GroupMovimientos.TabIndex = 49;
            this.GroupMovimientos.TabStop = false;
            this.GroupMovimientos.Text = "Cargar Movimiento";
            // 
            // BtnCancel
            // 
            this.BtnCancel.BackColor = System.Drawing.SystemColors.Highlight;
            this.BtnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancel.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.BtnCancel.Location = new System.Drawing.Point(589, 104);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(121, 57);
            this.BtnCancel.TabIndex = 62;
            this.BtnCancel.Text = "Cancelar";
            this.BtnCancel.UseVisualStyleBackColor = false;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // BtnSave
            // 
            this.BtnSave.BackColor = System.Drawing.SystemColors.Highlight;
            this.BtnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSave.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.BtnSave.Location = new System.Drawing.Point(589, 32);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(121, 57);
            this.BtnSave.TabIndex = 61;
            this.BtnSave.Text = "Guardar";
            this.BtnSave.UseVisualStyleBackColor = false;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // cmbCuotas
            // 
            this.cmbCuotas.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbCuotas.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbCuotas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbCuotas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCuotas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCuotas.FormattingEnabled = true;
            this.cmbCuotas.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "18",
            "24",
            "36"});
            this.cmbCuotas.Location = new System.Drawing.Point(181, 133);
            this.cmbCuotas.Name = "cmbCuotas";
            this.cmbCuotas.Size = new System.Drawing.Size(133, 24);
            this.cmbCuotas.TabIndex = 60;
            // 
            // RbAgendaN
            // 
            this.RbAgendaN.AutoSize = true;
            this.RbAgendaN.Checked = true;
            this.RbAgendaN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RbAgendaN.Location = new System.Drawing.Point(270, 64);
            this.RbAgendaN.Name = "RbAgendaN";
            this.RbAgendaN.Size = new System.Drawing.Size(44, 20);
            this.RbAgendaN.TabIndex = 59;
            this.RbAgendaN.TabStop = true;
            this.RbAgendaN.Text = "No";
            this.RbAgendaN.UseVisualStyleBackColor = true;
            this.RbAgendaN.CheckedChanged += new System.EventHandler(this.RbAgendaN_CheckedChanged);
            // 
            // RbAgendaY
            // 
            this.RbAgendaY.AutoSize = true;
            this.RbAgendaY.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RbAgendaY.Location = new System.Drawing.Point(225, 64);
            this.RbAgendaY.Name = "RbAgendaY";
            this.RbAgendaY.Size = new System.Drawing.Size(38, 20);
            this.RbAgendaY.TabIndex = 58;
            this.RbAgendaY.TabStop = true;
            this.RbAgendaY.Text = "Si";
            this.RbAgendaY.UseVisualStyleBackColor = true;
            this.RbAgendaY.CheckedChanged += new System.EventHandler(this.RbAgendaY_CheckedChanged);
            // 
            // cmbTransaccion
            // 
            this.cmbTransaccion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbTransaccion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTransaccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTransaccion.FormattingEnabled = true;
            this.cmbTransaccion.Items.AddRange(new object[] {
            "Agua",
            "Compra",
            "Extraccion",
            "Gas",
            "Gasto Permitido",
            "Luz",
            "Pago",
            "Sueldo",
            "SuperMercado",
            "Transferencia",
            "Venta dolares",
            "Otros"});
            this.cmbTransaccion.Location = new System.Drawing.Point(434, 29);
            this.cmbTransaccion.Name = "cmbTransaccion";
            this.cmbTransaccion.Size = new System.Drawing.Size(133, 24);
            this.cmbTransaccion.TabIndex = 57;
            // 
            // dtpFecha
            // 
            this.dtpFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.Location = new System.Drawing.Point(181, 95);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(133, 22);
            this.dtpFecha.TabIndex = 56;
            // 
            // lblObservaciones
            // 
            this.lblObservaciones.AutoSize = true;
            this.lblObservaciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblObservaciones.Location = new System.Drawing.Point(346, 68);
            this.lblObservaciones.Name = "lblObservaciones";
            this.lblObservaciones.Size = new System.Drawing.Size(103, 16);
            this.lblObservaciones.TabIndex = 55;
            this.lblObservaciones.Text = "Observaciones:";
            // 
            // lblCuotas
            // 
            this.lblCuotas.AutoSize = true;
            this.lblCuotas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCuotas.Location = new System.Drawing.Point(125, 136);
            this.lblCuotas.Name = "lblCuotas";
            this.lblCuotas.Size = new System.Drawing.Size(50, 16);
            this.lblCuotas.TabIndex = 54;
            this.lblCuotas.Text = "Cuotas";
            // 
            // lblAgendar
            // 
            this.lblAgendar.AutoSize = true;
            this.lblAgendar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAgendar.Location = new System.Drawing.Point(114, 66);
            this.lblAgendar.Name = "lblAgendar";
            this.lblAgendar.Size = new System.Drawing.Size(96, 16);
            this.lblAgendar.TabIndex = 53;
            this.lblAgendar.Text = "Agendar Pago";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.Location = new System.Drawing.Point(129, 100);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(46, 16);
            this.lblFecha.TabIndex = 52;
            this.lblFecha.Text = "Fecha";
            // 
            // lblTransaccion
            // 
            this.lblTransaccion.AutoSize = true;
            this.lblTransaccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTransaccion.Location = new System.Drawing.Point(345, 32);
            this.lblTransaccion.Name = "lblTransaccion";
            this.lblTransaccion.Size = new System.Drawing.Size(83, 16);
            this.lblTransaccion.TabIndex = 51;
            this.lblTransaccion.Text = "Transacción";
            // 
            // lblImporte
            // 
            this.lblImporte.AutoSize = true;
            this.lblImporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImporte.Location = new System.Drawing.Point(122, 34);
            this.lblImporte.Name = "lblImporte";
            this.lblImporte.Size = new System.Drawing.Size(53, 16);
            this.lblImporte.TabIndex = 50;
            this.lblImporte.Text = "Importe";
            // 
            // TxtObservaciones
            // 
            this.TxtObservaciones.Location = new System.Drawing.Point(343, 87);
            this.TxtObservaciones.Multiline = true;
            this.TxtObservaciones.Name = "TxtObservaciones";
            this.TxtObservaciones.Size = new System.Drawing.Size(225, 82);
            this.TxtObservaciones.TabIndex = 49;
            // 
            // TxtImporte
            // 
            this.TxtImporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtImporte.Location = new System.Drawing.Point(181, 31);
            this.TxtImporte.Name = "TxtImporte";
            this.TxtImporte.Size = new System.Drawing.Size(133, 22);
            this.TxtImporte.TabIndex = 48;
            this.TxtImporte.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtImporte_KeyPress);
            // 
            // notifyMovement
            // 
            this.notifyMovement.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifyMovement.BalloonTipTitle = "Registro exitoso";
            // 
            // FormMovimientos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(834, 510);
            this.Controls.Add(this.GroupMovimientos);
            this.Controls.Add(this.GroupDTGV);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormMovimientos";
            this.Text = "FormMovimientos";
            this.Load += new System.EventHandler(this.FormMovimientos_Load);
            this.GroupDTGV.ResumeLayout(false);
            this.GroupDTGV.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicFiltro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DtgMovFinal)).EndInit();
            this.MenuEdicion.ResumeLayout(false);
            this.GroupMovimientos.ResumeLayout(false);
            this.GroupMovimientos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GroupDTGV;
        private System.Windows.Forms.DataGridView DtgMovFinal;
        private System.Windows.Forms.GroupBox GroupMovimientos;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.ComboBox cmbCuotas;
        private System.Windows.Forms.RadioButton RbAgendaN;
        private System.Windows.Forms.RadioButton RbAgendaY;
        private System.Windows.Forms.ComboBox cmbTransaccion;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Label lblObservaciones;
        private System.Windows.Forms.Label lblCuotas;
        private System.Windows.Forms.Label lblAgendar;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblTransaccion;
        private System.Windows.Forms.Label lblImporte;
        private System.Windows.Forms.TextBox TxtObservaciones;
        private System.Windows.Forms.TextBox TxtImporte;
        private System.Windows.Forms.PictureBox PicFiltro;
        private System.Windows.Forms.TextBox TxtFiltro;
        private System.Windows.Forms.NotifyIcon notifyMovement;
        private System.Windows.Forms.DataGridViewTextBoxColumn Importe;
        private System.Windows.Forms.DataGridViewTextBoxColumn Transaccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumCuotaPaga;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cuotas;
        private System.Windows.Forms.DataGridViewTextBoxColumn Observaciones;
        private System.Windows.Forms.ContextMenuStrip MenuEdicion;
        private System.Windows.Forms.ToolStripMenuItem EditarMovimiento;
        private System.Windows.Forms.ToolStripMenuItem EliminarMovimiento;
    }
}