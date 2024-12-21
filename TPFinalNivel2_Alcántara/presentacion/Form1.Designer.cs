namespace presentacion
{
    partial class FormPrincipal
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
            this.BarraNavegacion = new System.Windows.Forms.MenuStrip();
            this.BuscarMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.AgregarMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.ModificarMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.EliminarMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.dgvListado = new System.Windows.Forms.DataGridView();
            this.GroupBData = new System.Windows.Forms.GroupBox();
            this.txtFiltroRapido = new System.Windows.Forms.TextBox();
            this.lblFiltroRapido = new System.Windows.Forms.Label();
            this.lblCampo = new System.Windows.Forms.Label();
            this.GroupBFiltroAvanzado = new System.Windows.Forms.GroupBox();
            this.txtFiltroAvanzado = new System.Windows.Forms.TextBox();
            this.lblFiltro = new System.Windows.Forms.Label();
            this.lblCriterio = new System.Windows.Forms.Label();
            this.cbBoxCriterio = new System.Windows.Forms.ComboBox();
            this.cbBoxCampo = new System.Windows.Forms.ComboBox();
            this.pcBoxArticulo = new System.Windows.Forms.PictureBox();
            this.BarraNavegacion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListado)).BeginInit();
            this.GroupBData.SuspendLayout();
            this.GroupBFiltroAvanzado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcBoxArticulo)).BeginInit();
            this.SuspendLayout();
            // 
            // BarraNavegacion
            // 
            this.BarraNavegacion.BackColor = System.Drawing.SystemColors.ControlLight;
            this.BarraNavegacion.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BuscarMenu,
            this.AgregarMenu,
            this.ModificarMenu,
            this.EliminarMenu});
            this.BarraNavegacion.Location = new System.Drawing.Point(0, 0);
            this.BarraNavegacion.Name = "BarraNavegacion";
            this.BarraNavegacion.Size = new System.Drawing.Size(966, 24);
            this.BarraNavegacion.TabIndex = 0;
            this.BarraNavegacion.Text = "menuStrip1";
            // 
            // BuscarMenu
            // 
            this.BuscarMenu.Name = "BuscarMenu";
            this.BuscarMenu.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.B)));
            this.BuscarMenu.Size = new System.Drawing.Size(54, 20);
            this.BuscarMenu.Text = "&Buscar";
            // 
            // AgregarMenu
            // 
            this.AgregarMenu.Name = "AgregarMenu";
            this.AgregarMenu.Size = new System.Drawing.Size(106, 20);
            this.AgregarMenu.Text = "&Agregar Artículo";
            this.AgregarMenu.Click += new System.EventHandler(this.AgregarMenu_Click);
            // 
            // ModificarMenu
            // 
            this.ModificarMenu.Name = "ModificarMenu";
            this.ModificarMenu.Size = new System.Drawing.Size(115, 20);
            this.ModificarMenu.Text = "&Modificar Artículo";
            // 
            // EliminarMenu
            // 
            this.EliminarMenu.Name = "EliminarMenu";
            this.EliminarMenu.Size = new System.Drawing.Size(107, 20);
            this.EliminarMenu.Text = "&Eliminar Artículo";
            // 
            // dgvListado
            // 
            this.dgvListado.AllowUserToResizeColumns = false;
            this.dgvListado.AllowUserToResizeRows = false;
            this.dgvListado.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dgvListado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListado.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvListado.Location = new System.Drawing.Point(6, 53);
            this.dgvListado.Name = "dgvListado";
            this.dgvListado.Size = new System.Drawing.Size(652, 261);
            this.dgvListado.TabIndex = 1;
            // 
            // GroupBData
            // 
            this.GroupBData.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.GroupBData.BackColor = System.Drawing.Color.WhiteSmoke;
            this.GroupBData.Controls.Add(this.pcBoxArticulo);
            this.GroupBData.Controls.Add(this.txtFiltroRapido);
            this.GroupBData.Controls.Add(this.lblFiltroRapido);
            this.GroupBData.Controls.Add(this.dgvListado);
            this.GroupBData.Location = new System.Drawing.Point(12, 27);
            this.GroupBData.Name = "GroupBData";
            this.GroupBData.Size = new System.Drawing.Size(942, 329);
            this.GroupBData.TabIndex = 2;
            this.GroupBData.TabStop = false;
            this.GroupBData.Text = "Listado de artículos";
            // 
            // txtFiltroRapido
            // 
            this.txtFiltroRapido.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFiltroRapido.Location = new System.Drawing.Point(376, 19);
            this.txtFiltroRapido.Name = "txtFiltroRapido";
            this.txtFiltroRapido.Size = new System.Drawing.Size(279, 20);
            this.txtFiltroRapido.TabIndex = 4;
            // 
            // lblFiltroRapido
            // 
            this.lblFiltroRapido.AutoSize = true;
            this.lblFiltroRapido.Location = new System.Drawing.Point(309, 22);
            this.lblFiltroRapido.Name = "lblFiltroRapido";
            this.lblFiltroRapido.Size = new System.Drawing.Size(61, 13);
            this.lblFiltroRapido.TabIndex = 3;
            this.lblFiltroRapido.Text = "Filtro rápido";
            // 
            // lblCampo
            // 
            this.lblCampo.AutoSize = true;
            this.lblCampo.Location = new System.Drawing.Point(15, 34);
            this.lblCampo.Name = "lblCampo";
            this.lblCampo.Size = new System.Drawing.Size(40, 13);
            this.lblCampo.TabIndex = 3;
            this.lblCampo.Text = "Campo";
            // 
            // GroupBFiltroAvanzado
            // 
            this.GroupBFiltroAvanzado.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.GroupBFiltroAvanzado.BackColor = System.Drawing.Color.WhiteSmoke;
            this.GroupBFiltroAvanzado.Controls.Add(this.txtFiltroAvanzado);
            this.GroupBFiltroAvanzado.Controls.Add(this.lblFiltro);
            this.GroupBFiltroAvanzado.Controls.Add(this.lblCriterio);
            this.GroupBFiltroAvanzado.Controls.Add(this.cbBoxCriterio);
            this.GroupBFiltroAvanzado.Controls.Add(this.cbBoxCampo);
            this.GroupBFiltroAvanzado.Controls.Add(this.lblCampo);
            this.GroupBFiltroAvanzado.Location = new System.Drawing.Point(12, 362);
            this.GroupBFiltroAvanzado.Name = "GroupBFiltroAvanzado";
            this.GroupBFiltroAvanzado.Size = new System.Drawing.Size(697, 65);
            this.GroupBFiltroAvanzado.TabIndex = 6;
            this.GroupBFiltroAvanzado.TabStop = false;
            this.GroupBFiltroAvanzado.Text = "Filtro Avanzado";
            // 
            // txtFiltroAvanzado
            // 
            this.txtFiltroAvanzado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFiltroAvanzado.Location = new System.Drawing.Point(413, 31);
            this.txtFiltroAvanzado.Name = "txtFiltroAvanzado";
            this.txtFiltroAvanzado.Size = new System.Drawing.Size(236, 20);
            this.txtFiltroAvanzado.TabIndex = 8;
            // 
            // lblFiltro
            // 
            this.lblFiltro.AutoSize = true;
            this.lblFiltro.Location = new System.Drawing.Point(366, 34);
            this.lblFiltro.Name = "lblFiltro";
            this.lblFiltro.Size = new System.Drawing.Size(29, 13);
            this.lblFiltro.TabIndex = 7;
            this.lblFiltro.Text = "Filtro";
            // 
            // lblCriterio
            // 
            this.lblCriterio.AutoSize = true;
            this.lblCriterio.Location = new System.Drawing.Point(191, 34);
            this.lblCriterio.Name = "lblCriterio";
            this.lblCriterio.Size = new System.Drawing.Size(39, 13);
            this.lblCriterio.TabIndex = 6;
            this.lblCriterio.Text = "Criterio";
            // 
            // cbBoxCriterio
            // 
            this.cbBoxCriterio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBoxCriterio.FormattingEnabled = true;
            this.cbBoxCriterio.Location = new System.Drawing.Point(248, 30);
            this.cbBoxCriterio.Name = "cbBoxCriterio";
            this.cbBoxCriterio.Size = new System.Drawing.Size(100, 21);
            this.cbBoxCriterio.TabIndex = 5;
            // 
            // cbBoxCampo
            // 
            this.cbBoxCampo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBoxCampo.FormattingEnabled = true;
            this.cbBoxCampo.Location = new System.Drawing.Point(73, 30);
            this.cbBoxCampo.Name = "cbBoxCampo";
            this.cbBoxCampo.Size = new System.Drawing.Size(100, 21);
            this.cbBoxCampo.TabIndex = 4;
            // 
            // pcBoxArticulo
            // 
            this.pcBoxArticulo.Location = new System.Drawing.Point(664, 53);
            this.pcBoxArticulo.Name = "pcBoxArticulo";
            this.pcBoxArticulo.Size = new System.Drawing.Size(272, 261);
            this.pcBoxArticulo.TabIndex = 5;
            this.pcBoxArticulo.TabStop = false;
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(966, 431);
            this.Controls.Add(this.GroupBData);
            this.Controls.Add(this.BarraNavegacion);
            this.Controls.Add(this.GroupBFiltroAvanzado);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "FormPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Página Principal | Buscar";
            this.Load += new System.EventHandler(this.FormPrincipal_Load);
            this.BarraNavegacion.ResumeLayout(false);
            this.BarraNavegacion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListado)).EndInit();
            this.GroupBData.ResumeLayout(false);
            this.GroupBData.PerformLayout();
            this.GroupBFiltroAvanzado.ResumeLayout(false);
            this.GroupBFiltroAvanzado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcBoxArticulo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip BarraNavegacion;
        private System.Windows.Forms.ToolStripMenuItem BuscarMenu;
        private System.Windows.Forms.ToolStripMenuItem AgregarMenu;
        private System.Windows.Forms.ToolStripMenuItem ModificarMenu;
        private System.Windows.Forms.ToolStripMenuItem EliminarMenu;
        private System.Windows.Forms.DataGridView dgvListado;
        private System.Windows.Forms.GroupBox GroupBData;
        private System.Windows.Forms.Label lblFiltroRapido;
        private System.Windows.Forms.TextBox txtFiltroRapido;
        private System.Windows.Forms.Label lblCampo;
        private System.Windows.Forms.GroupBox GroupBFiltroAvanzado;
        private System.Windows.Forms.Label lblCriterio;
        private System.Windows.Forms.ComboBox cbBoxCriterio;
        private System.Windows.Forms.ComboBox cbBoxCampo;
        private System.Windows.Forms.TextBox txtFiltroAvanzado;
        private System.Windows.Forms.Label lblFiltro;
        private System.Windows.Forms.PictureBox pcBoxArticulo;
    }
}

