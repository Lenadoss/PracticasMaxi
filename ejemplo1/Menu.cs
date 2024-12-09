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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }
        private void personaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
        foreach (var item in Application.OpenForms)
        {
            if (item.GetType() == typeof(Form1))
            {
                return; //Finaliza el evento; no se mostrará la pantalla.
            }
        }
        Form1 VentanaS1 = new Form1();
            VentanaS1.MdiParent = this;
            VentanaS1.Show();
        }

        private void magoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
        foreach (var item in Application.OpenForms)
        {
            if (item.GetType() == typeof(Form2))
            {
                return; //Finaliza el evento; no se mostrará la pantalla.
            }
        }
        
        Form2 VentanaS2 = new Form2();
            VentanaS2.MdiParent = this;
            VentanaS2.Show();
        }

        private void Menu_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult Result = MessageBox.Show("Estás seguro de que quieres salir?", "¿Seguro?", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if(Result == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        }
    }
}
