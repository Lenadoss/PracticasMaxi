using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using dominio;

namespace presentacion
{
    public partial class FormDetalle : Form
    {
        private List<Articulo> ListaArticuloDetalle = new List<Articulo>();
        public FormDetalle(List<Articulo> articulo)
        {
            InitializeComponent();
            ListaArticuloDetalle = articulo;
        }

        private void FormDetalle_Load(object sender, EventArgs e)
        {
            Cargar();
        }

        private void Cargar()
        {
            dgvDetalle.DataSource = null;
            dgvDetalle.DataSource = ListaArticuloDetalle;
            OcultarColumnas();
        }
        
        private void OcultarColumnas()
        {
            dgvDetalle.Columns["Imagen"].Visible = false;
        }

        private void CargarImagen()
        {
            try
            {
                if()
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
