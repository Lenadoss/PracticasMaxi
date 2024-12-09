using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1erdesafio
{
    internal class Telefono
    {
        private string Modelo;
        private string Marca;
        private string NumeroTelefonico;
        private int CodigoOperador;

        public string modelo 
        {
            get { return Modelo; }
        }
        public string marca
        {
            get { return Marca; }
        }
        public string numerotelefonico
        {
            get { return NumeroTelefonico; }
            set { NumeroTelefonico = value; }
        }

        public int codigooperador
        {
            get { return CodigoOperador; }
            set
            {
                if (value > 0 && value < 4)
                { 
                    CodigoOperador = value; 
                }
                else
                {
                    CodigoOperador = 0;
                }
            }
        }

        public Telefono(string Modelo, string Marca)
        {
            this.Modelo=Modelo;
            this.Marca = Marca;
        }

        public void Llamar()
        {
            Console.WriteLine("Estoy llamando..................");
        }

        public void Llamar(string Contacto)
        {
            Console.WriteLine("Estoy llamando a: " + Contacto);
        }
    }
}
