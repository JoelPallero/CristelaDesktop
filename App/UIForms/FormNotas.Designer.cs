namespace FrontEndLayer
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
            this.DTGVNotas = new System.Windows.Forms.DataGridView();
            this.TxtTitulo = new System.Windows.Forms.TextBox();
            this.LblTitulo = new System.Windows.Forms.Label();
            this.LblNota = new System.Windows.Forms.Label();
            this.BtnSave = new System.Windows.Forms.Button();
            this.PicFiltro = new System.Windows.Forms.PictureBox();
            this.TxtFiltro = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Titulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nota = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DTGVNotas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicFiltro)).BeginInit();
            this.SuspendLayout();
            // 
            // DTGVNotas
            // 
            this.DTGVNotas.AllowUserToAddRows = false;
            this.DTGVNotas.AllowUserToDeleteRows = false;
            this.DTGVNotas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DTGVNotas.BackgroundColor = System.Drawing.SystemColors.Control;
            this.DTGVNotas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DTGVNotas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Titulo,
            this.Nota});
            this.DTGVNotas.GridColor = System.Drawing.SystemColors.Control;
            this.DTGVNotas.Location = new System.Drawing.Point(12, 170);
            this.DTGVNotas.Name = "DTGVNotas";
            this.DTGVNotas.ReadOnly = true;
            this.DTGVNotas.RowHeadersVisible = false;
            this.DTGVNotas.Size = new System.Drawing.Size(460, 229);
            this.DTGVNotas.TabIndex = 0;
            // 
            // TxtTitulo
            // 
            this.TxtTitulo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtTitulo.Location = new System.Drawing.Point(13, 31);
            this.TxtTitulo.Name = "TxtTitulo";
            this.TxtTitulo.Size = new System.Drawing.Size(378, 20);
            this.TxtTitulo.TabIndex = 2;
            // 
            // LblTitulo
            // 
            this.LblTitulo.AutoSize = true;
            this.LblTitulo.Location = new System.Drawing.Point(17, 12);
            this.LblTitulo.Name = "LblTitulo";
            this.LblTitulo.Size = new System.Drawing.Size(38, 13);
            this.LblTitulo.TabIndex = 3;
            this.LblTitulo.Text = "Título:";
            // 
            // LblNota
            // 
            this.LblNota.AutoSize = true;
            this.LblNota.Location = new System.Drawing.Point(17, 61);
            this.LblNota.Name = "LblNota";
            this.LblNota.Size = new System.Drawing.Size(33, 13);
            this.LblNota.TabIndex = 4;
            this.LblNota.Text = "Nota:";
            // 
            // BtnSave
            // 
            this.BtnSave.BackColor = System.Drawing.SystemColors.Highlight;
            this.BtnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSave.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.BtnSave.Location = new System.Drawing.Point(397, 29);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(75, 40);
            this.BtnSave.TabIndex = 27;
            this.BtnSave.Text = "Guardar";
            this.BtnSave.UseVisualStyleBackColor = false;
            // 
            // PicFiltro
            // 
            this.PicFiltro.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PicFiltro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(88)))), ((int)(((byte)(88)))));
            this.PicFiltro.Location = new System.Drawing.Point(17, 162);
            this.PicFiltro.MaximumSize = new System.Drawing.Size(300, 2);
            this.PicFiltro.MinimumSize = new System.Drawing.Size(234, 2);
            this.PicFiltro.Name = "PicFiltro";
            this.PicFiltro.Size = new System.Drawing.Size(234, 2);
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
            this.TxtFiltro.Location = new System.Drawing.Point(19, 141);
            this.TxtFiltro.MaximumSize = new System.Drawing.Size(300, 20);
            this.TxtFiltro.MinimumSize = new System.Drawing.Size(230, 20);
            this.TxtFiltro.Name = "TxtFiltro";
            this.TxtFiltro.Size = new System.Drawing.Size(230, 15);
            this.TxtFiltro.TabIndex = 33;
            this.TxtFiltro.Text = "Buscar notas";
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(13, 77);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(459, 58);
            this.textBox1.TabIndex = 35;
            // 
            // Titulo
            // 
            this.Titulo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Titulo.Frozen = true;
            this.Titulo.HeaderText = "Titulo";
            this.Titulo.Name = "Titulo";
            this.Titulo.ReadOnly = true;
            this.Titulo.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Titulo.Width = 150;
            // 
            // Nota
            // 
            this.Nota.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Nota.Frozen = true;
            this.Nota.HeaderText = "Nota";
            this.Nota.Name = "Nota";
            this.Nota.ReadOnly = true;
            this.Nota.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Nota.Width = 305;
            // 
            // FormNotas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(484, 411);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.PicFiltro);
            this.Controls.Add(this.TxtFiltro);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.LblNota);
            this.Controls.Add(this.LblTitulo);
            this.Controls.Add(this.TxtTitulo);
            this.Controls.Add(this.DTGVNotas);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(500, 450);
            this.Name = "FormNotas";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Notas";
            ((System.ComponentModel.ISupportInitialize)(this.DTGVNotas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicFiltro)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DTGVNotas;
        private System.Windows.Forms.TextBox TxtTitulo;
        private System.Windows.Forms.Label LblTitulo;
        private System.Windows.Forms.Label LblNota;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.PictureBox PicFiltro;
        private System.Windows.Forms.TextBox TxtFiltro;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Titulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nota;
    }
}