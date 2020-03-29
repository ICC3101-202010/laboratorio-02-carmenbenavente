﻿using System;
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
            var cancion3 = new Cancion("Perfect", "Divide", "Ed Sheeran", "Indie Folk");
            if (spoti.AgregarCancion(cancion3))
            {
                lista.Add(cancion3);
            }
            
            int n = 1;
            while (n == 1)
            {
                Console.WriteLine("Select an option: 1.See all songs 2. Add a song 3. See songs by criteria 4.Create a Playlist 5. See all my playlist 9. Close");
                menu = Console.ReadLine();
                if (menu == "1")
                {
                    spoti.VerCanciones();
                    n = 1;
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
                    n = 1;
                }
                else if (menu == "3")
                {
                    string cri, val;
                    Console.WriteLine("Enter a criteria: genre, artist, name or album");
                    cri = Console.ReadLine();
                    Console.WriteLine("Enter a value");
                    val = Console.ReadLine();
                    List<Cancion> Songs = spoti.CancionesPorCriterio(cri, val);
                    spoti.VerCanciones(Songs);
                    n = 1;
                }
                
                else if (menu == "4")
                {
                    string cri, val, nam;
                    Console.WriteLine("Enter a criteria: genre, artist, name or album");
                    cri = Console.ReadLine();
                    Console.WriteLine("Enter a value");
                    val = Console.ReadLine();
                    Console.WriteLine("Enter a name");
                    nam = Console.ReadLine();
                    spoti.GenerarPlayList(cri,val,nam);
                    n = 1;
                }

                else if (menu == "5")
                {
                    spoti.VerMisPlaylists();
                    n = 1;
                }
                
                else if (menu == "9")
                {
                    Console.WriteLine("Closing");
                    n = 0;
                }
                else
                {
                    Console.WriteLine("Please enter a valid number");
                    n = 1;

                }

            }
            Console.WriteLine(lista.Count);
            Console.ReadLine();
        }
    }
}
