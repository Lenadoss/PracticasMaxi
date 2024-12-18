using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dominio
{
    public class Articulo
    {
        [DisplayName("Código")]
        public int Codigo { get; set; }
        public string Nombre { get; set; }
        [DisplayName("Descripción")]
        public string Descripcion { get; set; }
        public string Marca { get; set; }
        [DisplayName("Categoría")]
        public string Categoria { get; set; }
        public string Imagen { get; set; }
        public double Precio { get; set; }
    }
}
