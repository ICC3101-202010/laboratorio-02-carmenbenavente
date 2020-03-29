using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_2
{
    public class Espotifai
    {
        public List<Cancion> list = new List<Cancion>(); 

        public Espotifai()
        { }

        public bool  AgregarCancion(Cancion cancion)
        {
            {
                bool result = true;
                foreach (Cancion c in list)
                {
                    if ((c.Name == cancion.Name) && (c.Album == cancion.Album) && (c.Artist == cancion.Artist))
                    {
                        result = false;
                    }
                    else
                    {
                        result =  true;
                    }
                }
                return result;
            }
        }
        
        public void VerCanciones()
        {
            foreach (Cancion c1 in list)
            {
                c1.Informacion();
            }
        }
    }
}
