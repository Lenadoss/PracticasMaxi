using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1erdesafio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Telefono t1 = new Telefono("J2", "Samsung");
            t1.numerotelefonico = "849-207-0368";
            t1.codigooperador = 5;
            Console.WriteLine("Estado del teléfono: " + t1.modelo + ", " + t1.marca + ", " + t1.numerotelefonico + ", " + t1.codigooperador);
            t1.Llamar();
            t1.Llamar("Odanel");
            t1.Llamar("849-207-0368");
        }
    }
}
