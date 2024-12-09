using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListasEjemplos
{
    internal class AnimalDomestico : Animal, Caminadores
    {
        public string Nombre { get; set; }

        public string Comunicarse(string sonido)
        {
            return sonido;
        }

        public string caminar()
        {
            return "Estoy caminando";
        }
        public string patear()
        {
            return "Estoy pateando";
        }
    }
}
