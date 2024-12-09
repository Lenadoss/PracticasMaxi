using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemplo1
{
    internal class Persona
    {
        public string Nombre { get; set; }
        public DateTime Fecha { get; set; }
        public string GustaChocolate { get; set; }
        public string Tipo { get; set; }
        public string ColorFavorito { get; set; }
        public string NumeroFavorito { get; set; }

        public Persona(string nombre, DateTime fecha, string gustaChocolate, string tipo, string colorFavorito, string numeroFavorito)
        {
            Nombre = nombre;
            Fecha = fecha;
            GustaChocolate = gustaChocolate;
            Tipo = tipo;
            ColorFavorito = colorFavorito;
            NumeroFavorito = numeroFavorito;
        }

        public string Saludar()
        {
            return $"Hola {Nombre}, Naciste en: {Fecha}, ¿Te gusta el chocolate? {GustaChocolate}, Eres tipo: {Tipo}, Tu color favorito es: {ColorFavorito} y tu número favorito es: {NumeroFavorito} ";
        }
    }
}
