using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var cancion = new Cancion("Hell Or High Water", "Runaway", "Passenger","Indie Folk");
            var spoti = new Espotifai();
            var lista = spoti.list;    
            if (spoti.AgregarCancion(cancion))
            {
                lista.Add(cancion);
            }
            var cancion1 = new Cancion("Hell Or High Water", "Runaway", "Passenger", "Indie Folk");
            if (spoti.AgregarCancion(cancion1))
            {
                lista.Add(cancion1);
            }
            var cancion2 = new Cancion("Perfect Symphony", "Divide", "Ed Sheeran", "Indie Folk");
            if (spoti.AgregarCancion(cancion2))
            {
                lista.Add(cancion2);
            }
            spoti.VerCanciones();
            Console.WriteLine(lista.Count);
            Console.ReadLine();
        }
    }
}
