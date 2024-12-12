using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplicaciónPráctica
{
    public partial class Form1 : Form
    {
        private List<Disco> ListaDisco;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DiscoNegocio Negocio = new DiscoNegocio();
            ListaDisco = Negocio.Listar();
            dgvDisco.DataSource = ListaDisco;
            dgvDisco.Columns["UrlImagen"].Visible = false;
        }

        private void dgvDisco_SelectionChanged(object sender, EventArgs e)
        {
            Disco FilaSeleccionada = (Disco)dgvDisco.CurrentRow.DataBoundItem;
            CargarImagen(FilaSeleccionada.UrlImagen);
        }

        private void CargarImagen(string Url)
        {
            try
            {
                pbxDisco.Load(Url);
            }
            catch(Exception ex)
            {
                pbxDisco.Load("https://previews.123rf.com/images/3dgenerator/3dgenerator1705/3dgenerator170500753/78077135-se%C3%B1al-de-interrogaci%C3%B3n-signpost.jpg");
            }
        }
    }
}
