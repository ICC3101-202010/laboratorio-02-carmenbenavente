using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_2
{
    public class Playlist
    {
        public string NamePL;
        public List<Cancion> Plist = new List<Cancion>();

        public Playlist(string namePL, List<Cancion> plist)
        {
            this.NamePL = namePL;
            this.Plist = plist;
        }
        public void VerPlaylist()
        {
            Console.WriteLine(this.NamePL);

            foreach (Cancion c2 in Plist)
            {
                c2.Informacion();
            }
        }
    }
}
