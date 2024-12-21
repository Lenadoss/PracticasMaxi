using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocio;
using dominio;

namespace presentacion
{
    public partial class FormPrincipal : Form
    {
        private List<Articulo> ListaArticulos;
        ArticuloNegocio Negocio = new ArticuloNegocio();
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void Cargar()
        {
            ListaArticulos = Negocio.CargarListaBD();
            dgvListado.DataSource = ListaArticulos;
            OcultarColumnas();
        }
        private void OcultarColumnas()
        {
            dgvListado.Columns["Imagen"].Visible = false;
        }
      
        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            Cargar();
        }

        private void AgregarMenu_Click(object sender, EventArgs e)
        {
            FormAgregar Agregar = new FormAgregar();
            Agregar.ShowDialog();
        }
    }
}
