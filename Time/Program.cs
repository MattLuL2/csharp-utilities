using System.Runtime.Serialization;

namespace Time
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //create a list to store the objects
            List<Time> times = new List<Time>()
            {
                new Time(9, 35),
                new Time(18, 5),
                new Time(20, 500),
                new Time(10),
                new Time()
            };
            //display all the objects
            TimeFormat format = TimeFormat.Hour12;
            Console.WriteLine($"\n\nTime format is {format}");
            foreach (Time t in times)
            {
                Console.WriteLine(t);
            }
            //change the format of the output
            format = TimeFormat.Mil;
            Console.WriteLine($"\n\nSetting time format to {format}");
            //SetFormat(TimeFormat) is a class member, so you need the type to access it
            Time.SetFormat(format);
            //again display all the objects
            foreach (Time t in times)
            {
                Console.WriteLine(t);
            }
            //change the format of the output
            format = TimeFormat.Hour24;
            Console.WriteLine($"\n\nSetting time format to {format}");
            //SetFormat(TimeFormat) is a class member, so you need the type to access it
            Time.SetFormat(format);
            foreach (Time t in times)
            {
                Console.WriteLine(t);
            }

            Console.WriteLine("\nSong Lab\n");
             // To test the constructor and the ToString method
             Console.WriteLine(new Song("Baby", "Justin Bebier", 3.35, SongGenre.Pop));

             //This is first time that you are using the bitwise or. It is used to specify a combination of genres
             Console.WriteLine(new Song("The Promise", "Chris Cornell", 4.26, SongGenre.Country | SongGenre.Rock));

             Library.LoadSongs("Week_03_lab_09_songs4.txt"); //Class methods are invoke with the class name
             Console.WriteLine("\n\nAll songs");
             Library.DisplaySongs();

             SongGenre genre = SongGenre.Rock;
             Console.WriteLine($"\n\n{genre} songs");
             Library.DisplaySongs(genre);

             string artist = "Bob Dylan";
             Console.WriteLine($"\n\nSongs by {artist}");
             Library.DisplaySongs(artist);

             double length = 5.0;
             Console.WriteLine($"\n\nSongs more than {length}mins");
             Library.DisplaySongs(length);
            
        }
    


        public enum TimeFormat
        {
            Mil,
            Hour12,
            Hour24
        }

        public class Time
        {
            private static TimeFormat TIME_FORMAT = TimeFormat.Hour12;
            public int Hour { get; }
            public int Minute { get; }
            public Time(int hour = 0, int minute = 0)
            {
                if (hour >=0 && hour <= 24)
                {
                    Hour = hour;
                }
                else
                {
                    Hour = 0;
                }
                if(minute >=0 && minute <= 60)
                {
                    Minute = minute;
                }
                else
                {
                    Minute = 0;
                }
            }
            public override string ToString()
            {
                //string value;
                switch (TIME_FORMAT)
                {
                    case TimeFormat.Mil:
                        return $"{Hour:D2}{Minute:D2}";
                    case TimeFormat.Hour24:
                        return $"{Hour:D2}:{Minute:D2}";
                    case TimeFormat.Hour12:
                        if (Hour == 0)
                        {
                            return $"12:{Minute:D2} AM";
                        }
                        else if (Hour < 12)
                        {
                            return $"{Hour:D2}:{Minute:D2} AM";
                        }
                        else if (Hour == 12)
                        {
                            return $"12:{Minute:D2} PM";
                        }
                        else
                        {
                            return $"{(Hour - 12):D2}:{Minute:D2} PM";
                        }
                    default:
                        return "This should never show up";
                }
            }
            public static void SetFormat(TimeFormat timeFormat)
            {
                TIME_FORMAT = timeFormat;
            }
        }
    }
}
