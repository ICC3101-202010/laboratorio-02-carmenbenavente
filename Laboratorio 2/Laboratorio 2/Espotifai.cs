using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_2
{
    public class Espotifai
    {
        private List<Cancion> list = new List<Cancion>();
        private List<Playlist> playlist = new List<Playlist>();

        public List<Playlist> Playlist { get => playlist; set => playlist = value; }
        public List<Cancion> List { get => list; set => list = value; }

        public Espotifai()
        { }

        public bool  AgregarCancion(Cancion cancion)
        {
            {
                bool result = true;
                foreach (Cancion c in List)
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
            foreach (Cancion c1 in List)
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
                foreach (Cancion s in List)
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
                foreach (Cancion s in List)
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
                foreach (Cancion s in List)
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
                foreach (Cancion s in List)
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

         public bool GenerarPlayList(string criterio, string valorCriterio, string nombrePlaylist)
        {
            List<Cancion> pl = CancionesPorCriterio(criterio, valorCriterio);
            Playlist PL = new Playlist(nombrePlaylist, pl);
            
            foreach (Playlist p in Playlist)
            {
                if (nombrePlaylist == p.NamePL1)
                    {
                        Console.WriteLine("This name is already used");
                        return false;
                    }
                else 
                {
                    continue;
                }
                
            }
            if (pl.Count == 0)
            {
                Console.WriteLine("We find no matches");
                return false;
            }
            else
            {
                Playlist.Add(PL);
                return true;
            }

        }

       public void VerMisPlaylists()
        {
            foreach (Playlist j in Playlist)
            {
                j.VerPlaylist();
            }
        }

    }
}
