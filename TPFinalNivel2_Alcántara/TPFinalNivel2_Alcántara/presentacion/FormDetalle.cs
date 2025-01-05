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
            StartPosition = FormStartPosition.CenterScreen;
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

        private void CargarImagen(string imagen)
        {
            try
            {
                if (imagen != null || imagen != "")
                    pbDetalleImagen.Load(imagen);
                else
                    pbDetalleImagen.Load("https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSGZjYKPjVrCS_uKmuUXIkYNXPA3x0q_Y-hYQ&s"); 
            }
            catch (Exception)
            {
                pbDetalleImagen.Load("https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSGZjYKPjVrCS_uKmuUXIkYNXPA3x0q_Y-hYQ&s");
            }
        }
        private void dgvDetalle_SelectionChanged(object sender, EventArgs e)
        {
            string imagen = ListaArticuloDetalle[0].Imagen;
            CargarImagen(imagen);
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
