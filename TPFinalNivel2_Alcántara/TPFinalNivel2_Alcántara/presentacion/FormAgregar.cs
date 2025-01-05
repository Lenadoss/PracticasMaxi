using Data;
using System;
using dominio;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocio;

namespace presentacion
{
    public partial class FormAgregar : Form
    {
        Helpers helpers = new Helpers();    
        ArticuloNegocio Negocio = new ArticuloNegocio();
        MarcaNegocio MarcaNegocio = new MarcaNegocio();
        CategoriaNegocio CategoriaNegocio = new CategoriaNegocio();
        List<Categoria> ListaCategoria = new List<Categoria>();
        List<Marca> ListaMarca = new List<Marca>();
        FormPrincipal FormPrincipal = new FormPrincipal();
        private Articulo articulo = null;
        public FormAgregar()
        {
            InitializeComponent();
        }

        public FormAgregar(Articulo articulo)
        {
            InitializeComponent();
            this.articulo = articulo;
            Text = "Modificando artículo";
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                if(articulo == null)
                    articulo = new Articulo();
                
                articulo.Codigo = txtCodigo.Text;
                articulo.Nombre = txtNombre.Text;
                articulo.Descripcion = txtDescripcion.Text;
                articulo.Marca = (Marca)cbBoxMarca.SelectedItem;
                articulo.Categoria = (Categoria)cbBoxCategoria.SelectedItem;
                articulo.Imagen = txtImagen.Text;
                articulo.Precio = txtPrecio.Text != "" ? Convert.ToDecimal(txtPrecio.Text) : articulo.Precio = 0;

                if (articulo.Id != 0)
                {
                    Negocio.Modificar(articulo);
                    MessageBox.Show("¡Artículo modificado correctamente!", "¡Enhorabuena!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    this.Close();
                }
                else
                {
                    Negocio.Agregar(articulo);
                    MessageBox.Show("¡Artículo agregado correctamente!", "¡Enhorabuena!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    this.Close();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Algo anda mal con la inserción del artículo...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormAgregar_Load(object sender, EventArgs e)
        {
            ListaCategoria = CategoriaNegocio.Listar();
            ListaMarca = MarcaNegocio.Listar();
            cbBoxCategoria.DataSource = ListaCategoria;
            cbBoxMarca.DataSource = ListaMarca;
            cbBoxMarca.ValueMember = "Id";
            cbBoxMarca.DisplayMember = "Descripcion";
            cbBoxCategoria.ValueMember = "Id";
            cbBoxCategoria.DisplayMember = "Descripcion";

            if(articulo != null)
            {
                CargarImagen(articulo.Imagen);
                txtCodigo.Text = articulo.Codigo;
                txtNombre.Text = articulo.Nombre;
                txtDescripcion.Text = articulo.Descripcion;
                cbBoxMarca.SelectedItem = articulo.Marca;
                cbBoxCategoria.SelectedItem = articulo.Categoria;
                txtImagen.Text = articulo.Imagen;
                txtPrecio.Text = articulo.Precio.ToString();
            }
        }

        private void txtCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            helpers.SoloLetrasYNumeros(e);
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            helpers.SoloLetrasNumerosEspacio(e);
        }

        private void txtDescripcion_KeyPress(object sender, KeyPressEventArgs e)
        {
            helpers.SoloLetras(e);
        }

        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            helpers.SoloNumeros(e);
        }

        private void txtImagen_Leave(object sender, EventArgs e)
        {
            string Imagen = txtImagen.Text;
            CargarImagen(Imagen);   
        }

        private void CargarImagen(string imagen)
        {
            try
            {
                if(imagen != "" || imagen != null)
                    p.Load(imagen);
                else 
                    p.Load("https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSGZjYKPjVrCS_uKmuUXIkYNXPA3x0q_Y-hYQ&s");
            }
            catch (Exception ex)
            {
                p.Load("https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSGZjYKPjVrCS_uKmuUXIkYNXPA3x0q_Y-hYQ&s");
            }
        }
    }
}
