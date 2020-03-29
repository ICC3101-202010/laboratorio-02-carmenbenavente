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
           
            var spoti = new Espotifai();
            var lista = spoti.list;

            Console.WriteLine("Welcome to Espotifai");
            string menu;
            Console.WriteLine("Select an option: 1.See all songs 2. Add a song 3. Close");
            menu = Console.ReadLine();

            var cancion0 = new Cancion("Hell Or High Water", "Runaway", "Passenger","Indie Folk");
               
            if (spoti.AgregarCancion(cancion0))
            {
                lista.Add(cancion0);
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

            if (menu == "1")
            {
                spoti.VerCanciones();
            }
            else if (menu == "2")
            {
                string name, album, artist, genre;
                Console.WriteLine("Enter name of the song");
                name = Console.ReadLine();
                Console.WriteLine("Enter album of the song");
                album = Console.ReadLine();
                Console.WriteLine("Enter artist of the song");
                artist = Console.ReadLine();
                Console.WriteLine("Enter genre of the song");
                genre = Console.ReadLine();
                var cancion = new Cancion(name, album, artist, genre);
                if (spoti.AgregarCancion(cancion))
                {
                    lista.Add(cancion);
                }
            }
            else if (menu == "3")
            {
                Console.WriteLine("Closing");
            }
            else
            {
                Console.WriteLine("Please enter a valid number");
                Console.WriteLine("Select an option: 1.See all songs 2. Add a song 3. Close");
                menu = Console.ReadLine();
                if (menu == "1")
                {
                    spoti.VerCanciones();
                }
                else if (menu == "2")
                {
                    string name, album, artist, genre;
                    Console.WriteLine("Enter name of the song");
                    name = Console.ReadLine();
                    Console.WriteLine("Enter album of the song");
                    album = Console.ReadLine();
                    Console.WriteLine("Enter artist of the song");
                    artist = Console.ReadLine();
                    Console.WriteLine("Enter genre of the song");
                    genre = Console.ReadLine();
                    var cancion = new Cancion(name, album, artist, genre);
                    if (spoti.AgregarCancion(cancion))
                    {
                        lista.Add(cancion);
                    }
                }
                else if (menu == "3")
                {
                    Console.WriteLine("Closing");
                }
                else
                {
                    Console.WriteLine("Please enter a valid number");
                }
            }

            

            Console.WriteLine(lista.Count);
            Console.ReadLine();
        }
    }
}
