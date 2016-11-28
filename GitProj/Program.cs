using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitProj
{
    class Program
    {
        struct Songs
        {
            public int SongIndex;
            public string NamesSong;
            public string Author;
            public double Lengtch;
            public Ganre GanreMus;
        }
        
        public enum Ganre
        {
            Rock,
            Jazz,
            Blues
        }

        static void Main(string[] args)
        {

            double[] LengthSong = new double[6] { 3.45, 3.40, 3.45, 3.50, 4.40, 2.40 };
        


            Songs[] SongsCollection = new Songs[]
            {
                new Songs() {NamesSong = "Highway To Hell", Author = "AC/DC", GanreMus = Ganre.Rock, Lengtch = LengthSong[0], SongIndex = 1},
                new Songs() {NamesSong = "American Idiot", Author = "Green Day", GanreMus = Ganre.Rock, Lengtch = LengthSong[1], SongIndex = 2},

                new Songs() {NamesSong = "Strange Fruit ", Author = "Billie Holiday", GanreMus = Ganre.Jazz, Lengtch = LengthSong[2], SongIndex = 3},
                new Songs() {NamesSong = "Lush Life", Author = "Johnny Hartman", GanreMus = Ganre.Jazz, Lengtch = LengthSong[3], SongIndex = 4},

                new Songs() {NamesSong = "Hoochie Coochie Man", Author = "Muddy Waters", GanreMus = Ganre.Blues, Lengtch = LengthSong[4], SongIndex = 5},
                new Songs() {NamesSong = "Stormy Monday (Call It Stormy Monday)", Author = "T-Bone Walker", GanreMus = Ganre.Blues, Lengtch = LengthSong[5], SongIndex = 6}
            };


            Console.WriteLine(@"Hello user!
Chose the variant in menu 
1. Edit song name by index and print all;
2. Find the longest song and print info about it;
3. Print all songs of selected ganre.");
            string choise = Console.ReadLine();

            switch (choise)
            {
                case "1":
                    {

                        Console.WriteLine();
                        for (int i = 0; i < SongsCollection.Length; i++)
                        {
                            Console.WriteLine("Write index of Song:");
                            string index = Console.ReadLine();
                            if (SongsCollection[i].SongIndex.ToString() == index)
                            {
                                Console.WriteLine(SongsCollection[i].SongIndex.ToString() + " " + SongsCollection[i].NamesSong == "New value of song Name");
                                break;
                            }
                            Console.WriteLine(SongsCollection[i].NamesSong);
                        }

                        break;
                    }
                case "2":
                    {
                      // Console.WriteLine(LengthSong.Max);
                    }
                    break;
             
                case "3":
                    {
                        Console.WriteLine();
                        for (int i = 0; i < SongsCollection.Length; i++)
                        {
                            Console.WriteLine("Write ganre of Song:");
                            string ganre = Console.ReadLine();
                            if (SongsCollection[i].GanreMus.ToString() == ganre)
                            {
                                Console.WriteLine(SongsCollection[i].NamesSong.ToString());
                                break;
                            }
                        }
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Tap only 1,2,3 digits...");
                        break;
                    }
            }
            Console.ReadKey();

        }
    }
}
