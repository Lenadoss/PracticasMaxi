namespace presentacion
{
    partial class FormDetalle
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
            this.dgvDetalle = new System.Windows.Forms.DataGridView();
            this.gBoxContenedorDetalle = new System.Windows.Forms.GroupBox();
            this.pbDetalleImagen = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalle)).BeginInit();
            this.gBoxContenedorDetalle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbDetalleImagen)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDetalle
            // 
            this.dgvDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetalle.Location = new System.Drawing.Point(6, 28);
            this.dgvDetalle.Name = "dgvDetalle";
            this.dgvDetalle.Size = new System.Drawing.Size(720, 331);
            this.dgvDetalle.TabIndex = 0;
            // 
            // gBoxContenedorDetalle
            // 
            this.gBoxContenedorDetalle.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.gBoxContenedorDetalle.Controls.Add(this.pbDetalleImagen);
            this.gBoxContenedorDetalle.Controls.Add(this.dgvDetalle);
            this.gBoxContenedorDetalle.Location = new System.Drawing.Point(12, 12);
            this.gBoxContenedorDetalle.Name = "gBoxContenedorDetalle";
            this.gBoxContenedorDetalle.Size = new System.Drawing.Size(1079, 370);
            this.gBoxContenedorDetalle.TabIndex = 1;
            this.gBoxContenedorDetalle.TabStop = false;
            this.gBoxContenedorDetalle.Text = "Ver Detalle De Artículo";
            // 
            // pbDetalleImagen
            // 
            this.pbDetalleImagen.Location = new System.Drawing.Point(732, 28);
            this.pbDetalleImagen.Name = "pbDetalleImagen";
            this.pbDetalleImagen.Size = new System.Drawing.Size(341, 331);
            this.pbDetalleImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbDetalleImagen.TabIndex = 1;
            this.pbDetalleImagen.TabStop = false;
            // 
            // FormDetalle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1103, 392);
            this.Controls.Add(this.gBoxContenedorDetalle);
            this.Name = "FormDetalle";
            this.Text = "Ver Detalle";
            this.Load += new System.EventHandler(this.FormDetalle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalle)).EndInit();
            this.gBoxContenedorDetalle.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbDetalleImagen)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDetalle;
        private System.Windows.Forms.GroupBox gBoxContenedorDetalle;
        private System.Windows.Forms.PictureBox pbDetalleImagen;
    }
}