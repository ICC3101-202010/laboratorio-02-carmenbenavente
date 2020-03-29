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
        public void VerCanciones(List<Cancion> l)
        {
            foreach (Cancion c1 in l)
            {
                c1.Informacion();
            }
        }

        public List<Cancion> CancionesPorCriterio(string criterio,string valor)
        {
            List<Cancion> songs = new List<Cancion>(); 

            if (criterio == "name")
            {
                foreach (Cancion s in list)
                {
                    if (valor == s.Name)
                    {
                        songs.Add(s);
                    }
                    else
                    {
                        continue;
                    }
                }
                int cant = songs.Count;

                if (cant == 0)
                {
                    Console.WriteLine("We find no matches");
                    return songs;
                }
                else
                {
                    return songs;
                }
            }
             else if (criterio == "album")
            {
                foreach (Cancion s in list)
                {
                    if (valor == s.Album)
                    {
                        songs.Add(s);
                    }
                    else 
                    {
                        continue;
                    }
                }
                int cant = songs.Count;

                if (cant == 0)
                {
                    Console.WriteLine("We find no matches");
                    return songs;
                }
                else 
                {
                    return songs;
                }
            }
             else if (criterio == "artist")
            {
                foreach (Cancion s in list)
                {
                    if (valor == s.Artist)
                    {
                        songs.Add(s);
                    }
                    else 
                    {
                        continue;
                    }
                }
                int cant = songs.Count;

                if (cant == 0)
                {
                    Console.WriteLine("We find no matches");
                    return songs;
                }
                else 
                {
                    return songs;
                }
            }
             else if (criterio == "genre")
            {
                foreach (Cancion s in list)
                {
                    if (valor == s.Genre)
                    {
                        songs.Add(s);
                    }
                    else 
                    {
                        continue;
                    }
                }
                int cant = songs.Count;

                if (cant == 0)
                {
                    Console.WriteLine("We find no matches");
                    return songs;
                }
                else 
                {
                    return songs;
                }
            }
             else
            {
                Console.WriteLine("Please enter a valid answer");
                return songs;
            }
        }
    }
}
