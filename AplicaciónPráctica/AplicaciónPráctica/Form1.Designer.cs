namespace AplicaciónPráctica
{
    partial class Form1
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
            this.pbxDisco = new System.Windows.Forms.PictureBox();
            this.dgvDisco = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pbxDisco)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDisco)).BeginInit();
            this.SuspendLayout();
            // 
            // pbxDisco
            // 
            this.pbxDisco.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pbxDisco.Location = new System.Drawing.Point(814, 12);
            this.pbxDisco.Name = "pbxDisco";
            this.pbxDisco.Size = new System.Drawing.Size(358, 326);
            this.pbxDisco.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxDisco.TabIndex = 0;
            this.pbxDisco.TabStop = false;
            // 
            // dgvDisco
            // 
            this.dgvDisco.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dgvDisco.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDisco.Location = new System.Drawing.Point(61, 12);
            this.dgvDisco.Name = "dgvDisco";
            this.dgvDisco.Size = new System.Drawing.Size(747, 326);
            this.dgvDisco.TabIndex = 1;
            this.dgvDisco.SelectionChanged += new System.EventHandler(this.dgvDisco_SelectionChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(1217, 350);
            this.Controls.Add(this.dgvDisco);
            this.Controls.Add(this.pbxDisco);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxDisco)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDisco)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbxDisco;
        private System.Windows.Forms.DataGridView dgvDisco;
    }
}

