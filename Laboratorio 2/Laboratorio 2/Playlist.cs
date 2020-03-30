using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_2
{
    public class Playlist
    {
        private string NamePL;
        private List<Cancion> Plist = new List<Cancion>();

        public Playlist(string namePL, List<Cancion> plist)
        {
            this.NamePL1 = namePL;
            this.Plist1 = plist;
        }

        public string NamePL1 { get => NamePL; set => NamePL = value; }
        public List<Cancion> Plist1 { get => Plist; set => Plist = value; }

        public void VerPlaylist()
        {
            Console.WriteLine(this.NamePL1);

            foreach (Cancion c2 in Plist1)
            {
                c2.Informacion();
            }
        }
    }
}
