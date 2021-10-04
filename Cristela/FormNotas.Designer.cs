namespace Cristela
{
    partial class FormNotas
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.TxtTitulo = new System.Windows.Forms.TextBox();
            this.LblTitulo = new System.Windows.Forms.Label();
            this.LblNota = new System.Windows.Forms.Label();
            this.BtnSave = new System.Windows.Forms.Button();
            this.PicFiltro = new System.Windows.Forms.PictureBox();
            this.TxtFiltro = new System.Windows.Forms.TextBox();
            this.DTGVNotas = new System.Windows.Forms.DataGridView();
            this.Importe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Transaccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MenuEdicion = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.EditarMovimiento = new System.Windows.Forms.ToolStripMenuItem();
            this.EliminarMovimiento = new System.Windows.Forms.ToolStripMenuItem();
            this.TxtNota = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.PicFiltro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DTGVNotas)).BeginInit();
            this.MenuEdicion.SuspendLayout();
            this.SuspendLayout();
            // 
            // TxtTitulo
            // 
            this.TxtTitulo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtTitulo.Location = new System.Drawing.Point(19, 38);
            this.TxtTitulo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TxtTitulo.Name = "TxtTitulo";
            this.TxtTitulo.Size = new System.Drawing.Size(503, 22);
            this.TxtTitulo.TabIndex = 0;
            // 
            // LblTitulo
            // 
            this.LblTitulo.AutoSize = true;
            this.LblTitulo.Location = new System.Drawing.Point(23, 15);
            this.LblTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblTitulo.Name = "LblTitulo";
            this.LblTitulo.Size = new System.Drawing.Size(47, 17);
            this.LblTitulo.TabIndex = 3;
            this.LblTitulo.Text = "Título:";
            // 
            // LblNota
            // 
            this.LblNota.AutoSize = true;
            this.LblNota.Location = new System.Drawing.Point(23, 75);
            this.LblNota.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblNota.Name = "LblNota";
            this.LblNota.Size = new System.Drawing.Size(42, 17);
            this.LblNota.TabIndex = 4;
            this.LblNota.Text = "Nota:";
            // 
            // BtnSave
            // 
            this.BtnSave.BackColor = System.Drawing.SystemColors.Highlight;
            this.BtnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSave.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.BtnSave.Location = new System.Drawing.Point(529, 36);
            this.BtnSave.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(100, 49);
            this.BtnSave.TabIndex = 2;
            this.BtnSave.Text = "Guardar";
            this.BtnSave.UseVisualStyleBackColor = false;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // PicFiltro
            // 
            this.PicFiltro.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PicFiltro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(88)))), ((int)(((byte)(88)))));
            this.PicFiltro.Location = new System.Drawing.Point(23, 199);
            this.PicFiltro.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PicFiltro.MaximumSize = new System.Drawing.Size(400, 2);
            this.PicFiltro.MinimumSize = new System.Drawing.Size(312, 2);
            this.PicFiltro.Name = "PicFiltro";
            this.PicFiltro.Size = new System.Drawing.Size(312, 2);
            this.PicFiltro.TabIndex = 34;
            this.PicFiltro.TabStop = false;
            // 
            // TxtFiltro
            // 
            this.TxtFiltro.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtFiltro.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.TxtFiltro.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtFiltro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtFiltro.ForeColor = System.Drawing.Color.Gray;
            this.TxtFiltro.Location = new System.Drawing.Point(25, 174);
            this.TxtFiltro.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TxtFiltro.MaximumSize = new System.Drawing.Size(400, 20);
            this.TxtFiltro.MinimumSize = new System.Drawing.Size(307, 20);
            this.TxtFiltro.Name = "TxtFiltro";
            this.TxtFiltro.Size = new System.Drawing.Size(307, 19);
            this.TxtFiltro.TabIndex = 3;
            this.TxtFiltro.Text = "Buscar notas";
            this.TxtFiltro.Enter += new System.EventHandler(this.TxtFiltro_Enter);
            this.TxtFiltro.Leave += new System.EventHandler(this.TxtFiltro_Leave);
            this.TxtFiltro.MouseEnter += new System.EventHandler(this.TxtFiltro_MouseEnter);
            this.TxtFiltro.MouseLeave += new System.EventHandler(this.TxtFiltro_MouseLeave);
            // 
            // DTGVNotas
            // 
            this.DTGVNotas.AllowUserToAddRows = false;
            this.DTGVNotas.AllowUserToDeleteRows = false;
            this.DTGVNotas.AllowUserToResizeRows = false;
            this.DTGVNotas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DTGVNotas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.DTGVNotas.BackgroundColor = System.Drawing.SystemColors.Control;
            this.DTGVNotas.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.BottomCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.Format = "C1";
            dataGridViewCellStyle1.NullValue = "0";
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DTGVNotas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DTGVNotas.ColumnHeadersHeight = 29;
            this.DTGVNotas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DTGVNotas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Importe,
            this.Transaccion});
            this.DTGVNotas.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DTGVNotas.DefaultCellStyle = dataGridViewCellStyle4;
            this.DTGVNotas.EnableHeadersVisualStyles = false;
            this.DTGVNotas.Location = new System.Drawing.Point(16, 210);
            this.DTGVNotas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DTGVNotas.MultiSelect = false;
            this.DTGVNotas.Name = "DTGVNotas";
            this.DTGVNotas.ReadOnly = true;
            this.DTGVNotas.RowHeadersVisible = false;
            this.DTGVNotas.RowHeadersWidth = 51;
            this.DTGVNotas.RowTemplate.ReadOnly = true;
            this.DTGVNotas.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.DTGVNotas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DTGVNotas.Size = new System.Drawing.Size(613, 282);
            this.DTGVNotas.TabIndex = 35;
            this.DTGVNotas.TabStop = false;
            // 
            // Importe
            // 
            this.Importe.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle2.Format = "C2";
            dataGridViewCellStyle2.NullValue = "0";
            this.Importe.DefaultCellStyle = dataGridViewCellStyle2;
            this.Importe.HeaderText = "Titulo";
            this.Importe.MinimumWidth = 6;
            this.Importe.Name = "Importe";
            this.Importe.ReadOnly = true;
            this.Importe.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Importe.Width = 150;
            // 
            // Transaccion
            // 
            this.Transaccion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle3.NullValue = "Otros";
            this.Transaccion.DefaultCellStyle = dataGridViewCellStyle3;
            this.Transaccion.HeaderText = "Nota";
            this.Transaccion.MinimumWidth = 6;
            this.Transaccion.Name = "Transaccion";
            this.Transaccion.ReadOnly = true;
            this.Transaccion.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Transaccion.Width = 310;
            // 
            // MenuEdicion
            // 
            this.MenuEdicion.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.MenuEdicion.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.EditarMovimiento,
            this.EliminarMovimiento});
            this.MenuEdicion.Name = "MenuEdicion";
            this.MenuEdicion.Size = new System.Drawing.Size(133, 52);
            // 
            // EditarMovimiento
            // 
            this.EditarMovimiento.Name = "EditarMovimiento";
            this.EditarMovimiento.Size = new System.Drawing.Size(132, 24);
            this.EditarMovimiento.Text = "Editar";
            // 
            // EliminarMovimiento
            // 
            this.EliminarMovimiento.Name = "EliminarMovimiento";
            this.EliminarMovimiento.Size = new System.Drawing.Size(132, 24);
            this.EliminarMovimiento.Text = "Eliminar";
            // 
            // TxtNota
            // 
            this.TxtNota.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtNota.Location = new System.Drawing.Point(19, 96);
            this.TxtNota.Multiline = true;
            this.TxtNota.Name = "TxtNota";
            this.TxtNota.Size = new System.Drawing.Size(610, 71);
            this.TxtNota.TabIndex = 36;
            // 
            // FormNotas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(645, 506);
            this.Controls.Add(this.TxtNota);
            this.Controls.Add(this.DTGVNotas);
            this.Controls.Add(this.PicFiltro);
            this.Controls.Add(this.TxtFiltro);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.LblNota);
            this.Controls.Add(this.LblTitulo);
            this.Controls.Add(this.TxtTitulo);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(661, 543);
            this.Name = "FormNotas";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Notas";
            ((System.ComponentModel.ISupportInitialize)(this.PicFiltro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DTGVNotas)).EndInit();
            this.MenuEdicion.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox TxtTitulo;
        private System.Windows.Forms.Label LblTitulo;
        private System.Windows.Forms.Label LblNota;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.PictureBox PicFiltro;
        private System.Windows.Forms.TextBox TxtFiltro;
        private System.Windows.Forms.DataGridView DTGVNotas;
        private System.Windows.Forms.DataGridViewTextBoxColumn Importe;
        private System.Windows.Forms.DataGridViewTextBoxColumn Transaccion;
        private System.Windows.Forms.ContextMenuStrip MenuEdicion;
        private System.Windows.Forms.ToolStripMenuItem EditarMovimiento;
        private System.Windows.Forms.ToolStripMenuItem EliminarMovimiento;
        private System.Windows.Forms.TextBox TxtNota;
    }
}