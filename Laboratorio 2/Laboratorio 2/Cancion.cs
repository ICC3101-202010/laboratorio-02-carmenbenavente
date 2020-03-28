using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_2
{
    public class Cancion
    {
        public string Name;
        public string Album;
        public string Artist;
        public string Genre;

        public Cancion(string name, string album, string artist, string genre)
        {
            this.Name = name;
            this.Album = album;
            this.Artist = artist;
            this.Genre = genre;
        }

        public void Informacion()
        {
            Console.WriteLine("genero: {0}, artista: {1}, album: {2}, nombre: {3}", this.Genre, this.Artist, this.Album, this.Name);
        }
    }
    }
