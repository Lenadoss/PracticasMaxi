using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemplosConsolaClase
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string Nom;
            string Col;
            string Ori;

            Console.Write("Ingrese el nombre del perro:");
            Nom = Console.ReadLine();

            Console.Write("Ingrese el color del perro:");
            Col = Console.ReadLine();

            Console.Write("Ingrese el origen del perro:");
            Ori = Console.ReadLine();

            var perro1 = new Perro(Nom, Col, Ori);
            
            
            Console.WriteLine("Esta es la información del perro: "+ perro1.nombre +", " + perro1.color + ", " + perro1.origen);

            perro1.Ladrar();
        }
    }
}
