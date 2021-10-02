namespace Cristela
{
    partial class FormPagosAgendados
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.DtgMovAgendados = new System.Windows.Forms.DataGridView();
            this.ReferenciaId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id_Mov = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Importe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Transaccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumCuotaPaga = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cuotas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Observaciones = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Hecho = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DtgMovAgendados)).BeginInit();
            this.SuspendLayout();
            // 
            // DtgMovAgendados
            // 
            this.DtgMovAgendados.AllowUserToAddRows = false;
            this.DtgMovAgendados.AllowUserToDeleteRows = false;
            this.DtgMovAgendados.AllowUserToResizeRows = false;
            this.DtgMovAgendados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.DtgMovAgendados.BackgroundColor = System.Drawing.SystemColors.Control;
            this.DtgMovAgendados.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DtgMovAgendados.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DtgMovAgendados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DtgMovAgendados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ReferenciaId,
            this.Id_Mov,
            this.Importe,
            this.Transaccion,
            this.NumCuotaPaga,
            this.Cuotas,
            this.Observaciones,
            this.Hecho});
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DtgMovAgendados.DefaultCellStyle = dataGridViewCellStyle9;
            this.DtgMovAgendados.EnableHeadersVisualStyles = false;
            this.DtgMovAgendados.Location = new System.Drawing.Point(9, 12);
            this.DtgMovAgendados.Name = "DtgMovAgendados";
            this.DtgMovAgendados.ReadOnly = true;
            this.DtgMovAgendados.RowHeadersVisible = false;
            this.DtgMovAgendados.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.DtgMovAgendados.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.DtgMovAgendados.RowTemplate.ReadOnly = true;
            this.DtgMovAgendados.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.DtgMovAgendados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DtgMovAgendados.Size = new System.Drawing.Size(816, 486);
            this.DtgMovAgendados.TabIndex = 34;
            this.DtgMovAgendados.TabStop = false;
            this.DtgMovAgendados.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DtgMovAgendados_CellContentClick);
            // 
            // ReferenciaId
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ReferenciaId.DefaultCellStyle = dataGridViewCellStyle2;
            this.ReferenciaId.Frozen = true;
            this.ReferenciaId.HeaderText = "ID Pago";
            this.ReferenciaId.Name = "ReferenciaId";
            this.ReferenciaId.ReadOnly = true;
            this.ReferenciaId.Width = 82;
            // 
            // Id_Mov
            // 
            this.Id_Mov.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Id_Mov.Frozen = true;
            this.Id_Mov.HeaderText = "Referencia";
            this.Id_Mov.Name = "Id_Mov";
            this.Id_Mov.ReadOnly = true;
            this.Id_Mov.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Id_Mov.Width = 90;
            // 
            // Importe
            // 
            this.Importe.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.Format = "N2";
            dataGridViewCellStyle3.NullValue = null;
            this.Importe.DefaultCellStyle = dataGridViewCellStyle3;
            this.Importe.Frozen = true;
            this.Importe.HeaderText = "Importe";
            this.Importe.Name = "Importe";
            this.Importe.ReadOnly = true;
            this.Importe.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Importe.Width = 70;
            // 
            // Transaccion
            // 
            this.Transaccion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.NullValue = null;
            this.Transaccion.DefaultCellStyle = dataGridViewCellStyle4;
            this.Transaccion.Frozen = true;
            this.Transaccion.HeaderText = "Transacción";
            this.Transaccion.Name = "Transaccion";
            this.Transaccion.ReadOnly = true;
            this.Transaccion.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // NumCuotaPaga
            // 
            this.NumCuotaPaga.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.NullValue = null;
            this.NumCuotaPaga.DefaultCellStyle = dataGridViewCellStyle5;
            this.NumCuotaPaga.Frozen = true;
            this.NumCuotaPaga.HeaderText = "Cuotas Pagas";
            this.NumCuotaPaga.Name = "NumCuotaPaga";
            this.NumCuotaPaga.ReadOnly = true;
            this.NumCuotaPaga.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Cuotas
            // 
            this.Cuotas.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.Format = "N0";
            dataGridViewCellStyle6.NullValue = "1";
            this.Cuotas.DefaultCellStyle = dataGridViewCellStyle6;
            this.Cuotas.Frozen = true;
            this.Cuotas.HeaderText = "Cuotas Totales";
            this.Cuotas.Name = "Cuotas";
            this.Cuotas.ReadOnly = true;
            this.Cuotas.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Cuotas.Width = 60;
            // 
            // Observaciones
            // 
            this.Observaciones.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.NullValue = "-";
            this.Observaciones.DefaultCellStyle = dataGridViewCellStyle7;
            this.Observaciones.Frozen = true;
            this.Observaciones.HeaderText = "Observaciones";
            this.Observaciones.Name = "Observaciones";
            this.Observaciones.ReadOnly = true;
            this.Observaciones.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Observaciones.Width = 200;
            // 
            // Hecho
            // 
            this.Hecho.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.White;
            this.Hecho.DefaultCellStyle = dataGridViewCellStyle8;
            this.Hecho.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Hecho.Frozen = true;
            this.Hecho.HeaderText = "Registrar Pago";
            this.Hecho.Name = "Hecho";
            this.Hecho.ReadOnly = true;
            this.Hecho.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Hecho.Text = "Registrar";
            this.Hecho.UseColumnTextForButtonValue = true;
            this.Hecho.Width = 110;
            // 
            // FormPagosAgendados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 510);
            this.Controls.Add(this.DtgMovAgendados);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormPagosAgendados";
            this.Text = "FormPagosAgendados";
            this.Load += new System.EventHandler(this.FormPagosAgendados_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DtgMovAgendados)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DtgMovAgendados;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReferenciaId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_Mov;
        private System.Windows.Forms.DataGridViewTextBoxColumn Importe;
        private System.Windows.Forms.DataGridViewTextBoxColumn Transaccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumCuotaPaga;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cuotas;
        private System.Windows.Forms.DataGridViewTextBoxColumn Observaciones;
        private System.Windows.Forms.DataGridViewButtonColumn Hecho;
    }
}