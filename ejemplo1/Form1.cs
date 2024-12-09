using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejemplo1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string NOmbre, Chocolate, Tipo, Color, Numero;
            NOmbre = txtBNombre.Text;
            DateTime Fecha = DTPickerFecha.Value;
            Chocolate = chkBChocolate.Checked ? "Si" : "No";
            if (rdBWizard.Checked)
            {
                Tipo = rdBWizard.Text;
            }
            else if (rdBMuggle.Checked)
            {
                Tipo = rdBMuggle.Text;
            }
            else
            {
                Tipo = rdBSquibs.Text;
            }
            Color = CBoxColor.SelectedItem.ToString();
            Numero = NumUPFavorito.Value.ToString();
            Persona perfil = new Persona(NOmbre, Fecha, Chocolate, Tipo, Color, Numero);
            MessageBox.Show(perfil.Saludar());
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CBoxColor.Items.Add("Rojo");
            CBoxColor.Items.Add("Azul");
        }
    }
}
