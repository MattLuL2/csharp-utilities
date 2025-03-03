using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Time
{
    [Flags]
    public enum SongGenre
    {
        Unclassified = 0,
        Pop = 0b1,
        Rock = 0b10,
        Blues = 0b100,
        Country = 0b1_00,
        Metal = 0b10_000,
        Soul = 0b100_000
    }

    public class Song
    {
        public string Artist { get; }
        public string Title { get; }
        public double Length { get; }
        public SongGenre Genre { get; }
        public Song(string title, string artist, double length, SongGenre genre)
        {
            Title = title;
            Artist = artist;
            Length = length;
            Genre = genre;
        }

        public override string ToString()
        {
            return $"{Title} by {Artist} ({Genre}) {Length}min";
        }

    }

    static public class Library
    {
        static private List<Song> songs;
        static public void LoadSongs(string filename)
        {
            songs = new List<Song>();
            StreamReader reader = new StreamReader(filename);
            string title, artist, length, genre;

            while (true)
            {
                title = reader.ReadLine();
                if (title == null)
                {
                    break;
                }
                artist = reader.ReadLine();
                length = reader.ReadLine();
                genre = reader.ReadLine();
                songs.Add(new Song(title, artist, Convert.ToDouble(length), Enum.Parse<SongGenre>(genre)));
            }



        }
        static public void DisplaySongs()
        {
            foreach (Song song in songs)
            {
                Console.WriteLine(song + "\n");
            }
        }
        static public void DisplaySongs(double longerThan)
        {
            foreach (Song song in songs)
            {
                if (song.Length > longerThan)
                {
                    Console.WriteLine(song + "\n");
                }
                   
            }
        }
        static public void DisplaySongs(SongGenre genre)
        {
            foreach (Song song in songs)
            {
                if (song.Genre == genre)
                {
                    Console.WriteLine(song + "\n");
                }
            }
        }
        static public void DisplaySongs(string artist)
        {
            foreach (Song song in songs)
            {
                if (song.Artist == artist)
                {
                    Console.WriteLine(song + "\n");
                }
            }
        }
    }
}
