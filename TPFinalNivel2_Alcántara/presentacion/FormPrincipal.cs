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
        ArticuloNegocio Negocio = new ArticuloNegocio();
        public FormPrincipal()
        {
            InitializeComponent();
        }

        public void Cargar()
        {
            try
            {
                var ListaArticulos = new List<Articulo>();
                ListaArticulos = Negocio.CargarListaBD();
                dgvListado.DataSource = null; // Limpiar el DataSource actual
                dgvListado.DataSource = ListaArticulos; // Asignar el nuevo DataSource
                OcultarColumnas();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void OcultarColumnas()
        {
            try
            {
                dgvListado.Columns["Imagen"].Visible = false;
                dgvListado.Columns["Id"].Visible = false;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
      
        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            try
            {
                Cargar();
                cbBoxCampo.Items.Add("Nombre");
                cbBoxCampo.Items.Add("Descripción");
            }
            catch (Exception)
            {
                MessageBox.Show("Algo anda mal...", "Fallando", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AgregarMenu_Click(object sender, EventArgs e)
        {
            try
            {
                FormAgregar Agregar = new FormAgregar();
                Agregar.ShowDialog();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void dgvListado_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                CargarImagenArticulo();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private void txtFiltroRapido_TextChanged(object sender, EventArgs e)
        {
            try
            {
                FiltroRapido();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void FiltroRapido()
        {
            try
            {
                var Lista = new List<Articulo>();
                var ListaFiltrada = new List<Articulo>();
                Lista = Negocio.CargarListaBD();
                ListaFiltrada = Lista.FindAll(x => x.Nombre.ToUpper().Contains(txtFiltroRapido.Text.ToUpper()));
                dgvListado.DataSource = ListaFiltrada;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void CargarImagenArticulo()
        {
            try
            {
                Articulo Seleccionado = (Articulo)dgvListado.CurrentRow.DataBoundItem;
                if (Seleccionado.Imagen != null || Seleccionado.Imagen != "")
                    pcBoxArticulo.Load(Seleccionado.Imagen);
                else
                    pcBoxArticulo.Load("https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSGZjYKPjVrCS_uKmuUXIkYNXPA3x0q_Y-hYQ&s");
            }
            catch (Exception)
            {
                pcBoxArticulo.Load("https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSGZjYKPjVrCS_uKmuUXIkYNXPA3x0q_Y-hYQ&s");
            }
        }
        private void ModificarMenu_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult M = MessageBox.Show("¿Desea modificar este artículo?.", "Modificando", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (M == DialogResult.Yes)
                {
                    Articulo Seleccionado = (Articulo)dgvListado.CurrentRow.DataBoundItem;
                    FormAgregar Modificar = new FormAgregar(Seleccionado);
                    Modificar.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private void EliminarMenu_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult M = MessageBox.Show("¿Desea eliminar este artículo?", "Eliminando", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (M == DialogResult.Yes)
                {
                    Articulo Seleccionado = (Articulo)dgvListado.CurrentRow.DataBoundItem;
                    Negocio.EliminarBD(Seleccionado);
                    Cargar();
                }
                else
                    return;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private void cbBoxCampo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string opcion = cbBoxCampo.SelectedItem.ToString();

            switch (opcion)
            {
                case "Nombre":
                    cbBoxCriterio.Items.Clear();
                    cbBoxCriterio.Items.Add("Comienza con");
                    cbBoxCriterio.Items.Add("Termina con");
                    cbBoxCriterio.Items.Add("Contiene");
                    break;

                case "Descripción":
                    cbBoxCriterio.Items.Clear();
                    cbBoxCriterio.Items.Add("Comienza con");
                    cbBoxCriterio.Items.Add("Termina con");
                    cbBoxCriterio.Items.Add("Contiene");
                    break;
            }
        }

        private void btnBuscarFiltroAvanzado_Click(object sender, EventArgs e)
        {
            try
            {
                List<Articulo> listafiltrada = new List<Articulo>();
                string campo = cbBoxCampo.SelectedItem.ToString();
                string criterio = cbBoxCriterio.SelectedItem.ToString();
                string filtro = txtFiltroAvanzado.Text;
                listafiltrada = Negocio.FiltroBD(campo, criterio, filtro);

                dgvListado.DataSource = listafiltrada;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<Articulo> GuardarObjetoDetalle()
        {
            List<Articulo> ListaArticulosDetalle = new List<Articulo>();
            try
            {
                Articulo articulo;
                articulo = (Articulo)dgvListado.CurrentRow.DataBoundItem;
                ListaArticulosDetalle.Add(articulo);
                return ListaArticulosDetalle;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void verDetalleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<Articulo> ListaArticulosDetalle = new List<Articulo>();
            try
            {
                DialogResult Respuesta = MessageBox.Show("¿Desea conocer la información de este artículo?", "Detalle", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if(Respuesta == DialogResult.OK)
                {
                    ListaArticulosDetalle = GuardarObjetoDetalle(); 
                    FormDetalle Detalle = new FormDetalle(ListaArticulosDetalle);
                    Detalle.ShowDialog();
                }
                else
                {
                    return;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Algo anda mal con la información del artículo...", "Fallando", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
