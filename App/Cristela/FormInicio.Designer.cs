﻿namespace Cristela
{
    partial class FormInicio
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormInicio));
            this.DtgMovFinal = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Importe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Transaccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaDeCreacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumCuota = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cuotas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Observaciones = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.lblTextGastoPermitido = new System.Windows.Forms.Label();
            this.LblGastoPermitido = new System.Windows.Forms.Label();
            this.LblSaldoActual = new System.Windows.Forms.Label();
            this.BtnAjustes = new System.Windows.Forms.Button();
            this.BtnNotas = new System.Windows.Forms.Button();
            this.BtnAgenda = new System.Windows.Forms.Button();
            this.BtnMovimientos = new System.Windows.Forms.Button();
            this.BtnInicio = new System.Windows.Forms.Button();
            this.PicFiltro = new System.Windows.Forms.PictureBox();
            this.pnlForms = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.BtnClose = new System.Windows.Forms.Button();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.pnlTitulo = new System.Windows.Forms.Panel();
            this.TxtFiltro = new System.Windows.Forms.TextBox();
            this.MenuSalirIcono = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.nuevoMovimiento = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitCristela = new System.Windows.Forms.ToolStripMenuItem();
            this.TmrAlarma = new System.Windows.Forms.Timer(this.components);
            this.ConsultaNuevosMov = new System.Windows.Forms.NotifyIcon(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.DtgMovFinal)).BeginInit();
            this.pnlMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicFiltro)).BeginInit();
            this.pnlTitulo.SuspendLayout();
            this.MenuSalirIcono.SuspendLayout();
            this.SuspendLayout();
            // 
            // DtgMovFinal
            // 
            this.DtgMovFinal.AllowUserToAddRows = false;
            this.DtgMovFinal.AllowUserToDeleteRows = false;
            this.DtgMovFinal.AllowUserToResizeRows = false;
            this.DtgMovFinal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DtgMovFinal.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.DtgMovFinal.BackgroundColor = System.Drawing.SystemColors.Control;
            this.DtgMovFinal.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.BottomCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.Format = "C1";
            dataGridViewCellStyle1.NullValue = "0";
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DtgMovFinal.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DtgMovFinal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DtgMovFinal.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Importe,
            this.Transaccion,
            this.FechaDeCreacion,
            this.NumCuota,
            this.Cuotas,
            this.Observaciones});
            this.DtgMovFinal.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DtgMovFinal.DefaultCellStyle = dataGridViewCellStyle9;
            this.DtgMovFinal.EnableHeadersVisualStyles = false;
            this.DtgMovFinal.Location = new System.Drawing.Point(256, 96);
            this.DtgMovFinal.MultiSelect = false;
            this.DtgMovFinal.Name = "DtgMovFinal";
            this.DtgMovFinal.ReadOnly = true;
            this.DtgMovFinal.RowHeadersVisible = false;
            this.DtgMovFinal.RowTemplate.ReadOnly = true;
            this.DtgMovFinal.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.DtgMovFinal.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DtgMovFinal.Size = new System.Drawing.Size(822, 458);
            this.DtgMovFinal.TabIndex = 18;
            this.DtgMovFinal.TabStop = false;
            this.DtgMovFinal.MouseEnter += new System.EventHandler(this.DtgMovFinal_MouseEnter);
            this.DtgMovFinal.MouseLeave += new System.EventHandler(this.DtgMovFinal_MouseLeave);
            // 
            // Id
            // 
            this.Id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Id.DefaultCellStyle = dataGridViewCellStyle2;
            this.Id.HeaderText = "Referencia";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Id.Width = 90;
            // 
            // Importe
            // 
            this.Importe.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle3.Format = "N2";
            dataGridViewCellStyle3.NullValue = null;
            this.Importe.DefaultCellStyle = dataGridViewCellStyle3;
            this.Importe.HeaderText = "    $ Importe";
            this.Importe.Name = "Importe";
            this.Importe.ReadOnly = true;
            this.Importe.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Transaccion
            // 
            this.Transaccion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle4.NullValue = "Otros";
            this.Transaccion.DefaultCellStyle = dataGridViewCellStyle4;
            this.Transaccion.HeaderText = "      Transacción";
            this.Transaccion.Name = "Transaccion";
            this.Transaccion.ReadOnly = true;
            this.Transaccion.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Transaccion.Width = 130;
            // 
            // FechaDeCreacion
            // 
            this.FechaDeCreacion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle5.Format = "d";
            this.FechaDeCreacion.DefaultCellStyle = dataGridViewCellStyle5;
            this.FechaDeCreacion.HeaderText = "   Fecha";
            this.FechaDeCreacion.Name = "FechaDeCreacion";
            this.FechaDeCreacion.ReadOnly = true;
            this.FechaDeCreacion.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // NumCuota
            // 
            this.NumCuota.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle6.NullValue = "No";
            this.NumCuota.DefaultCellStyle = dataGridViewCellStyle6;
            this.NumCuota.HeaderText = "Cuotas Pagas";
            this.NumCuota.Name = "NumCuota";
            this.NumCuota.ReadOnly = true;
            this.NumCuota.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Cuotas
            // 
            this.Cuotas.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle7.Format = "N0";
            dataGridViewCellStyle7.NullValue = "1";
            this.Cuotas.DefaultCellStyle = dataGridViewCellStyle7;
            this.Cuotas.HeaderText = "Cuotas Totales";
            this.Cuotas.Name = "Cuotas";
            this.Cuotas.ReadOnly = true;
            this.Cuotas.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Cuotas.Width = 110;
            // 
            // Observaciones
            // 
            this.Observaciones.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle8.NullValue = "-----";
            this.Observaciones.DefaultCellStyle = dataGridViewCellStyle8;
            this.Observaciones.HeaderText = "     Observaciones";
            this.Observaciones.Name = "Observaciones";
            this.Observaciones.ReadOnly = true;
            this.Observaciones.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Observaciones.Width = 190;
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pnlMenu.Controls.Add(this.lblTextGastoPermitido);
            this.pnlMenu.Controls.Add(this.LblGastoPermitido);
            this.pnlMenu.Controls.Add(this.LblSaldoActual);
            this.pnlMenu.Controls.Add(this.BtnAjustes);
            this.pnlMenu.Controls.Add(this.BtnNotas);
            this.pnlMenu.Controls.Add(this.BtnAgenda);
            this.pnlMenu.Controls.Add(this.BtnMovimientos);
            this.pnlMenu.Controls.Add(this.BtnInicio);
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMenu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(93)))), ((int)(((byte)(93)))));
            this.pnlMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(250, 560);
            this.pnlMenu.TabIndex = 19;
            this.pnlMenu.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PnlTitulo_MouseDown);
            // 
            // lblTextGastoPermitido
            // 
            this.lblTextGastoPermitido.AutoSize = true;
            this.lblTextGastoPermitido.BackColor = System.Drawing.Color.CornflowerBlue;
            this.lblTextGastoPermitido.ForeColor = System.Drawing.Color.White;
            this.lblTextGastoPermitido.Location = new System.Drawing.Point(0, 50);
            this.lblTextGastoPermitido.Name = "lblTextGastoPermitido";
            this.lblTextGastoPermitido.Size = new System.Drawing.Size(81, 13);
            this.lblTextGastoPermitido.TabIndex = 8;
            this.lblTextGastoPermitido.Text = "Gasto Permitido";
            this.lblTextGastoPermitido.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // LblGastoPermitido
            // 
            this.LblGastoPermitido.BackColor = System.Drawing.Color.CornflowerBlue;
            this.LblGastoPermitido.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.LblGastoPermitido.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblGastoPermitido.ForeColor = System.Drawing.Color.White;
            this.LblGastoPermitido.Location = new System.Drawing.Point(0, 63);
            this.LblGastoPermitido.Name = "LblGastoPermitido";
            this.LblGastoPermitido.Size = new System.Drawing.Size(250, 40);
            this.LblGastoPermitido.TabIndex = 7;
            this.LblGastoPermitido.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // LblSaldoActual
            // 
            this.LblSaldoActual.AutoSize = true;
            this.LblSaldoActual.BackColor = System.Drawing.Color.LawnGreen;
            this.LblSaldoActual.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.LblSaldoActual.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblSaldoActual.ForeColor = System.Drawing.Color.White;
            this.LblSaldoActual.Location = new System.Drawing.Point(0, 0);
            this.LblSaldoActual.MinimumSize = new System.Drawing.Size(250, 50);
            this.LblSaldoActual.Name = "LblSaldoActual";
            this.LblSaldoActual.Size = new System.Drawing.Size(250, 50);
            this.LblSaldoActual.TabIndex = 6;
            this.LblSaldoActual.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LblSaldoActual.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PnlTitulo_MouseDown);
            // 
            // BtnAjustes
            // 
            this.BtnAjustes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnAjustes.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnAjustes.BackColor = System.Drawing.Color.Transparent;
            this.BtnAjustes.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.BtnAjustes.FlatAppearance.BorderSize = 0;
            this.BtnAjustes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAjustes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAjustes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.BtnAjustes.Image = ((System.Drawing.Image)(resources.GetObject("BtnAjustes.Image")));
            this.BtnAjustes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnAjustes.Location = new System.Drawing.Point(0, 508);
            this.BtnAjustes.MaximumSize = new System.Drawing.Size(300, 50);
            this.BtnAjustes.MinimumSize = new System.Drawing.Size(200, 50);
            this.BtnAjustes.Name = "BtnAjustes";
            this.BtnAjustes.Size = new System.Drawing.Size(250, 50);
            this.BtnAjustes.TabIndex = 4;
            this.BtnAjustes.Text = "Ajustes";
            this.BtnAjustes.UseVisualStyleBackColor = false;
            this.BtnAjustes.Click += new System.EventHandler(this.BtnAjustes_Click);
            // 
            // BtnNotas
            // 
            this.BtnNotas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.BtnNotas.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnNotas.BackColor = System.Drawing.Color.Transparent;
            this.BtnNotas.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.BtnNotas.FlatAppearance.BorderSize = 0;
            this.BtnNotas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnNotas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnNotas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.BtnNotas.Image = ((System.Drawing.Image)(resources.GetObject("BtnNotas.Image")));
            this.BtnNotas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnNotas.Location = new System.Drawing.Point(0, 293);
            this.BtnNotas.MaximumSize = new System.Drawing.Size(300, 50);
            this.BtnNotas.MinimumSize = new System.Drawing.Size(200, 50);
            this.BtnNotas.Name = "BtnNotas";
            this.BtnNotas.Size = new System.Drawing.Size(250, 50);
            this.BtnNotas.TabIndex = 3;
            this.BtnNotas.Text = "Notas";
            this.BtnNotas.UseVisualStyleBackColor = false;
            this.BtnNotas.Click += new System.EventHandler(this.BtnNotas_Click);
            // 
            // BtnAgenda
            // 
            this.BtnAgenda.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.BtnAgenda.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnAgenda.BackColor = System.Drawing.Color.Transparent;
            this.BtnAgenda.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.BtnAgenda.FlatAppearance.BorderSize = 0;
            this.BtnAgenda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAgenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAgenda.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.BtnAgenda.Image = ((System.Drawing.Image)(resources.GetObject("BtnAgenda.Image")));
            this.BtnAgenda.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnAgenda.Location = new System.Drawing.Point(0, 237);
            this.BtnAgenda.MaximumSize = new System.Drawing.Size(300, 50);
            this.BtnAgenda.MinimumSize = new System.Drawing.Size(200, 50);
            this.BtnAgenda.Name = "BtnAgenda";
            this.BtnAgenda.Size = new System.Drawing.Size(250, 50);
            this.BtnAgenda.TabIndex = 2;
            this.BtnAgenda.Text = "Agenda de Pagos";
            this.BtnAgenda.UseVisualStyleBackColor = false;
            this.BtnAgenda.Click += new System.EventHandler(this.BtnAgenda_Click);
            // 
            // BtnMovimientos
            // 
            this.BtnMovimientos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.BtnMovimientos.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnMovimientos.BackColor = System.Drawing.Color.Transparent;
            this.BtnMovimientos.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.BtnMovimientos.FlatAppearance.BorderSize = 0;
            this.BtnMovimientos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMovimientos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnMovimientos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.BtnMovimientos.Image = ((System.Drawing.Image)(resources.GetObject("BtnMovimientos.Image")));
            this.BtnMovimientos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnMovimientos.Location = new System.Drawing.Point(0, 181);
            this.BtnMovimientos.MaximumSize = new System.Drawing.Size(300, 50);
            this.BtnMovimientos.MinimumSize = new System.Drawing.Size(200, 50);
            this.BtnMovimientos.Name = "BtnMovimientos";
            this.BtnMovimientos.Size = new System.Drawing.Size(250, 50);
            this.BtnMovimientos.TabIndex = 1;
            this.BtnMovimientos.Text = "Agregar Movimientos";
            this.BtnMovimientos.UseVisualStyleBackColor = false;
            this.BtnMovimientos.Click += new System.EventHandler(this.BtnMovimientos_Click);
            // 
            // BtnInicio
            // 
            this.BtnInicio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.BtnInicio.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnInicio.BackColor = System.Drawing.Color.Transparent;
            this.BtnInicio.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.BtnInicio.FlatAppearance.BorderSize = 0;
            this.BtnInicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnInicio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.BtnInicio.Image = ((System.Drawing.Image)(resources.GetObject("BtnInicio.Image")));
            this.BtnInicio.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnInicio.Location = new System.Drawing.Point(0, 125);
            this.BtnInicio.MaximumSize = new System.Drawing.Size(300, 50);
            this.BtnInicio.MinimumSize = new System.Drawing.Size(200, 50);
            this.BtnInicio.Name = "BtnInicio";
            this.BtnInicio.Size = new System.Drawing.Size(250, 50);
            this.BtnInicio.TabIndex = 0;
            this.BtnInicio.Text = "Inicio";
            this.BtnInicio.UseVisualStyleBackColor = false;
            this.BtnInicio.Click += new System.EventHandler(this.BtnInicio_Click);
            // 
            // PicFiltro
            // 
            this.PicFiltro.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.PicFiltro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(88)))), ((int)(((byte)(88)))));
            this.PicFiltro.Location = new System.Drawing.Point(265, 88);
            this.PicFiltro.Name = "PicFiltro";
            this.PicFiltro.Size = new System.Drawing.Size(234, 2);
            this.PicFiltro.TabIndex = 37;
            this.PicFiltro.TabStop = false;
            // 
            // pnlForms
            // 
            this.pnlForms.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlForms.BackColor = System.Drawing.Color.Transparent;
            this.pnlForms.Location = new System.Drawing.Point(250, 50);
            this.pnlForms.Name = "pnlForms";
            this.pnlForms.Size = new System.Drawing.Size(834, 510);
            this.pnlForms.TabIndex = 35;
            this.pnlForms.Visible = false;
            // 
            // lblTitulo
            // 
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblTitulo.Location = new System.Drawing.Point(327, 11);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(180, 27);
            this.lblTitulo.TabIndex = 2;
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BtnClose
            // 
            this.BtnClose.BackColor = System.Drawing.Color.Transparent;
            this.BtnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnClose.FlatAppearance.BorderSize = 0;
            this.BtnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.BtnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnClose.Image = ((System.Drawing.Image)(resources.GetObject("BtnClose.Image")));
            this.BtnClose.Location = new System.Drawing.Point(784, 0);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(50, 50);
            this.BtnClose.TabIndex = 3;
            this.BtnClose.UseVisualStyleBackColor = false;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // btnMinimize
            // 
            this.btnMinimize.BackColor = System.Drawing.Color.Transparent;
            this.btnMinimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Highlight;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimize.Image")));
            this.btnMinimize.Location = new System.Drawing.Point(735, 0);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(50, 50);
            this.btnMinimize.TabIndex = 4;
            this.btnMinimize.UseVisualStyleBackColor = false;
            this.btnMinimize.Click += new System.EventHandler(this.BtnMinimize_Click);
            // 
            // pnlTitulo
            // 
            this.pnlTitulo.BackColor = System.Drawing.Color.CornflowerBlue;
            this.pnlTitulo.Controls.Add(this.btnMinimize);
            this.pnlTitulo.Controls.Add(this.BtnClose);
            this.pnlTitulo.Controls.Add(this.lblTitulo);
            this.pnlTitulo.Location = new System.Drawing.Point(250, 0);
            this.pnlTitulo.Name = "pnlTitulo";
            this.pnlTitulo.Size = new System.Drawing.Size(834, 50);
            this.pnlTitulo.TabIndex = 21;
            this.pnlTitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PnlTitulo_MouseDown);
            // 
            // TxtFiltro
            // 
            this.TxtFiltro.BackColor = System.Drawing.SystemColors.Control;
            this.TxtFiltro.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtFiltro.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtFiltro.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.TxtFiltro.Location = new System.Drawing.Point(267, 68);
            this.TxtFiltro.MinimumSize = new System.Drawing.Size(230, 20);
            this.TxtFiltro.Name = "TxtFiltro";
            this.TxtFiltro.Size = new System.Drawing.Size(230, 20);
            this.TxtFiltro.TabIndex = 39;
            this.TxtFiltro.Text = "Buscar";
            this.TxtFiltro.Enter += new System.EventHandler(this.TxtFiltro_Enter);
            this.TxtFiltro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtFiltro_KeyPress);
            this.TxtFiltro.Leave += new System.EventHandler(this.TxtFiltro_Leave);
            this.TxtFiltro.MouseEnter += new System.EventHandler(this.TxtFiltro_MouseEnter);
            this.TxtFiltro.MouseLeave += new System.EventHandler(this.TxtFiltro_MouseLeave);
            // 
            // MenuSalirIcono
            // 
            this.MenuSalirIcono.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator1,
            this.nuevoMovimiento,
            this.ExitCristela});
            this.MenuSalirIcono.Name = "MenuSalirIcono";
            this.MenuSalirIcono.Size = new System.Drawing.Size(178, 54);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(174, 6);
            // 
            // nuevoMovimiento
            // 
            this.nuevoMovimiento.Name = "nuevoMovimiento";
            this.nuevoMovimiento.Size = new System.Drawing.Size(177, 22);
            this.nuevoMovimiento.Text = "Nuevo Movimiento";
            this.nuevoMovimiento.Click += new System.EventHandler(this.BtnMovimientos_Click);
            // 
            // ExitCristela
            // 
            this.ExitCristela.Name = "ExitCristela";
            this.ExitCristela.Size = new System.Drawing.Size(177, 22);
            this.ExitCristela.Text = "Apagar Cristela";
            this.ExitCristela.Click += new System.EventHandler(this.ExitCristela_Click);
            // 
            // TmrAlarma
            // 
            this.TmrAlarma.Interval = 1000;
            this.TmrAlarma.Tick += new System.EventHandler(this.TmrAlarma_Tick);
            // 
            // ConsultaNuevosMov
            // 
            this.ConsultaNuevosMov.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.ConsultaNuevosMov.BalloonTipText = "No te olvides de registrarlo";
            this.ConsultaNuevosMov.BalloonTipTitle = "¿Tienes algún nuevo movimiento sin registrar?";
            this.ConsultaNuevosMov.ContextMenuStrip = this.MenuSalirIcono;
            this.ConsultaNuevosMov.Icon = ((System.Drawing.Icon)(resources.GetObject("ConsultaNuevosMov.Icon")));
            this.ConsultaNuevosMov.Text = "Cristela";
            this.ConsultaNuevosMov.Visible = true;
            this.ConsultaNuevosMov.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ConsultaNuevosMov_MouseClick);
            // 
            // FormInicio
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1084, 560);
            this.Controls.Add(this.TxtFiltro);
            this.Controls.Add(this.PicFiltro);
            this.Controls.Add(this.DtgMovFinal);
            this.Controls.Add(this.pnlMenu);
            this.Controls.Add(this.pnlForms);
            this.Controls.Add(this.pnlTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(600, 450);
            this.Name = "FormInicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cristela";
            this.Load += new System.EventHandler(this.FormInicio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DtgMovFinal)).EndInit();
            this.pnlMenu.ResumeLayout(false);
            this.pnlMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicFiltro)).EndInit();
            this.pnlTitulo.ResumeLayout(false);
            this.MenuSalirIcono.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DtgMovFinal;
        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Button BtnAjustes;
        private System.Windows.Forms.Button BtnNotas;
        private System.Windows.Forms.Button BtnAgenda;
        private System.Windows.Forms.Button BtnMovimientos;
        private System.Windows.Forms.Button BtnInicio;
        private System.Windows.Forms.PictureBox PicFiltro;
        private System.Windows.Forms.Panel pnlForms;
        private System.Windows.Forms.Label lblTextGastoPermitido;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button BtnClose;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Panel pnlTitulo;
        private System.Windows.Forms.TextBox TxtFiltro;
        private System.Windows.Forms.Label LblGastoPermitido;
        private System.Windows.Forms.Label LblSaldoActual;
        private System.Windows.Forms.ContextMenuStrip MenuSalirIcono;
        private System.Windows.Forms.ToolStripMenuItem ExitCristela;
        public System.Windows.Forms.Timer TmrAlarma;
        private System.Windows.Forms.NotifyIcon ConsultaNuevosMov;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem nuevoMovimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Importe;
        private System.Windows.Forms.DataGridViewTextBoxColumn Transaccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaDeCreacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumCuota;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cuotas;
        private System.Windows.Forms.DataGridViewTextBoxColumn Observaciones;
    }
}