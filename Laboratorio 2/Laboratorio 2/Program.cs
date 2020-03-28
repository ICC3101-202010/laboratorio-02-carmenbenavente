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
            var cancion = new Cancion("Stairway to Heaven", "Led Zeppelin IV", "Led Zeppelin","Hard Rock");
            cancion.Informacion();
            Console.ReadLine();
        }
    }
}
