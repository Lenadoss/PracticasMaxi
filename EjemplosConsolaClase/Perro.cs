using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemplosConsolaClase
{
    internal class Perro
    {
        private string Nombre;
        private string Color;
        private string Origen;
        public Perro(string Nombre, string Color, string Origen)
        {
            this.Nombre = Nombre;
            this.Color = Color;
            this.Origen = Origen;
        }

        public string nombre
        {
            get { return Nombre; }
        }

        public string color 
        {
            get { return Color; }
        }

        public string origen
        {
            get { return Origen; }
        }
        public void Ladrar()
        {
            Console.WriteLine("Estoy ladrando...");
        }
    }
}
