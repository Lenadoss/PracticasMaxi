using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicaciónPráctica
{
    internal class Disco
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public DateTime FechaLanzamiento { get; set; }
        public int CantidadCanciones { get; set; }
        public string UrlImagen { get; set; }
        public string Estilo { get; set; }
        public string Edicion { get; set; }

        public Disco(int Id, string Titulo, DateTime FechaLanzamiento, int CantidadCanciones, string UrlImagen, string Estilo, string Edicion)
        {
            this.Id = Id;
            this.Titulo = Titulo;
            this.FechaLanzamiento = FechaLanzamiento;
            this.CantidadCanciones = CantidadCanciones;
            this.UrlImagen = UrlImagen;
            this.Estilo = Estilo;
            this.Edicion = Edicion;
        }
    }
}
