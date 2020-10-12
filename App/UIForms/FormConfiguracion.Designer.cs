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
            this.PnlMenuConfig = new System.Windows.Forms.Panel();
            this.BtnReset = new System.Windows.Forms.Button();
            this.BtnTema = new System.Windows.Forms.Button();
            this.BtnSaldos = new System.Windows.Forms.Button();
            this.PnlMenuConfig.SuspendLayout();
            this.SuspendLayout();
            // 
            // PnlMenuConfig
            // 
            this.PnlMenuConfig.Controls.Add(this.BtnReset);
            this.PnlMenuConfig.Controls.Add(this.BtnSaldos);
            this.PnlMenuConfig.Controls.Add(this.BtnTema);
            this.PnlMenuConfig.Dock = System.Windows.Forms.DockStyle.Left;
            this.PnlMenuConfig.Location = new System.Drawing.Point(0, 0);
            this.PnlMenuConfig.Name = "PnlMenuConfig";
            this.PnlMenuConfig.Size = new System.Drawing.Size(200, 261);
            this.PnlMenuConfig.TabIndex = 0;
            // 
            // BtnReset
            // 
            this.BtnReset.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.BtnReset.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnReset.BackColor = System.Drawing.Color.Transparent;
            this.BtnReset.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.BtnReset.FlatAppearance.BorderSize = 0;
            this.BtnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnReset.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.BtnReset.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnReset.Location = new System.Drawing.Point(0, 207);
            this.BtnReset.MaximumSize = new System.Drawing.Size(300, 50);
            this.BtnReset.MinimumSize = new System.Drawing.Size(200, 50);
            this.BtnReset.Name = "BtnReset";
            this.BtnReset.Size = new System.Drawing.Size(200, 50);
            this.BtnReset.TabIndex = 7;
            this.BtnReset.Text = "Borrar Datos";
            this.BtnReset.UseVisualStyleBackColor = false;
            // 
            // BtnTema
            // 
            this.BtnTema.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.BtnTema.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnTema.BackColor = System.Drawing.Color.Transparent;
            this.BtnTema.Enabled = false;
            this.BtnTema.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.BtnTema.FlatAppearance.BorderSize = 0;
            this.BtnTema.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnTema.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnTema.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.BtnTema.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnTema.Location = new System.Drawing.Point(0, 94);
            this.BtnTema.MaximumSize = new System.Drawing.Size(300, 50);
            this.BtnTema.MinimumSize = new System.Drawing.Size(200, 50);
            this.BtnTema.Name = "BtnTema";
            this.BtnTema.Size = new System.Drawing.Size(200, 50);
            this.BtnTema.TabIndex = 5;
            this.BtnTema.Text = "Temas";
            this.BtnTema.UseVisualStyleBackColor = false;
            // 
            // BtnSaldos
            // 
            this.BtnSaldos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.BtnSaldos.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnSaldos.BackColor = System.Drawing.Color.Transparent;
            this.BtnSaldos.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.BtnSaldos.FlatAppearance.BorderSize = 0;
            this.BtnSaldos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSaldos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSaldos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.BtnSaldos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnSaldos.Location = new System.Drawing.Point(0, 38);
            this.BtnSaldos.MaximumSize = new System.Drawing.Size(300, 50);
            this.BtnSaldos.MinimumSize = new System.Drawing.Size(200, 50);
            this.BtnSaldos.Name = "BtnSaldos";
            this.BtnSaldos.Size = new System.Drawing.Size(200, 50);
            this.BtnSaldos.TabIndex = 4;
            this.BtnSaldos.Text = "Saldos";
            this.BtnSaldos.UseVisualStyleBackColor = false;
            // 
            // FormConfiguracion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 261);
            this.Controls.Add(this.PnlMenuConfig);
            this.MaximumSize = new System.Drawing.Size(500, 300);
            this.MinimumSize = new System.Drawing.Size(500, 300);
            this.Name = "FormConfiguracion";
            this.Text = "FormConfiguracion";
            this.PnlMenuConfig.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PnlMenuConfig;
        private System.Windows.Forms.Button BtnReset;
        private System.Windows.Forms.Button BtnSaldos;
        private System.Windows.Forms.Button BtnTema;
    }
}