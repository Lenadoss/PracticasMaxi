namespace ejemplo1
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
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtBNombre = new System.Windows.Forms.TextBox();
            this.lblNacimiento = new System.Windows.Forms.Label();
            this.DTPickerFecha = new System.Windows.Forms.DateTimePicker();
            this.chkBChocolate = new System.Windows.Forms.CheckBox();
            this.lblTipo = new System.Windows.Forms.Label();
            this.GPTipo = new System.Windows.Forms.GroupBox();
            this.rdBSquibs = new System.Windows.Forms.RadioButton();
            this.rdBMuggle = new System.Windows.Forms.RadioButton();
            this.rdBWizard = new System.Windows.Forms.RadioButton();
            this.CBoxColor = new System.Windows.Forms.ComboBox();
            this.lblColor = new System.Windows.Forms.Label();
            this.lblNumero = new System.Windows.Forms.Label();
            this.NumUPFavorito = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.GPTipo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumUPFavorito)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(33, 66);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(47, 13);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre:";
            // 
            // txtBNombre
            // 
            this.txtBNombre.Location = new System.Drawing.Point(148, 59);
            this.txtBNombre.Name = "txtBNombre";
            this.txtBNombre.Size = new System.Drawing.Size(200, 20);
            this.txtBNombre.TabIndex = 1;
            // 
            // lblNacimiento
            // 
            this.lblNacimiento.AutoSize = true;
            this.lblNacimiento.Location = new System.Drawing.Point(33, 91);
            this.lblNacimiento.Name = "lblNacimiento";
            this.lblNacimiento.Size = new System.Drawing.Size(109, 13);
            this.lblNacimiento.TabIndex = 2;
            this.lblNacimiento.Text = "Fecha de nacimiento:";
            // 
            // DTPickerFecha
            // 
            this.DTPickerFecha.Location = new System.Drawing.Point(148, 91);
            this.DTPickerFecha.Name = "DTPickerFecha";
            this.DTPickerFecha.Size = new System.Drawing.Size(200, 20);
            this.DTPickerFecha.TabIndex = 3;
            // 
            // chkBChocolate
            // 
            this.chkBChocolate.AutoSize = true;
            this.chkBChocolate.Location = new System.Drawing.Point(36, 120);
            this.chkBChocolate.Name = "chkBChocolate";
            this.chkBChocolate.Size = new System.Drawing.Size(141, 17);
            this.chkBChocolate.TabIndex = 4;
            this.chkBChocolate.Text = "¿Te gusta el chocolate?";
            this.chkBChocolate.UseVisualStyleBackColor = true;
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Location = new System.Drawing.Point(33, 152);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(28, 13);
            this.lblTipo.TabIndex = 5;
            this.lblTipo.Text = "Tipo";
            // 
            // GPTipo
            // 
            this.GPTipo.Controls.Add(this.rdBSquibs);
            this.GPTipo.Controls.Add(this.rdBMuggle);
            this.GPTipo.Controls.Add(this.rdBWizard);
            this.GPTipo.Location = new System.Drawing.Point(36, 172);
            this.GPTipo.Name = "GPTipo";
            this.GPTipo.Size = new System.Drawing.Size(281, 60);
            this.GPTipo.TabIndex = 6;
            this.GPTipo.TabStop = false;
            // 
            // rdBSquibs
            // 
            this.rdBSquibs.AutoSize = true;
            this.rdBSquibs.Location = new System.Drawing.Point(188, 19);
            this.rdBSquibs.Name = "rdBSquibs";
            this.rdBSquibs.Size = new System.Drawing.Size(57, 17);
            this.rdBSquibs.TabIndex = 2;
            this.rdBSquibs.TabStop = true;
            this.rdBSquibs.Text = "Squibs";
            this.rdBSquibs.UseVisualStyleBackColor = true;
            // 
            // rdBMuggle
            // 
            this.rdBMuggle.AutoSize = true;
            this.rdBMuggle.Location = new System.Drawing.Point(97, 19);
            this.rdBMuggle.Name = "rdBMuggle";
            this.rdBMuggle.Size = new System.Drawing.Size(60, 17);
            this.rdBMuggle.TabIndex = 1;
            this.rdBMuggle.TabStop = true;
            this.rdBMuggle.Text = "Muggle";
            this.rdBMuggle.UseVisualStyleBackColor = true;
            // 
            // rdBWizard
            // 
            this.rdBWizard.AutoSize = true;
            this.rdBWizard.Location = new System.Drawing.Point(6, 19);
            this.rdBWizard.Name = "rdBWizard";
            this.rdBWizard.Size = new System.Drawing.Size(58, 17);
            this.rdBWizard.TabIndex = 0;
            this.rdBWizard.TabStop = true;
            this.rdBWizard.Text = "Wizard";
            this.rdBWizard.UseVisualStyleBackColor = true;
            // 
            // CBoxColor
            // 
            this.CBoxColor.FormattingEnabled = true;
            this.CBoxColor.Location = new System.Drawing.Point(111, 238);
            this.CBoxColor.Name = "CBoxColor";
            this.CBoxColor.Size = new System.Drawing.Size(237, 21);
            this.CBoxColor.TabIndex = 7;
            // 
            // lblColor
            // 
            this.lblColor.AutoSize = true;
            this.lblColor.Location = new System.Drawing.Point(33, 241);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(72, 13);
            this.lblColor.TabIndex = 8;
            this.lblColor.Text = "Color Favorito";
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Location = new System.Drawing.Point(33, 273);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(88, 13);
            this.lblNumero.TabIndex = 9;
            this.lblNumero.Text = "Número Favorito:";
            // 
            // NumUPFavorito
            // 
            this.NumUPFavorito.Location = new System.Drawing.Point(127, 271);
            this.NumUPFavorito.Name = "NumUPFavorito";
            this.NumUPFavorito.Size = new System.Drawing.Size(120, 20);
            this.NumUPFavorito.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(36, 316);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "Ver Perfil";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.NumUPFavorito);
            this.Controls.Add(this.lblNumero);
            this.Controls.Add(this.lblColor);
            this.Controls.Add(this.CBoxColor);
            this.Controls.Add(this.GPTipo);
            this.Controls.Add(this.lblTipo);
            this.Controls.Add(this.chkBChocolate);
            this.Controls.Add(this.DTPickerFecha);
            this.Controls.Add(this.lblNacimiento);
            this.Controls.Add(this.txtBNombre);
            this.Controls.Add(this.lblNombre);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.GPTipo.ResumeLayout(false);
            this.GPTipo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumUPFavorito)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtBNombre;
        private System.Windows.Forms.Label lblNacimiento;
        private System.Windows.Forms.DateTimePicker DTPickerFecha;
        private System.Windows.Forms.CheckBox chkBChocolate;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.GroupBox GPTipo;
        private System.Windows.Forms.RadioButton rdBSquibs;
        private System.Windows.Forms.RadioButton rdBMuggle;
        private System.Windows.Forms.RadioButton rdBWizard;
        private System.Windows.Forms.ComboBox CBoxColor;
        private System.Windows.Forms.Label lblColor;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.NumericUpDown NumUPFavorito;
        private System.Windows.Forms.Button button1;
    }
}

