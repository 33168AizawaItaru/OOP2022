using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            var songs = new Song[]
            {
                new Song("Let it be","The Batles",243),
                new Song("Bridge Over Troubled Water","Simon & Garhunkel",293),
                new Song("Close To You","Carpenters",276),
                new Song("Honesty","Billy Joel",231),
                new Song("I Will Always Love You","Wnitney Houston",273),
            };
            PrintSongs(songs);
        }

        private static void PrintSongs(IEnumerable<Song> songs) 
        {
            foreach (var song in songs)
            {
                Console.WriteLine("{0},{1},{2:m\\:ss}",
                    song.Title,song.ArtistName,TimeSpan.FromSeconds(song.Length));
            }
        }
    }
}
